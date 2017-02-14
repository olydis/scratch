// MIT

namespace BlobStorageTest.Client.Models
{
    using Client;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public partial class BlockList
    {
        /// <summary>
        /// Initializes a new instance of the BlockList class.
        /// </summary>
        public BlockList() { }

        /// <summary>
        /// Initializes a new instance of the BlockList class.
        /// </summary>
        public BlockList(IList<Block> committedBlocks = default(IList<Block>), IList<Block> uncommittedBlocks = default(IList<Block>))
        {
            CommittedBlocks = committedBlocks;
            UncommittedBlocks = uncommittedBlocks;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CommittedBlocks")]
        public IList<Block> CommittedBlocks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UncommittedBlocks")]
        public IList<Block> UncommittedBlocks { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != CommittedBlocks )
            {
                var seq = new XElement("CommittedBlocks");
                foreach( var value in CommittedBlocks ){
                    seq.Add(value.XmlSerialize( new XElement( "Block") ) );
                }
                result.Add(seq);
            }
            if( null != UncommittedBlocks )
            {
                var seq = new XElement("UncommittedBlocks");
                foreach( var value in UncommittedBlocks ){
                    seq.Add(value.XmlSerialize( new XElement( "Block") ) );
                }
                result.Add(seq);
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of BlockList
        /// </summary>
        internal static BlockList XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static BlockList XmlDeserialize(XElement payload)
        {
            var result = new BlockList();
            var deserializeCommittedBlocks = XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => Block.XmlDeserialize(e)), "Block");
            IList<Block> resultCommittedBlocks;
            if (deserializeCommittedBlocks(payload, "CommittedBlocks", out resultCommittedBlocks))
            {
                result.CommittedBlocks = resultCommittedBlocks;
            }
            var deserializeUncommittedBlocks = XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => Block.XmlDeserialize(e)), "Block");
            IList<Block> resultUncommittedBlocks;
            if (deserializeUncommittedBlocks(payload, "UncommittedBlocks", out resultUncommittedBlocks))
            {
                result.UncommittedBlocks = resultUncommittedBlocks;
            }
            return result;
        }
    }
}

