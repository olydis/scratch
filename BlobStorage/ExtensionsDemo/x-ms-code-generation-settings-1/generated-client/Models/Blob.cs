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
    /// An Azure Storage blob
    /// </summary>
    public partial class Blob
    {
        /// <summary>
        /// Initializes a new instance of the Blob class.
        /// </summary>
        public Blob() { }

        /// <summary>
        /// Initializes a new instance of the Blob class.
        /// </summary>
        public Blob(string name = default(string), System.DateTime? snapshot = default(System.DateTime?), BlobProperties properties = default(BlobProperties), IDictionary<string, string> metadata = default(IDictionary<string, string>))
        {
            Name = name;
            Snapshot = snapshot;
            Properties = properties;
            Metadata = metadata;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Snapshot")]
        public System.DateTime? Snapshot { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Properties")]
        public BlobProperties Properties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != Name )
            {
                result.Add(new XElement("Name", Name) );
            }
            if( null != Snapshot )
            {
                result.Add(new XElement("Snapshot", Snapshot) );
            }
            if( null != Properties )
            {
                result.Add(Properties.XmlSerialize(new XElement( "Properties" )));
            }
            if( null != Metadata )
            {
                var dict = new XElement("Metadata");
                foreach( var key in Metadata.Keys ){
                    dict.Add(new XElement( key, Metadata[key] ) );
                }
                result.Add(dict);
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of Blob
        /// </summary>
        internal static Blob XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static Blob XmlDeserialize(XElement payload)
        {
            var result = new Blob();
            var deserializeName = XmlSerialization.ToDeserializer(e => (string)e);
            string resultName;
            if (deserializeName(payload, "Name", out resultName))
            {
                result.Name = resultName;
            }
            var deserializeSnapshot = XmlSerialization.ToDeserializer(e => (System.DateTime?)e);
            System.DateTime? resultSnapshot;
            if (deserializeSnapshot(payload, "Snapshot", out resultSnapshot))
            {
                result.Snapshot = resultSnapshot;
            }
            var deserializeProperties = XmlSerialization.ToDeserializer(e => BlobProperties.XmlDeserialize(e));
            BlobProperties resultProperties;
            if (deserializeProperties(payload, "Properties", out resultProperties))
            {
                result.Properties = resultProperties;
            }
            var deserializeMetadata = XmlSerialization.CreateDictionaryXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e));
            IDictionary<string, string> resultMetadata;
            if (deserializeMetadata(payload, "Metadata", out resultMetadata))
            {
                result.Metadata = resultMetadata;
            }
            return result;
        }
    }
}
