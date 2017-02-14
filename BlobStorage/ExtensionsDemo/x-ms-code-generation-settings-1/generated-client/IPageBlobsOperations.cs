// Our custom header

namespace blob-storage
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
    /// PageBlobsOperations operations.
    /// </summary>
    public partial interface IPageBlobsOperations
    {
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
        /// - Update: Writes the bytes specified by the request body into the
        /// specified range. The Range and Content-Length headers must match to
        /// perform the update.
        /// - Clear: Clears the specified range and releases the space used in
        /// storage for that range. To clear a range, set the Content-Length
        /// header to zero, and the Range header to a value that indicates the
        /// range to clear, up to maximum blob size. Possible values include:
        /// 'update', 'clear'
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
        /// <param name='range'>
        /// Return only the bytes of the blob in the specified range.
        /// </param>
        /// <param name='leaseId'>
        /// If specified, the operation only succeeds if the container's lease
        /// is active and matches this ID.
        /// </param>
        /// <param name='ifSequenceNumberLessThanOrEqualTo'>
        /// Specify this header value to operate only on a blob if it has a
        /// sequence number less than or equal to the specified.
        /// </param>
        /// <param name='ifSequenceNumberLessThan'>
        /// Specify this header value to operate only on a blob if it has a
        /// sequence number less than the specified.
        /// </param>
        /// <param name='ifSequenceNumberEqualTo'>
        /// Specify this header value to operate only on a blob if it has the
        /// specified sequence number.
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
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<PageBlobsPutPageHeaders>> PutPageWithHttpMessagesAsync(string accountName, string container, string blob, PageWrite pageWrite, Stream body, int? timeout = default(int?), string range = default(string), string leaseId = default(string), int? ifSequenceNumberLessThanOrEqualTo = default(int?), int? ifSequenceNumberLessThan = default(int?), int? ifSequenceNumberEqualTo = default(int?), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Get Page Ranges operation returns the list of valid page ranges
        /// for a page blob or snapshot of a page blob
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
        /// <param name='prevsnapshot'>
        /// Optional in version 2015-07-08 and newer. The prevsnapshot
        /// parameter is a DateTime value that specifies that the response will
        /// contain only pages that were changed between target blob and
        /// previous snapshot. Changed pages include both updated and cleared
        /// pages. The target blob may be a snapshot, as long as the snapshot
        /// specified by prevsnapshot is the older of the two. Note that
        /// incremental snapshots are currently supported only for blobs
        /// created on or after January 1, 2016.
        /// </param>
        /// <param name='range'>
        /// Return only the bytes of the blob in the specified range.
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
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<object,PageBlobsGetPageRangesHeaders>> GetPageRangesWithHttpMessagesAsync(string accountName, string container, string blob, System.DateTime? snapshot = default(System.DateTime?), int? timeout = default(int?), System.DateTime? prevsnapshot = default(System.DateTime?), string range = default(string), string leaseId = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Incremental Copy Blob operation copies a snapshot of the source
        /// page blob to a destination page blob. The snapshot is copied such
        /// that only the differential changes between the previously copied
        /// snapshot are transferred to the destination. The copied snapshots
        /// are complete copies of the original snapshot and can be read or
        /// copied from as usual. This API is supported since REST version
        /// 2016-05-31.
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
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<PageBlobsIncrementalCopyHeaders>> IncrementalCopyWithHttpMessagesAsync(string accountName, string container, string blob, string copySource, int? timeout = default(int?), IDictionary<string, string> xMsMeta = default(IDictionary<string, string>), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}

