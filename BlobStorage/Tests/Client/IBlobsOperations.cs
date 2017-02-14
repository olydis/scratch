// MIT

namespace BlobStorageTest.Client
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// BlobsOperations operations.
    /// </summary>
    public partial interface IBlobsOperations
    {
        /// <summary>
        /// The Get Blob operation reads or downloads a blob from the system,
        /// including its metadata and properties. You can also call Get Blob
        /// to read a snapshot.
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
        /// The snapshot parameter is an opaque DateTime value that, when
        /// present, specifies the blob snapshot to retrieve. For more
        /// information on working with blob snapshots, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/creating-a-snapshot-of-a-blob"&gt;Creating
        /// a Snapshot of a Blob.&lt;/a&gt;
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='range'>
        /// Return only the bytes of the blob in the specified range.
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
        /// </param>
        /// <param name='xMsRangeGetContentMd5'>
        /// When set to true and specified together with the Range, the service
        /// returns the MD5 hash for the range, as long as the range is less
        /// than or equal to 4 MB in size.
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
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching
        /// value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching
        /// value.
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
        Task<AzureOperationResponse<Stream,BlobsGetHeaders>> GetWithHttpMessagesAsync(string accountName, string container, string blob, System.DateTime? snapshot = default(System.DateTime?), int? timeout = default(int?), string range = default(string), string leaseId = default(string), bool? xMsRangeGetContentMd5 = default(bool?), string origin = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Get Blob Properties operation returns all user-defined
        /// metadata, standard HTTP properties, and system properties for the
        /// blob. It does not return the content of the blob.
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
        /// The snapshot parameter is an opaque DateTime value that, when
        /// present, specifies the blob snapshot to retrieve. For more
        /// information on working with blob snapshots, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/creating-a-snapshot-of-a-blob"&gt;Creating
        /// a Snapshot of a Blob.&lt;/a&gt;
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
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching
        /// value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching
        /// value.
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
        Task<AzureOperationHeaderResponse<BlobsGetPropertiesHeaders>> GetPropertiesWithHttpMessagesAsync(string accountName, string container, string blob, System.DateTime? snapshot = default(System.DateTime?), int? timeout = default(int?), string leaseId = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Delete Blob operation marks the specified blob or snapshot for
        /// deletion. The blob is later deleted during garbage collection. Note
        /// that in order to delete a blob, you must delete all of its
        /// snapshots. You can delete both at the same time with the Delete
        /// Blob operation.
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
        /// The snapshot parameter is an opaque DateTime value that, when
        /// present, specifies the blob snapshot to retrieve. For more
        /// information on working with blob snapshots, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/creating-a-snapshot-of-a-blob"&gt;Creating
        /// a Snapshot of a Blob.&lt;/a&gt;
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
        /// <param name='deleteSnapshots'>
        /// Required if the blob has associated snapshots. Specify one of the
        /// following two options: include: Delete the base blob and all of its
        /// snapshots. only: Delete only the blob's snapshots and not the blob
        /// itself. Possible values include: 'include', 'only'
        /// </param>
        /// <param name='ifModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been
        /// modified since the specified date/time.
        /// </param>
        /// <param name='ifUnmodifiedSince'>
        /// Specify this header value to operate only on a blob if it has not
        /// been modified since the specified date/time.
        /// </param>
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching
        /// value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching
        /// value.
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
        Task<AzureOperationHeaderResponse<BlobsDeleteHeaders>> DeleteWithHttpMessagesAsync(string accountName, string container, string blob, System.DateTime? snapshot = default(System.DateTime?), int? timeout = default(int?), string leaseId = default(string), DeleteSnapshotsOption? deleteSnapshots = default(DeleteSnapshotsOption?), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Put Blob operation creates a new block, page, or append blob,
        /// or updates the content of an existing block blob. Updating an
        /// existing block blob overwrites any existing metadata on the blob.
        /// Partial updates are not supported with Put Blob; the content of the
        /// existing blob is overwritten with the content of the new blob. To
        /// perform a partial update of the content of a block blob, use the
        /// Put Block List operation.
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
        /// <param name='blobType'>
        /// Specifies the type of blob to create: block blob, page blob, or
        /// append blob. Possible values include: 'BlockBlob', 'PageBlob',
        /// 'AppendBlob'
        /// </param>
        /// <param name='body'>
        /// Initial data
        /// </param>
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='cacheControl'>
        /// Cache control for given resource
        /// </param>
        /// <param name='xMsBlobContentType'>
        /// Optional. Sets the blob's content type. If specified, this property
        /// is stored with the blob and returned with a read request.
        /// </param>
        /// <param name='xMsBlobContentEncoding'>
        /// Optional. Sets the blob's content encoding. If specified, this
        /// property is stored with the blob and returned with a read request.
        /// </param>
        /// <param name='xMsBlobContentLanguage'>
        /// Optional. Set the blob's content language. If specified, this
        /// property is stored with the blob and returned with a read request.
        /// </param>
        /// <param name='xMsBlobContentMd5'>
        /// Optional. An MD5 hash of the blob content. Note that this hash is
        /// not validated, as the hashes for the individual blocks were
        /// validated when each was uploaded.
        /// </param>
        /// <param name='xMsBlobCacheControl'>
        /// Optional. Sets the blob's cache control. If specified, this
        /// property is stored with the blob and returned with a read request.
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
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
        /// </param>
        /// <param name='xMsBlobContentDisposition'>
        /// Optional. Sets the blob's Content-Disposition header.
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
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching
        /// value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching
        /// value.
        /// </param>
        /// <param name='xMsBlobContentLength'>
        /// This header specifies the maximum size for the page blob, up to 1
        /// TB. The page blob size must be aligned to a 512-byte boundary.
        /// </param>
        /// <param name='blobSequenceNumber'>
        /// Set for page blobs only. The sequence number is a user-controlled
        /// value that you can use to track requests. The value of the sequence
        /// number must be between 0 and 2^63 - 1.
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
        Task<AzureOperationHeaderResponse<BlobsPutHeaders>> PutWithHttpMessagesAsync(string accountName, string container, string blob, BlobType blobType, Stream body, int? timeout = default(int?), string cacheControl = default(string), string xMsBlobContentType = default(string), string xMsBlobContentEncoding = default(string), string xMsBlobContentLanguage = default(string), string xMsBlobContentMd5 = default(string), string xMsBlobCacheControl = default(string), IDictionary<string, string> xMsMeta = default(IDictionary<string, string>), string leaseId = default(string), string xMsBlobContentDisposition = default(string), string origin = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), long? xMsBlobContentLength = default(long?), long? blobSequenceNumber = 0, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Set Blob Properties operation sets system properties on the
        /// blob
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
        /// <param name='timeout'>
        /// The timeout parameter is expressed in seconds. For more
        /// information, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/setting-timeouts-for-blob-service-operations"&gt;Setting
        /// Timeouts for Blob Service Operations.&lt;/a&gt;
        /// </param>
        /// <param name='xMsBlobCacheControl'>
        /// Optional. Sets the blob's cache control. If specified, this
        /// property is stored with the blob and returned with a read request.
        /// </param>
        /// <param name='xMsBlobContentType'>
        /// Optional. Sets the blob's content type. If specified, this property
        /// is stored with the blob and returned with a read request.
        /// </param>
        /// <param name='xMsBlobContentMd5'>
        /// Optional. An MD5 hash of the blob content. Note that this hash is
        /// not validated, as the hashes for the individual blocks were
        /// validated when each was uploaded.
        /// </param>
        /// <param name='xMsBlobContentEncoding'>
        /// Optional. Sets the blob's content encoding. If specified, this
        /// property is stored with the blob and returned with a read request.
        /// </param>
        /// <param name='xMsBlobContentLanguage'>
        /// Optional. Set the blob's content language. If specified, this
        /// property is stored with the blob and returned with a read request.
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
        /// </param>
        /// <param name='xMsBlobContentDisposition'>
        /// Optional. Sets the blob's Content-Disposition header.
        /// </param>
        /// <param name='origin'>
        /// Specifies the origin from which the request is issued. The presence
        /// of this header results in cross-origin resource sharing (CORS)
        /// headers on the response.
        /// </param>
        /// <param name='xMsBlobContentLength'>
        /// This header specifies the maximum size for the page blob, up to 1
        /// TB. The page blob size must be aligned to a 512-byte boundary.
        /// </param>
        /// <param name='sequenceNumberAction'>
        /// Required if the x-ms-blob-sequence-number header is set for the
        /// request. This property applies to page blobs only. This property
        /// indicates how the service should modify the blob's sequence number.
        /// Possible values include: 'max', 'update', 'increment'
        /// </param>
        /// <param name='blobSequenceNumber'>
        /// Set for page blobs only. The sequence number is a user-controlled
        /// value that you can use to track requests. The value of the sequence
        /// number must be between 0 and 2^63 - 1.
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
        Task<AzureOperationHeaderResponse<BlobsSetPropertiesHeaders>> SetPropertiesWithHttpMessagesAsync(string accountName, string container, string blob, int? timeout = default(int?), string xMsBlobCacheControl = default(string), string xMsBlobContentType = default(string), string xMsBlobContentMd5 = default(string), string xMsBlobContentEncoding = default(string), string xMsBlobContentLanguage = default(string), string leaseId = default(string), string xMsBlobContentDisposition = default(string), string origin = default(string), long? xMsBlobContentLength = default(long?), SequenceNumberAction? sequenceNumberAction = default(SequenceNumberAction?), long? blobSequenceNumber = 0, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Get Blob Metadata operation returns all user-defined metadata
        /// for the specified blob or snapshot
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
        /// The snapshot parameter is an opaque DateTime value that, when
        /// present, specifies the blob snapshot to retrieve. For more
        /// information on working with blob snapshots, see &lt;a
        /// href="https://docs.microsoft.com/en-us/rest/api/storageservices/fileservices/creating-a-snapshot-of-a-blob"&gt;Creating
        /// a Snapshot of a Blob.&lt;/a&gt;
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
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching
        /// value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching
        /// value.
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
        Task<AzureOperationHeaderResponse<BlobsGetMetadataHeaders>> GetMetadataWithHttpMessagesAsync(string accountName, string container, string blob, System.DateTime? snapshot = default(System.DateTime?), int? timeout = default(int?), string leaseId = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Set Blob Metadata operation sets user-defined metadata for the
        /// specified blob as one or more name-value pairs
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
        Task<AzureOperationHeaderResponse<BlobsSetMetadataHeaders>> SetMetadataWithHttpMessagesAsync(string accountName, string container, string blob, int? timeout = default(int?), IDictionary<string, string> xMsMeta = default(IDictionary<string, string>), string leaseId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Lease Blob operation establishes and manages a lock on a blob
        /// for write and delete operations
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
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching
        /// value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching
        /// value.
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
        Task<AzureOperationHeaderResponse<BlobsLeaseHeaders>> LeaseWithHttpMessagesAsync(string accountName, string container, string blob, string action, int? timeout = default(int?), string leaseId = default(string), int? breakPeriod = default(int?), int? duration = default(int?), string proposedLeaseId = default(string), string origin = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Snapshot Blob operation creates a read-only snapshot of a blob
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
        /// <param name='ifModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been
        /// modified since the specified date/time.
        /// </param>
        /// <param name='ifUnmodifiedSince'>
        /// Specify this header value to operate only on a blob if it has not
        /// been modified since the specified date/time.
        /// </param>
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching
        /// value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching
        /// value.
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
        Task<AzureOperationHeaderResponse<BlobsTakeSnapshotHeaders>> TakeSnapshotWithHttpMessagesAsync(string accountName, string container, string blob, int? timeout = default(int?), IDictionary<string, string> xMsMeta = default(IDictionary<string, string>), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), string leaseId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Copy Blob operation copies a blob to a destination within the
        /// storage account.
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
        /// Specifies the name of the source page blob snapshot. This value is
        /// a URL of up to 2 KB in length that specifies a page blob snapshot.
        /// The value should be URL-encoded as it would appear in a request
        /// URI. The source blob must either be public or must be authenticated
        /// via a shared access signature.
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
        /// <param name='sourceIfModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been
        /// modified since the specified date/time.
        /// </param>
        /// <param name='sourceIfUnmodifiedSince'>
        /// Specify this header value to operate only on a blob if it has not
        /// been modified since the specified date/time.
        /// </param>
        /// <param name='sourceIfMatches'>
        /// Specify an ETag value to operate only on blobs with a matching
        /// value.
        /// </param>
        /// <param name='sourceIfNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching
        /// value.
        /// </param>
        /// <param name='ifModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been
        /// modified since the specified date/time.
        /// </param>
        /// <param name='ifUnmodifiedSince'>
        /// Specify this header value to operate only on a blob if it has not
        /// been modified since the specified date/time.
        /// </param>
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching
        /// value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching
        /// value.
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
        /// </param>
        /// <param name='sourceLeaseId'>
        /// Specify this header to perform the operation only if the lease ID
        /// given matches the active lease ID of the source blob.
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
        Task<AzureOperationHeaderResponse<BlobsCopyHeaders>> CopyWithHttpMessagesAsync(string accountName, string container, string blob, string copySource, int? timeout = default(int?), IDictionary<string, string> xMsMeta = default(IDictionary<string, string>), System.DateTime? sourceIfModifiedSince = default(System.DateTime?), System.DateTime? sourceIfUnmodifiedSince = default(System.DateTime?), string sourceIfMatches = default(string), string sourceIfNoneMatch = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), string leaseId = default(string), string sourceLeaseId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Abort Copy Blob operation aborts a pending Copy Blob operation,
        /// and leaves a destination blob with zero length and full metadata.
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
        /// <param name='copyId'>
        /// The copy identifier provided in the x-ms-copy-id header of the
        /// original Copy Blob operation.
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
        Task<AzureOperationHeaderResponse<BlobsAbortCopyHeaders>> AbortCopyWithHttpMessagesAsync(string accountName, string container, string blob, string copyId, int? timeout = default(int?), string leaseId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Append Block operation commits a new block of data to the end
        /// of an existing append blob. The Append Block operation is permitted
        /// only if the blob was created with x-ms-blob-type set to AppendBlob.
        /// Append Block is supported only on version 2015-02-21 version or
        /// later.
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
        /// <param name='body'>
        /// Initial data
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
        /// <param name='maxSize'>
        /// Optional conditional header. The max length in bytes permitted for
        /// the append blob. If the Append Block operation would cause the blob
        /// to exceed that limit or if the blob size is already greater than
        /// the value specified in this header, the request will fail with
        /// MaxBlobSizeConditionNotMet error (HTTP status code 412 -
        /// Precondition Failed).
        /// </param>
        /// <param name='appendPosition'>
        /// Optional conditional header, used only for the Append Block
        /// operation. A number indicating the byte offset to compare. Append
        /// Block will succeed only if the append position is equal to this
        /// number. If it is not, the request will fail with the
        /// AppendPositionConditionNotMet error (HTTP status code 412 -
        /// Precondition Failed).
        /// </param>
        /// <param name='ifModifiedSince'>
        /// Specify this header value to operate only on a blob if it has been
        /// modified since the specified date/time.
        /// </param>
        /// <param name='ifUnmodifiedSince'>
        /// Specify this header value to operate only on a blob if it has not
        /// been modified since the specified date/time.
        /// </param>
        /// <param name='ifMatches'>
        /// Specify an ETag value to operate only on blobs with a matching
        /// value.
        /// </param>
        /// <param name='ifNoneMatch'>
        /// Specify an ETag value to operate only on blobs without a matching
        /// value.
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
        Task<AzureOperationHeaderResponse<BlobsAppendBlockHeaders>> AppendBlockWithHttpMessagesAsync(string accountName, string container, string blob, Stream body, int? timeout = default(int?), string leaseId = default(string), int? maxSize = default(int?), int? appendPosition = default(int?), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}

