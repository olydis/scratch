// MIT

namespace BlobStorageTest.Client.Models
{
    using Client;
    using Newtonsoft.Json;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public partial class ErrorExceptionDetails
    {
        /// <summary>
        /// Initializes a new instance of the ErrorExceptionDetails class.
        /// </summary>
        public ErrorExceptionDetails() { }

        /// <summary>
        /// Initializes a new instance of the ErrorExceptionDetails class.
        /// </summary>
        public ErrorExceptionDetails(string exceptionMessage = default(string), string stackTrace = default(string))
        {
            ExceptionMessage = exceptionMessage;
            StackTrace = stackTrace;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExceptionMessage")]
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StackTrace")]
        public string StackTrace { get; set; }

        /// <summary>
        /// Serializes the object to an XML node
        /// </summary>
        internal XElement XmlSerialize(XElement result)
        {
            if( null != ExceptionMessage )
            {
                result.Add(new XElement("ExceptionMessage", ExceptionMessage) );
            }
            if( null != StackTrace )
            {
                result.Add(new XElement("StackTrace", StackTrace) );
            }
            return result;
        }
        /// <summary>
        /// Deserializes an XML node to an instance of ErrorExceptionDetails
        /// </summary>
        internal static ErrorExceptionDetails XmlDeserialize(string payload)
        {
            // deserialize to xml and use the overload to do the work
            return XmlDeserialize( XElement.Parse( payload ) );
        }
        internal static ErrorExceptionDetails XmlDeserialize(XElement payload)
        {
            var result = new ErrorExceptionDetails();
            var deserializeExceptionMessage = XmlSerialization.ToDeserializer(e => (string)e);
            string resultExceptionMessage;
            if (deserializeExceptionMessage(payload, "ExceptionMessage", out resultExceptionMessage))
            {
                result.ExceptionMessage = resultExceptionMessage;
            }
            var deserializeStackTrace = XmlSerialization.ToDeserializer(e => (string)e);
            string resultStackTrace;
            if (deserializeStackTrace(payload, "StackTrace", out resultStackTrace))
            {
                result.StackTrace = resultStackTrace;
            }
            return result;
        }
    }
}

