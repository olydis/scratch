// MIT

namespace BlobStorageTest.Client.Models
{
    using Client;
    using Microsoft.Rest;
    using System.Runtime;
    using System.Runtime.Serialization;
    using System.Security;

    /// <summary>
    /// Exception thrown for an invalid response with Error information.
    /// </summary>
#if !PORTABLE
    [System.Serializable]
#endif
    public class ErrorException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public Error Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the ErrorException class.
        /// </summary>
        public ErrorException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ErrorException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public ErrorException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }

#if !PORTABLE
        /// <summary>
        /// Initializes a new instance of the ErrorException class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected ErrorException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Serializes content of the exception.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            if (info == null)
            {
                throw new System.ArgumentNullException("info");
            }

            info.AddValue("Request", Request);
            info.AddValue("Response", Response);
            info.AddValue("Body", Body);
        }
#endif
    }
}
