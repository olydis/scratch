// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Rest.ClientRuntime.Slim
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest.RequestPolicy;

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
        private bool disposedValue = false;

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
