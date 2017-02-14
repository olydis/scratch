// MIT

namespace BlobStorageTest.Client.Models
{
    using Client;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// the reqtention policy
    /// </summary>
    public partial class RetentionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the RetentionPolicy class.
        /// </summary>
        public RetentionPolicy() { }

        /// <summary>
        /// Initializes a new instance of the RetentionPolicy class.
        /// </summary>
        /// <param name="enabled">Indicates whether a retention policy is
        /// enabled for the storage service</param>
        /// <param name="days">Indicates the number of days that metrics or
        /// logging data should be retained. All data older than this value
        /// will be deleted</param>
        public RetentionPolicy(bool enabled, int? days = default(int?))
        {
            Enabled = enabled;
            Days = days;
        }

        /// <summary>
        /// Gets or sets indicates whether a retention policy is enabled for
        /// the storage service
        /// </summary>
        [JsonProperty(PropertyName = "Enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets indicates the number of days that metrics or logging
        /// data should be retained. All data older than this value will be
        /// deleted
        /// </summary>
        [JsonProperty(PropertyName = "Days")]
        public int? Days { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Days < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Days", 1);
            }
        }
        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
                result.Add(new XElement("Enabled", Enabled) );
            if( null != Days )
            {
                result.Add(new XElement("Days", Days) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of RetentionPolicy
        /// </summary>
        internal static RetentionPolicy XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static RetentionPolicy XmlDeserialize(XElement payload)
        {
            var result = new RetentionPolicy();
            var deserializeEnabled = XmlSerialization.ToDeserializer(e => (bool)e);
            bool resultEnabled;
            if (deserializeEnabled(payload, "Enabled", out resultEnabled))
            {
                result.Enabled = resultEnabled;
            }
            var deserializeDays = XmlSerialization.ToDeserializer(e => (int?)e);
            int? resultDays;
            if (deserializeDays(payload, "Days", out resultDays))
            {
                result.Days = resultDays;
            }
            return result;
        }
    }
}

