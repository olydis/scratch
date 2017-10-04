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
    using Microsoft.Rest.ClientRuntime.Slim;
    using Microsoft.Rest.ClientRuntime.Slim.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    public partial class AzureBlobStorageClient : ServiceClient<AzureBlobStorageClient>, IAzureBlobStorageClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        internal string BaseUri {get; set;}

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// The Azure storage account to use.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Specifies the version of the operation to use for this request.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Provides a client-generated, opaque value with a 1 KB character limit that
        /// is recorded in the analytics logs when storage analytics logging is
        /// enabled.
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Gets the IService.
        /// </summary>
        public virtual IService Service { get; private set; }

        /// <summary>
        /// Gets the IContainerOperations.
        /// </summary>
        public virtual IContainerOperations Container { get; private set; }

        /// <summary>
        /// Gets the IBlobs.
        /// </summary>
        public virtual IBlobs Blobs { get; private set; }

        /// <summary>
        /// Gets the IBlockBlobs.
        /// </summary>
        public virtual IBlockBlobs BlockBlobs { get; private set; }

        /// <summary>
        /// Gets the IPageBlobs.
        /// </summary>
        public virtual IPageBlobs PageBlobs { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AzureBlobStorageClient class.
        /// </summary>
        public AzureBlobStorageClient() : base()
        {
            Initialize();
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Service = new Service(this);
            Container = new ContainerOperations(this);
            Blobs = new Blobs(this);
            BlockBlobs = new BlockBlobs(this);
            PageBlobs = new PageBlobs(this);
            BaseUri = "https://{accountName}.blob.core.windows.net";
            Version = "2016-05-31";
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
