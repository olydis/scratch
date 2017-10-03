// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Rest
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest.TransientFaultHandling;
    using System.Text.RegularExpressions;
    using Microsoft.Rest.ClientRuntime.RequestPolicy;

    public class ParsedHttpContent<T> : HttpContent
    {
        public T ParsedObject { get; private set; }

        public ParsedHttpContent(T parsedObject)
        {
            this.ParsedObject = parsedObject;
        }

        protected override bool TryComputeLength(out long length) => throw new InvalidOperationException("Cannot compute length of parsed content.");
        protected override Task SerializeToStreamAsync(Stream s, TransportContext tc) => throw new InvalidOperationException("Cannot serialize parsed content back to stream.");
    }

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

    /// <summary>
    /// ServiceClient is the abstraction for accessing REST operations and their payload data types..
    /// </summary>
    /// <typeparam name="T">Type of the ServiceClient.</typeparam>
    public abstract class ServiceClient<T> : IDisposable where T : ServiceClient<T>
    {
        /// <summary>
        /// Initializes a new instance of the ServiceClient class.
        /// </summary>
        protected ServiceClient()
        {
        }

        public IEnumerable<IFactory> Pipeline { get; set; } = new IFactory[0];
        
        public Task<HttpResponseMessage> SendAsync<TResult>(HttpRequestMessage request, Func<HttpResponseMessage, Task<TResult>> deserializer, CancellationToken cancellationToken)
            => new Pipeline(Pipeline, new HttpClient()).SendAsync(new Context(cancellationToken), new DeserializerPolicyFactory<TResult>(deserializer), request);

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // cleanup Pipeline?
                }
                disposedValue = true;
            }
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
