// MIT

namespace BlobStorageTest.Client
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ServiceOperations operations.
    /// </summary>
    public partial interface IServiceOperations
    {
        /// <summary>
        /// Sets properties for a storage account's Blob service endpoint,
        /// including properties for Storage Analytics and CORS (Cross-Origin
        /// Resource Sharing) rules
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='storageServiceProperties'>
        /// The StorageService properties.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ServiceSetPropertiesHeaders>> SetPropertiesWithHttpMessagesAsync(string accountName, StorageServiceProperties storageServiceProperties, int? timeout = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// gets the properties of a storage account's Blob service, including
        /// properties for Storage Analytics and CORS (Cross-Origin Resource
        /// Sharing) rules.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StorageServiceProperties,ServiceGetPropertiesHeaders>> GetPropertiesWithHttpMessagesAsync(string accountName, int? timeout = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves statistics related to replication for the Blob service.
        /// It is only available on the secondary location endpoint when
        /// read-access geo-redundant replication is enabled for the storage
        /// account.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<StorageServiceStats,ServiceGetStatsHeaders>> GetStatsWithHttpMessagesAsync(string accountName, int? timeout = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List Containers operation returns a list of the containers
        /// under the specified account
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='prefix'>
        /// Filters the results to return only containers whose name begins
        /// with the specified prefix.
        /// </param>
        /// <param name='marker'>
        /// A string value that identifies the portion of the list of
        /// containers to be returned with the next listing operation. The
        /// operation returns the NextMarker value within the response body if
        /// the listing operation did not return all containers remaining to be
        /// listed with the current page. The NextMarker value can be used as
        /// the value for the marker parameter in a subsequent call to request
        /// the next page of list items. The marker value is opaque to the
        /// client.
        /// </param>
        /// <param name='maxresults'>
        /// Specifies the maximum number of containers to return. If the
        /// request does not specify maxresults, or specifies a value greater
        /// than 5000, the server will return up to 5000 items. Note that if
        /// the listing operation crosses a partition boundary, then the
        /// service will return a continuation token for retrieving the
        /// remainder of the results. For this reason, it is possible that the
        /// service will return fewer results than specified by maxresults, or
        /// than the default of 5000.
        /// </param>
        /// <param name='include'>
        /// Include this parameter to specify that the container's metadata be
        /// returned as part of the response body. Possible values include:
        /// 'metadata'
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ContainerEnumerationResults,ServiceListContainersHeaders>> ListContainersWithHttpMessagesAsync(string accountName, string prefix = default(string), string marker = default(string), int? maxresults = default(int?), string include = default(string), int? timeout = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}

