using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.Rest.RequestPolicy.StoragePolicies
{
    public sealed class RetryOptions
    {
        // Policy tells the pipeline what kind of retry policy to use. See the RetryPolicy* constants (0=RetryPolicyExponential).
        public RetryPolicy Policy { get; private set; }

        // MaxTries specifies the maximum number of attempts an operation will be tried before producing an error (0=default).
	    // Set this to 1 to disable retries.
        public int MaxTries { get; private set; }

        // TryTimeout indicates the maximum time allowed for any single try of an HTTP request (0=default).
        public TimeSpan TryTimeout { get; private set; }
        
        // RetryDelay specifies the amount of delay to use before retrying an operation (0=default).
        // The delay increases (exponentially or linearly) with each retry up to a maximum specified by
        // MaxRetryDelay. If you specify 0, then you must also specify 0 for MaxRetryDelay.
        public TimeSpan RetryDelay { get; private set; }

        // MaxRetryDelay specifies the maximum delay allowed before retrying an operation (0=default).
        // If you specify 0, then you must also specify 0 for RetryDelay.
        public TimeSpan MaxRetryDelay { get; private set; }

        // RetryReadsFromSecondaryURL specifies whether the retry policy should retry a read operation against another URL.
        // If the URL's Host field is "" (the default) then operations are not retried against another URL.
        // NOTE: Before setting this field, make sure you understand the issues around reading stale & potentially-inconsistent
        // data at this webpage: https://docs.microsoft.com/en-us/azure/storage/common/storage-designing-ha-apps-with-ragrs
        public Uri RetryReadsFromSecondaryURL { get; private set; }

        public RetryOptions(
            RetryPolicy policy,
            int maxTries,
            TimeSpan tryTimeout,
            TimeSpan retryDelay,
            TimeSpan maxRetryDelay,
            Uri retryReadsFromSecondaryURL)
        {
            if ((retryDelay == TimeSpan.Zero && maxRetryDelay != TimeSpan.Zero) || (retryDelay != TimeSpan.Zero && maxRetryDelay == TimeSpan.Zero))
                throw new ArgumentException("both RetryDelay and MaxRetryDelay must be 0 or neither can be 0");

            Func<TimeSpan, TimeSpan, TimeSpan> ifDefault = (current, desired) => current == TimeSpan.Zero ? desired : current;

            this.Policy = policy;
            this.MaxTries = maxTries == 0 ? 3 : maxTries;
            this.TryTimeout = ifDefault(tryTimeout, TimeSpan.FromSeconds(30));
            this.RetryDelay = ifDefault(retryDelay, TimeSpan.FromSeconds(3));
            this.MaxRetryDelay = ifDefault(maxRetryDelay, TimeSpan.FromSeconds(30));
            this.RetryReadsFromSecondaryURL = retryReadsFromSecondaryURL;
        }
    }

    public enum RetryPolicy
    {
	    // tells the pipeline to use an exponential back-off retry policy
        Exponential = 0,

	    // tells the pipeline to use a linear back-off retry policy
        Linear = 1
    }

    public sealed class RetryPolicyFactory : IFactory
    {
        RetryOptions o;

        public RetryPolicyFactory(RetryOptions o)
        {
            this.o = o;
        }

        public IPolicy Create(PolicyNode node)
            => new RetryPolicyImpl(node, o);

        private sealed class RetryPolicyImpl : IPolicy
        {
            PolicyNode node;
            RetryOptions o;

            public RetryPolicyImpl(PolicyNode node, RetryOptions o)
            {
                this.node = node;
                this.o = o;
            }

            public async Task<HttpResponseMessage> SendAsync(Context ctx, HttpRequestMessage request)
            {
                // var operationEndTime = DateTime.UtcNow + o.MaxOperationTime;
                var primaryUrl = request.RequestUri;
                var secondaryUrl = primaryUrl;
                var primaryTries = 0;

                Exception err = null;

                // We only consider retring against a secondary if we have a read request (GET/HEAD) AND theis policy has a Secondary URL it can use
                var considerSecondary = (request.Method == HttpMethod.Get || request.Method == HttpMethod.Head) && o.RetryReadsFromSecondaryURL.Host != "";
                if (considerSecondary)
                {
                    secondaryUrl = o.RetryReadsFromSecondaryURL;
                    var primaryBuilder = new UriBuilder(primaryUrl);
                    var secondaryBuilder = new UriBuilder(secondaryUrl);
                    secondaryBuilder.Path = primaryBuilder.Path;
                    // secondaryUrl.RawPath = primaryURL.RawPath
                    secondaryBuilder.Query = primaryBuilder.Query;
                    secondaryUrl = secondaryBuilder.Uri;
                }

                // Exponential retry algorithm: ((2 ^ attempt) - 1) * delay * random(0.8, 1.2)
                // When to retry: connection failure or an HTTP status code of 500 or greater, except 501 and 505
                // If using a secondary:
                //    Even tries go agsainst primary; odd tries go against the secondary
                //    For a primary wait ((2 ^ primaryTries - 1) * delay * random(0.8, 1.2)
                //    If secondary gets a 404, don't fail, retry but future retries are only against the primary
                //    When retrying against a secondary, ignore the retry count and wait (.1 second * random(0.8, 1.2))
                for (int attempt = 0; attempt < o.MaxTries; attempt++)
                {
                    // Determine which endpoint to try. It's primary if there is no secondary or if it is an even attempt.
                    var tryingPrimary = !considerSecondary || (attempt % 2 == 0);

                    // Select the right URL endpoint
                    if (tryingPrimary)
                    {
                        request.RequestUri = primaryUrl;
                        primaryTries++;
                    }
                    else
                    {
                        request.RequestUri = secondaryUrl;
                    }

                    // Select the right URL endpoint & make the request
                    // TODO: Fix the endpoint

                    // Insert delay:
                    var delay = TimeSpan.Zero;
                    if (tryingPrimary)
                    {
                        switch (o.Policy)
                        {
                            case RetryPolicy.Exponential:
                                delay = TimeSpan.FromTicks(o.RetryDelay.Ticks * ((Pow(2, primaryTries - 1) - 1) / 2));
                                break;
                            case RetryPolicy.Linear:
                                delay = TimeSpan.FromTicks(o.RetryDelay.Ticks * (primaryTries - 1));
                                break;
                        }
                    }
                    else
                    {
                        delay = TimeSpan.FromSeconds(1);
                    }

                    // .8 + [0, .1, .2, .3, or .4] = .8, .9, 1.0, 1.1, or 1.2
                    var jitter = (8 + new Random().Next(5)) / 10f; // NOTE: We want math/rand; not crypto/rand
                    delay = TimeSpan.FromTicks((int)(delay.Ticks * jitter));

                    if (delay > o.MaxRetryDelay)
                    {
                        delay = o.MaxRetryDelay;
                    }
                    await Task.Delay(delay, ctx.CancellationToken);

		            // Set the server-side timeout query parameter
                    // System.Console.WriteLine(request.RequestUri);
                    var queryToAppend = $"timeout={(int)o.TryTimeout.TotalSeconds}";
                    var q = new UriBuilder(request.RequestUri);
                    if (q.Query != null && q.Query.Length > 1)
                        q.Query = q.Query.Substring(1) + "&" + queryToAppend;
                    else
                        q.Query = queryToAppend;
                    request.RequestUri = q.Uri;
                    // System.Console.WriteLine(request.RequestUri);
                    
		            // Seek to the beginning of the Body stream in case this is a retry
                    // TODO
                    // if err = request.RewindBody(); err != nil {
                    //     panic(fmt.Sprintf("Failed to RewindBody: Err: %+v", err))
                    // }

                    var tryCtx = ctx.WithTimeout(o.TryTimeout, out var isTimeout).WithCancel(out var cancel);
                    HttpResponseMessage response = null;
                    try
                    {
                        response = await node.SendAsync(ctx, request); // Make the request
                    }
                    catch (Exception e)
                    {
                        err = e;
                        // If temporary or timeout; retry
                        //TODO:
                        //if (nerr, ok:= err.(net.Error); ok)
                        //{
                        //    retry = nerr.Temporary() || nerr.Timeout()
                        //}
                    }
                    cancel();

                    var action = "";
                    if (isTimeout())
                        action = "NoRetry: Op timeout";
                    else if (err != null)
                    {
                        // TODO
                    }
                    else if (!response.IsSuccessStatusCode)
                    {
                        if (response.StatusCode == HttpStatusCode.InternalServerError || 
                            response.StatusCode == HttpStatusCode.ServiceUnavailable)
                        {
                            action = "Retry: Op timeout";
                        }
                        // TODO
                    }

                    // TODO
                }
                throw err; // Not retryable or too many retries; return the last response/error
            }

            private static long Pow(long number, int exponent)
            {
                long result = 1;
                for (int n = 0; n < exponent; n++)
                {
                    result *= number;
                }
                return result;
            }
        }
    }
}
