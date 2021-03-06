// MIT

namespace BlobStorageTest.Client.Models
{
    using Client;
    using Newtonsoft.Json;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public partial class Block
    {
        /// <summary>
        /// Initializes a new instance of the Block class.
        /// </summary>
        public Block() { }

        /// <summary>
        /// Initializes a new instance of the Block class.
        /// </summary>
        /// <param name="name">The base64 encoded block ID</param>
        /// <param name="size">The block size in bytes</param>
        public Block(string name = default(string), int? size = default(int?))
        {
            Name = name;
            Size = size;
        }

        /// <summary>
        /// Gets or sets the base64 encoded block ID
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the block size in bytes
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int? Size { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != Name )
            {
                result.Add(new XElement("Name", Name) );
            }
            if( null != Size )
            {
                result.Add(new XElement("Size", Size) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of Block
        /// </summary>
        internal static Block XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static Block XmlDeserialize(XElement payload)
        {
            var result = new Block();
            var deserializeName = XmlSerialization.ToDeserializer(e => (string)e);
            string resultName;
            if (deserializeName(payload, "Name", out resultName))
            {
                result.Name = resultName;
            }
            var deserializeSize = XmlSerialization.ToDeserializer(e => (int?)e);
            int? resultSize;
            if (deserializeSize(payload, "Size", out resultSize))
            {
                result.Size = resultSize;
            }
            return result;
        }
    }
}

