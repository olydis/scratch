//
// Note: This is a slight deviation from "ServiceClient" which we have in the ClientRuntime already.
//       So most stuff in here is irrelevant to request policies,
//       I'm just trying to simulate what would/could be done to the ClientRuntime to add request policies. 
//


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
    using System.Text.RegularExpressions;
    using Microsoft.Rest.ClientRuntime.RequestPolicy;
#if FullNetFx
    using Microsoft.Win32;
#endif

    /// <summary>
    /// ServiceClient is the abstraction for accessing REST operations and their payload data types..
    /// </summary>
    /// <typeparam name="T">Type of the ServiceClient.</typeparam>
    public abstract class ServiceClientX<T> : IDisposable
        where T : ServiceClientX<T>
    {
        /// <summary>
        /// ProductName string to be used to set Framework Version in UserAgent
        /// </summary>
        private const string FXVERSION = "FxVersion";
        private const string OSNAME = "OSName";
        private const string OSVERSION = "OSVersion";

        /// <summary>
        /// List of default UserAgent info that will be added to HttpClientSender instance
        /// </summary>
        private List<ProductInfoHeaderValue> _defaultUserAgentInfoList;

        /// <summary>
        /// Indicates whether the ServiceClient has been disposed. 
        /// </summary>
        private bool _disposed;

        /// <summary>
        /// Flag to track if provided httpClient needs to disposed
        /// </summary>
        private bool _disposeHttpClient;

        /// <summary>
        /// Field used for ClientVersion property
        /// </summary>
        private string _clientVersion;
        
        /// <summary>
        /// Field used for Framework Version property
        /// </summary>
        private string _fxVersion;

        #region Full Net Fx specific code
#if FullNetFx
        /// <summary>
        /// Indicates OS Name
        /// </summary>
        private string _osName;

        /// <summary>
        /// Indicates OS Version
        /// </summary>
        private string _osVersion;

        /// <summary>
        /// Gets Os Information, OSName - OS Major.Minor.Build version
        /// e.g. Windows 10 Enterprise - 6.3.14393
        /// </summary>
        private string OsName
        {
            get
            {  
                if(string.IsNullOrEmpty(_osName))
                {
                    _osName = ReadHKLMRegistry(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName");
                    _osName = CleanUserAgentInfoEntry(_osName);
                }

                return _osName;
            }
        }
        
        /// <summary>
        /// Gets Os Major.Minor.Build version
        /// e.g. 6.3.14393
        /// </summary>
        private string OsVersion
        {
            get
            {
                if (string.IsNullOrEmpty(_osVersion))
                {   
                    string osMajorMinorVersion = ReadHKLMRegistry(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentVersion");
                    string osBuildNumber = ReadHKLMRegistry(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CurrentBuild");
                    _osVersion = string.Format("{0}.{1}", osMajorMinorVersion, osBuildNumber);
                    _osVersion = CleanUserAgentInfoEntry(_osVersion);
                }

                return _osVersion;
            }
        }

        /// <summary>
        /// Reads HKLM registry key from the provided path/key combination
        /// </summary>
        /// <param name="path">Path to HKLM key</param>
        /// <param name="key">HKLM key name</param>
        /// <returns>Value for provided HKLM key</returns>
        private string ReadHKLMRegistry(string path, string key)
        {
            try
            {
                using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(path))
                {
                    if (rk == null) return "";
                    return (string)rk.GetValue(key);
                }
            }
            catch { return ""; }
        }
#endif
        #endregion

        /// <summary>
        /// List of default info that gets added to DefaultHeaders.UserAgent of HttpClientSender
        /// </summary>
        private List<ProductInfoHeaderValue> DefaultUserAgentInfoList
        {
            get
            {
                if(_defaultUserAgentInfoList == null)
                {
                    _defaultUserAgentInfoList = new List<ProductInfoHeaderValue>();
                    _defaultUserAgentInfoList.Add(new ProductInfoHeaderValue(FXVERSION, FrameworkVersion));
#if FullNetFx
                    _defaultUserAgentInfoList.Add(new ProductInfoHeaderValue(OSNAME, OsName));
                    _defaultUserAgentInfoList.Add(new ProductInfoHeaderValue(OSVERSION, OsVersion));
#endif
                }

                return _defaultUserAgentInfoList;
            }
        }

        /// <summary>
        /// Gets the AssemblyInformationalVersion if available
        /// if not it gets the AssemblyFileVerion
        /// if neither are available it will default to the Assembly Version of a service client.
        /// </summary>
        private string ClientVersion
        {
            get
            {
                if (string.IsNullOrEmpty(_clientVersion))
                {
                    Type type = this.GetType();
                    Assembly assembly = type.GetTypeInfo().Assembly;

                    try
                    {
                        AssemblyVersionAttribute asmVerAttribute =
                            assembly.GetCustomAttribute(typeof(AssemblyVersionAttribute)) as AssemblyVersionAttribute;
                        _clientVersion = asmVerAttribute?.Version;

                        // if not available try to get AssemblyFileVersion
                        if (String.IsNullOrEmpty(_clientVersion))
                        {
                            AssemblyFileVersionAttribute fvAttribute =
                                assembly.GetCustomAttribute(typeof(AssemblyFileVersionAttribute)) as AssemblyFileVersionAttribute;
                            _clientVersion = fvAttribute?.Version;
                        }

                        // If everything fails we try AssemblyInformationalVersion
                        if (string.IsNullOrEmpty(_clientVersion))
                        {
                            AssemblyInformationalVersionAttribute aivAttribute =
                                    assembly.GetCustomAttribute(typeof(AssemblyInformationalVersionAttribute)) as AssemblyInformationalVersionAttribute;
                            _clientVersion = aivAttribute?.InformationalVersion;
                        }
                    }
                    catch (AmbiguousMatchException)
                    {
                        // in case there are more then one attribute of the type
                    }

                    // no usable version attribute found so default to Assembly Version
                    if (String.IsNullOrEmpty(_clientVersion))
                    {
                        _clientVersion =
                            assembly
                                .FullName
                                .Split(',')
                                .Select(c => c.Trim())
                                .First(c => c.StartsWith("Version=", StringComparison.OrdinalIgnoreCase))
                                .Substring("Version=".Length);
                    }

                }
                return _clientVersion;
            }
        }

        /// <summary>
        /// Get file version for System.dll
        /// </summary>
        private string FrameworkVersion
        {
            get
            {
                if (string.IsNullOrEmpty(_fxVersion))
                {
                    Assembly assembly = typeof(Object).GetTypeInfo().Assembly;                    
                    AssemblyFileVersionAttribute fvAttribute =
                                assembly.GetCustomAttribute(typeof(AssemblyFileVersionAttribute)) as AssemblyFileVersionAttribute;
                    _fxVersion = fvAttribute?.Version;
                }
        
                return _fxVersion;
            }
        }

        /// <summary>
        /// Reference to the first HTTP handler (which is the start of send HTTP
        /// pipeline).
        /// </summary>
        protected HttpMessageHandler FirstMessageHandler { get; set; }

        /// <summary>
        /// Reference to the innermost HTTP handler (which is the end of send HTTP
        /// pipeline).
        /// </summary>
        protected HttpClientHandler HttpClientHandler { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the ServiceClient class.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Reliability",
            "CA2000:Dispose objects before losing scope",
            Justification = "The created objects should be disposed on caller's side")]
        protected ServiceClientX()
            : this(CreateRootHandler())
        {
        }

        /// <summary>
        /// Initializes a new instance of the ServiceClient class.
        /// </summary>
        /// <param name="httpClient">HttpClientSender to be used</param>
        /// <param name="disposeHttpClient">true: Will dispose the supplied httpClient on calling Dispose(). False: will not dispose</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Reliability",
            "CA2000:Dispose objects before losing scope",
            Justification = "The created objects should be disposed on caller's side")]
        protected ServiceClientX(HttpClient httpClient, bool disposeHttpClient = true)
        {
            _disposeHttpClient = disposeHttpClient;
            InitializeHttpClient(httpClient, null);
        }
        
        /// <summary>
        /// Initializes a new instance of the ServiceClient class.
        /// </summary>
        /// <param name="handlers">List of handlers from top to bottom (outer handler is the first in the list)</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Reliability",
            "CA2000:Dispose objects before losing scope",
            Justification = "The created objects should be disposed on caller's side")]
        protected ServiceClientX(params DelegatingHandler[] handlers)
            : this(CreateRootHandler(), handlers)
        {
        }

        /// <summary>
        /// Initializes ServiceClient using base HttpClientHandler and list of handlers.
        /// </summary>
        /// <param name="rootHandler">Base HttpClientHandler.</param>
        /// <param name="handlers">List of handlers from top to bottom (outer handler is the first in the list)</param>
        protected ServiceClientX(HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            InitializeHttpClient(rootHandler, handlers);
        }

        /// <summary>
        /// Create a new instance of the root handler.
        /// </summary>
        /// <returns>HttpClientHandler created.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Reliability",
            "CA2000:Dispose objects before losing scope",
            Justification = "The created objects should be disposed on caller's side")]
        protected static HttpClientHandler CreateRootHandler()
        {
            // Create our root handler
#if FullNetFx
            return new WebRequestHandler();
#else
            return new HttpClientHandler();
#endif
        }

        /// <summary>
        /// Gets the HttpClientSender used for making HTTP requests.
        /// </summary>
        private HttpClient HttpClientSender { get; set; }

        public IEnumerable<IFactory> Pipeline { get; set; } = new IFactory[0];

        public IHttpSender HttpClient => new Pipeline(Pipeline, HttpClientSender);


        // IEnumerable<IFactory> factories

        /// <summary>
        /// Gets the UserAgent collection which can be augmented with custom
        /// user agent strings.
        /// </summary>
        public virtual HttpHeaderValueCollection<ProductInfoHeaderValue> UserAgent
        {
            get { return HttpClientSender.DefaultRequestHeaders.UserAgent; }
        }

        /// <summary>
        /// Get the HTTP pipelines for the given service client.
        /// </summary>
        /// <returns>The client's HTTP pipeline.</returns>
        public virtual IEnumerable<HttpMessageHandler> HttpMessageHandlers
        {
            get
            {
                var handler = FirstMessageHandler;

                while (handler != null)
                {
                    yield return handler;

                    DelegatingHandler delegating = handler as DelegatingHandler;
                    handler = delegating != null ? delegating.InnerHandler : null;
                }
            }
        }

        /// <summary>
        /// Dispose the ServiceClient.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose the HttpClientSender and Handlers.
        /// </summary>
        /// <param name="disposing">True to release both managed and unmanaged resources; false to releases only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;

                // Dispose the client
                if(_disposeHttpClient)
                {
                    HttpClientSender.Dispose();
                    HttpClientSender = null;
                }                
                
                FirstMessageHandler = null;
                HttpClientHandler = null;
            }
        }
        

        /// <summary>
        /// Initializes HttpClientSender using HttpClientHandler.
        /// </summary>
        /// <param name="httpClientHandler">Base HttpClientHandler.</param>
        /// <param name="handlers">List of handlers from top to bottom (outer handler is the first in the list)</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "Microsoft.Reliability",
            "CA2000:Dispose objects before losing scope",
            Justification = "We let HttpClientSender instance dispose")]
        protected void InitializeHttpClient(HttpClientHandler httpClientHandler, params DelegatingHandler[] handlers)
        {
            InitializeHttpClient(null, httpClientHandler, handlers);
        }

        /// <summary>
        /// Initialize service client with provided HttpClientSender
        /// </summary>
        /// <param name="httpClient">HttpClientSender</param>
        /// <param name="httpClientHandler">HttpClientHandler</param>
        /// <param name="handlers">List of handlers from top to bottom (outer handler is the first in the list)</param>
        protected void InitializeHttpClient(HttpClient httpClient, HttpClientHandler httpClientHandler, params DelegatingHandler[] handlers)
        {
           if (httpClient == null)
            {
                if(httpClientHandler == null)
                {
                    httpClientHandler = CreateRootHandler();
                }

                HttpClientHandler = httpClientHandler;
                HttpMessageHandler currentHandler = httpClientHandler;

                if (handlers != null)
                {
                    for (int i = handlers.Length - 1; i >= 0; --i)
                    {
                        DelegatingHandler handler = handlers[i];
                        // Non-delegating handlers are ignored since we always 
                        // have RetryDelegatingHandler as the outer-most handler
                        while (handler.InnerHandler is DelegatingHandler)
                        {
                            handler = handler.InnerHandler as DelegatingHandler;
                        }

                        handler.InnerHandler = currentHandler;
                        currentHandler = handler;
                    }
                }

                HttpClientSender = new HttpClient(currentHandler, false);
                FirstMessageHandler = currentHandler;
            }
            else
            {
                HttpClientSender = httpClient;
            }
            
            SetUserAgent(this.GetType().FullName, ClientVersion);
        }
        
        /// <summary>
        /// Sets the product name to be used in the user agent header when making requests
        /// </summary>
        /// <param name="productName">Name of the product to be used in the user agent</param>
        public bool SetUserAgent(string productName)
        {
            return SetUserAgent(productName, ClientVersion);
        }

        /// <summary>
        /// Sets the product name and version to be used in the user agent header when making requests
        /// </summary>
        /// <param name="productName">Name of the product to be used in the user agent</param>
        /// <param name="version">Version of the product to be used in the user agent</param>
        public bool SetUserAgent(string productName, string version)
        {
            if (!_disposed && HttpClientSender != null)
            {
                MergeUserAgentInfo(DefaultUserAgentInfoList);
                string cleanedProductName = CleanUserAgentInfoEntry(productName);                
                HttpClientSender.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(cleanedProductName, version));
                return true;
            }

            // Returns false if the HttpClientSender was disposed before invoking the method
            return false;
        }

        /// <summary>
        /// Cleaning unsupported characters from user agent strings
        /// </summary>
        /// <param name="infoEntry"></param>
        /// <returns></returns>
        private string CleanUserAgentInfoEntry(string infoEntry)
        {
            Regex pattern = new Regex("[~`!@#$%^&*(), ]");            
            infoEntry = pattern.Replace(infoEntry, "");

            return infoEntry;
        }

        /// <summary>
        /// Finds if default UserAgent info is already set in UserAgent collection, if not it will add it
        /// We do this because, now we accept passed in HttpClientSender.
        /// So for any reason the passed HttpClientSender has our default UserAgent info (based on key name), we will not verify and check the values and will honor those values
        /// </summary>
        private void MergeUserAgentInfo(List<ProductInfoHeaderValue> defaultUserAgentInfoList)
        {
            // If you want to log ProductName in userAgent, it has to be without spaces

            foreach(ProductInfoHeaderValue piHv in defaultUserAgentInfoList)
            {
                if(!HttpClientSender.DefaultRequestHeaders.UserAgent.Any<ProductInfoHeaderValue>((hv) => hv.Product.Name.Equals(piHv.Product.Name, StringComparison.OrdinalIgnoreCase)));
                {
                    HttpClientSender.DefaultRequestHeaders.UserAgent.Add(piHv);
                }
            }
        }
    }
}
