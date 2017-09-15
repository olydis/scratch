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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// Defines headers for GetProperties operation.
    /// </summary>
    public partial class ContainerGetPropertiesHeaders
    {
        /// <summary>
        /// Initializes a new instance of the ContainerGetPropertiesHeaders
        /// class.
        /// </summary>
        public ContainerGetPropertiesHeaders()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerGetPropertiesHeaders
        /// class.
        /// </summary>
        /// <param name="eTag">The ETag contains a value that you can use to
        /// perform operations conditionally. If the request version is
        /// 2011-08-18 or newer, the ETag value will be in quotes.</param>
        /// <param name="lastModified">Returns the date and time the container
        /// was last modified. Any operation that modifies the blob, including
        /// an update of the blob's metadata or properties, changes the
        /// last-modified time of the blob.</param>
        /// <param name="leaseDuration">When a blob is leased, specifies
        /// whether the lease is of infinite or fixed duration. Possible values
        /// include: 'infinite', 'fixed'</param>
        /// <param name="leaseState">Lease state of the blob. Possible values
        /// include: 'available', 'leased', 'expired', 'breaking',
        /// 'broken'</param>
        /// <param name="leaseStatus">The current lease status of the blob.
        /// Possible values include: 'locked', 'unlocked'</param>
        /// <param name="requestId">This header uniquely identifies the request
        /// that was made and can be used for troubleshooting the
        /// request.</param>
        /// <param name="version">Indicates the version of the Blob service
        /// used to execute the request. This header is returned for requests
        /// made against version 2009-09-19 and above.</param>
        /// <param name="date">UTC date/time value generated by the service
        /// that indicates the time at which the response was initiated</param>
        /// <param name="blobPublicAccess">Indicated whether data in the
        /// container may be accessed publicly and the level of access.
        /// Possible values include: 'container', 'blob'</param>
        public ContainerGetPropertiesHeaders(IDictionary<string, string> metadata = default(IDictionary<string, string>), string eTag = default(string), string lastModified = default(string), LeaseDurationType? leaseDuration = default(LeaseDurationType?), LeaseStateType? leaseState = default(LeaseStateType?), LeaseStatusType? leaseStatus = default(LeaseStatusType?), string requestId = default(string), string version = default(string), System.DateTime? date = default(System.DateTime?), string blobPublicAccess = default(string))
        {
            Metadata = metadata;
            ETag = eTag;
            LastModified = lastModified;
            LeaseDuration = leaseDuration;
            LeaseState = leaseState;
            LeaseStatus = leaseStatus;
            RequestId = requestId;
            Version = version;
            Date = date;
            BlobPublicAccess = blobPublicAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-meta")]
        public IDictionary<string, string> Metadata { get; set; }

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
        /// Gets or sets indicated whether data in the container may be
        /// accessed publicly and the level of access. Possible values include:
        /// 'container', 'blob'
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-blob-public-access")]
        public string BlobPublicAccess { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != Metadata )
            {
                var dict = new XElement("x-ms-meta");
                foreach( var key in Metadata.Keys ){
                    dict.Add(new XElement( key, Metadata[key] ) );
                }
                result.Add(dict);
            }
            if( null != ETag )
            {
                result.Add(new XElement("ETag", ETag) );
            }
            if( null != LastModified )
            {
                result.Add(new XElement("Last-Modified", LastModified) );
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
            if( null != BlobPublicAccess )
            {
                result.Add(new XElement("x-ms-blob-public-access", BlobPublicAccess) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of ContainerGetPropertiesHeaders
        /// </summary>
        internal static ContainerGetPropertiesHeaders XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static ContainerGetPropertiesHeaders XmlDeserialize(XElement payload)
        {
            var result = new ContainerGetPropertiesHeaders();
            var deserializeMetadata = XmlSerialization.CreateDictionaryXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e));
            IDictionary<string, string> resultMetadata;
            if (deserializeMetadata(payload, "x-ms-meta", out resultMetadata))
            {
                result.Metadata = resultMetadata;
            }
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
            var deserializeBlobPublicAccess = XmlSerialization.ToDeserializer(e => (string)e);
            string resultBlobPublicAccess;
            if (deserializeBlobPublicAccess(payload, "x-ms-blob-public-access", out resultBlobPublicAccess))
            {
                result.BlobPublicAccess = resultBlobPublicAccess;
            }
            return result;
        }
    }
}
