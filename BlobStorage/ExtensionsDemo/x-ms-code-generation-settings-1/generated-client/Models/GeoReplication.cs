// Our custom header

namespace blob-storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public partial class GeoReplication
    {
        /// <summary>
        /// Initializes a new instance of the GeoReplication class.
        /// </summary>
        public GeoReplication() { }

        /// <summary>
        /// Initializes a new instance of the GeoReplication class.
        /// </summary>
        /// <param name="status">The status of the secondary location. Possible
        /// values include: 'live', 'bootstrap', 'unavailable'</param>
        /// <param name="lastSyncTime">A GMT date/time value, to the second.
        /// All primary writes preceding this value are guaranteed to be
        /// available for read operations at the secondary. Primary writes
        /// after this point in time may or may not be available for
        /// reads.</param>
        public GeoReplication(GeoReplicationStatus? status = default(GeoReplicationStatus?), System.DateTime? lastSyncTime = default(System.DateTime?))
        {
            Status = status;
            LastSyncTime = lastSyncTime;
        }

        /// <summary>
        /// Gets or sets the status of the secondary location. Possible values
        /// include: 'live', 'bootstrap', 'unavailable'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public GeoReplicationStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets a GMT date/time value, to the second. All primary
        /// writes preceding this value are guaranteed to be available for read
        /// operations at the secondary. Primary writes after this point in
        /// time may or may not be available for reads.
        /// </summary>
        [JsonConverter(typeof(DateTimeRfc1123JsonConverter))]
        [JsonProperty(PropertyName = "LastSyncTime")]
        public System.DateTime? LastSyncTime { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != Status )
            {
                result.Add(new XElement("Status", Status.ToSerializedValue()) );
            }
            if( null != LastSyncTime )
            {
                result.Add(new XElement("LastSyncTime", LastSyncTime?.ToUniversalTime().ToString("R")) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of GeoReplication
        /// </summary>
        internal static GeoReplication XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static GeoReplication XmlDeserialize(XElement payload)
        {
            var result = new GeoReplication();
            var deserializeStatus = XmlSerialization.ToDeserializer(e => e.Value.ParseGeoReplicationStatus());
            GeoReplicationStatus? resultStatus;
            if (deserializeStatus(payload, "Status", out resultStatus))
            {
                result.Status = resultStatus;
            }
            var deserializeLastSyncTime = XmlSerialization.ToDeserializer(e => (System.DateTime?)e);
            System.DateTime? resultLastSyncTime;
            if (deserializeLastSyncTime(payload, "LastSyncTime", out resultLastSyncTime))
            {
                result.LastSyncTime = resultLastSyncTime;
            }
            return result;
        }
    }
}

