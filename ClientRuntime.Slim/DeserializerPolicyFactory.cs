// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Rest.ClientRuntime.Slim
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.Rest.RequestPolicy;

    public sealed class DeserializerPolicyFactory<T> : IFactory
    {
        Func<HttpResponseMessage, Task<T>> deserializer;

        public DeserializerPolicyFactory(Func<HttpResponseMessage, Task<T>> deserializer)
        {
            this.deserializer = deserializer;
        }

        public IPolicy Create(PolicyNode node)
            => new DeserializerPolicy(node, deserializer);

        private class DeserializerPolicy : IPolicy
        {
            PolicyNode node;
            Func<HttpResponseMessage, Task<T>> deserializer;

            public DeserializerPolicy(PolicyNode node, Func<HttpResponseMessage, Task<T>> deserializer)
            {
                this.node = node;
                this.deserializer = deserializer;
            }

            public async Task<HttpResponseMessage> SendAsync(Context ctx, HttpRequestMessage request)
            {
                var response = await node.SendAsync(ctx, request);
                var parsedResult = await deserializer(response);
                // TODO: clone response
                response.Content = new ParsedHttpContent<T>(parsedResult);
                return response;
            }
        }
    }
}
