// Our custom header

namespace blob-storage
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public partial interface IAzureBlobStorageClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Specifies the version of the operation to use for this request.
        /// </summary>
        string Version { get; set; }

        /// <summary>
        /// Provides a client-generated, opaque value with a 1 KB character
        /// limit that is recorded in the analytics logs when storage analytics
        /// logging is enabled.
        /// </summary>
        string RequestId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IServiceOperations.
        /// </summary>
        IServiceOperations Service { get; }

        /// <summary>
        /// Gets the IContainerOperations.
        /// </summary>
        IContainerOperations Container { get; }

        /// <summary>
        /// Gets the IBlobsOperations.
        /// </summary>
        IBlobsOperations Blobs { get; }

        /// <summary>
        /// Gets the IBlockBlobsOperations.
        /// </summary>
        IBlockBlobsOperations BlockBlobs { get; }

        /// <summary>
        /// Gets the IPageBlobsOperations.
        /// </summary>
        IPageBlobsOperations PageBlobs { get; }

    }
}

