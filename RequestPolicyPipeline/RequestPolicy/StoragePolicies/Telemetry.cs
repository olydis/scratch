using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.Rest.RequestPolicy.StoragePolicies
{
    // TelemetryOptions configures the telemetry policy's behavior.
    public class TelemetryOptions
    {
        public TelemetryOptions(string value)
        {
            this.Value = value;
        }

        // Value is a string prepended to each request's User-Agent and sent to the service.
        // The service records the user-agent in logs for diagnostics and tracking of client requests.
        public string Value { get; private set; }
    }

    public sealed class TelemetryPolicyFactory : IFactory
    {
        string serviceVersion;
        TelemetryOptions options;

        public TelemetryPolicyFactory(TelemetryOptions options)
        {
            this.serviceVersion = serviceVersion;
            this.options = options;
        }

        public IPolicy Create(PolicyNode node)
            => new ServerTimeLimitPolicy(node, this);

        private sealed class ServerTimeLimitPolicy : IPolicy
        {
            PolicyNode node;
            TelemetryPolicyFactory factory;

            public ServerTimeLimitPolicy(PolicyNode node, TelemetryPolicyFactory factory)
            {
                this.node = node;
                this.factory = factory;
            }

            public Task<HttpResponseMessage> SendAsync(Context ctx, HttpRequestMessage request)
            {	
                // request = request.Copy(); // TODO: Don't mutate the incoming request object's headers
                var v = factory.options.Value;
                if (v != "")
                {
                    v += " ";
                }
                v += $"Azure-Storage/{factory.serviceVersion} {System.Runtime.InteropServices.RuntimeInformation.OSDescription}";
                request.Headers.Add("User-Agent", v);
                return node.SendAsync(ctx, request);
            }
        }
    }
}
