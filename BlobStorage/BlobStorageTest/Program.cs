using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlobStorageTest.Client;
using BlobStorageTest.Client.Models;
using Microsoft.Rest.ClientRuntime.RequestPolicy;
using Microsoft.Rest.ClientRuntime.RequestPolicy.StoragePolicies;
using Microsoft.WindowsAzure.Storage.Auth;

namespace BlobStorageTest
{
    class Program
    {
        private static string accountName;

        private static void Main(string[] args)
        {
            accountName = args[0];
            var key = args[1]; 
            var credentials = new StorageCredentials(accountName, key);
            // var client = new AzureBlobStorageClient(credentials);
            var client = new AzureBlobStorageClient(null);
            client.AccountName = accountName;
            client.Pipeline = new IFactory[]
            {
                new CredentialPolicyFactory(credentials),
                new TelemetryPolicyFactory("0.0.1-test", new TelemetryOptions("prefex")),
                new RetryPolicyFactory(new RetryOptions(
                    RetryPolicy.Linear,
                    3,
                    TimeSpan.Zero,
                    TimeSpan.Zero,
                    TimeSpan.Zero,
                    TimeSpan.Zero,
                    new Uri("https://bing.com/")))
            };
            
            ScenarioSample(client).GetAwaiter().GetResult();
        }

        private static async Task ScenarioSample(AzureBlobStorageClient client)
        {
            var containerName = "mycontainer";
            var blobName1 = "myblob1";
            var blobName2 = "myblob2";
            var blobContent = "Hello World";

            Console.WriteLine("Creating container");
            await client.Container.CreateAsync(containerName);

            Console.WriteLine("Creating blob");
            using (var contentStream = new MemoryStream(Encoding.UTF8.GetBytes(blobContent)))
            {
                await client.Blobs.PutAsync(containerName, blobName1, BlobType.BlockBlob, contentStream);
            }

            Console.WriteLine("Copying blob");
            await client.Blobs.CopyAsync(containerName, blobName2, $"https://{accountName}.blob.core.windows.net/{containerName}/{blobName1}");

            Console.WriteLine("Retrieving blob");
            using (var contentStream = await client.Blobs.GetAsync(containerName, blobName2))
            {
                var reader = new StreamReader(contentStream, Encoding.UTF8);
                Console.WriteLine("Retrieved blob content: {0}", reader.ReadToEnd());
            }

            Console.WriteLine("Deleting container");
            await client.Container.DeleteAsync(containerName);
        }
    }
}
