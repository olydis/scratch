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
    /// ContainerOperations operations.
    /// </summary>
    public partial interface IContainerOperations
    {
        /// <summary>
        /// creates a new container under the specified account. If the
        /// container with the same name already exists, the operation fails
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='xMsMeta'>
        /// Optional. Specifies a user-defined name-value pair associated with
        /// the blob. If no name-value pairs are specified, the operation will
        /// copy the metadata from the source blob or file to the destination
        /// blob. If one or more name-value pairs are specified, the
        /// destination blob is created with the specified metadata, and
        /// metadata is not copied from the source blob or file. Note that
        /// beginning with version 2009-09-19, metadata names must adhere to
        /// the naming rules for C# identifiers. See Naming and Referencing
        /// Containers, Blobs, and Metadata for more information.
        /// </param>
        /// <param name='access'>
        /// Specifies whether data in the container may be accessed publicly
        /// and the level of access. Possible values include: 'container',
        /// 'blob'
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
        Task<AzureOperationHeaderResponse<ContainerCreateHeaders>> CreateWithHttpMessagesAsync(string accountName, string container, int? timeout = default(int?), IDictionary<string, string> xMsMeta = default(IDictionary<string, string>), string access = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// returns all user-defined metadata and system properties for the
        /// specified container. The data returned does not include the
        /// container's list of blobs
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
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
        Task<AzureOperationHeaderResponse<ContainerGetPropertiesHeaders>> GetPropertiesWithHttpMessagesAsync(string accountName, string container, int? timeout = default(int?), string leaseId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// operation marks the specified container for deletion. The container
        /// and any blobs contained within it are later deleted during garbage
        /// collection
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
        /// </param>
        /// <param name='ifModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been
        /// modified since the specified date/time.
        /// </param>
        /// <param name='ifUnmodifiedSince'>
        /// Specify this header value to operate only on a blob if it has not
        /// been modified since the specified date/time.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string accountName, string container, int? timeout = default(int?), string leaseId = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// returns all user-defined metadata for the container
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
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
        Task<AzureOperationHeaderResponse<ContainerGetMetadataHeaders>> GetMetadataWithHttpMessagesAsync(string accountName, string container, int? timeout = default(int?), string leaseId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// operation sets one or more user-defined name-value pairs for the
        /// specified container.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
        /// </param>
        /// <param name='xMsMeta'>
        /// Optional. Specifies a user-defined name-value pair associated with
        /// the blob. If no name-value pairs are specified, the operation will
        /// copy the metadata from the source blob or file to the destination
        /// blob. If one or more name-value pairs are specified, the
        /// destination blob is created with the specified metadata, and
        /// metadata is not copied from the source blob or file. Note that
        /// beginning with version 2009-09-19, metadata names must adhere to
        /// the naming rules for C# identifiers. See Naming and Referencing
        /// Containers, Blobs, and Metadata for more information.
        /// </param>
        /// <param name='ifModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been
        /// modified since the specified date/time.
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
        Task<AzureOperationHeaderResponse<ContainerSetMetadataHeaders>> SetMetadataWithHttpMessagesAsync(string accountName, string container, int? timeout = default(int?), string leaseId = default(string), IDictionary<string, string> xMsMeta = default(IDictionary<string, string>), System.DateTime? ifModifiedSince = default(System.DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
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
        Task<AzureOperationResponse<IList<SignedIdentifier>,ContainerGetAclHeaders>> GetAclWithHttpMessagesAsync(string accountName, string container, int? timeout = default(int?), string leaseId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='containerAcl'>
        /// the acls for the container
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
        /// </param>
        /// <param name='access'>
        /// Specifies whether data in the container may be accessed publicly
        /// and the level of access. Possible values include: 'container',
        /// 'blob'
        /// </param>
        /// <param name='ifModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been
        /// modified since the specified date/time.
        /// </param>
        /// <param name='ifUnmodifiedSince'>
        /// Specify this header value to operate only on a blob if it has not
        /// been modified since the specified date/time.
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
        Task<AzureOperationHeaderResponse<ContainerSetAclHeaders>> SetAclWithHttpMessagesAsync(string accountName, string container, IList<SignedIdentifier> containerAcl = default(IList<SignedIdentifier>), int? timeout = default(int?), string leaseId = default(string), string access = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// establishes and manages a lock on a container for delete
        /// operations. The lock duration can be 15 to 60 seconds, or can be
        /// infinite
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='action'>
        /// Describes what lease action to take. Possible values include:
        /// 'acquire', 'renew', 'change', 'release', 'break'
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
        /// </param>
        /// <param name='breakPeriod'>
        /// For a break operation, proposed duration the lease should continue
        /// before it is broken, in seconds, between 0 and 60. This break
        /// period is only used if it is shorter than the time remaining on the
        /// lease. If longer, the time remaining on the lease is used. A new
        /// lease will not be available before the break period has expired,
        /// but the lease may be held for longer than the break period. If this
        /// header does not appear with a break operation, a fixed-duration
        /// lease breaks after the remaining lease period elapses, and an
        /// infinite lease breaks immediately.
        /// </param>
        /// <param name='duration'>
        /// Specifies the duration of the lease, in seconds, or negative one
        /// (-1) for a lease that never expires. A non-infinite lease can be
        /// between 15 and 60 seconds. A lease duration cannot be changed using
        /// renew or change.
        /// </param>
        /// <param name='proposedLeaseId'>
        /// Proposed lease ID, in a GUID string format. The Blob service
        /// returns 400 (Invalid request) if the proposed lease ID is not in
        /// the correct format. See Guid Constructor (String) for a list of
        /// valid GUID string formats.
        /// </param>
        /// <param name='origin'>
        /// Specifies the origin from which the request is issued. The presence
        /// of this header results in cross-origin resource sharing (CORS)
        /// headers on the response.
        /// </param>
        /// <param name='ifModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been
        /// modified since the specified date/time.
        /// </param>
        /// <param name='ifUnmodifiedSince'>
        /// Specify this header value to operate only on a blob if it has not
        /// been modified since the specified date/time.
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
        Task<AzureOperationHeaderResponse<ContainerLeaseHeaders>> LeaseWithHttpMessagesAsync(string accountName, string container, string action, int? timeout = default(int?), string leaseId = default(string), int? breakPeriod = default(int?), int? duration = default(int?), string proposedLeaseId = default(string), string origin = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List Blobs operation returns a list of the blobs under the
        /// specified container
        /// </summary>
        /// <param name='accountName'>
        /// The Azure storage account to use.
        /// </param>
        /// <param name='container'>
        /// The container name.
        /// </param>
        /// <param name='prefix'>
        /// Filters the results to return only containers whose name begins
        /// with the specified prefix.
        /// </param>
        /// <param name='delimiter'>
        /// When the request includes this parameter, the operation returns a
        /// BlobPrefix element in the response body that acts as a placeholder
        /// for all blobs whose names begin with the same substring up to the
        /// appearance of the delimiter character. The delimiter may be a
        /// single character or a string.
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
        Task<AzureOperationResponse<BlobEnumerationResults,ContainerListBlobsHeaders>> ListBlobsWithHttpMessagesAsync(string accountName, string container, string prefix = default(string), string delimiter = default(string), string marker = default(string), int? maxresults = default(int?), string include = default(string), int? timeout = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
