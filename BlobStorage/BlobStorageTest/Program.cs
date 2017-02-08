using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlobStorageTest.Client;
using BlobStorageTest.Client.Models;
using Microsoft.WindowsAzure.Storage.Auth;

namespace BlobStorageTest
{
    class Program
    {
        private static readonly string accountName = "FILLME";
        private static readonly string key = "FILLME";

        private static void Main(string[] args)
        {
            var credentials = new StorageCredentials(accountName, key);
            var client = new AzureStorageClient(credentials);
            
            ScenarioSample(client).GetAwaiter().GetResult();
        }

        private static async Task ScenarioSample(AzureStorageClient client)
        {
            var containerName = "mycontainer";
            var blobName1 = "myblob1";
            var blobName2 = "myblob2";
            var blobContent = "Hello World";

            Console.WriteLine("Creating container");
            await client.Container.CreateAsync(accountName, containerName);

            Console.WriteLine("Creating blob");
            using (var contentStream = new MemoryStream(Encoding.UTF8.GetBytes(blobContent)))
            {
                await client.Blobs.PutAsync(accountName, containerName, blobName1, BlobType.BlockBlob, contentStream);
            }

            Console.WriteLine("Copying blob");
            await client.Blobs.CopyAsync(accountName, containerName, blobName2, $"https://{accountName}.blob.core.windows.net/{containerName}/{blobName1}");

            Console.WriteLine("Retrieving blob");
            using (var contentStream = await client.Blobs.GetAsync(accountName, containerName, blobName2))
            {
                var reader = new StreamReader(contentStream, Encoding.UTF8);
                Console.WriteLine("Retrieved blob content: {0}", reader.ReadToEnd());
            }

            Console.WriteLine("Deleting container");
            await client.Container.DeleteAsync(accountName, containerName);
        }
    }
}
