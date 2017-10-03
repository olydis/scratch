// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace BlobStorageTest.Client.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// Defines headers for GetProperties operation.
    /// </summary>
    public partial class BlobsGetPropertiesHeaders
    {
        /// <summary>
        /// Initializes a new instance of the BlobsGetPropertiesHeaders class.
        /// </summary>
        public BlobsGetPropertiesHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobsGetPropertiesHeaders class.
        /// </summary>
        /// <param name="lastModified">Returns the date and time the container
        /// was last modified. Any operation that modifies the blob, including
        /// an update of the blob's metadata or properties, changes the
        /// last-modified time of the blob.</param>
        /// <param name="blobType">The blob's type. Possible values include:
        /// 'BlockBlob', 'PageBlob', 'AppendBlob'</param>
        /// <param name="copyCompletionTime">Conclusion time of the last
        /// attempted Copy Blob operation where this blob was the destination
        /// blob. This value can specify the time of a completed, aborted, or
        /// failed copy attempt. This header does not appear if a copy is
        /// pending, if this blob has never been the destination in a Copy Blob
        /// operation, or if this blob has been modified after a concluded Copy
        /// Blob operation using Set Blob Properties, Put Blob, or Put Block
        /// List.</param>
        /// <param name="copyStatusDescription">Only appears when
        /// x-ms-copy-status is failed or pending. Describes the cause of the
        /// last fatal or non-fatal copy operation failure. This header does
        /// not appear if this blob has never been the destination in a Copy
        /// Blob operation, or if this blob has been modified after a concluded
        /// Copy Blob operation using Set Blob Properties, Put Blob, or Put
        /// Block List</param>
        /// <param name="copyId">String identifier for this copy operation. Use
        /// with Get Blob Properties to check the status of this copy
        /// operation, or pass to Abort Copy Blob to abort a pending
        /// copy.</param>
        /// <param name="copyProgress">Contains the number of bytes copied and
        /// the total bytes in the source in the last attempted Copy Blob
        /// operation where this blob was the destination blob. Can show
        /// between 0 and Content-Length bytes copied. This header does not
        /// appear if this blob has never been the destination in a Copy Blob
        /// operation, or if this blob has been modified after a concluded Copy
        /// Blob operation using Set Blob Properties, Put Blob, or Put Block
        /// List</param>
        /// <param name="copySource">URL up to 2 KB in length that specifies
        /// the source blob or file used in the last attempted Copy Blob
        /// operation where this blob was the destination blob. This header
        /// does not appear if this blob has never been the destination in a
        /// Copy Blob operation, or if this blob has been modified after a
        /// concluded Copy Blob operation using Set Blob Properties, Put Blob,
        /// or Put Block List.</param>
        /// <param name="copyStatus">State of the copy operation identified by
        /// x-ms-copy-id. Possible values include: 'pending', 'success',
        /// 'aborted', 'failed'</param>
        /// <param name="isIncrementalCopy">Included if the blob is incremental
        /// copy blob.</param>
        /// <param name="leaseDuration">When a blob is leased, specifies
        /// whether the lease is of infinite or fixed duration. Possible values
        /// include: 'infinite', 'fixed'</param>
        /// <param name="leaseState">Lease state of the blob. Possible values
        /// include: 'available', 'leased', 'expired', 'breaking',
        /// 'broken'</param>
        /// <param name="leaseStatus">The current lease status of the blob.
        /// Possible values include: 'locked', 'unlocked'</param>
        /// <param name="contentLength">The number of bytes present in the
        /// response body.</param>
        /// <param name="contentType">The content type specified for the blob.
        /// The default content type is 'application/octet-stream'</param>
        /// <param name="eTag">The ETag contains a value that you can use to
        /// perform operations conditionally. If the request version is
        /// 2011-08-18 or newer, the ETag value will be in quotes.</param>
        /// <param name="contentMD5">If the blob has an MD5 hash and this
        /// operation is to read the full blob, this response header is
        /// returned so that the client can check for message content
        /// integrity.</param>
        /// <param name="contentEncoding">This header returns the value that
        /// was specified for the Content-Encoding request header</param>
        /// <param name="contentDisposition">This header returns the value that
        /// was specified for the 'x-ms-blob-content-disposition' header. The
        /// Content-Disposition response header field conveys additional
        /// information about how to process the response payload, and also can
        /// be used to attach additional metadata. For example, if set to
        /// attachment, it indicates that the user-agent should not display the
        /// response, but instead show a Save As dialog with a filename other
        /// than the blob name specified.</param>
        /// <param name="cacheControl">This header is returned if it was
        /// previously specified for the blob.</param>
        /// <param name="blobSequenceNumber">The current sequence number for a
        /// page blob. This header is not returned for block blobs or append
        /// blobs</param>
        /// <param name="requestId">This header uniquely identifies the request
        /// that was made and can be used for troubleshooting the
        /// request.</param>
        /// <param name="version">Indicates the version of the Blob service
        /// used to execute the request. This header is returned for requests
        /// made against version 2009-09-19 and above.</param>
        /// <param name="date">UTC date/time value generated by the service
        /// that indicates the time at which the response was initiated</param>
        /// <param name="acceptRanges">Indicates that the service supports
        /// requests for partial blob content.</param>
        /// <param name="blobCommittedBlockCount">The number of committed
        /// blocks present in the blob. This header is returned only for append
        /// blobs.</param>
        /// <param name="isServerEncrypted">The value of this header is set to
        /// true if the blob data and application metadata are completely
        /// encrypted using the specified algorithm. Otherwise, the value is
        /// set to false (when the blob is unencrypted, or if only parts of the
        /// blob/application metadata are encrypted).</param>
        public BlobsGetPropertiesHeaders(string lastModified = default(string), IDictionary<string, string> metadata = default(IDictionary<string, string>), BlobType? blobType = default(BlobType?), System.DateTime? copyCompletionTime = default(System.DateTime?), string copyStatusDescription = default(string), string copyId = default(string), string copyProgress = default(string), string copySource = default(string), CopyStatusType? copyStatus = default(CopyStatusType?), bool? isIncrementalCopy = default(bool?), LeaseDurationType? leaseDuration = default(LeaseDurationType?), LeaseStateType? leaseState = default(LeaseStateType?), LeaseStatusType? leaseStatus = default(LeaseStatusType?), int? contentLength = default(int?), string contentType = default(string), string eTag = default(string), string contentMD5 = default(string), string contentEncoding = default(string), string contentDisposition = default(string), string cacheControl = default(string), string blobSequenceNumber = default(string), string requestId = default(string), string version = default(string), System.DateTime? date = default(System.DateTime?), string acceptRanges = default(string), string blobCommittedBlockCount = default(string), bool? isServerEncrypted = default(bool?))
        {
            LastModified = lastModified;
            Metadata = metadata;
            BlobType = blobType;
            CopyCompletionTime = copyCompletionTime;
            CopyStatusDescription = copyStatusDescription;
            CopyId = copyId;
            CopyProgress = copyProgress;
            CopySource = copySource;
            CopyStatus = copyStatus;
            IsIncrementalCopy = isIncrementalCopy;
            LeaseDuration = leaseDuration;
            LeaseState = leaseState;
            LeaseStatus = leaseStatus;
            ContentLength = contentLength;
            ContentType = contentType;
            ETag = eTag;
            ContentMD5 = contentMD5;
            ContentEncoding = contentEncoding;
            ContentDisposition = contentDisposition;
            CacheControl = cacheControl;
            BlobSequenceNumber = blobSequenceNumber;
            RequestId = requestId;
            Version = version;
            Date = date;
            AcceptRanges = acceptRanges;
            BlobCommittedBlockCount = blobCommittedBlockCount;
            IsServerEncrypted = isServerEncrypted;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets returns the date and time the container was last
        /// modified. Any operation that modifies the blob, including an update
        /// of the blob's metadata or properties, changes the last-modified
        /// time of the blob.
        /// </summary>
        [JsonProperty(PropertyName = "Last-Modified")]
        public string LastModified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-meta")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the blob's type. Possible values include: 'BlockBlob',
        /// 'PageBlob', 'AppendBlob'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-blob-type")]
        public BlobType? BlobType { get; set; }

        /// <summary>
        /// Gets or sets conclusion time of the last attempted Copy Blob
        /// operation where this blob was the destination blob. This value can
        /// specify the time of a completed, aborted, or failed copy attempt.
        /// This header does not appear if a copy is pending, if this blob has
        /// never been the destination in a Copy Blob operation, or if this
        /// blob has been modified after a concluded Copy Blob operation using
        /// Set Blob Properties, Put Blob, or Put Block List.
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [JsonProperty(PropertyName = "x-ms-copy-completion-time")]
        public System.DateTime? CopyCompletionTime { get; set; }

        /// <summary>
        /// Gets or sets only appears when x-ms-copy-status is failed or
        /// pending. Describes the cause of the last fatal or non-fatal copy
        /// operation failure. This header does not appear if this blob has
        /// never been the destination in a Copy Blob operation, or if this
        /// blob has been modified after a concluded Copy Blob operation using
        /// Set Blob Properties, Put Blob, or Put Block List
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-copy-status-description")]
        public string CopyStatusDescription { get; set; }

        /// <summary>
        /// Gets or sets string identifier for this copy operation. Use with
        /// Get Blob Properties to check the status of this copy operation, or
        /// pass to Abort Copy Blob to abort a pending copy.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-copy-id")]
        public string CopyId { get; set; }

        /// <summary>
        /// Gets or sets contains the number of bytes copied and the total
        /// bytes in the source in the last attempted Copy Blob operation where
        /// this blob was the destination blob. Can show between 0 and
        /// Content-Length bytes copied. This header does not appear if this
        /// blob has never been the destination in a Copy Blob operation, or if
        /// this blob has been modified after a concluded Copy Blob operation
        /// using Set Blob Properties, Put Blob, or Put Block List
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-copy-progress")]
        public string CopyProgress { get; set; }

        /// <summary>
        /// Gets or sets URL up to 2 KB in length that specifies the source
        /// blob or file used in the last attempted Copy Blob operation where
        /// this blob was the destination blob. This header does not appear if
        /// this blob has never been the destination in a Copy Blob operation,
        /// or if this blob has been modified after a concluded Copy Blob
        /// operation using Set Blob Properties, Put Blob, or Put Block List.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-copy-source")]
        public string CopySource { get; set; }

        /// <summary>
        /// Gets or sets state of the copy operation identified by
        /// x-ms-copy-id. Possible values include: 'pending', 'success',
        /// 'aborted', 'failed'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-copy-status")]
        public CopyStatusType? CopyStatus { get; set; }

        /// <summary>
        /// Gets or sets included if the blob is incremental copy blob.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-incremental-copy")]
        public bool? IsIncrementalCopy { get; set; }

        /// <summary>
        /// Gets or sets when a blob is leased, specifies whether the lease is
        /// of infinite or fixed duration. Possible values include: 'infinite',
        /// 'fixed'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-lease-duration")]
        public LeaseDurationType? LeaseDuration { get; set; }

        /// <summary>
        /// Gets or sets lease state of the blob. Possible values include:
        /// 'available', 'leased', 'expired', 'breaking', 'broken'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-lease-state")]
        public LeaseStateType? LeaseState { get; set; }

        /// <summary>
        /// Gets or sets the current lease status of the blob. Possible values
        /// include: 'locked', 'unlocked'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-lease-status")]
        public LeaseStatusType? LeaseStatus { get; set; }

        /// <summary>
        /// Gets or sets the number of bytes present in the response body.
        /// </summary>
        [JsonProperty(PropertyName = "Content-Length")]
        public int? ContentLength { get; set; }

        /// <summary>
        /// Gets or sets the content type specified for the blob. The default
        /// content type is 'application/octet-stream'
        /// </summary>
        [JsonProperty(PropertyName = "Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the ETag contains a value that you can use to perform
        /// operations conditionally. If the request version is 2011-08-18 or
        /// newer, the ETag value will be in quotes.
        /// </summary>
        [JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets if the blob has an MD5 hash and this operation is to
        /// read the full blob, this response header is returned so that the
        /// client can check for message content integrity.
        /// </summary>
        [JsonProperty(PropertyName = "Content-MD5")]
        public string ContentMD5 { get; set; }

        /// <summary>
        /// Gets or sets this header returns the value that was specified for
        /// the Content-Encoding request header
        /// </summary>
        [JsonProperty(PropertyName = "Content-Encoding")]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// Gets or sets this header returns the value that was specified for
        /// the 'x-ms-blob-content-disposition' header. The Content-Disposition
        /// response header field conveys additional information about how to
        /// process the response payload, and also can be used to attach
        /// additional metadata. For example, if set to attachment, it
        /// indicates that the user-agent should not display the response, but
        /// instead show a Save As dialog with a filename other than the blob
        /// name specified.
        /// </summary>
        [JsonProperty(PropertyName = "Content-Disposition")]
        public string ContentDisposition { get; set; }

        /// <summary>
        /// Gets or sets this header is returned if it was previously specified
        /// for the blob.
        /// </summary>
        [JsonProperty(PropertyName = "Cache-Control")]
        public string CacheControl { get; set; }

        /// <summary>
        /// Gets or sets the current sequence number for a page blob. This
        /// header is not returned for block blobs or append blobs
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-blob-sequence-number")]
        public string BlobSequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets this header uniquely identifies the request that was
        /// made and can be used for troubleshooting the request.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-request-id")]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets indicates the version of the Blob service used to
        /// execute the request. This header is returned for requests made
        /// against version 2009-09-19 and above.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets UTC date/time value generated by the service that
        /// indicates the time at which the response was initiated
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [JsonProperty(PropertyName = "Date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets indicates that the service supports requests for
        /// partial blob content.
        /// </summary>
        [JsonProperty(PropertyName = "Accept-Ranges")]
        public string AcceptRanges { get; set; }

        /// <summary>
        /// Gets or sets the number of committed blocks present in the blob.
        /// This header is returned only for append blobs.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-blob-committed-block-count")]
        public string BlobCommittedBlockCount { get; set; }

        /// <summary>
        /// Gets or sets the value of this header is set to true if the blob
        /// data and application metadata are completely encrypted using the
        /// specified algorithm. Otherwise, the value is set to false (when the
        /// blob is unencrypted, or if only parts of the blob/application
        /// metadata are encrypted).
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-server-encrypted")]
        public bool? IsServerEncrypted { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != LastModified )
            {
                result.Add(new XElement("Last-Modified", LastModified) );
            }
            if( null != Metadata )
            {
                var dict = new XElement("x-ms-meta");
                foreach( var key in Metadata.Keys ){
                    dict.Add(new XElement( key, Metadata[key] ) );
                }
                result.Add(dict);
            }
            if( null != BlobType )
            {
                result.Add(new XElement("x-ms-blob-type", BlobType.ToSerializedValue()) );
            }
            if( null != CopyCompletionTime )
            {
                result.Add(new XElement("x-ms-copy-completion-time", CopyCompletionTime?.ToUniversalTime().ToString("R")) );
            }
            if( null != CopyStatusDescription )
            {
                result.Add(new XElement("x-ms-copy-status-description", CopyStatusDescription) );
            }
            if( null != CopyId )
            {
                result.Add(new XElement("x-ms-copy-id", CopyId) );
            }
            if( null != CopyProgress )
            {
                result.Add(new XElement("x-ms-copy-progress", CopyProgress) );
            }
            if( null != CopySource )
            {
                result.Add(new XElement("x-ms-copy-source", CopySource) );
            }
            if( null != CopyStatus )
            {
                result.Add(new XElement("x-ms-copy-status", CopyStatus.ToSerializedValue()) );
            }
            if( null != IsIncrementalCopy )
            {
                result.Add(new XElement("x-ms-incremental-copy", IsIncrementalCopy) );
            }
            if( null != LeaseDuration )
            {
                result.Add(new XElement("x-ms-lease-duration", LeaseDuration.ToSerializedValue()) );
            }
            if( null != LeaseState )
            {
                result.Add(new XElement("x-ms-lease-state", LeaseState.ToSerializedValue()) );
            }
            if( null != LeaseStatus )
            {
                result.Add(new XElement("x-ms-lease-status", LeaseStatus.ToSerializedValue()) );
            }
            if( null != ContentLength )
            {
                result.Add(new XElement("Content-Length", ContentLength) );
            }
            if( null != ContentType )
            {
                result.Add(new XElement("Content-Type", ContentType) );
            }
            if( null != ETag )
            {
                result.Add(new XElement("ETag", ETag) );
            }
            if( null != ContentMD5 )
            {
                result.Add(new XElement("Content-MD5", ContentMD5) );
            }
            if( null != ContentEncoding )
            {
                result.Add(new XElement("Content-Encoding", ContentEncoding) );
            }
            if( null != ContentDisposition )
            {
                result.Add(new XElement("Content-Disposition", ContentDisposition) );
            }
            if( null != CacheControl )
            {
                result.Add(new XElement("Cache-Control", CacheControl) );
            }
            if( null != BlobSequenceNumber )
            {
                result.Add(new XElement("x-ms-blob-sequence-number", BlobSequenceNumber) );
            }
            if( null != RequestId )
            {
                result.Add(new XElement("x-ms-request-id", RequestId) );
            }
            if( null != Version )
            {
                result.Add(new XElement("x-ms-version", Version) );
            }
            if( null != Date )
            {
                result.Add(new XElement("Date", Date?.ToUniversalTime().ToString("R")) );
            }
            if( null != AcceptRanges )
            {
                result.Add(new XElement("Accept-Ranges", AcceptRanges) );
            }
            if( null != BlobCommittedBlockCount )
            {
                result.Add(new XElement("x-ms-blob-committed-block-count", BlobCommittedBlockCount) );
            }
            if( null != IsServerEncrypted )
            {
                result.Add(new XElement("x-ms-server-encrypted", IsServerEncrypted) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of BlobsGetPropertiesHeaders
        /// </summary>
        internal static BlobsGetPropertiesHeaders XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static BlobsGetPropertiesHeaders XmlDeserialize(XElement payload)
        {
            var result = new BlobsGetPropertiesHeaders();
            var deserializeLastModified = XmlSerialization.ToDeserializer(e => (string)e);
            string resultLastModified;
            if (deserializeLastModified(payload, "Last-Modified", out resultLastModified))
            {
                result.LastModified = resultLastModified;
            }
            var deserializeMetadata = XmlSerialization.CreateDictionaryXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e));
            IDictionary<string, string> resultMetadata;
            if (deserializeMetadata(payload, "x-ms-meta", out resultMetadata))
            {
                result.Metadata = resultMetadata;
            }
            var deserializeBlobType = XmlSerialization.ToDeserializer(e => e.Value.ParseBlobType());
            BlobType? resultBlobType;
            if (deserializeBlobType(payload, "x-ms-blob-type", out resultBlobType))
            {
                result.BlobType = resultBlobType;
            }
            var deserializeCopyCompletionTime = XmlSerialization.ToDeserializer(e => (System.DateTime?)e);
            System.DateTime? resultCopyCompletionTime;
            if (deserializeCopyCompletionTime(payload, "x-ms-copy-completion-time", out resultCopyCompletionTime))
            {
                result.CopyCompletionTime = resultCopyCompletionTime;
            }
            var deserializeCopyStatusDescription = XmlSerialization.ToDeserializer(e => (string)e);
            string resultCopyStatusDescription;
            if (deserializeCopyStatusDescription(payload, "x-ms-copy-status-description", out resultCopyStatusDescription))
            {
                result.CopyStatusDescription = resultCopyStatusDescription;
            }
            var deserializeCopyId = XmlSerialization.ToDeserializer(e => (string)e);
            string resultCopyId;
            if (deserializeCopyId(payload, "x-ms-copy-id", out resultCopyId))
            {
                result.CopyId = resultCopyId;
            }
            var deserializeCopyProgress = XmlSerialization.ToDeserializer(e => (string)e);
            string resultCopyProgress;
            if (deserializeCopyProgress(payload, "x-ms-copy-progress", out resultCopyProgress))
            {
                result.CopyProgress = resultCopyProgress;
            }
            var deserializeCopySource = XmlSerialization.ToDeserializer(e => (string)e);
            string resultCopySource;
            if (deserializeCopySource(payload, "x-ms-copy-source", out resultCopySource))
            {
                result.CopySource = resultCopySource;
            }
            var deserializeCopyStatus = XmlSerialization.ToDeserializer(e => e.Value.ParseCopyStatusType());
            CopyStatusType? resultCopyStatus;
            if (deserializeCopyStatus(payload, "x-ms-copy-status", out resultCopyStatus))
            {
                result.CopyStatus = resultCopyStatus;
            }
            var deserializeIsIncrementalCopy = XmlSerialization.ToDeserializer(e => (bool?)e);
            bool? resultIsIncrementalCopy;
            if (deserializeIsIncrementalCopy(payload, "x-ms-incremental-copy", out resultIsIncrementalCopy))
            {
                result.IsIncrementalCopy = resultIsIncrementalCopy;
            }
            var deserializeLeaseDuration = XmlSerialization.ToDeserializer(e => e.Value.ParseLeaseDurationType());
            LeaseDurationType? resultLeaseDuration;
            if (deserializeLeaseDuration(payload, "x-ms-lease-duration", out resultLeaseDuration))
            {
                result.LeaseDuration = resultLeaseDuration;
            }
            var deserializeLeaseState = XmlSerialization.ToDeserializer(e => e.Value.ParseLeaseStateType());
            LeaseStateType? resultLeaseState;
            if (deserializeLeaseState(payload, "x-ms-lease-state", out resultLeaseState))
            {
                result.LeaseState = resultLeaseState;
            }
            var deserializeLeaseStatus = XmlSerialization.ToDeserializer(e => e.Value.ParseLeaseStatusType());
            LeaseStatusType? resultLeaseStatus;
            if (deserializeLeaseStatus(payload, "x-ms-lease-status", out resultLeaseStatus))
            {
                result.LeaseStatus = resultLeaseStatus;
            }
            var deserializeContentLength = XmlSerialization.ToDeserializer(e => (int?)e);
            int? resultContentLength;
            if (deserializeContentLength(payload, "Content-Length", out resultContentLength))
            {
                result.ContentLength = resultContentLength;
            }
            var deserializeContentType = XmlSerialization.ToDeserializer(e => (string)e);
            string resultContentType;
            if (deserializeContentType(payload, "Content-Type", out resultContentType))
            {
                result.ContentType = resultContentType;
            }
            var deserializeETag = XmlSerialization.ToDeserializer(e => (string)e);
            string resultETag;
            if (deserializeETag(payload, "ETag", out resultETag))
            {
                result.ETag = resultETag;
            }
            var deserializeContentMD5 = XmlSerialization.ToDeserializer(e => (string)e);
            string resultContentMD5;
            if (deserializeContentMD5(payload, "Content-MD5", out resultContentMD5))
            {
                result.ContentMD5 = resultContentMD5;
            }
            var deserializeContentEncoding = XmlSerialization.ToDeserializer(e => (string)e);
            string resultContentEncoding;
            if (deserializeContentEncoding(payload, "Content-Encoding", out resultContentEncoding))
            {
                result.ContentEncoding = resultContentEncoding;
            }
            var deserializeContentDisposition = XmlSerialization.ToDeserializer(e => (string)e);
            string resultContentDisposition;
            if (deserializeContentDisposition(payload, "Content-Disposition", out resultContentDisposition))
            {
                result.ContentDisposition = resultContentDisposition;
            }
            var deserializeCacheControl = XmlSerialization.ToDeserializer(e => (string)e);
            string resultCacheControl;
            if (deserializeCacheControl(payload, "Cache-Control", out resultCacheControl))
            {
                result.CacheControl = resultCacheControl;
            }
            var deserializeBlobSequenceNumber = XmlSerialization.ToDeserializer(e => (string)e);
            string resultBlobSequenceNumber;
            if (deserializeBlobSequenceNumber(payload, "x-ms-blob-sequence-number", out resultBlobSequenceNumber))
            {
                result.BlobSequenceNumber = resultBlobSequenceNumber;
            }
            var deserializeRequestId = XmlSerialization.ToDeserializer(e => (string)e);
            string resultRequestId;
            if (deserializeRequestId(payload, "x-ms-request-id", out resultRequestId))
            {
                result.RequestId = resultRequestId;
            }
            var deserializeVersion = XmlSerialization.ToDeserializer(e => (string)e);
            string resultVersion;
            if (deserializeVersion(payload, "x-ms-version", out resultVersion))
            {
                result.Version = resultVersion;
            }
            var deserializeDate = XmlSerialization.ToDeserializer(e => (System.DateTime?)e);
            System.DateTime? resultDate;
            if (deserializeDate(payload, "Date", out resultDate))
            {
                result.Date = resultDate;
            }
            var deserializeAcceptRanges = XmlSerialization.ToDeserializer(e => (string)e);
            string resultAcceptRanges;
            if (deserializeAcceptRanges(payload, "Accept-Ranges", out resultAcceptRanges))
            {
                result.AcceptRanges = resultAcceptRanges;
            }
            var deserializeBlobCommittedBlockCount = XmlSerialization.ToDeserializer(e => (string)e);
            string resultBlobCommittedBlockCount;
            if (deserializeBlobCommittedBlockCount(payload, "x-ms-blob-committed-block-count", out resultBlobCommittedBlockCount))
            {
                result.BlobCommittedBlockCount = resultBlobCommittedBlockCount;
            }
            var deserializeIsServerEncrypted = XmlSerialization.ToDeserializer(e => (bool?)e);
            bool? resultIsServerEncrypted;
            if (deserializeIsServerEncrypted(payload, "x-ms-server-encrypted", out resultIsServerEncrypted))
            {
                result.IsServerEncrypted = resultIsServerEncrypted;
            }
            return result;
        }
    }
}
