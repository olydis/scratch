// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 

using Microsoft.Rest;
using System;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xunit;
using BlobStorageTest.Client;
using BlobStorageTest.Client.Models;
using BlobStorageTest.Tests;
using Microsoft.Rest.Azure;

//<dump disabled/>

public class Test001173 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001173_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001173_s.txt", Encoding.UTF8);

    public Test001173() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>w+/pfF121UudctIds4GK1g==" +
    "</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc67d98aceb5544ce895ef33b7baac1ff7",
                        blob: "abd255efef-0864-4430-87eb-b1560b232fac",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00368 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00368_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00368_s.txt", Encoding.UTF8);

    public Test00368() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>sjg/qsa6vQfowU7/H/I" +
    "IU8WijuKhKJ5nKX4kRGzO8Te0lNJAeprdc1dD79NVUIJmhmG/zqlA2ImZ2IBIlXmaGQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa1b08fe4604144a1b972fa72d06e267c",
                        blob: "Bloba9ccbb10f9d34d00a02170af1be1181b",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00371 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00371_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00371_s.txt", Encoding.UTF8);

    public Test00371() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>sjg/qsa6vQfowU7/H/I" +
    "IU8WijuKhKJ5nKX4kRGzO8Te0lNJAeprdc1dD79NVUIJmhmG/zqlA2ImZ2IBIlXmaGQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa1b08fe4604144a1b972fa72d06e267c",
                        blob: "Bloba9ccbb10f9d34d00a02170af1be1181b",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00366 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00366_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00366_s.txt", Encoding.UTF8);

    public Test00366() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>sjg/qsa6vQfowU7/H/I" +
    "IU8WijuKhKJ5nKX4kRGzO8Te0lNJAeprdc1dD79NVUIJmhmG/zqlA2ImZ2IBIlXmaGQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa1b08fe4604144a1b972fa72d06e267c",
                        blob: "Bloba9ccbb10f9d34d00a02170af1be1181b",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00367 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00367_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00367_s.txt", Encoding.UTF8);

    public Test00367() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>sjg/qsa6vQfowU7/H/I" +
    "IU8WijuKhKJ5nKX4kRGzO8Te0lNJAeprdc1dD79NVUIJmhmG/zqlA2ImZ2IBIlXmaGQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa1b08fe4604144a1b972fa72d06e267c",
                        blob: "Bloba9ccbb10f9d34d00a02170af1be1181b",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00372 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00372_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00372_s.txt", Encoding.UTF8);

    public Test00372() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>sjg/qsa6vQfowU7/H/I" +
    "IU8WijuKhKJ5nKX4kRGzO8Te0lNJAeprdc1dD79NVUIJmhmG/zqlA2ImZ2IBIlXmaGQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa1b08fe4604144a1b972fa72d06e267c",
                        blob: "Bloba9ccbb10f9d34d00a02170af1be1181b",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00370 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00370_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00370_s.txt", Encoding.UTF8);

    public Test00370() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>sjg/qsa6vQfowU7/H/I" +
    "IU8WijuKhKJ5nKX4kRGzO8Te0lNJAeprdc1dD79NVUIJmhmG/zqlA2ImZ2IBIlXmaGQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa1b08fe4604144a1b972fa72d06e267c",
                        blob: "Bloba9ccbb10f9d34d00a02170af1be1181b",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00373 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00373_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00373_s.txt", Encoding.UTF8);

    public Test00373() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>sjg/qsa6vQfowU7/H/I" +
    "IU8WijuKhKJ5nKX4kRGzO8Te0lNJAeprdc1dD79NVUIJmhmG/zqlA2ImZ2IBIlXmaGQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa1b08fe4604144a1b972fa72d06e267c",
                        blob: "Bloba9ccbb10f9d34d00a02170af1be1181b",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00566 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00566_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00566_s.txt", Encoding.UTF8);

    public Test00566() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList />"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersc116a400f07e4be3a7e25bcc394fff8a",
                        blob: "Blob09dcdaa35f934ebf91cc3c6c00076b0a",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00369 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00369_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00369_s.txt", Encoding.UTF8);

    public Test00369() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>sjg/qsa6vQfowU7/H/I" +
    "IU8WijuKhKJ5nKX4kRGzO8Te0lNJAeprdc1dD79NVUIJmhmG/zqlA2ImZ2IBIlXmaGQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa1b08fe4604144a1b972fa72d06e267c",
                        blob: "Bloba9ccbb10f9d34d00a02170af1be1181b",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21631 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21631_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21631_s.txt", Encoding.UTF8);

    public Test21631() : base(recordedRequest, recordedResponse, "accounts8d43a03fa6cc46e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Committed>jrJEQGCjq0LxAkw9lHH39" +
    "1p3fpgRNk6RaT26UeCnN6en2fTuT6uJ+mb93FjZzhyYMKOMZufOy1djstYj6VlhSg==</Committed><" +
    "/BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fa6cc46e",
                        container: "containers7117c8556c6a4ecebe17d0c374d67493",
                        blob: "Bloba28ab5e362684381b5cff83f5201e316",
                        blocks: body,
                        timeout: 30,
                        xMsBlobContentType: "application/octet-stream",
                        ifNoneMatch: "0x8D43A03FA7947A2",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21695 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21695_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21695_s.txt", Encoding.UTF8);

    public Test21695() : base(recordedRequest, recordedResponse, "accounts8d43a03fb5418db")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>iaD1rmKG1vGgrXMmP/0nJT6iMDqYdZL05pT4b8tE5LSRWhUXznm1x2qvuC7+OWGCoTaVePQB4RMNAMfOjWclXA==</Committed><Committed>iaD1rmKG1vGgrXMmP/0nJT6iMDqYdZL05pT4b8tE5LSRWhUXznm1x2qvuC7+OWGCoTaVePQB4RMNAMfOjWclXA==</Committed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fb5418db",
                        container: "containersaf1acb213e094ebf8dd912c17be3bef1",
                        blob: "Bloba406a305a6d34a41888744bf1aae03dd",
                        blocks: body,
                        timeout: 30,
                        xMsBlobContentType: "application/octet-stream",
                        ifMatches: "\"0x8D43A03FB61AD9A\"",
                        ifNoneMatch: "\"0x8D43A03FB61AD9A\"",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21579 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21579_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21579_s.txt", Encoding.UTF8);

    public Test21579() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>3kE/fQIpGv4R8KEEnMSiIkD6nWmBD+qR869BUWC94YAVTOZFVUvq1YQEnN0VImjWL+L+WtYoP85XrolS6MmeVA==</Uncommitted><Uncommitted>voeq7QwX7qfBl+27ZUfO9DMY+NMVCUoOQsJaSjG4C36nH5WHdgFDxm4lMnjaKhYrPoeeLnFOaLQ9nKpJvKN1CQ==</Uncommitted><Uncommitted>Gt0MWbfhStpW+gnKrynsaxfQefcJbVo/6Xfda2iTnY2Xy++uYrmO0Pyj2toomUGt5Mf/27UUoK2CzXA/A99xww==</Uncommitted><Uncommitted>k8LYgytBK5RJT80dMRZ+rWddc6a9opkMGjkaArcgCNNYzzCZo6+4+BJ0FPLb3DV8AWno2b3g5PEozGjxJyjdKQ==</Uncommitted><Uncommitted>Ny8VeOs+cdZGx9Hpl+qr4RfTlR1fMTRCTJtjgZwq7Yknj/EX5Ex2qHMzcN2pqbGj+04mMAjj7gb70yxP2u86HA==</Uncommitted><Uncommitted>BLyAQ6HrHBEgJs2E+FQCYeeqqWdRW9MbOcJFozqKZRpo7Bcexn5mDXjsqjcgJjNsVDe6PxYf/KjpZQnepnjXlQ==</Uncommitted><Uncommitted>zyYDSe9vNWB0h2f/FBR2bQomL3CbUft6MJf3TWv2T80p1Maar9Icza869Lw171CbJY0JaKjeZ30qiRhYd+j1fg==</Uncommitted><Uncommitted>7eYkS21IbyW6w1bHRHWEmhkPTUjP0V1GHQUg7ETWEBvAGJFRdYrTBm2YfUYM+RzouaooOA7fDhuI3S5nKILh4w==</Uncommitted><Uncommitted>rtgM4Ql1yZhbbN7qt5mT0fLvA4aFmPzHBNfIcaMLfe9PRzXaLiUibmmMM89o8H+6g2gw+TSrFBXcRd0yrVf0UA==</Uncommitted><Uncommitted>2oS7ozIf/ehI8MESmOLhelUQVcrFYyyfjhywsObJ2p9puXZpM/c9RLu6hN3TC1+CSuS+R7gjdXdYGxUWb00Bfw==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers429d085826354b938d7d2a0634179bc2",
                        blob: "Blobf5a77c7fab44431289b85a465c50a6cf",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21674 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21674_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21674_s.txt", Encoding.UTF8);

    public Test21674() : base(recordedRequest, recordedResponse, "accounts8d43a03fb0b287a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>So2rH1FnLFQ0eYAv282uW/uwfhyighVQceHzs23To/WHP4cuz9l/vZH/nlvi67FZR4KGdtXWCMh4Wq5vdHjnYQ==</Committed><Uncommitted>f4whMMGLo+O5boYwmWvqTCwfsDe+tnQrD0gYFzyGVkMUE8f2ZUYUS2TkvuwnP9sM/BSoa/dlh8kX9SF4counMw==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fb0b287a",
                        container: "containersef5f2033f44f4ac287b087b49cb7efef",
                        blob: "Blobccd53387d2ee4dabbf8cefa6093ad2aa",
                        blocks: body,
                        timeout: 30,
                        ifNoneMatch: "*",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21614 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21614_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21614_s.txt", Encoding.UTF8);

    public Test21614() : base(recordedRequest, recordedResponse, "accounts8d43a03fa35125d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>J+TKpFCqa+SQxh3p7Lk" +
    "a9ONf+JFE6R3vz1+hdcRiV4cs+xncLcXeUP/BVOUrwv1/Ttdt9Fhsgj3H29XxCPYgLQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fa35125d",
                        container: "containers0ee683d47cc44edabf48db739b266634",
                        blob: "Blobaa008db11bdc4eda953c16d787868aa4",
                        blocks: body,
                        timeout: 30,
                        ifMatches: "\"invalidETag\"",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21689 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21689_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21689_s.txt", Encoding.UTF8);

    public Test21689() : base(recordedRequest, recordedResponse, "accounts8d43a03fb421770")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>luBtU9R8hYj4xx8dsExQuxGJv1O0HahFOtWiuLNYD1v1mP8OGbitTfMTnd/pZrp9fDnObmZGNXk3Jxj/2c3Unw==</Committed><Committed>luBtU9R8hYj4xx8dsExQuxGJv1O0HahFOtWiuLNYD1v1mP8OGbitTfMTnd/pZrp9fDnObmZGNXk3Jxj/2c3Unw==</Committed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fb421770",
                        container: "containers98f8fca915874a54ad91c67b5a33ee2f",
                        blob: "Blob05e4de49fbf647cd94b70d8b251621ea",
                        blocks: body,
                        timeout: 30,
                        ifNoneMatch: "*",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21618 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21618_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21618_s.txt", Encoding.UTF8);

    public Test21618() : base(recordedRequest, recordedResponse, "accounts8d43a03fa4258c2")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>9WIvwHnbFVLw7EcJoSZ" +
    "2lgUM3xEQT3Ow2v+nkBfIjubPMjgMZft3wyh0LZNfh+FvwS0HVUIV3KXvf+Z5NIU6KA==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fa4258c2",
                        container: "containers547fd17490ff49eea7143502f7ba9c2d",
                        blob: "Blob9b2c6194040f4ad79ab766f336f22d2c",
                        blocks: body,
                        timeout: 30,
                        ifMatches: "invalidETag",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}
