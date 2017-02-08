// MIT

namespace BlobStorageTest.Client
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PageBlobsOperations operations.
    /// </summary>
    internal partial class PageBlobsOperations : IServiceOperations<AzureBlobStorageClient>, IPageBlobsOperations
    {
        /// <summary>
        /// Initializes a new instance of the PageBlobsOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        internal PageBlobsOperations(AzureBlobStorageClient client)
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
        /// The Put Page operation writes a range of pages to a page blob
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='blob'>
        /// The blob name.
        /// </param>
        /// <param name='pageWrite'>
        /// Required. You may specify one of the following options:
        /// - Update: Writes the bytes specified by the request body into the specified
        /// range. The Range and Content-Length headers must match to perform the
        /// update.
        /// - Clear: Clears the specified range and releases the space used in storage
        /// for that range. To clear a range, set the Content-Length header to zero,
        /// and the Range header to a value that indicates the range to clear, up to
        /// maximum blob size. Possible values include: 'update', 'clear'
        /// </param>
        /// <param name='body'>
        /// Initial data
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more information, see
        /// &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='range'>
        /// Return only the bytes of the blob in the specified range.
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease is
        /// active and matches this ID.
        /// </param>
        /// <param name='ifSequenceNumberLessThanOrEqualTo'>
        /// Specify this header value to operate only on a blob if it has a sequence
        /// number less than or equal to the specified.
        /// </param>
        /// <param name='ifSequenceNumberLessThan'>
        /// Specify this header value to operate only on a blob if it has a sequence
        /// number less than the specified.
        /// </param>
        /// <param name='ifSequenceNumberEqualTo'>
        /// Specify this header value to operate only on a blob if it has the specified
        /// sequence number.
        /// </param>
        /// <param name='ifModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been modified
        /// since the specified date/time.
        /// </param>
        /// <param name='ifUnmodifiedSince'>
        /// Specify this header value to operate only on a blob if it has not been
        /// modified since the specified date/time.
        /// </param>
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching value.
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
        public async Task<AzureOperationHeaderResponse<PageBlobsPutPageHeaders>> PutPageWithHttpMessagesAsync(string accountName, string container, string blob, PageWrite pageWrite, Stream body, int? timeout = default(int?), string range = default(string), string leaseId = default(string), int? ifSequenceNumberLessThanOrEqualTo = default(int?), int? ifSequenceNumberLessThan = default(int?), int? ifSequenceNumberEqualTo = default(int?), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (accountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "accountName");
            }
            if (container == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "container");
            }
            if (blob == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "blob");
            }
            if (blob != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(blob, "^(?!.*\\/$)^[\\s\\S]{1,1024}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "blob", "^(?!.*\\/$)^[\\s\\S]{1,1024}$");
                }
            }
            if (timeout < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "timeout", 0);
            }
            if (body == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "body");
            }
            string comp = "page";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("accountName", accountName);
                tracingParameters.Add("container", container);
                tracingParameters.Add("blob", blob);
                tracingParameters.Add("timeout", timeout);
                tracingParameters.Add("range", range);
                tracingParameters.Add("pageWrite", pageWrite);
                tracingParameters.Add("leaseId", leaseId);
                tracingParameters.Add("ifSequenceNumberLessThanOrEqualTo", ifSequenceNumberLessThanOrEqualTo);
                tracingParameters.Add("ifSequenceNumberLessThan", ifSequenceNumberLessThan);
                tracingParameters.Add("ifSequenceNumberEqualTo", ifSequenceNumberEqualTo);
                tracingParameters.Add("ifModifiedSince", ifModifiedSince);
                tracingParameters.Add("ifUnmodifiedSince", ifUnmodifiedSince);
                tracingParameters.Add("ifMatches", ifMatches);
                tracingParameters.Add("ifNoneMatch", ifNoneMatch);
                tracingParameters.Add("body", body);
                tracingParameters.Add("comp", comp);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "PutPage", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri;
            var _url = _baseUrl + (_baseUrl.EndsWith("/") ? "" : "/") + "{container}/{blob}";
            _url = _url.Replace("{accountName}", accountName);
            _url = _url.Replace("{container}", System.Uri.EscapeDataString(container));
            _url = _url.Replace("{blob}", System.Uri.EscapeDataString(blob));
            List<string> _queryParameters = new List<string>();
            if (timeout != null)
            {
                _queryParameters.Add(string.Format("timeout={0}", System.Uri.EscapeDataString(SafeJsonConvert.SerializeObject(timeout, Client.SerializationSettings).Trim('"'))));
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
            if (range != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-range"))
                {
                    _httpRequest.Headers.Remove("x-ms-range");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-range", range);
            }
            if (_httpRequest.Headers.Contains("x-ms-page-write"))
            {
                _httpRequest.Headers.Remove("x-ms-page-write");
            }
            _httpRequest.Headers.TryAddWithoutValidation("x-ms-page-write", SafeJsonConvert.SerializeObject(pageWrite, Client.SerializationSettings).Trim('"'));
            if (leaseId != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-lease-id"))
                {
                    _httpRequest.Headers.Remove("x-ms-lease-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-lease-id", leaseId);
            }
            if (ifSequenceNumberLessThanOrEqualTo != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-if-sequence-number-le"))
                {
                    _httpRequest.Headers.Remove("x-ms-if-sequence-number-le");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-if-sequence-number-le", SafeJsonConvert.SerializeObject(ifSequenceNumberLessThanOrEqualTo, Client.SerializationSettings).Trim('"'));
            }
            if (ifSequenceNumberLessThan != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-if-sequence-number-lt"))
                {
                    _httpRequest.Headers.Remove("x-ms-if-sequence-number-lt");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-if-sequence-number-lt", SafeJsonConvert.SerializeObject(ifSequenceNumberLessThan, Client.SerializationSettings).Trim('"'));
            }
            if (ifSequenceNumberEqualTo != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-if-sequence-number-eq"))
                {
                    _httpRequest.Headers.Remove("x-ms-if-sequence-number-eq");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-if-sequence-number-eq", SafeJsonConvert.SerializeObject(ifSequenceNumberEqualTo, Client.SerializationSettings).Trim('"'));
            }
            if (ifModifiedSince != null)
            {
                if (_httpRequest.Headers.Contains("If-Modified-Since"))
                {
                    _httpRequest.Headers.Remove("If-Modified-Since");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-Modified-Since", SafeJsonConvert.SerializeObject(ifModifiedSince, new DateTimeRfc1123JsonConverter()).Trim('"'));
            }
            if (ifUnmodifiedSince != null)
            {
                if (_httpRequest.Headers.Contains("If-Unmodified-Since"))
                {
                    _httpRequest.Headers.Remove("If-Unmodified-Since");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-Unmodified-Since", SafeJsonConvert.SerializeObject(ifUnmodifiedSince, new DateTimeRfc1123JsonConverter()).Trim('"'));
            }
            if (ifMatches != null)
            {
                if (_httpRequest.Headers.Contains("If-Match"))
                {
                    _httpRequest.Headers.Remove("If-Match");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-Match", ifMatches);
            }
            if (ifNoneMatch != null)
            {
                if (_httpRequest.Headers.Contains("If-None-Match"))
                {
                    _httpRequest.Headers.Remove("If-None-Match");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-None-Match", ifNoneMatch);
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
            if(body == null)
            {
              throw new System.ArgumentNullException("body");
            }
            if (body != null && body != Stream.Null)
            {
              _httpRequest.Content = new System.Net.Http.StreamContent(body);
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
            if ((int)_statusCode != 201)
            {
                var ex = new ErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Error _errorBody =  SafeJsonConvert.DeserializeObject<Error>(_responseContent, Client.DeserializationSettings);
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
            var _result = new AzureOperationHeaderResponse<PageBlobsPutPageHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<PageBlobsPutPageHeaders>(JsonSerializer.Create(Client.DeserializationSettings));
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
        /// The Get Page Ranges operation returns the list of valid page ranges for a
        /// page blob or snapshot of a page blob
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='blob'>
        /// The blob name.
        /// </param>
        /// <param name='snapshot'>
        /// The snapshot parameter is an opaque DateTime value that, when present,
        /// specifies the blob snapshot to retrieve. For more information on working
        /// with blob snapshots, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/creating-a-snapshot-of-a-blob"&gt;Creating
        /// a Snapshot of a Blob.&lt;/a&gt;
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more information, see
        /// &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='prevsnapshot'>
        /// Optional in version 2015-07-08 and newer. The prevsnapshot parameter is a
        /// DateTime value that specifies that the response will contain only pages
        /// that were changed between target blob and previous snapshot. Changed pages
        /// include both updated and cleared pages. The target blob may be a snapshot,
        /// as long as the snapshot specified by prevsnapshot is the older of the two.
        /// Note that incremental snapshots are currently supported only for blobs
        /// created on or after January 1, 2016.
        /// </param>
        /// <param name='range'>
        /// Return only the bytes of the blob in the specified range.
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease is
        /// active and matches this ID.
        /// </param>
        /// <param name='ifModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been modified
        /// since the specified date/time.
        /// </param>
        /// <param name='ifUnmodifiedSince'>
        /// Specify this header value to operate only on a blob if it has not been
        /// modified since the specified date/time.
        /// </param>
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching value.
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
        public async Task<AzureOperationResponse<object,PageBlobsGetPageRangesHeaders>> GetPageRangesWithHttpMessagesAsync(string accountName, string container, string blob, System.DateTime? snapshot = default(System.DateTime?), int? timeout = default(int?), System.DateTime? prevsnapshot = default(System.DateTime?), string range = default(string), string leaseId = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (accountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "accountName");
            }
            if (container == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "container");
            }
            if (blob == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "blob");
            }
            if (blob != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(blob, "^(?!.*\\/$)^[\\s\\S]{1,1024}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "blob", "^(?!.*\\/$)^[\\s\\S]{1,1024}$");
                }
            }
            if (timeout < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "timeout", 0);
            }
            string comp = "pagelist";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("accountName", accountName);
                tracingParameters.Add("container", container);
                tracingParameters.Add("blob", blob);
                tracingParameters.Add("snapshot", snapshot);
                tracingParameters.Add("timeout", timeout);
                tracingParameters.Add("prevsnapshot", prevsnapshot);
                tracingParameters.Add("range", range);
                tracingParameters.Add("leaseId", leaseId);
                tracingParameters.Add("ifModifiedSince", ifModifiedSince);
                tracingParameters.Add("ifUnmodifiedSince", ifUnmodifiedSince);
                tracingParameters.Add("ifMatches", ifMatches);
                tracingParameters.Add("ifNoneMatch", ifNoneMatch);
                tracingParameters.Add("comp", comp);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GetPageRanges", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri;
            var _url = _baseUrl + (_baseUrl.EndsWith("/") ? "" : "/") + "{container}/{blob}";
            _url = _url.Replace("{accountName}", accountName);
            _url = _url.Replace("{container}", System.Uri.EscapeDataString(container));
            _url = _url.Replace("{blob}", System.Uri.EscapeDataString(blob));
            List<string> _queryParameters = new List<string>();
            if (snapshot != null)
            {
                _queryParameters.Add(string.Format("snapshot={0}", System.Uri.EscapeDataString(SafeJsonConvert.SerializeObject(snapshot, new DateTimeRfc1123JsonConverter()).Trim('"'))));
            }
            if (timeout != null)
            {
                _queryParameters.Add(string.Format("timeout={0}", System.Uri.EscapeDataString(SafeJsonConvert.SerializeObject(timeout, Client.SerializationSettings).Trim('"'))));
            }
            if (prevsnapshot != null)
            {
                _queryParameters.Add(string.Format("prevsnapshot={0}", System.Uri.EscapeDataString(SafeJsonConvert.SerializeObject(prevsnapshot, new DateTimeRfc1123JsonConverter()).Trim('"'))));
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
            if (range != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-range"))
                {
                    _httpRequest.Headers.Remove("x-ms-range");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-range", range);
            }
            if (leaseId != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-lease-id"))
                {
                    _httpRequest.Headers.Remove("x-ms-lease-id");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-lease-id", leaseId);
            }
            if (ifModifiedSince != null)
            {
                if (_httpRequest.Headers.Contains("If-Modified-Since"))
                {
                    _httpRequest.Headers.Remove("If-Modified-Since");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-Modified-Since", SafeJsonConvert.SerializeObject(ifModifiedSince, new DateTimeRfc1123JsonConverter()).Trim('"'));
            }
            if (ifUnmodifiedSince != null)
            {
                if (_httpRequest.Headers.Contains("If-Unmodified-Since"))
                {
                    _httpRequest.Headers.Remove("If-Unmodified-Since");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-Unmodified-Since", SafeJsonConvert.SerializeObject(ifUnmodifiedSince, new DateTimeRfc1123JsonConverter()).Trim('"'));
            }
            if (ifMatches != null)
            {
                if (_httpRequest.Headers.Contains("If-Match"))
                {
                    _httpRequest.Headers.Remove("If-Match");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-Match", ifMatches);
            }
            if (ifNoneMatch != null)
            {
                if (_httpRequest.Headers.Contains("If-None-Match"))
                {
                    _httpRequest.Headers.Remove("If-None-Match");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-None-Match", ifNoneMatch);
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
                    Error _errorBody =  SafeJsonConvert.DeserializeObject<Error>(_responseContent, Client.DeserializationSettings);
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
            var _result = new AzureOperationResponse<object,PageBlobsGetPageRangesHeaders>();
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
                    object _tmp_ = null;
                    if (_httpResponse.Content.Headers.ContentType.MediaType == "application/xml" &&
                        XmlSerialization.Root(XmlSerialization.ToDeserializer(e => (object)e))(System.Xml.Linq.XElement.Parse(_responseContent), out _tmp_))
                    {
                        _result.Body = _tmp_;
                    }else
                    {
                        _result.Body = SafeJsonConvert.DeserializeObject<object>(_responseContent, Client.DeserializationSettings);
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
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<PageBlobsGetPageRangesHeaders>(JsonSerializer.Create(Client.DeserializationSettings));
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
        /// The Incremental Copy Blob operation copies a snapshot of the source page
        /// blob to a destination page blob. The snapshot is copied such that only the
        /// differential changes between the previously copied snapshot are transferred
        /// to the destination. The copied snapshots are complete copies of the
        /// original snapshot and can be read or copied from as usual. This API is
        /// supported since REST version 2016-05-31.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='blob'>
        /// The blob name.
        /// </param>
        /// <param name='copySource'>
        /// Specifies the name of the source page blob snapshot. This value is a URL of
        /// up to 2 KB in length that specifies a page blob snapshot. The value should
        /// be URL-encoded as it would appear in a request URI. The source blob must
        /// either be public or must be authenticated via a shared access signature.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more information, see
        /// &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='xMsMeta'>
        /// Optional. Specifies a user-defined name-value pair associated with the
        /// blob. If no name-value pairs are specified, the operation will copy the
        /// metadata from the source blob or file to the destination blob. If one or
        /// more name-value pairs are specified, the destination blob is created with
        /// the specified metadata, and metadata is not copied from the source blob or
        /// file. Note that beginning with version 2009-09-19, metadata names must
        /// adhere to the naming rules for C# identifiers. See Naming and Referencing
        /// Containers, Blobs, and Metadata for more information.
        /// </param>
        /// <param name='ifModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been modified
        /// since the specified date/time.
        /// </param>
        /// <param name='ifUnmodifiedSince'>
        /// Specify this header value to operate only on a blob if it has not been
        /// modified since the specified date/time.
        /// </param>
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching value.
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
        public async Task<AzureOperationHeaderResponse<PageBlobsIncrementalCopyHeaders>> IncrementalCopyWithHttpMessagesAsync(string accountName, string container, string blob, string copySource, int? timeout = default(int?), IDictionary<string, string> xMsMeta = default(IDictionary<string, string>), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (accountName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "accountName");
            }
            if (container == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "container");
            }
            if (blob == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "blob");
            }
            if (blob != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(blob, "^(?!.*\\/$)^[\\s\\S]{1,1024}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "blob", "^(?!.*\\/$)^[\\s\\S]{1,1024}$");
                }
            }
            if (timeout < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "timeout", 0);
            }
            if (xMsMeta != null)
            {
                if (!System.Linq.Enumerable.All(xMsMeta.Values, value => System.Text.RegularExpressions.Regex.IsMatch(value, "^(?:((?!\\d)\\w+(?:\\.(?!\\d)\\w+)*)\\.)?((?!\\d)\\w+)$")))
                {
                    throw new ValidationException(ValidationRules.Pattern, "xMsMeta", "^(?:((?!\\d)\\w+(?:\\.(?!\\d)\\w+)*)\\.)?((?!\\d)\\w+)$");
                }
            }
            if (copySource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "copySource");
            }
            string comp = "incrementalcopy";
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("accountName", accountName);
                tracingParameters.Add("container", container);
                tracingParameters.Add("blob", blob);
                tracingParameters.Add("timeout", timeout);
                tracingParameters.Add("xMsMeta", xMsMeta);
                tracingParameters.Add("ifModifiedSince", ifModifiedSince);
                tracingParameters.Add("ifUnmodifiedSince", ifUnmodifiedSince);
                tracingParameters.Add("ifMatches", ifMatches);
                tracingParameters.Add("ifNoneMatch", ifNoneMatch);
                tracingParameters.Add("copySource", copySource);
                tracingParameters.Add("comp", comp);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "IncrementalCopy", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri;
            var _url = _baseUrl + (_baseUrl.EndsWith("/") ? "" : "/") + "{container}/{blob}";
            _url = _url.Replace("{accountName}", accountName);
            _url = _url.Replace("{container}", System.Uri.EscapeDataString(container));
            _url = _url.Replace("{blob}", System.Uri.EscapeDataString(blob));
            List<string> _queryParameters = new List<string>();
            if (timeout != null)
            {
                _queryParameters.Add(string.Format("timeout={0}", System.Uri.EscapeDataString(SafeJsonConvert.SerializeObject(timeout, Client.SerializationSettings).Trim('"'))));
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
            if (ifModifiedSince != null)
            {
                if (_httpRequest.Headers.Contains("If-Modified-Since"))
                {
                    _httpRequest.Headers.Remove("If-Modified-Since");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-Modified-Since", SafeJsonConvert.SerializeObject(ifModifiedSince, new DateTimeRfc1123JsonConverter()).Trim('"'));
            }
            if (ifUnmodifiedSince != null)
            {
                if (_httpRequest.Headers.Contains("If-Unmodified-Since"))
                {
                    _httpRequest.Headers.Remove("If-Unmodified-Since");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-Unmodified-Since", SafeJsonConvert.SerializeObject(ifUnmodifiedSince, new DateTimeRfc1123JsonConverter()).Trim('"'));
            }
            if (ifMatches != null)
            {
                if (_httpRequest.Headers.Contains("If-Match"))
                {
                    _httpRequest.Headers.Remove("If-Match");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-Match", ifMatches);
            }
            if (ifNoneMatch != null)
            {
                if (_httpRequest.Headers.Contains("If-None-Match"))
                {
                    _httpRequest.Headers.Remove("If-None-Match");
                }
                _httpRequest.Headers.TryAddWithoutValidation("If-None-Match", ifNoneMatch);
            }
            if (copySource != null)
            {
                if (_httpRequest.Headers.Contains("x-ms-copy-source"))
                {
                    _httpRequest.Headers.Remove("x-ms-copy-source");
                }
                _httpRequest.Headers.TryAddWithoutValidation("x-ms-copy-source", copySource);
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

            if (xMsMeta != null)
            {
                foreach (var _header in xMsMeta)
                {
                    var key = "x-ms-meta-" + _header.Key;
                    if (_httpRequest.Headers.Contains(key))
                    {
                        _httpRequest.Headers.Remove(key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(key, _header.Value);
                }
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
            if ((int)_statusCode != 202)
            {
                var ex = new ErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Error _errorBody =  SafeJsonConvert.DeserializeObject<Error>(_responseContent, Client.DeserializationSettings);
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
            var _result = new AzureOperationHeaderResponse<PageBlobsIncrementalCopyHeaders>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            if (_httpResponse.Headers.Contains("x-ms-request-id"))
            {
                _result.RequestId = _httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
            }
            try
            {
                _result.Headers = _httpResponse.GetHeadersAsJson().ToObject<PageBlobsIncrementalCopyHeaders>(JsonSerializer.Create(Client.DeserializationSettings));
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

