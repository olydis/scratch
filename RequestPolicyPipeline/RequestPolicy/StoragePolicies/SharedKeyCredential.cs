﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Auth;

namespace Microsoft.Rest.ClientRuntime.RequestPolicy.StoragePolicies
{
    //
    // NOTE: I've reused the "StorageCredentials" from some existing Storage SDK.
    //
    public sealed class SharedKeyCredentialPolicyFactory : IFactory
    {
        StorageCredentials credentials;

        public SharedKeyCredentialPolicyFactory(StorageCredentials credentials)
        {
            this.credentials = credentials;
        }

        public IPolicy Create(PolicyNode node)
            => new SharedKeyCredentialPolicy(node, credentials);

        private sealed class SharedKeyCredentialPolicy : IPolicy
        {
            PolicyNode node;
            StorageCredentials credentials;

            public SharedKeyCredentialPolicy(PolicyNode node, StorageCredentials credentials)
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