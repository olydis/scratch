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
    using BlobStorageTest.Client;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// Defines headers for SetProperties operation.
    /// </summary>
    public partial class BlobsSetPropertiesHeaders
    {
        /// <summary>
        /// Initializes a new instance of the BlobsSetPropertiesHeaders class.
        /// </summary>
        public BlobsSetPropertiesHeaders()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobsSetPropertiesHeaders class.
        /// </summary>
        /// <param name="eTag">The ETag contains a value that you can use to
        /// perform operations conditionally. If the request version is
        /// 2011-08-18 or newer, the ETag value will be in quotes.</param>
        /// <param name="lastModified">Returns the date and time the container
        /// was last modified. Any operation that modifies the blob, including
        /// an update of the blob's metadata or properties, changes the
        /// last-modified time of the blob.</param>
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
        public BlobsSetPropertiesHeaders(string eTag = default(string), string lastModified = default(string), string blobSequenceNumber = default(string), string requestId = default(string), string version = default(string), System.DateTime? date = default(System.DateTime?))
        {
            ETag = eTag;
            LastModified = lastModified;
            BlobSequenceNumber = blobSequenceNumber;
            RequestId = requestId;
            Version = version;
            Date = date;
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
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of BlobsSetPropertiesHeaders
        /// </summary>
        internal static BlobsSetPropertiesHeaders XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static BlobsSetPropertiesHeaders XmlDeserialize(XElement payload)
        {
            var result = new BlobsSetPropertiesHeaders();
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
            return result;
        }
    }
}
