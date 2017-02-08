// Our custom header

namespace blob-storage.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    /// <summary>
    /// CORS is an HTTP feature that enables a web application running under
    /// one domain to access resources in another domain. Web browsers
    /// implement a security restriction known as same-origin policy that
    /// prevents a web page from calling APIs in a different domain; CORS
    /// provides a secure way to allow one domain (the origin domain) to call
    /// APIs in another domain
    /// </summary>
    public partial class CorsRule
    {
        /// <summary>
        /// Initializes a new instance of the CorsRule class.
        /// </summary>
        public CorsRule() { }

        /// <summary>
        /// Initializes a new instance of the CorsRule class.
        /// </summary>
        /// <param name="allowedOrigins">The origin domains that are permitted
        /// to make a request against the storage service via CORS. The origin
        /// domain is the domain from which the request originates. Note that
        /// the origin must be an exact case-sensitive match with the origin
        /// that the user age sends to the service. You can also use the
        /// wildcard character '*' to allow all origin domains to make requests
        /// via CORS.</param>
        /// <param name="allowedMethods">The methods (HTTP request verbs) that
        /// the origin domain may use for a CORS request. (comma
        /// separated)</param>
        /// <param name="allowedHeaders">the request headers that the origin
        /// domain may specify on the CORS request.</param>
        /// <param name="exposedHeaders">The response headers that may be sent
        /// in the response to the CORS request and exposed by the browser to
        /// the request issuer</param>
        /// <param name="maxAgeInSeconds">The maximum amount time that a
        /// browser should cache the preflight OPTIONS request.</param>
        public CorsRule(string allowedOrigins, string allowedMethods, string allowedHeaders, string exposedHeaders, int maxAgeInSeconds)
        {
            AllowedOrigins = allowedOrigins;
            AllowedMethods = allowedMethods;
            AllowedHeaders = allowedHeaders;
            ExposedHeaders = exposedHeaders;
            MaxAgeInSeconds = maxAgeInSeconds;
        }

        /// <summary>
        /// Gets or sets the origin domains that are permitted to make a
        /// request against the storage service via CORS. The origin domain is
        /// the domain from which the request originates. Note that the origin
        /// must be an exact case-sensitive match with the origin that the user
        /// age sends to the service. You can also use the wildcard character
        /// '*' to allow all origin domains to make requests via CORS.
        /// </summary>
        [JsonProperty(PropertyName = "AllowedOrigins")]
        public string AllowedOrigins { get; set; }

        /// <summary>
        /// Gets or sets the methods (HTTP request verbs) that the origin
        /// domain may use for a CORS request. (comma separated)
        /// </summary>
        [JsonProperty(PropertyName = "AllowedMethods")]
        public string AllowedMethods { get; set; }

        /// <summary>
        /// Gets or sets the request headers that the origin domain may specify
        /// on the CORS request.
        /// </summary>
        [JsonProperty(PropertyName = "AllowedHeaders")]
        public string AllowedHeaders { get; set; }

        /// <summary>
        /// Gets or sets the response headers that may be sent in the response
        /// to the CORS request and exposed by the browser to the request
        /// issuer
        /// </summary>
        [JsonProperty(PropertyName = "ExposedHeaders")]
        public string ExposedHeaders { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount time that a browser should cache
        /// the preflight OPTIONS request.
        /// </summary>
        [JsonProperty(PropertyName = "MaxAgeInSeconds")]
        public int MaxAgeInSeconds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AllowedOrigins == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AllowedOrigins");
            }
            if (AllowedMethods == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AllowedMethods");
            }
            if (AllowedHeaders == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AllowedHeaders");
            }
            if (ExposedHeaders == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ExposedHeaders");
            }
            if (MaxAgeInSeconds < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxAgeInSeconds", 0);
            }
        }
        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != AllowedOrigins )
            {
                result.Add(new XElement("AllowedOrigins", AllowedOrigins) );
            }
            if( null != AllowedMethods )
            {
                result.Add(new XElement("AllowedMethods", AllowedMethods) );
            }
            if( null != AllowedHeaders )
            {
                result.Add(new XElement("AllowedHeaders", AllowedHeaders) );
            }
            if( null != ExposedHeaders )
            {
                result.Add(new XElement("ExposedHeaders", ExposedHeaders) );
            }
                result.Add(new XElement("MaxAgeInSeconds", MaxAgeInSeconds) );
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of CorsRule
        /// </summary>
        internal static CorsRule XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static CorsRule XmlDeserialize(XElement payload)
        {
            var result = new CorsRule();
            var deserializeAllowedOrigins = XmlSerialization.ToDeserializer(e => (string)e);
            string resultAllowedOrigins;
            if (deserializeAllowedOrigins(payload, "AllowedOrigins", out resultAllowedOrigins))
            {
                result.AllowedOrigins = resultAllowedOrigins;
            }
            var deserializeAllowedMethods = XmlSerialization.ToDeserializer(e => (string)e);
            string resultAllowedMethods;
            if (deserializeAllowedMethods(payload, "AllowedMethods", out resultAllowedMethods))
            {
                result.AllowedMethods = resultAllowedMethods;
            }
            var deserializeAllowedHeaders = XmlSerialization.ToDeserializer(e => (string)e);
            string resultAllowedHeaders;
            if (deserializeAllowedHeaders(payload, "AllowedHeaders", out resultAllowedHeaders))
            {
                result.AllowedHeaders = resultAllowedHeaders;
            }
            var deserializeExposedHeaders = XmlSerialization.ToDeserializer(e => (string)e);
            string resultExposedHeaders;
            if (deserializeExposedHeaders(payload, "ExposedHeaders", out resultExposedHeaders))
            {
                result.ExposedHeaders = resultExposedHeaders;
            }
            var deserializeMaxAgeInSeconds = XmlSerialization.ToDeserializer(e => (int)e);
            int resultMaxAgeInSeconds;
            if (deserializeMaxAgeInSeconds(payload, "MaxAgeInSeconds", out resultMaxAgeInSeconds))
            {
                result.MaxAgeInSeconds = resultMaxAgeInSeconds;
            }
            return result;
        }
    }
}

