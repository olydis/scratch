using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.Rest.ClientRuntime.RequestPolicy.StoragePolicies
{
    public sealed class UniqueRequestIDPolicyFactory : IFactory
    {
        private static readonly string xMsClientRequestID = "x-ms-client-request-id";

        public UniqueRequestIDPolicyFactory() { }

        public IPolicy Create(PolicyNode node)
            => new UniqueRequestIDPolicy(node);

        private sealed class UniqueRequestIDPolicy : IPolicy
        {
            PolicyNode node;

            public UniqueRequestIDPolicy(PolicyNode node)
            {
                this.node = node;
            }

            public Task<HttpResponseMessage> SendAsync(Context ctx, HttpRequestMessage request)
            {
                var newUUID = Guid.NewGuid();
                if (!request.Headers.TryGetValues(xMsClientRequestID, out var values) || values.All(string.IsNullOrEmpty))
                {
                    // TODO: copy request?
                    request.Headers.Add(xMsClientRequestID, newUUID.ToString());
                }
                return node.SendAsync(ctx, request);
            }
        }
    }
}
