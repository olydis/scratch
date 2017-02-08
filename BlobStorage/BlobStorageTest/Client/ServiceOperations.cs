// MIT

namespace BlobStorageTest.Client
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// ServiceOperations operations.
    /// </summary>
    internal partial class ServiceOperations : IServiceOperations<AzureBlobStorageClient>, IServiceOperations
    {
        /// <summary>
        /// Initializes a new instance of the ServiceOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        internal ServiceOperations(AzureBlobStorageClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the AzureStorageClient
        /// </summary>
        public AzureBlobStorageClient Client { get; private set; }

        /// <summary>
        /// Sets properties for a storage account's Blob service endpoint, including
        /// properties for Storage Analytics and CORS (Cross-Origin Resource Sharing)
        /// rules
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='storageServiceProperties'>
        /// The StorageService properties.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more information, see
        /// &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationHeaderResponse<ServiceSetPropertiesHeaders>> SetPropertiesWithHttpMessagesAsync(string accountName, StorageServiceProperties storageServiceProperties, int? timeout = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (accountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "accountName");
            }
            if (storageServiceProperties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "storageServiceProperties");
            }
            if (storageServiceProperties != null)
            {
                storageServiceProperties.Validate();
            }
            if (timeout < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "timeout", 0);
            }
            string restype = "service";
            string comp = "properties";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("accountName", accountName);
                tracingParameters.Add("storageServiceProperties", storageServiceProperties);
                tracingParameters.Add("timeout", timeout);
                tracingParameters.Add("restype", restype);
                tracingParameters.Add("comp", comp);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "SetProperties", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri;
            var _url = _baseUrl + (_baseUrl.EndsWith("/") ? "" : "/") + "";
            _url = _url.Replace("{accountName}", accountName);
            List<string> _queryParameters = new List<string>();
            if (timeout != null)
            {
                _queryParameters.Add(string.Format("timeout={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(timeout, Client.SerializationSettings).Trim('"'))));
            }
            if (restype != null)
            {
                _queryParameters.Add(string.Format("restype={0}", System.Uri.EscapeDataString(restype)));
            }
            if (comp != null)
            {
                _queryParameters.Add(string.Format("comp={0}", System.Uri.EscapeDataString(comp)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new System.Net.Http.HttpRequestMessage();
            System.Net.Http.HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new System.Net.Http.HttpMethod("PUT");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (Client.Version != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-version"))
                {
                    _httpRequest.Headers.Remove("x-ms-version");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-version", Client.Version);
            }
            if (Client.RequestId != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-client-request-id"))
                {
                    _httpRequest.Headers.Remove("x-ms-client-request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", Client.RequestId);
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            if(storageServiceProperties != null)
            {
                _requestContent = storageServiceProperties.XmlSerialize( new XElement("StorageServiceProperties") ).ToString();
                _requestContent = $"<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n{_requestContent}";
                _httpRequest.Content = new System.Net.Http.StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/xml; charset=utf-8");
            }
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 202)
            {
                var ex = new ErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Error _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Error>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationHeaderResponse<ServiceSetPropertiesHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<ServiceSetPropertiesHeaders>(JsonSerializer.Create(Client.DeserializationSettings));
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// gets the properties of a storage account's Blob service, including
        /// properties for Storage Analytics and CORS (Cross-Origin Resource Sharing)
        /// rules.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more information, see
        /// &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse<StorageServiceProperties,ServiceGetPropertiesHeaders>> GetPropertiesWithHttpMessagesAsync(string accountName, int? timeout = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (accountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "accountName");
            }
            if (timeout < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "timeout", 0);
            }
            string restype = "service";
            string comp = "properties";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("accountName", accountName);
                tracingParameters.Add("timeout", timeout);
                tracingParameters.Add("restype", restype);
                tracingParameters.Add("comp", comp);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetProperties", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri;
            var _url = _baseUrl + (_baseUrl.EndsWith("/") ? "" : "/") + "";
            _url = _url.Replace("{accountName}", accountName);
            List<string> _queryParameters = new List<string>();
            if (timeout != null)
            {
                _queryParameters.Add(string.Format("timeout={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(timeout, Client.SerializationSettings).Trim('"'))));
            }
            if (restype != null)
            {
                _queryParameters.Add(string.Format("restype={0}", System.Uri.EscapeDataString(restype)));
            }
            if (comp != null)
            {
                _queryParameters.Add(string.Format("comp={0}", System.Uri.EscapeDataString(comp)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new System.Net.Http.HttpRequestMessage();
            System.Net.Http.HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new System.Net.Http.HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (Client.Version != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-version"))
                {
                    _httpRequest.Headers.Remove("x-ms-version");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-version", Client.Version);
            }
            if (Client.RequestId != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-client-request-id"))
                {
                    _httpRequest.Headers.Remove("x-ms-client-request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", Client.RequestId);
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Error _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Error>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse<StorageServiceProperties,ServiceGetPropertiesHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    StorageServiceProperties _tmp_ = null;
                    if (_httpResponse.Content.Headers.ContentType.MediaType == "application/xml" &&
                        XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(_responseContent), out _tmp_))
                    {
                        _result.Body = _tmp_;
                    }else
                    {
                        _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<StorageServiceProperties>(_responseContent, Client.DeserializationSettings);
                    }
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<ServiceGetPropertiesHeaders>(JsonSerializer.Create(Client.DeserializationSettings));
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Retrieves statistics related to replication for the Blob service. It is
        /// only available on the secondary location endpoint when read-access
        /// geo-redundant replication is enabled for the storage account.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more information, see
        /// &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse<StorageServiceStats,ServiceGetStatsHeaders>> GetStatsWithHttpMessagesAsync(string accountName, int? timeout = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (accountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "accountName");
            }
            if (timeout < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "timeout", 0);
            }
            string restype = "service";
            string comp = "stats";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("accountName", accountName);
                tracingParameters.Add("timeout", timeout);
                tracingParameters.Add("restype", restype);
                tracingParameters.Add("comp", comp);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetStats", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri;
            var _url = _baseUrl + (_baseUrl.EndsWith("/") ? "" : "/") + "";
            _url = _url.Replace("{accountName}", accountName);
            List<string> _queryParameters = new List<string>();
            if (timeout != null)
            {
                _queryParameters.Add(string.Format("timeout={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(timeout, Client.SerializationSettings).Trim('"'))));
            }
            if (restype != null)
            {
                _queryParameters.Add(string.Format("restype={0}", System.Uri.EscapeDataString(restype)));
            }
            if (comp != null)
            {
                _queryParameters.Add(string.Format("comp={0}", System.Uri.EscapeDataString(comp)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new System.Net.Http.HttpRequestMessage();
            System.Net.Http.HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new System.Net.Http.HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (Client.Version != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-version"))
                {
                    _httpRequest.Headers.Remove("x-ms-version");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-version", Client.Version);
            }
            if (Client.RequestId != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-client-request-id"))
                {
                    _httpRequest.Headers.Remove("x-ms-client-request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", Client.RequestId);
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Error _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Error>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse<StorageServiceStats,ServiceGetStatsHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    StorageServiceStats _tmp_ = null;
                    if (_httpResponse.Content.Headers.ContentType.MediaType == "application/xml" &&
                        XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceStats.XmlDeserialize(e)))(XElement.Parse(_responseContent), out _tmp_))
                    {
                        _result.Body = _tmp_;
                    }else
                    {
                        _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<StorageServiceStats>(_responseContent, Client.DeserializationSettings);
                    }
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<ServiceGetStatsHeaders>(JsonSerializer.Create(Client.DeserializationSettings));
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// The List Containers operation returns a list of the containers under the
        /// specified account
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='prefix'>
        /// Filters the results to return only containers whose name begins with the
        /// specified prefix.
        /// </param>
        /// <param name='marker'>
        /// A string value that identifies the portion of the list of containers to be
        /// returned with the next listing operation. The operation returns the
        /// NextMarker value within the response body if the listing operation did not
        /// return all containers remaining to be listed with the current page. The
        /// NextMarker value can be used as the value for the marker parameter in a
        /// subsequent call to request the next page of list items. The marker value is
        /// opaque to the client.
        /// </param>
        /// <param name='maxresults'>
        /// Specifies the maximum number of containers to return. If the request does
        /// not specify maxresults, or specifies a value greater than 5000, the server
        /// will return up to 5000 items. Note that if the listing operation crosses a
        /// partition boundary, then the service will return a continuation token for
        /// retrieving the remainder of the results. For this reason, it is possible
        /// that the service will return fewer results than specified by maxresults, or
        /// than the default of 5000.
        /// </param>
        /// <param name='include'>
        /// Include this parameter to specify that the container's metadata be returned
        /// as part of the response body. Possible values include: 'metadata'
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more information, see
        /// &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<AzureOperationResponse<ContainerEnumerationResults,ServiceListContainersHeaders>> ListContainersWithHttpMessagesAsync(string accountName, string prefix = default(string), string marker = default(string), int? maxresults = default(int?), string include = default(string), int? timeout = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (accountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "accountName");
            }
            if (maxresults < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "maxresults", 0);
            }
            if (timeout < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "timeout", 0);
            }
            string comp = "list";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("accountName", accountName);
                tracingParameters.Add("prefix", prefix);
                tracingParameters.Add("marker", marker);
                tracingParameters.Add("maxresults", maxresults);
                tracingParameters.Add("include", include);
                tracingParameters.Add("timeout", timeout);
                tracingParameters.Add("comp", comp);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "ListContainers", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri;
            var _url = _baseUrl + (_baseUrl.EndsWith("/") ? "" : "/") + "";
            _url = _url.Replace("{accountName}", accountName);
            List<string> _queryParameters = new List<string>();
            if (prefix != null)
            {
                _queryParameters.Add(string.Format("prefix={0}", System.Uri.EscapeDataString(prefix)));
            }
            if (marker != null)
            {
                _queryParameters.Add(string.Format("marker={0}", System.Uri.EscapeDataString(marker)));
            }
            if (maxresults != null)
            {
                _queryParameters.Add(string.Format("maxresults={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(maxresults, Client.SerializationSettings).Trim('"'))));
            }
            if (include != null)
            {
                _queryParameters.Add(string.Format("include={0}", System.Uri.EscapeDataString(include)));
            }
            if (timeout != null)
            {
                _queryParameters.Add(string.Format("timeout={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(timeout, Client.SerializationSettings).Trim('"'))));
            }
            if (comp != null)
            {
                _queryParameters.Add(string.Format("comp={0}", System.Uri.EscapeDataString(comp)));
            }
            if (_queryParameters.Count > 0)
            {
                _url += (_url.Contains("?") ? "&" : "?") + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new System.Net.Http.HttpRequestMessage();
            System.Net.Http.HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new System.Net.Http.HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (Client.GenerateClientRequestId != null && Client.GenerateClientRequestId.Value)
            {
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", System.Guid.NewGuid().ToString());
            }
            if (Client.Version != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-version"))
                {
                    _httpRequest.Headers.Remove("x-ms-version");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-version", Client.Version);
            }
            if (Client.RequestId != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-client-request-id"))
                {
                    _httpRequest.Headers.Remove("x-ms-client-request-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-client-request-id", Client.RequestId);
            }
            if (Client.AcceptLanguage != null)
            {
                if (_httpRequest.Headers.Contains("accept-language"))
                {
                    _httpRequest.Headers.Remove("accept-language");
                }
                _httpRequest.Headers.TryAddWithoutValidation("accept-language", Client.AcceptLanguage);
            }


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Error _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Error>(_responseContent, Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new AzureOperationResponse<ContainerEnumerationResults,ServiceListContainersHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    ContainerEnumerationResults _tmp_ = null;
                    if (_httpResponse.Content.Headers.ContentType.MediaType == "application/xml" &&
                        XmlSerialization.Root(XmlSerialization.ToDeserializer(e => ContainerEnumerationResults.XmlDeserialize(e)))(XElement.Parse(_responseContent), out _tmp_))
                    {
                        _result.Body = _tmp_;
                    }else
                    {
                        _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<ContainerEnumerationResults>(_responseContent, Client.DeserializationSettings);
                    }
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<ServiceListContainersHeaders>(JsonSerializer.Create(Client.DeserializationSettings));
            }
            catch (JsonException ex)
            {
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw new SerializationException("Unable to deserialize the headers.", _httpResponse.GetHeadersAsJson().ToString(), ex);
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}

