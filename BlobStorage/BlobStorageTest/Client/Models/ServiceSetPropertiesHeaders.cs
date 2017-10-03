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
    using Newtonsoft.Json;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// Defines headers for SetProperties operation.
    /// </summary>
    public partial class ServiceSetPropertiesHeaders
    {
        /// <summary>
        /// Initializes a new instance of the ServiceSetPropertiesHeaders
        /// class.
        /// </summary>
        public ServiceSetPropertiesHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceSetPropertiesHeaders
        /// class.
        /// </summary>
        /// <param name="requestId">This header uniquely identifies the request
        /// that was made and can be used for troubleshooting the
        /// request.</param>
        /// <param name="version">Indicates the version of the Blob service
        /// used to execute the request. This header is returned for requests
        /// made against version 2009-09-19 and above.</param>
        public ServiceSetPropertiesHeaders(string requestId = default(string), string version = default(string))
        {
            RequestId = requestId;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != RequestId )
            {
                result.Add(new XElement("x-ms-request-id", RequestId) );
            }
            if( null != Version )
            {
                result.Add(new XElement("x-ms-version", Version) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of ServiceSetPropertiesHeaders
        /// </summary>
        internal static ServiceSetPropertiesHeaders XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static ServiceSetPropertiesHeaders XmlDeserialize(XElement payload)
        {
            var result = new ServiceSetPropertiesHeaders();
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
            return result;
        }
    }
}
