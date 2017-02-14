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
    /// BlockBlobsOperations operations.
    /// </summary>
    public partial interface IBlockBlobsOperations
    {
        /// <summary>
        /// The Put Block operation creates a new block to be committed as part
        /// of a blob
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
        /// <param name='blockId'>
        /// A valid Base64 string value that identifies the block. Prior to
        /// encoding, the string must be less than or equal to 64 bytes in
        /// size. For a given blob, the length of the value specified for the
        /// blockid parameter must be the same size for each block.
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
        Task<AzureOperationHeaderResponse<BlockBlobsPutBlockHeaders>> PutBlockWithHttpMessagesAsync(string accountName, string container, string blob, string blockId, Stream body, int? timeout = default(int?), string leaseId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Put Block List operation writes a blob by specifying the list
        /// of block IDs that make up the blob. In order to be written as part
        /// of a blob, a block must have been successfully written to the
        /// server in a prior Put Block operation. You can call Put Block List
        /// to update a blob by uploading only those blocks that have changed,
        /// then committing the new and existing blocks together. You can do
        /// this by specifying whether to commit a block from the committed
        /// block list or from the uncommitted block list, or to commit the
        /// most recently uploaded version of the block, whichever list it may
        /// belong to.
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
        /// <param name='blocks'>
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
        Task<AzureOperationHeaderResponse<BlockBlobsPutBlockListHeaders>> PutBlockListWithHttpMessagesAsync(string accountName, string container, string blob, IList<string> blocks, int? timeout = default(int?), string xMsBlobCacheControl = default(string), string xMsBlobContentType = default(string), string xMsBlobContentEncoding = default(string), string xMsBlobContentLanguage = default(string), string xMsBlobContentMd5 = default(string), IDictionary<string, string> xMsMeta = default(IDictionary<string, string>), string leaseId = default(string), string xMsBlobContentDisposition = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?), string ifMatches = default(string), string ifNoneMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Get Block List operation retrieves the list of blocks that have
        /// been uploaded as part of a block blob
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
        /// <param name='listType'>
        /// Specifies whether to return the list of committed blocks, the list
        /// of uncommitted blocks, or both lists together. Possible values
        /// include: 'committed', 'uncommitted', 'all'
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
        Task<AzureOperationResponse<BlockList,BlockBlobsGetBlockListHeaders>> GetBlockListWithHttpMessagesAsync(string accountName, string container, string blob, System.DateTime? snapshot = default(System.DateTime?), BlockListType? listType = default(BlockListType?), int? timeout = default(int?), string leaseId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}

