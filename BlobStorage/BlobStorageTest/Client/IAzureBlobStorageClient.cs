// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace BlobStorageTest.Client
{
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
        /// The Azure storage account to use.
        /// </summary>
        string AccountName { get; set; }

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
        /// Gets the IService.
        /// </summary>
        IService Service { get; }

        /// <summary>
        /// Gets the IContainerOperations.
        /// </summary>
        IContainerOperations Container { get; }

        /// <summary>
        /// Gets the IBlobs.
        /// </summary>
        IBlobs Blobs { get; }

        /// <summary>
        /// Gets the IBlockBlobs.
        /// </summary>
        IBlockBlobs BlockBlobs { get; }

        /// <summary>
        /// Gets the IPageBlobs.
        /// </summary>
        IPageBlobs PageBlobs { get; }

    }
}
