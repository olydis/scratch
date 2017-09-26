using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.Rest.ClientRuntime.RequestPolicy.StoragePolicies
{
    //
    // NOTE: I've reused the existing "ServiceClientCredentials" infrastructure we already have rather than converting Go.
    //
    public sealed class CredentialPolicyFactory : IFactory
    {
        ServiceClientCredentials credentials;

        public CredentialPolicyFactory(ServiceClientCredentials credentials)
        {
            this.credentials = credentials;
        }

        public IPolicy Create(PolicyNode node)
            => new CredentialPolicy(node, credentials);

        private sealed class CredentialPolicy : IPolicy
        {
            PolicyNode node;
            ServiceClientCredentials credentials;

            public CredentialPolicy(PolicyNode node, ServiceClientCredentials credentials)
            {
                this.node = node;
                this.credentials = credentials;
            }

            public async Task<HttpResponseMessage> SendAsync(Context ctx, HttpRequestMessage request)
            {
                await this.credentials.ProcessHttpRequestAsync(request, ctx.CancellationToken);
                return await node.SendAsync(ctx, request); // Make the request
            }
        }
    }
}
