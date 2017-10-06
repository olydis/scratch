using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.Rest.RequestPolicy.StoragePolicies
{
    // RequestLogOptions configures the request log policy's behavior.
    public sealed class RequestLogOptions
    {
	    // LogWarningIfTryOverThreshold logs a warning if a tried operation takes longer than the specified duration (0=no logging).
        public TimeSpan LogWarningIfTryOverThreshold { get; private set; }

        public RequestLogOptions(TimeSpan logWarningIfTryOverThreshold)
        {
            this.LogWarningIfTryOverThreshold = logWarningIfTryOverThreshold;
        }
    }

    public sealed class RequestLogPolicyFactory : IFactory
    {
        RequestLogOptions o;

        public RequestLogPolicyFactory(RequestLogOptions o)
        {
            this.o = o;
        }

        public IPolicy Create(PolicyNode node)
            => new RequestLogPolicy(node, o);

        private sealed class RequestLogPolicy : IPolicy
        {
            PolicyNode node;
            RequestLogOptions o;
            int attempt;

            public RequestLogPolicy(PolicyNode node, RequestLogOptions o)
            {
                this.node = node;
                this.o = o;
                this.attempt = 0;
            }

            public async Task<HttpResponseMessage> SendAsync(Context ctx, HttpRequestMessage request)
            {
                attempt++; // The first try is #1 (not #0)
                var operationStart = DateTime.UtcNow;

                // Log the outgoing request as informational
                if (node.WouldLog(LogSeverity.Info))
                {
                    node.Log(LogSeverity.Info,$"===== OUTGOING REQUEST (Try={attempt}):\n" + request.Format());
                }

                // Set the time for this particular retry operation and then Do the operation.
                var tryStart = DateTime.UtcNow;
                HttpResponseMessage response = null;
                Exception err = null;
                try
                {
                    response = await node.SendAsync(ctx, request); // Make the request
                }
                catch (Exception e)
                {
                    err = e;
                }
                var tryEnd = DateTime.UtcNow;
                var tryDuration = tryEnd - tryStart;
                var opDuration = tryEnd - operationStart;

                // Assume success and default to informational logging
                var severity = LogSeverity.Info;
                Func<string> logMsg = () => $"Success\n{response.Format()}";

                // If the response took too long, we'll upgrade to warning.
                if (o.LogWarningIfTryOverThreshold != TimeSpan.Zero && tryDuration > o.LogWarningIfTryOverThreshold)
                {
                    // Log a warning if the try duration exceeded the specified threshold
                    severity = LogSeverity.Warning;
                    logMsg = () => $"SLOW [tryDuration > {o.LogWarningIfTryOverThreshold}]\n{response.Format()}";
                }

                // TODO: ResponseException
                // if (err is ResponseException serr)
                // {
                //     // We have an error, upgrade the severity to error.
                //     severity = LogSeverity.Error;
                //     // For errors, we append the stack trace (an expensive operation)
                //     logMsg = s => $"ERROR\n{response.Format()}{Environment.StackTrace}";
                // }

                if (node.WouldLog(severity))
                {
                    node.Log(severity, $"RESPONSE (Try={attempt}, TryDuration={tryDuration}, OpDuration={opDuration}): {logMsg()}");
                }

                if (err != null)
                {
                    throw err;
                }
                return response;
            }
        }
    }
}
