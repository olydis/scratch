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
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// Defines headers for IncrementalCopy operation.
    /// </summary>
    public partial class PageBlobsIncrementalCopyHeaders
    {
        /// <summary>
        /// Initializes a new instance of the PageBlobsIncrementalCopyHeaders
        /// class.
        /// </summary>
        public PageBlobsIncrementalCopyHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ETag contains a value that you can use to perform
        /// operations conditionally. If the request version is 2011-08-18 or
        /// newer, the ETag value will be in quotes.
        /// </summary>
        [JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets returns the date and time the container was last
        /// modified. Any operation that modifies the blob, including an update
        /// of the blob's metadata or properties, changes the last-modified
        /// time of the blob.
        /// </summary>
        [JsonProperty(PropertyName = "Last-Modified")]
        public string LastModified { get; set; }

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
        /// Gets or sets string identifier for this copy operation. Use with
        /// Get Blob Properties to check the status of this copy operation, or
        /// pass to Abort Copy Blob to abort a pending copy.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-copy-id")]
        public string CopyId { get; set; }

        /// <summary>
        /// Gets or sets state of the copy operation identified by
        /// x-ms-copy-id. Possible values include: 'pending', 'success',
        /// 'aborted', 'failed'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-copy-status")]
        public CopyStatusType? CopyStatus { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != ETag )
            {
                result.Add(new XElement("ETag", ETag) );
            }
            if( null != LastModified )
            {
                result.Add(new XElement("Last-Modified", LastModified) );
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
            if( null != CopyId )
            {
                result.Add(new XElement("x-ms-copy-id", CopyId) );
            }
            if( null != CopyStatus )
            {
                result.Add(new XElement("x-ms-copy-status", CopyStatus.ToSerializedValue()) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of PageBlobsIncrementalCopyHeaders
        /// </summary>
        internal static PageBlobsIncrementalCopyHeaders XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static PageBlobsIncrementalCopyHeaders XmlDeserialize(XElement payload)
        {
            var result = new PageBlobsIncrementalCopyHeaders();
            var deserializeETag = XmlSerialization.ToDeserializer(e => (string)e);
            string resultETag;
            if (deserializeETag(payload, "ETag", out resultETag))
            {
                result.ETag = resultETag;
            }
            var deserializeLastModified = XmlSerialization.ToDeserializer(e => (string)e);
            string resultLastModified;
            if (deserializeLastModified(payload, "Last-Modified", out resultLastModified))
            {
                result.LastModified = resultLastModified;
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
            var deserializeCopyId = XmlSerialization.ToDeserializer(e => (string)e);
            string resultCopyId;
            if (deserializeCopyId(payload, "x-ms-copy-id", out resultCopyId))
            {
                result.CopyId = resultCopyId;
            }
            var deserializeCopyStatus = XmlSerialization.ToDeserializer(e => e.Value.ParseCopyStatusType());
            CopyStatusType? resultCopyStatus;
            if (deserializeCopyStatus(payload, "x-ms-copy-status", out resultCopyStatus))
            {
                result.CopyStatus = resultCopyStatus;
            }
            return result;
        }
    }
}
