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

    public partial class Metrics
    {
        /// <summary>
        /// Initializes a new instance of the Metrics class.
        /// </summary>
        public Metrics()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version of Storage Analytics to configure.
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets indicates whether metrics are enabled for the Blob
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "Enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets indicates whether metrics should generate summary
        /// statistics for called API operations.
        /// </summary>
        [JsonProperty(PropertyName = "IncludeAPIs")]
        public bool? IncludeAPIs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RetentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RetentionPolicy != null)
            {
                RetentionPolicy.Validate();
            }
        }
        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != Version )
            {
                result.Add(new XElement("Version", Version) );
            }
            if( null != Enabled )
            {
                result.Add(new XElement("Enabled", Enabled) );
            }
            if( null != IncludeAPIs )
            {
                result.Add(new XElement("IncludeAPIs", IncludeAPIs) );
            }
            if( null != RetentionPolicy )
            {
                result.Add(RetentionPolicy.XmlSerialize(new XElement( "RetentionPolicy" )));
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of Metrics
        /// </summary>
        internal static Metrics XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static Metrics XmlDeserialize(XElement payload)
        {
            var result = new Metrics();
            var deserializeVersion = XmlSerialization.ToDeserializer(e => (string)e);
            string resultVersion;
            if (deserializeVersion(payload, "Version", out resultVersion))
            {
                result.Version = resultVersion;
            }
            var deserializeEnabled = XmlSerialization.ToDeserializer(e => (bool?)e);
            bool? resultEnabled;
            if (deserializeEnabled(payload, "Enabled", out resultEnabled))
            {
                result.Enabled = resultEnabled;
            }
            var deserializeIncludeAPIs = XmlSerialization.ToDeserializer(e => (bool?)e);
            bool? resultIncludeAPIs;
            if (deserializeIncludeAPIs(payload, "IncludeAPIs", out resultIncludeAPIs))
            {
                result.IncludeAPIs = resultIncludeAPIs;
            }
            var deserializeRetentionPolicy = XmlSerialization.ToDeserializer(e => RetentionPolicy.XmlDeserialize(e));
            RetentionPolicy resultRetentionPolicy;
            if (deserializeRetentionPolicy(payload, "RetentionPolicy", out resultRetentionPolicy))
            {
                result.RetentionPolicy = resultRetentionPolicy;
            }
            return result;
        }
    }
}
