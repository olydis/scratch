// MIT

namespace BlobStorageTest.Client.Models
{
    using Client;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// Properties of a container
    /// </summary>
    public partial class ContainerProperties
    {
        /// <summary>
        /// Initializes a new instance of the ContainerProperties class.
        /// </summary>
        public ContainerProperties() { }

        /// <summary>
        /// Initializes a new instance of the ContainerProperties class.
        /// </summary>
        /// <param name="leaseStatus">Possible values include: 'locked',
        /// 'unlocked'</param>
        /// <param name="leaseState">Possible values include: 'available',
        /// 'leased', 'expired', 'breaking', 'broken'</param>
        /// <param name="leaseDuration">Possible values include: 'infinite',
        /// 'fixed'</param>
        /// <param name="publicAccess">Possible values include: 'container',
        /// 'blob'</param>
        public ContainerProperties(System.DateTime? lastModified = default(System.DateTime?), string etag = default(string), LeaseStatusType? leaseStatus = default(LeaseStatusType?), LeaseStateType? leaseState = default(LeaseStateType?), LeaseDurationType? leaseDuration = default(LeaseDurationType?), string publicAccess = default(string))
        {
            LastModified = lastModified;
            Etag = etag;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            PublicAccess = publicAccess;
        }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [JsonProperty(PropertyName = "Last-Modified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'locked', 'unlocked'
        /// </summary>
        [JsonProperty(PropertyName = "LeaseStatus")]
        public LeaseStatusType? LeaseStatus { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'available', 'leased',
        /// 'expired', 'breaking', 'broken'
        /// </summary>
        [JsonProperty(PropertyName = "LeaseState")]
        public LeaseStateType? LeaseState { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'infinite', 'fixed'
        /// </summary>
        [JsonProperty(PropertyName = "LeaseDuration")]
        public LeaseDurationType? LeaseDuration { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'container', 'blob'
        /// </summary>
        [JsonProperty(PropertyName = "PublicAccess")]
        public string PublicAccess { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != LastModified )
            {
                result.Add(new XElement("Last-Modified", LastModified?.ToUniversalTime().ToString("R")) );
            }
            if( null != Etag )
            {
                result.Add(new XElement("Etag", Etag) );
            }
            if( null != LeaseStatus )
            {
                result.Add(new XElement("LeaseStatus", LeaseStatus.ToSerializedValue()) );
            }
            if( null != LeaseState )
            {
                result.Add(new XElement("LeaseState", LeaseState.ToSerializedValue()) );
            }
            if( null != LeaseDuration )
            {
                result.Add(new XElement("LeaseDuration", LeaseDuration.ToSerializedValue()) );
            }
            if( null != PublicAccess )
            {
                result.Add(new XElement("PublicAccess", PublicAccess) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of ContainerProperties
        /// </summary>
        internal static ContainerProperties XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static ContainerProperties XmlDeserialize(XElement payload)
        {
            var result = new ContainerProperties();
            var deserializeLastModified = XmlSerialization.ToDeserializer(e => (System.DateTime?)e);
            System.DateTime? resultLastModified;
            if (deserializeLastModified(payload, "Last-Modified", out resultLastModified))
            {
                result.LastModified = resultLastModified;
            }
            var deserializeEtag = XmlSerialization.ToDeserializer(e => (string)e);
            string resultEtag;
            if (deserializeEtag(payload, "Etag", out resultEtag))
            {
                result.Etag = resultEtag;
            }
            var deserializeLeaseStatus = XmlSerialization.ToDeserializer(e => e.Value.ParseLeaseStatusType());
            LeaseStatusType? resultLeaseStatus;
            if (deserializeLeaseStatus(payload, "LeaseStatus", out resultLeaseStatus))
            {
                result.LeaseStatus = resultLeaseStatus;
            }
            var deserializeLeaseState = XmlSerialization.ToDeserializer(e => e.Value.ParseLeaseStateType());
            LeaseStateType? resultLeaseState;
            if (deserializeLeaseState(payload, "LeaseState", out resultLeaseState))
            {
                result.LeaseState = resultLeaseState;
            }
            var deserializeLeaseDuration = XmlSerialization.ToDeserializer(e => e.Value.ParseLeaseDurationType());
            LeaseDurationType? resultLeaseDuration;
            if (deserializeLeaseDuration(payload, "LeaseDuration", out resultLeaseDuration))
            {
                result.LeaseDuration = resultLeaseDuration;
            }
            var deserializePublicAccess = XmlSerialization.ToDeserializer(e => (string)e);
            string resultPublicAccess;
            if (deserializePublicAccess(payload, "PublicAccess", out resultPublicAccess))
            {
                result.PublicAccess = resultPublicAccess;
            }
            return result;
        }
    }
}

