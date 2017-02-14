// Our custom header

namespace blob-storage.Models
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
    /// Defines headers for Get operation.
    /// </summary>
    public partial class BlobsGetHeaders
    {
        /// <summary>
        /// Initializes a new instance of the BlobsGetHeaders class.
        /// </summary>
        public BlobsGetHeaders() { }

        /// <summary>
        /// Initializes a new instance of the BlobsGetHeaders class.
        /// </summary>
        /// <param name="lastModified">Returns the date and time the container
        /// was last modified. Any operation that modifies the blob, including
        /// an update of the blob's metadata or properties, changes the
        /// last-modified time of the blob.</param>
        /// <param name="contentLength">The number of bytes present in the
        /// response body.</param>
        /// <param name="contentType">The content type specified for the blob.
        /// The default content type is 'application/octet-stream'</param>
        /// <param name="contentRange">Indicates the range of bytes returned in
        /// the event that the client requested a subset of the blob by setting
        /// the 'Range' request header.</param>
        /// <param name="eTag">The ETag contains a value that you can use to
        /// perform operations conditionally. If the request version is
        /// 2011-08-18 or newer, the ETag value will be in quotes.</param>
        /// <param name="contentMD5">If the blob has an MD5 hash and this
        /// operation is to read the full blob, this response header is
        /// returned so that the client can check for message content
        /// integrity.</param>
        /// <param name="contentEncoding">This header returns the value that
        /// was specified for the Content-Encoding request header</param>
        /// <param name="cacheControl">This header is returned if it was
        /// previously specified for the blob.</param>
        /// <param name="contentDisposition">This header returns the value that
        /// was specified for the 'x-ms-blob-content-disposition' header. The
        /// Content-Disposition response header field conveys additional
        /// information about how to process the response payload, and also can
        /// be used to attach additional metadata. For example, if set to
        /// attachment, it indicates that the user-agent should not display the
        /// response, but instead show a Save As dialog with a filename other
        /// than the blob name specified.</param>
        /// <param name="xMsBlobSequenceNumber">The current sequence number for
        /// a page blob. This header is not returned for block blobs or append
        /// blobs</param>
        /// <param name="xMsBlobType">The blob's type. Possible values include:
        /// 'BlockBlob', 'PageBlob', 'AppendBlob'</param>
        /// <param name="xMsCopyCompletionTime">Conclusion time of the last
        /// attempted Copy Blob operation where this blob was the destination
        /// blob. This value can specify the time of a completed, aborted, or
        /// failed copy attempt. This header does not appear if a copy is
        /// pending, if this blob has never been the destination in a Copy Blob
        /// operation, or if this blob has been modified after a concluded Copy
        /// Blob operation using Set Blob Properties, Put Blob, or Put Block
        /// List.</param>
        /// <param name="xMsCopyStatusDescription">Only appears when
        /// x-ms-copy-status is failed or pending. Describes the cause of the
        /// last fatal or non-fatal copy operation failure. This header does
        /// not appear if this blob has never been the destination in a Copy
        /// Blob operation, or if this blob has been modified after a concluded
        /// Copy Blob operation using Set Blob Properties, Put Blob, or Put
        /// Block List</param>
        /// <param name="xMsCopyId">String identifier for this copy operation.
        /// Use with Get Blob Properties to check the status of this copy
        /// operation, or pass to Abort Copy Blob to abort a pending
        /// copy.</param>
        /// <param name="xMsCopyProgress">Contains the number of bytes copied
        /// and the total bytes in the source in the last attempted Copy Blob
        /// operation where this blob was the destination blob. Can show
        /// between 0 and Content-Length bytes copied. This header does not
        /// appear if this blob has never been the destination in a Copy Blob
        /// operation, or if this blob has been modified after a concluded Copy
        /// Blob operation using Set Blob Properties, Put Blob, or Put Block
        /// List</param>
        /// <param name="xMsCopySource">URL up to 2 KB in length that specifies
        /// the source blob or file used in the last attempted Copy Blob
        /// operation where this blob was the destination blob. This header
        /// does not appear if this blob has never been the destination in a
        /// Copy Blob operation, or if this blob has been modified after a
        /// concluded Copy Blob operation using Set Blob Properties, Put Blob,
        /// or Put Block List.</param>
        /// <param name="xMsCopyStatus">State of the copy operation identified
        /// by x-ms-copy-id. Possible values include: 'pending', 'success',
        /// 'aborted', 'failed'</param>
        /// <param name="xMsLeaseDuration">When a blob is leased, specifies
        /// whether the lease is of infinite or fixed duration. Possible values
        /// include: 'infinite', 'fixed'</param>
        /// <param name="xMsLeaseState">Lease state of the blob. Possible
        /// values include: 'available', 'leased', 'expired', 'breaking',
        /// 'broken'</param>
        /// <param name="xMsLeaseStatus">The current lease status of the blob.
        /// Possible values include: 'locked', 'unlocked'</param>
        /// <param name="xMsRequestId">This header uniquely identifies the
        /// request that was made and can be used for troubleshooting the
        /// request.</param>
        /// <param name="xMsVersion">Indicates the version of the Blob service
        /// used to execute the request. This header is returned for requests
        /// made against version 2009-09-19 and above.</param>
        /// <param name="acceptRanges">Indicates that the service supports
        /// requests for partial blob content.</param>
        /// <param name="date">UTC date/time value generated by the service
        /// that indicates the time at which the response was initiated</param>
        /// <param name="vary">Returned with the value of the Origin header
        /// when CORS rules are specified</param>
        /// <param name="xMsBlobCommittedBlockCount">The number of committed
        /// blocks present in the blob. This header is returned only for append
        /// blobs.</param>
        /// <param name="xMsServerEncrypted">The value of this header is set to
        /// true if the blob data and application metadata are completely
        /// encrypted using the specified algorithm. Otherwise, the value is
        /// set to false (when the blob is unencrypted, or if only parts of the
        /// blob/application metadata are encrypted).</param>
        /// <param name="xMsBlobContentMd5">If the blob has a MD5 hash, and if
        /// request contains range header (Range or x-ms-range), this response
        /// header is returned with the value of the whole blob's MD5 value.
        /// This value may or may not be equal to the value returned in
        /// Content-MD5 header, with the latter calculated from the requested
        /// range</param>
        public BlobsGetHeaders(string lastModified = default(string), IDictionary<string, string> metadata = default(IDictionary<string, string>), int? contentLength = default(int?), string contentType = default(string), string contentRange = default(string), string eTag = default(string), string contentMD5 = default(string), string contentEncoding = default(string), string cacheControl = default(string), string contentDisposition = default(string), string xMsBlobSequenceNumber = default(string), BlobType? xMsBlobType = default(BlobType?), System.DateTime? xMsCopyCompletionTime = default(System.DateTime?), string xMsCopyStatusDescription = default(string), string xMsCopyId = default(string), string xMsCopyProgress = default(string), string xMsCopySource = default(string), CopyStatusType? xMsCopyStatus = default(CopyStatusType?), LeaseDurationType? xMsLeaseDuration = default(LeaseDurationType?), LeaseStateType? xMsLeaseState = default(LeaseStateType?), LeaseStatusType? xMsLeaseStatus = default(LeaseStatusType?), string xMsRequestId = default(string), string xMsVersion = default(string), string acceptRanges = default(string), System.DateTime? date = default(System.DateTime?), string vary = default(string), string xMsBlobCommittedBlockCount = default(string), bool? xMsServerEncrypted = default(bool?), string xMsBlobContentMd5 = default(string))
        {
            LastModified = lastModified;
            Metadata = metadata;
            ContentLength = contentLength;
            ContentType = contentType;
            ContentRange = contentRange;
            ETag = eTag;
            ContentMD5 = contentMD5;
            ContentEncoding = contentEncoding;
            CacheControl = cacheControl;
            ContentDisposition = contentDisposition;
            XMsBlobSequenceNumber = xMsBlobSequenceNumber;
            XMsBlobType = xMsBlobType;
            XMsCopyCompletionTime = xMsCopyCompletionTime;
            XMsCopyStatusDescription = xMsCopyStatusDescription;
            XMsCopyId = xMsCopyId;
            XMsCopyProgress = xMsCopyProgress;
            XMsCopySource = xMsCopySource;
            XMsCopyStatus = xMsCopyStatus;
            XMsLeaseDuration = xMsLeaseDuration;
            XMsLeaseState = xMsLeaseState;
            XMsLeaseStatus = xMsLeaseStatus;
            XMsRequestId = xMsRequestId;
            XMsVersion = xMsVersion;
            AcceptRanges = acceptRanges;
            Date = date;
            Vary = vary;
            XMsBlobCommittedBlockCount = xMsBlobCommittedBlockCount;
            XMsServerEncrypted = xMsServerEncrypted;
            XMsBlobContentMd5 = xMsBlobContentMd5;
        }

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
        /// Gets or sets indicates the range of bytes returned in the event
        /// that the client requested a subset of the blob by setting the
        /// 'Range' request header.
        /// </summary>
        [JsonProperty(PropertyName = "Content-Range")]
        public string ContentRange { get; set; }

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
        /// Gets or sets this header is returned if it was previously specified
        /// for the blob.
        /// </summary>
        [JsonProperty(PropertyName = "Cache-Control")]
        public string CacheControl { get; set; }

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
        /// Gets or sets the current sequence number for a page blob. This
        /// header is not returned for block blobs or append blobs
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-blob-sequence-number")]
        public string XMsBlobSequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the blob's type. Possible values include: 'BlockBlob',
        /// 'PageBlob', 'AppendBlob'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-blob-type")]
        public BlobType? XMsBlobType { get; set; }

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
        public System.DateTime? XMsCopyCompletionTime { get; set; }

        /// <summary>
        /// Gets or sets only appears when x-ms-copy-status is failed or
        /// pending. Describes the cause of the last fatal or non-fatal copy
        /// operation failure. This header does not appear if this blob has
        /// never been the destination in a Copy Blob operation, or if this
        /// blob has been modified after a concluded Copy Blob operation using
        /// Set Blob Properties, Put Blob, or Put Block List
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-copy-status-description")]
        public string XMsCopyStatusDescription { get; set; }

        /// <summary>
        /// Gets or sets string identifier for this copy operation. Use with
        /// Get Blob Properties to check the status of this copy operation, or
        /// pass to Abort Copy Blob to abort a pending copy.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-copy-id")]
        public string XMsCopyId { get; set; }

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
        public string XMsCopyProgress { get; set; }

        /// <summary>
        /// Gets or sets URL up to 2 KB in length that specifies the source
        /// blob or file used in the last attempted Copy Blob operation where
        /// this blob was the destination blob. This header does not appear if
        /// this blob has never been the destination in a Copy Blob operation,
        /// or if this blob has been modified after a concluded Copy Blob
        /// operation using Set Blob Properties, Put Blob, or Put Block List.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-copy-source")]
        public string XMsCopySource { get; set; }

        /// <summary>
        /// Gets or sets state of the copy operation identified by
        /// x-ms-copy-id. Possible values include: 'pending', 'success',
        /// 'aborted', 'failed'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-copy-status")]
        public CopyStatusType? XMsCopyStatus { get; set; }

        /// <summary>
        /// Gets or sets when a blob is leased, specifies whether the lease is
        /// of infinite or fixed duration. Possible values include: 'infinite',
        /// 'fixed'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-lease-duration")]
        public LeaseDurationType? XMsLeaseDuration { get; set; }

        /// <summary>
        /// Gets or sets lease state of the blob. Possible values include:
        /// 'available', 'leased', 'expired', 'breaking', 'broken'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-lease-state")]
        public LeaseStateType? XMsLeaseState { get; set; }

        /// <summary>
        /// Gets or sets the current lease status of the blob. Possible values
        /// include: 'locked', 'unlocked'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-lease-status")]
        public LeaseStatusType? XMsLeaseStatus { get; set; }

        /// <summary>
        /// Gets or sets this header uniquely identifies the request that was
        /// made and can be used for troubleshooting the request.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-request-id")]
        public string XMsRequestId { get; set; }

        /// <summary>
        /// Gets or sets indicates the version of the Blob service used to
        /// execute the request. This header is returned for requests made
        /// against version 2009-09-19 and above.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-version")]
        public string XMsVersion { get; set; }

        /// <summary>
        /// Gets or sets indicates that the service supports requests for
        /// partial blob content.
        /// </summary>
        [JsonProperty(PropertyName = "Accept-Ranges")]
        public string AcceptRanges { get; set; }

        /// <summary>
        /// Gets or sets UTC date/time value generated by the service that
        /// indicates the time at which the response was initiated
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [JsonProperty(PropertyName = "Date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets returned with the value of the Origin header when CORS
        /// rules are specified
        /// </summary>
        [JsonProperty(PropertyName = "Vary")]
        public string Vary { get; set; }

        /// <summary>
        /// Gets or sets the number of committed blocks present in the blob.
        /// This header is returned only for append blobs.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-blob-committed-block-count")]
        public string XMsBlobCommittedBlockCount { get; set; }

        /// <summary>
        /// Gets or sets the value of this header is set to true if the blob
        /// data and application metadata are completely encrypted using the
        /// specified algorithm. Otherwise, the value is set to false (when the
        /// blob is unencrypted, or if only parts of the blob/application
        /// metadata are encrypted).
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-server-encrypted")]
        public bool? XMsServerEncrypted { get; set; }

        /// <summary>
        /// Gets or sets if the blob has a MD5 hash, and if request contains
        /// range header (Range or x-ms-range), this response header is
        /// returned with the value of the whole blob's MD5 value. This value
        /// may or may not be equal to the value returned in Content-MD5
        /// header, with the latter calculated from the requested range
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-blob-content-md5")]
        public string XMsBlobContentMd5 { get; set; }

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
            if( null != ContentLength )
            {
                result.Add(new XElement("Content-Length", ContentLength) );
            }
            if( null != ContentType )
            {
                result.Add(new XElement("Content-Type", ContentType) );
            }
            if( null != ContentRange )
            {
                result.Add(new XElement("Content-Range", ContentRange) );
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
            if( null != CacheControl )
            {
                result.Add(new XElement("Cache-Control", CacheControl) );
            }
            if( null != ContentDisposition )
            {
                result.Add(new XElement("Content-Disposition", ContentDisposition) );
            }
            if( null != XMsBlobSequenceNumber )
            {
                result.Add(new XElement("x-ms-blob-sequence-number", XMsBlobSequenceNumber) );
            }
            if( null != XMsBlobType )
            {
                result.Add(new XElement("x-ms-blob-type", XMsBlobType.ToSerializedValue()) );
            }
            if( null != XMsCopyCompletionTime )
            {
                result.Add(new XElement("x-ms-copy-completion-time", XMsCopyCompletionTime?.ToUniversalTime().ToString("R")) );
            }
            if( null != XMsCopyStatusDescription )
            {
                result.Add(new XElement("x-ms-copy-status-description", XMsCopyStatusDescription) );
            }
            if( null != XMsCopyId )
            {
                result.Add(new XElement("x-ms-copy-id", XMsCopyId) );
            }
            if( null != XMsCopyProgress )
            {
                result.Add(new XElement("x-ms-copy-progress", XMsCopyProgress) );
            }
            if( null != XMsCopySource )
            {
                result.Add(new XElement("x-ms-copy-source", XMsCopySource) );
            }
            if( null != XMsCopyStatus )
            {
                result.Add(new XElement("x-ms-copy-status", XMsCopyStatus.ToSerializedValue()) );
            }
            if( null != XMsLeaseDuration )
            {
                result.Add(new XElement("x-ms-lease-duration", XMsLeaseDuration.ToSerializedValue()) );
            }
            if( null != XMsLeaseState )
            {
                result.Add(new XElement("x-ms-lease-state", XMsLeaseState.ToSerializedValue()) );
            }
            if( null != XMsLeaseStatus )
            {
                result.Add(new XElement("x-ms-lease-status", XMsLeaseStatus.ToSerializedValue()) );
            }
            if( null != XMsRequestId )
            {
                result.Add(new XElement("x-ms-request-id", XMsRequestId) );
            }
            if( null != XMsVersion )
            {
                result.Add(new XElement("x-ms-version", XMsVersion) );
            }
            if( null != AcceptRanges )
            {
                result.Add(new XElement("Accept-Ranges", AcceptRanges) );
            }
            if( null != Date )
            {
                result.Add(new XElement("Date", Date?.ToUniversalTime().ToString("R")) );
            }
            if( null != Vary )
            {
                result.Add(new XElement("Vary", Vary) );
            }
            if( null != XMsBlobCommittedBlockCount )
            {
                result.Add(new XElement("x-ms-blob-committed-block-count", XMsBlobCommittedBlockCount) );
            }
            if( null != XMsServerEncrypted )
            {
                result.Add(new XElement("x-ms-server-encrypted", XMsServerEncrypted) );
            }
            if( null != XMsBlobContentMd5 )
            {
                result.Add(new XElement("x-ms-blob-content-md5", XMsBlobContentMd5) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of BlobsGetHeaders
        /// </summary>
        internal static BlobsGetHeaders XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static BlobsGetHeaders XmlDeserialize(XElement payload)
        {
            var result = new BlobsGetHeaders();
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
            var deserializeContentRange = XmlSerialization.ToDeserializer(e => (string)e);
            string resultContentRange;
            if (deserializeContentRange(payload, "Content-Range", out resultContentRange))
            {
                result.ContentRange = resultContentRange;
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
            var deserializeCacheControl = XmlSerialization.ToDeserializer(e => (string)e);
            string resultCacheControl;
            if (deserializeCacheControl(payload, "Cache-Control", out resultCacheControl))
            {
                result.CacheControl = resultCacheControl;
            }
            var deserializeContentDisposition = XmlSerialization.ToDeserializer(e => (string)e);
            string resultContentDisposition;
            if (deserializeContentDisposition(payload, "Content-Disposition", out resultContentDisposition))
            {
                result.ContentDisposition = resultContentDisposition;
            }
            var deserializeXMsBlobSequenceNumber = XmlSerialization.ToDeserializer(e => (string)e);
            string resultXMsBlobSequenceNumber;
            if (deserializeXMsBlobSequenceNumber(payload, "x-ms-blob-sequence-number", out resultXMsBlobSequenceNumber))
            {
                result.XMsBlobSequenceNumber = resultXMsBlobSequenceNumber;
            }
            var deserializeXMsBlobType = XmlSerialization.ToDeserializer(e => e.Value.ParseBlobType());
            BlobType? resultXMsBlobType;
            if (deserializeXMsBlobType(payload, "x-ms-blob-type", out resultXMsBlobType))
            {
                result.XMsBlobType = resultXMsBlobType;
            }
            var deserializeXMsCopyCompletionTime = XmlSerialization.ToDeserializer(e => (System.DateTime?)e);
            System.DateTime? resultXMsCopyCompletionTime;
            if (deserializeXMsCopyCompletionTime(payload, "x-ms-copy-completion-time", out resultXMsCopyCompletionTime))
            {
                result.XMsCopyCompletionTime = resultXMsCopyCompletionTime;
            }
            var deserializeXMsCopyStatusDescription = XmlSerialization.ToDeserializer(e => (string)e);
            string resultXMsCopyStatusDescription;
            if (deserializeXMsCopyStatusDescription(payload, "x-ms-copy-status-description", out resultXMsCopyStatusDescription))
            {
                result.XMsCopyStatusDescription = resultXMsCopyStatusDescription;
            }
            var deserializeXMsCopyId = XmlSerialization.ToDeserializer(e => (string)e);
            string resultXMsCopyId;
            if (deserializeXMsCopyId(payload, "x-ms-copy-id", out resultXMsCopyId))
            {
                result.XMsCopyId = resultXMsCopyId;
            }
            var deserializeXMsCopyProgress = XmlSerialization.ToDeserializer(e => (string)e);
            string resultXMsCopyProgress;
            if (deserializeXMsCopyProgress(payload, "x-ms-copy-progress", out resultXMsCopyProgress))
            {
                result.XMsCopyProgress = resultXMsCopyProgress;
            }
            var deserializeXMsCopySource = XmlSerialization.ToDeserializer(e => (string)e);
            string resultXMsCopySource;
            if (deserializeXMsCopySource(payload, "x-ms-copy-source", out resultXMsCopySource))
            {
                result.XMsCopySource = resultXMsCopySource;
            }
            var deserializeXMsCopyStatus = XmlSerialization.ToDeserializer(e => e.Value.ParseCopyStatusType());
            CopyStatusType? resultXMsCopyStatus;
            if (deserializeXMsCopyStatus(payload, "x-ms-copy-status", out resultXMsCopyStatus))
            {
                result.XMsCopyStatus = resultXMsCopyStatus;
            }
            var deserializeXMsLeaseDuration = XmlSerialization.ToDeserializer(e => e.Value.ParseLeaseDurationType());
            LeaseDurationType? resultXMsLeaseDuration;
            if (deserializeXMsLeaseDuration(payload, "x-ms-lease-duration", out resultXMsLeaseDuration))
            {
                result.XMsLeaseDuration = resultXMsLeaseDuration;
            }
            var deserializeXMsLeaseState = XmlSerialization.ToDeserializer(e => e.Value.ParseLeaseStateType());
            LeaseStateType? resultXMsLeaseState;
            if (deserializeXMsLeaseState(payload, "x-ms-lease-state", out resultXMsLeaseState))
            {
                result.XMsLeaseState = resultXMsLeaseState;
            }
            var deserializeXMsLeaseStatus = XmlSerialization.ToDeserializer(e => e.Value.ParseLeaseStatusType());
            LeaseStatusType? resultXMsLeaseStatus;
            if (deserializeXMsLeaseStatus(payload, "x-ms-lease-status", out resultXMsLeaseStatus))
            {
                result.XMsLeaseStatus = resultXMsLeaseStatus;
            }
            var deserializeXMsRequestId = XmlSerialization.ToDeserializer(e => (string)e);
            string resultXMsRequestId;
            if (deserializeXMsRequestId(payload, "x-ms-request-id", out resultXMsRequestId))
            {
                result.XMsRequestId = resultXMsRequestId;
            }
            var deserializeXMsVersion = XmlSerialization.ToDeserializer(e => (string)e);
            string resultXMsVersion;
            if (deserializeXMsVersion(payload, "x-ms-version", out resultXMsVersion))
            {
                result.XMsVersion = resultXMsVersion;
            }
            var deserializeAcceptRanges = XmlSerialization.ToDeserializer(e => (string)e);
            string resultAcceptRanges;
            if (deserializeAcceptRanges(payload, "Accept-Ranges", out resultAcceptRanges))
            {
                result.AcceptRanges = resultAcceptRanges;
            }
            var deserializeDate = XmlSerialization.ToDeserializer(e => (System.DateTime?)e);
            System.DateTime? resultDate;
            if (deserializeDate(payload, "Date", out resultDate))
            {
                result.Date = resultDate;
            }
            var deserializeVary = XmlSerialization.ToDeserializer(e => (string)e);
            string resultVary;
            if (deserializeVary(payload, "Vary", out resultVary))
            {
                result.Vary = resultVary;
            }
            var deserializeXMsBlobCommittedBlockCount = XmlSerialization.ToDeserializer(e => (string)e);
            string resultXMsBlobCommittedBlockCount;
            if (deserializeXMsBlobCommittedBlockCount(payload, "x-ms-blob-committed-block-count", out resultXMsBlobCommittedBlockCount))
            {
                result.XMsBlobCommittedBlockCount = resultXMsBlobCommittedBlockCount;
            }
            var deserializeXMsServerEncrypted = XmlSerialization.ToDeserializer(e => (bool?)e);
            bool? resultXMsServerEncrypted;
            if (deserializeXMsServerEncrypted(payload, "x-ms-server-encrypted", out resultXMsServerEncrypted))
            {
                result.XMsServerEncrypted = resultXMsServerEncrypted;
            }
            var deserializeXMsBlobContentMd5 = XmlSerialization.ToDeserializer(e => (string)e);
            string resultXMsBlobContentMd5;
            if (deserializeXMsBlobContentMd5(payload, "x-ms-blob-content-md5", out resultXMsBlobContentMd5))
            {
                result.XMsBlobContentMd5 = resultXMsBlobContentMd5;
            }
            return result;
        }
    }
}

