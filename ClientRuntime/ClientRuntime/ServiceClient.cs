// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Rest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Reflection;
    using Microsoft.Rest.TransientFaultHandling;
    using System.Text.RegularExpressions;
    using Microsoft.Rest.ClientRuntime.RequestPolicy;

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

        public IHttpSender HttpClient => new Pipeline(Pipeline, new HttpClient());

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
