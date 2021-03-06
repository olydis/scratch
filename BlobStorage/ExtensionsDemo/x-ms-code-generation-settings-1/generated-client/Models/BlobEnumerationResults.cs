// Our custom header

namespace blob-storage.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// An enumeration of blobs
    /// </summary>
    public partial class BlobEnumerationResults
    {
        /// <summary>
        /// Initializes a new instance of the BlobEnumerationResults class.
        /// </summary>
        public BlobEnumerationResults() { }

        /// <summary>
        /// Initializes a new instance of the BlobEnumerationResults class.
        /// </summary>
        public BlobEnumerationResults(string serviceEndpoint = default(string), string containerName = default(string), string prefix = default(string), string marker = default(string), int? maxResults = default(int?), string delimiter = default(string), IList<Blob> blobs = default(IList<Blob>), string nextMarker = default(string))
        {
            ServiceEndpoint = serviceEndpoint;
            ContainerName = containerName;
            Prefix = prefix;
            Marker = marker;
            MaxResults = maxResults;
            Delimiter = delimiter;
            Blobs = blobs;
            NextMarker = nextMarker;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ServiceEndpoint")]
        public string ServiceEndpoint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContainerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Marker")]
        public string Marker { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxResults")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Delimiter")]
        public string Delimiter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Blobs")]
        public IList<Blob> Blobs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NextMarker")]
        public string NextMarker { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != ServiceEndpoint )
            {
                result.Add(new XAttribute("ServiceEndpoint", ServiceEndpoint) );
            }
            if( null != ContainerName )
            {
                result.Add(new XAttribute("ContainerName", ContainerName) );
            }
            if( null != Prefix )
            {
                result.Add(new XElement("Prefix", Prefix) );
            }
            if( null != Marker )
            {
                result.Add(new XElement("Marker", Marker) );
            }
            if( null != MaxResults )
            {
                result.Add(new XElement("MaxResults", MaxResults) );
            }
            if( null != Delimiter )
            {
                result.Add(new XElement("Delimiter", Delimiter) );
            }
            if( null != Blobs )
            {
                var seq = new XElement("Blobs");
                foreach( var value in Blobs ){
                    seq.Add(value.XmlSerialize( new XElement( "Blob") ) );
                }
                result.Add(seq);
            }
            if( null != NextMarker )
            {
                result.Add(new XElement("NextMarker", NextMarker) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of BlobEnumerationResults
        /// </summary>
        internal static BlobEnumerationResults XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static BlobEnumerationResults XmlDeserialize(XElement payload)
        {
            var result = new BlobEnumerationResults();
            XAttribute attribute;
            if( null != (attribute = payload.Attribute("ServiceEndpoint")))
            {
                result.ServiceEndpoint = (string)attribute;
            }
            if( null != (attribute = payload.Attribute("ContainerName")))
            {
                result.ContainerName = (string)attribute;
            }
            var deserializePrefix = XmlSerialization.ToDeserializer(e => (string)e);
            string resultPrefix;
            if (deserializePrefix(payload, "Prefix", out resultPrefix))
            {
                result.Prefix = resultPrefix;
            }
            var deserializeMarker = XmlSerialization.ToDeserializer(e => (string)e);
            string resultMarker;
            if (deserializeMarker(payload, "Marker", out resultMarker))
            {
                result.Marker = resultMarker;
            }
            var deserializeMaxResults = XmlSerialization.ToDeserializer(e => (int?)e);
            int? resultMaxResults;
            if (deserializeMaxResults(payload, "MaxResults", out resultMaxResults))
            {
                result.MaxResults = resultMaxResults;
            }
            var deserializeDelimiter = XmlSerialization.ToDeserializer(e => (string)e);
            string resultDelimiter;
            if (deserializeDelimiter(payload, "Delimiter", out resultDelimiter))
            {
                result.Delimiter = resultDelimiter;
            }
            var deserializeBlobs = XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => Blob.XmlDeserialize(e)), "Blob");
            IList<Blob> resultBlobs;
            if (deserializeBlobs(payload, "Blobs", out resultBlobs))
            {
                result.Blobs = resultBlobs;
            }
            var deserializeNextMarker = XmlSerialization.ToDeserializer(e => (string)e);
            string resultNextMarker;
            if (deserializeNextMarker(payload, "NextMarker", out resultNextMarker))
            {
                result.NextMarker = resultNextMarker;
            }
            return result;
        }
    }
}

