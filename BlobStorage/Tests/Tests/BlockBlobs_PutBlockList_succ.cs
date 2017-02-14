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

public class Test000033 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000033_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000033_s.txt", Encoding.UTF8);

    public Test000033() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "c1ef6d0bdbd7b4177ac01b19f920a107c",
                        blob: "blob1",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000059 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000059_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000059_s.txt", Encoding.UTF8);

    public Test000059() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "testc34dc0a100f0149e6beb73e7ff73eb393",
                        blob: "destination",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000057 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000057_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000057_s.txt", Encoding.UTF8);

    public Test000057() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YWU2NjMyNzdjNTYyNGRmZTkx" +
    "MGU0NWUzNDRmODcxMTQtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc34dc0a100f0149e6beb73e7ff73eb393",
                        blob: "source",
                        blocks: body,
                        xMsBlobContentMd5: "JJpVfi4VMj6Y7SXgwcaZvg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000224 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000224_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000224_s.txt", Encoding.UTF8);

    public Test000224() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YWMwZDc4ZDgyMGIxNGQ4ZGEz" +
    "MDBhY2RlMDlhYzljMzktMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "6cda9e166fc244c1a7489c5703b39b9b-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000249 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000249_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000249_s.txt", Encoding.UTF8);

    public Test000249() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>M2UwMTRmYTE4MmNmNGQ0Mzgx" +
    "MmI5M2U0NDEwMmMxN2ItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "6cda9e166fc244c1a7489c5703b39b9b-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000298 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000298_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000298_s.txt", Encoding.UTF8);

    public Test000298() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>N2M4NGFkNzMwMTJkNDllODgy" +
    "YTIyYjYwMjM0OTExMDEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "6cda9e166fc244c1a7489c5703b39b9b-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000288 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000288_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000288_s.txt", Encoding.UTF8);

    public Test000288() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YzY0MzgzM2IyOGRjNDU3MmE4" +
    "M2I3NDI0NDRkMGJjZDctMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "6cda9e166fc244c1a7489c5703b39b9b-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000268 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000268_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000268_s.txt", Encoding.UTF8);

    public Test000268() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZDE3MjkwNzMzYmM4NDdiZDk2" +
    "OThmYzc5ZDdmOGVhZjEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "6cda9e166fc244c1a7489c5703b39b9b-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000258 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000258_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000258_s.txt", Encoding.UTF8);

    public Test000258() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MmFkNmE5NGFjODExNGEwYzgx" +
    "YjJkMGJhMTZjOWQwNWItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "6cda9e166fc244c1a7489c5703b39b9b-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000232 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000232_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000232_s.txt", Encoding.UTF8);

    public Test000232() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZjUwYzdiYTdmNTc5NDE0MWE2" +
    "N2I1MGM1ZTk4ZjUyNjYtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "6cda9e166fc244c1a7489c5703b39b9b-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000240 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000240_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000240_s.txt", Encoding.UTF8);

    public Test000240() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>NjljYmMzYjZmNzgyNDEwNTk1" +
    "MzQzOWU4MDJmN2UwZjYtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "6cda9e166fc244c1a7489c5703b39b9b-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000355 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000355_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000355_s.txt", Encoding.UTF8);

    public Test000355() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>QmxvY2tfMDAwMDE=</Latest" +
    "><Latest>QmxvY2tfMDAwMDI=</Latest><Latest>QmxvY2tfMDAwMDM=</Latest><Latest>QmxvY" +
    "2tfMDAwMDQ=</Latest><Latest>QmxvY2tfMDAwMDU=</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcdabebc2c93df448d80d539646b0d91a1",
                        blob: "test1",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000375 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000375_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000375_s.txt", Encoding.UTF8);

    public Test000375() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>QmxvY2tfMDAwMDE=</Latest" +
    "><Latest>QmxvY2tfMDAwMDI=</Latest><Latest>QmxvY2tfMDAwMDM=</Latest><Latest>QmxvY" +
    "2tfMDAwMDQ=</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcd87c14faf2f841608e5695bc42408260",
                        blob: "blob3",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000381 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000381_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000381_s.txt", Encoding.UTF8);

    public Test000381() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>QmxvY2tfMDAwMDE=</Latest" +
    "><Latest>QmxvY2tfMDAwMDI=</Latest><Latest>QmxvY2tfMDAwMDM=</Latest><Latest>QmxvY" +
    "2tfMDAwMDQ=</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcd87c14faf2f841608e5695bc42408260",
                        blob: "blob4",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000369 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000369_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000369_s.txt", Encoding.UTF8);

    public Test000369() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>QmxvY2tfMDAwMDE=</Latest" +
    "><Latest>QmxvY2tfMDAwMDI=</Latest><Latest>QmxvY2tfMDAwMDM=</Latest><Latest>QmxvY" +
    "2tfMDAwMDQ=</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcd87c14faf2f841608e5695bc42408260",
                        blob: "blob2",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000278 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000278_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000278_s.txt", Encoding.UTF8);

    public Test000278() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZWI2NDM2ZjcyNzM3NGU0Mjgz" +
    "YmUxN2QzMzJjNzNkNzctMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "6cda9e166fc244c1a7489c5703b39b9b-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000363 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000363_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000363_s.txt", Encoding.UTF8);

    public Test000363() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>QmxvY2tfMDAwMDE=</Latest" +
    "><Latest>QmxvY2tfMDAwMDI=</Latest><Latest>QmxvY2tfMDAwMDM=</Latest><Latest>QmxvY" +
    "2tfMDAwMDQ=</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcd87c14faf2f841608e5695bc42408260",
                        blob: "blob1",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000551 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000551_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000551_s.txt", Encoding.UTF8);

    public Test000551() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "$root",
                        blob: "bb7bab6b22-7c8c-4bb7-b7d5-d20ca330c2ec",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000552 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000552_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000552_s.txt", Encoding.UTF8);

    public Test000552() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "$root",
                        blob: "bbe2e69b3f-de2c-437a-ab20-725f42b22ab4",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000506 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000506_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000506_s.txt", Encoding.UTF8);

    public Test000506() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZmE5MjIzY2Q4ZTBhNGQyZWE1" +
    "MWE0NDQ3MjkxMWY0YWEtMDAwMDAw</Latest><Latest>ZmE5MjIzY2Q4ZTBhNGQyZWE1MWE0NDQ3Mjk" +
    "xMWY0YWEtMDAwMDAx</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcec35583db2564bbca88eeaf7d45b7674",
                        blob: "blob1",
                        blocks: body,
                        xMsBlobContentMd5: "9VpUBBYbzR70p+LQAgCTbA==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000550 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000550_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000550_s.txt", Encoding.UTF8);

    public Test000550() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "bbtestc3012aff7573643288f691f37cc6c715d",
                        blob: "bbd19841c7-4d77-4343-adf0-df45f52c0afb",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000625 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000625_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000625_s.txt", Encoding.UTF8);

    public Test000625() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>M2M4MTQyZjQ2MTc0NGYwYWE1" +
    "ZDBjYmNlNmRmZmJlMTctMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "b94b53950bd1424286b9b0d9b95cfe70-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000606 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000606_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000606_s.txt", Encoding.UTF8);

    public Test000606() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZjZjOWM2MDc2MDc3NDUyZGEx" +
    "OTFlZDY3YmViOTY2MmItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "b94b53950bd1424286b9b0d9b95cfe70-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000663 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000663_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000663_s.txt", Encoding.UTF8);

    public Test000663() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZDJkN2U2MjI4OTg4NDNhMzg4" +
    "NWU0YzM0MDY4Njc5ZjUtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "b94b53950bd1424286b9b0d9b95cfe70-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000548 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000548_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000548_s.txt", Encoding.UTF8);

    public Test000548() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "bbtestc3012aff7573643288f691f37cc6c715d",
                        blob: "bb82cec404-8dd8-4771-a4bb-01868c3bef80",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000677 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000677_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000677_s.txt", Encoding.UTF8);

    public Test000677() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>phekvT+Uo06P0bQ3MI5q2A==" +
    "</Latest><Latest>ma5+KO+RY0i7Ps5loOKsYw==</Latest><Latest>MkmuKONLvUWlrb7nkMItTg" +
    "==</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc1daf5150f40342528c2b11be85b4cb86",
                        blob: "blob1",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000647 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000647_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000647_s.txt", Encoding.UTF8);

    public Test000647() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YzM3NGYyNzUxY2ZmNGM1ZGFi" +
    "ZTUzYjAwNzk2MThiZTktMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "b94b53950bd1424286b9b0d9b95cfe70-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000656 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000656_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000656_s.txt", Encoding.UTF8);

    public Test000656() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>OGFkOTE2YzM3OTQ4NGUwZDg1" +
    "NzA3YzU3NWEyYzI1YzgtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "b94b53950bd1424286b9b0d9b95cfe70-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000744 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000744_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000744_s.txt", Encoding.UTF8);

    public Test000744() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YzgyZTlmNTk1YWFhNDA4MDlh" +
    "N2FkODAyNmYyZjE2OGUtMDAwMDAw</Latest><Latest>YzgyZTlmNTk1YWFhNDA4MDlhN2FkODAyNmY" +
    "yZjE2OGUtMDAwMDAx</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc04115bb2c5c140eab94c6867b6ad6b7c",
                        blob: "blob1",
                        blocks: body,
                        xMsBlobContentMd5: "8tsWxJGhTaqZFCcfefB2zQ==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000611 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000611_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000611_s.txt", Encoding.UTF8);

    public Test000611() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MTY3ZjUxYjMwZGQzNDJlOTkx" +
    "ZmFhOTEwZGE3YmQwYzgtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "b94b53950bd1424286b9b0d9b95cfe70-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000619 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000619_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000619_s.txt", Encoding.UTF8);

    public Test000619() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZGVmYmE2OTg5MzNjNGE0Y2Fl" +
    "MDZiZjU5YzNiN2Q0OGEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "b94b53950bd1424286b9b0d9b95cfe70-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000633 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000633_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000633_s.txt", Encoding.UTF8);

    public Test000633() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>NjE5MjM2YTI0NzgyNDFiZjhh" +
    "NmIzMGFkYjU5ZmRmYWItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "b94b53950bd1424286b9b0d9b95cfe70-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000825 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000825_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000825_s.txt", Encoding.UTF8);

    public Test000825() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZmRjNTc5NDIxZmE5NDlkZDhl" +
    "ZGZiNGExODQzMmRlMjctMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob1",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000879 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000879_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000879_s.txt", Encoding.UTF8);

    public Test000879() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZWYzNzRlMDZhOGQyNDY2NGJl" +
    "NzA3NjkyOGU0ZGVlZGEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob11",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000847 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000847_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000847_s.txt", Encoding.UTF8);

    public Test000847() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>NjM0NmJjMDEwNTBkNDYwZmFh" +
    "YjgwYmY1NzYxY2YwYTItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob5",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000549 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000549_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000549_s.txt", Encoding.UTF8);

    public Test000549() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "bbtestc3012aff7573643288f691f37cc6c715d",
                        blob: "bbc83dcb3b-433a-4bc0-8706-e6426efcf2c4",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000841 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000841_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000841_s.txt", Encoding.UTF8);

    public Test000841() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>OGIxMmE2YTAyMmM3NDcyMDkz" +
    "NmFlNWZlYzMyN2NmMjEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob4",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000750 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000750_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000750_s.txt", Encoding.UTF8);

    public Test000750() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZjBhYzYwMjg5M2RiNDY4YTg0" +
    "MTE3ODVlNTY0M2M5NTItMDAwMDAw</Latest><Latest>ZjBhYzYwMjg5M2RiNDY4YTg0MTE3ODVlNTY" +
    "0M2M5NTItMDAwMDAx</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc04115bb2c5c140eab94c6867b6ad6b7c",
                        blob: "blob1",
                        blocks: body,
                        xMsBlobContentMd5: "o/GFvAcmIHZzHAKGsT4kTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000857 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000857_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000857_s.txt", Encoding.UTF8);

    public Test000857() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MjMxMDMwNTc0NTc0NGVmOGE2" +
    "ZWQ1YWM0ZDg0ZWI2YzYtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob7",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000830 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000830_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000830_s.txt", Encoding.UTF8);

    public Test000830() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MTZlZDc1YzBhOWExNGY5ZmJh" +
    "ZmI3ODZlMzcxMWVjMGUtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob2",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000640 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000640_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000640_s.txt", Encoding.UTF8);

    public Test000640() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZDE2ZWQwNmQ5Mjg4NGJjNWJl" +
    "MjQ3MTgwMzUxMTY2ZTctMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "b94b53950bd1424286b9b0d9b95cfe70-lease-tests",
                        blob: "LeasedBlob",
                        blocks: body,
                        xMsBlobContentMd5: "1k8u1fwp5a3gLfTOYHBiTw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000852 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000852_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000852_s.txt", Encoding.UTF8);

    public Test000852() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZTZmNDFlZDJmOGYwNDg2OTkx" +
    "NDJlMDRjZTkzNjY2NGEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob6",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000924 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000924_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000924_s.txt", Encoding.UTF8);

    public Test000924() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZWFjZjkwMjJmY2UwNDEyZTkz" +
    "MWQ1MWNhNDEyMzY5OWEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob19",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000863 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000863_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000863_s.txt", Encoding.UTF8);

    public Test000863() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YjA1MTVmZjkyMTQxNDY2YTk0" +
    "NjY0NTY2ZjhhNTYyYjktMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob8",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000968 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000968_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000968_s.txt", Encoding.UTF8);

    public Test000968() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ODgyNjAyY2JlNzg5NGY0ZGJh" +
    "ZDJiNDUzZmJiNzk2OGEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob27",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000869 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000869_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000869_s.txt", Encoding.UTF8);

    public Test000869() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>OTkwZTYxNzVhYTYyNDFjZTgy" +
    "MDc2YjJmNWEzYjgzNDctMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob9",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000946 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000946_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000946_s.txt", Encoding.UTF8);

    public Test000946() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MTU4ZjM1YzljMjQ5NDE1YWIw" +
    "YTUxOTBjNzY0ODQ0MzktMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob23",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001002 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001002_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001002_s.txt", Encoding.UTF8);

    public Test001002() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ODJlNWE2Y2VkNTgwNDM4Zjkz" +
    "ZjM2ZWZiNzg5ZjcwZDMtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob33",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000980 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000980_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000980_s.txt", Encoding.UTF8);

    public Test000980() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZGZlZDMyYzRjZjBjNGJkMjli" +
    "YTgyM2Q5OTAyZjVmZjQtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob29",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000919 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000919_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000919_s.txt", Encoding.UTF8);

    public Test000919() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MjA4Yzc0ZjQ3ZGU3NDJmNjky" +
    "MDZiZDYzYTBkNjE2MzUtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob18",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000952 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000952_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000952_s.txt", Encoding.UTF8);

    public Test000952() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>NGE0MDVlOTBlOGIyNDg1OTgx" +
    "ZDQ1ZmE2OGM5MTk1YzYtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob24",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000874 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000874_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000874_s.txt", Encoding.UTF8);

    public Test000874() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MTRlOThkZDc5OGU1NDY4NGFl" +
    "MDI5NGY0MTI0NGM3YmItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob10",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000891 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000891_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000891_s.txt", Encoding.UTF8);

    public Test000891() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MDNmMTg4NTM5ZDVjNDgwZWE4" +
    "MGZiYjYwNTUzOGY1ZjgtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob13",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000930 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000930_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000930_s.txt", Encoding.UTF8);

    public Test000930() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MTUyOGRiNDEyNmE0NGNmZGEz" +
    "NWQ0NTNhNmU4ZDY2YjgtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob20",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001040 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001040_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001040_s.txt", Encoding.UTF8);

    public Test001040() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MWY2MzNlZjBlZmU3NDVjYjkz" +
    "ODZiMzYxNTUzYWVmNGYtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob40",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001024 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001024_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001024_s.txt", Encoding.UTF8);

    public Test001024() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZjhiOWZjNmE2MDI4NDA5ODk1" +
    "NDgxZjBhYzA5YTcxZGEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob37",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000985 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000985_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000985_s.txt", Encoding.UTF8);

    public Test000985() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YTgyYzNjMWQ1NWMzNDUzOWE1" +
    "Y2E5ZTQxMTY4OTFjZTYtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob30",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001051 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001051_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001051_s.txt", Encoding.UTF8);

    public Test001051() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>OGY1ZGRhNDRlZmY0NGZjM2I4" +
    "MjBlNjczYWFmMTAxNDMtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob42",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001046 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001046_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001046_s.txt", Encoding.UTF8);

    public Test001046() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MmI1Y2UyMTNmYTI0NDY3MWFj" +
    "ZjJjNzBmZWY4NjEwNjctMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob41",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001062 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001062_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001062_s.txt", Encoding.UTF8);

    public Test001062() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YmU4N2MwMDI3OGVjNDgzNTkz" +
    "OGNjN2RiYjg1ZDRjY2QtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob44",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001106 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001106_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001106_s.txt", Encoding.UTF8);

    public Test001106() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YmRjNzY3NGJlNjU1NGM5ZTk0" +
    "MjlmNWE2ZDI5ZWQyZWMtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob52",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000936 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000936_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000936_s.txt", Encoding.UTF8);

    public Test000936() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>OTUzOTg5NTIyZjJlNDRmNDk4" +
    "NTM4Y2I2ZGJhZTg0MGQtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob21",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000990 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000990_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000990_s.txt", Encoding.UTF8);

    public Test000990() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>NTk4MjhjYmFmY2E4NDI2Y2E4" +
    "ZTA2YjZlNTJmMmE3NzktMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob31",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001073 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001073_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001073_s.txt", Encoding.UTF8);

    public Test001073() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YjEwZGYxZDMzNTM0NDAzZWE2" +
    "MmY2OTJhNTY1YWUzNWEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob46",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000963 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000963_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000963_s.txt", Encoding.UTF8);

    public Test000963() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZGZiYWQyZmJmZjJjNDk4N2Fj" +
    "ZTY5MDVlZjgwOGZjZDItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob26",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000958 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000958_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000958_s.txt", Encoding.UTF8);

    public Test000958() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YzkxMTVmYzVjOWQ5NDY0YmFm" +
    "NmY0NGI0ZWU5N2IzMjEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob25",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001095 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001095_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001095_s.txt", Encoding.UTF8);

    public Test001095() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MzJmMGM1YTM1ZGNmNGI3MmE0" +
    "NzM3ODExMGM0NTU5MjMtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob50",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000835 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000835_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000835_s.txt", Encoding.UTF8);

    public Test000835() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MTQzZjA2YzUyOGUwNDY5MWJk" +
    "ZGU0NGM2ZmQ2NjVmYTQtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob3",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001018 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001018_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001018_s.txt", Encoding.UTF8);

    public Test001018() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>Mzg2MmVjMjliZTJkNGE1Njg0" +
    "NTViNjU0ZWI1OTRiOWMtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob36",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000901 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000901_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000901_s.txt", Encoding.UTF8);

    public Test000901() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MWUwYTk5MmY0MDgxNGJmNTgy" +
    "NjZiYmZjMmM3ZTg0NmItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob15",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001117 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001117_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001117_s.txt", Encoding.UTF8);

    public Test001117() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MzNhZDZjMjEyNmQ3NDk4NDkw" +
    "ZjBiZTAzNTk2N2QwN2ItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob54",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001007 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001007_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001007_s.txt", Encoding.UTF8);

    public Test001007() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YjhjNzNkMjhhMDk5NGE4YTg1" +
    "ODE2YmFiMzM2NDQ5NTUtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob34",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001056 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001056_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001056_s.txt", Encoding.UTF8);

    public Test001056() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YWU1ODllMzRjNjc2NDY1YThh" +
    "MzEyNGUxY2I5NWQyZTAtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob43",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001128 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001128_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001128_s.txt", Encoding.UTF8);

    public Test001128() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MWI3MGEyMTVkNDc1NGE3OThh" +
    "NWFkYjU1MzMyNGNmYzMtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob56",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000885 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000885_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000885_s.txt", Encoding.UTF8);

    public Test000885() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MGM1M2JkNDMzY2JiNGU0M2I2" +
    "NzcwNjc2OGM4ZGM4MTAtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob12",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001078 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001078_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001078_s.txt", Encoding.UTF8);

    public Test001078() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MTAzMDRlNmZlNDcxNDY2M2Ew" +
    "MzZiNmJlODA0ODllNGMtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob47",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001122 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001122_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001122_s.txt", Encoding.UTF8);

    public Test001122() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>NGJmMmE4YWQ3YTkzNGU5ZGE0" +
    "ZGJkMTdjY2VlMzVmMWItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob55",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000996 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000996_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000996_s.txt", Encoding.UTF8);

    public Test000996() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>NTIyYzNmYjUwNDcwNDVjMmE0" +
    "YzYxYmMwMTQwMjY2ZTAtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob32",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000974 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000974_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000974_s.txt", Encoding.UTF8);

    public Test000974() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MmVmMjM5NTdhNDgyNDA2Mjg0" +
    "YzA4YmMzOWMxNWE3ZWYtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob28",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001144 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001144_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001144_s.txt", Encoding.UTF8);

    public Test001144() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MDU4NmQwMmQ0YTA3NGQ0OGI5" +
    "NjkxNjMwNjBmMWIyYTktMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob59",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001139 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001139_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001139_s.txt", Encoding.UTF8);

    public Test001139() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>NWU0OWY5ZDUyYWMwNDMyODg2" +
    "NmNhYWY5N2YwM2NmMTYtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob58",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001134 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001134_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001134_s.txt", Encoding.UTF8);

    public Test001134() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YjA0MGNmMjI5YzVkNDg1NmJi" +
    "MDRhOGY3MjU5YmEzODUtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob57",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000913 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000913_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000913_s.txt", Encoding.UTF8);

    public Test000913() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MjE2ZWQxYzVkOWFkNGQwNDhm" +
    "MzZmMGVhNzc5ZDU5NTEtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob17",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001068 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001068_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001068_s.txt", Encoding.UTF8);

    public Test001068() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZWQwMGE4MmQ2MzAxNDc3NTli" +
    "MTdhMjIwMGQxMjVjMTktMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob45",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001029 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001029_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001029_s.txt", Encoding.UTF8);

    public Test001029() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MzBhMDM1OTdlNmJhNDdmZWJh" +
    "MmJkN2M5NDM1MTAwODQtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob38",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001112 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001112_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001112_s.txt", Encoding.UTF8);

    public Test001112() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MzNjZDllOTgwOGIxNDdiOTg1" +
    "OWVhYjA3ZjhmYmY1ZmUtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob53",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001034 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001034_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001034_s.txt", Encoding.UTF8);

    public Test001034() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZmMyMTkyM2JmYjRkNGI2N2Ix" +
    "NTU0NjYzOGQyYmI3ZTYtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob39",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001150 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001150_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001150_s.txt", Encoding.UTF8);

    public Test001150() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZWRiM2QzYjc0YzU0NDQ2ZWFh" +
    "YzA5MGE1NmExOTllYjUtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob60",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001012 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001012_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001012_s.txt", Encoding.UTF8);

    public Test001012() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>OTA5YzVmZjZkZWU5NDI4Yjky" +
    "YTg4OGNlOTcwMTczYzktMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob35",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000896 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000896_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000896_s.txt", Encoding.UTF8);

    public Test000896() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YmVmZTc3Y2E4ZDhiNDBiM2E2" +
    "YTY4NjhmN2FkOWRiYWUtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob14",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000941 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000941_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000941_s.txt", Encoding.UTF8);

    public Test000941() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MWJiOTg5NmExZWFhNDhlYWJi" +
    "YzY2ZWNiOGU1YzFjZTMtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob22",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001291 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001291_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001291_s.txt", Encoding.UTF8);

    public Test001291() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>M2IwM2E5NGQ5NWRjNGU3ZDlk" +
    "YjVjNTBhNTVmYzkyNjItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc7af05eb93fa04815a478675b009858ea",
                        blob: "blockblob",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001090 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001090_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001090_s.txt", Encoding.UTF8);

    public Test001090() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MmM4MGViNmE0MmNiNDU2YWJk" +
    "NjE0ZTMzOWViZGFhYzAtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob49",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001084 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001084_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001084_s.txt", Encoding.UTF8);

    public Test001084() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>MzdiNDc0OTIxNzQ1NGMxMjli" +
    "NWVjYTEzZjdmNzI1ZjUtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob48",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001247 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001247_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001247_s.txt", Encoding.UTF8);

    public Test001247() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "testc5780a37d2cde4bc98f80fd4fac669ac0",
                        blob: "blob1",
                        blocks: body,
                        xMsBlobContentMd5: "1B2M2Y8AsgTpgAmY7PhCfg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test000907 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000907_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000907_s.txt", Encoding.UTF8);

    public Test000907() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YTllZjIzZWFlNTA5NGZmOWEy" +
    "MmVkNzJlNjQ0ZmFjYWQtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob16",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001235 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001235_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001235_s.txt", Encoding.UTF8);

    public Test001235() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>SsBgjnnyxUCI4LYztJwrzg==" +
    "</Latest><Latest>0sLKdV+WIk6xUC38sQaNzw==</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcc52dfc439dd240cc8bead0eb9a9cda80",
                        blob: "blob1",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001100 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001100_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001100_s.txt", Encoding.UTF8);

    public Test001100() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>YzM2ZGU0OWM0NzU4NGYxMDgy" +
    "ZjA3MGZhZWYzYmQxM2ItMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob51",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001320 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001320_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001320_s.txt", Encoding.UTF8);

    public Test001320() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>Y2VmMWUxMWUxM2M1NGEzYzg1" +
    "MGNhYjk2OTZiNmUyNGMtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcab7d96c5fd3745b7a69c4233860d8c7e",
                        blob: "source",
                        blocks: body,
                        xMsBlobContentMd5: "JJpVfi4VMj6Y7SXgwcaZvg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001166 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001166_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001166_s.txt", Encoding.UTF8);

    public Test001166() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ZDNhMmUxNDQwZmJiNGM4N2Iy" +
    "NGE4MzMwZjNhMmM5NzAtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob63",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001156 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001156_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001156_s.txt", Encoding.UTF8);

    public Test001156() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>NTVkNGZjNGVlYWVjNDQ1NDlh" +
    "OTNjNmI0NmFlM2RmNjAtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob61",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001161 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001161_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001161_s.txt", Encoding.UTF8);

    public Test001161() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>ODdmNGI4NTU2Y2FlNDU2NWE5" +
    "NTY1YjUyYWQxM2ZlYTYtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc2a084fd9d448462682e100753c1889e6",
                        blob: "blob62",
                        blocks: body,
                        xMsBlobContentMd5: "7iaQi/linutLN9rDUPR1Sg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001447 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001447_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001447_s.txt", Encoding.UTF8);

    public Test001447() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>NLVoJiWpnkeD5gBMCgIQKA==" +
    "</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc15012f04d72e432d908c08c19ba0f211",
                        blob: "blob1",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001425 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001425_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001425_s.txt", Encoding.UTF8);

    public Test001425() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "testc245c72583b954b34a4fc53ce0bd10ca8",
                        blob: "myblob",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001481 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001481_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001481_s.txt", Encoding.UTF8);

    public Test001481() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>KZY44ETlnUWUU5TFVnTRrA==" +
    "</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcbbddebc6b30a47018b5c231c156bb1ca",
                        blob: "blob1",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001458 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001458_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001458_s.txt", Encoding.UTF8);

    public Test001458() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "testcf5dee7c19bf94da5a9609c7bcbe0aa5b",
                        blob: "destination",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001374 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001374_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001374_s.txt", Encoding.UTF8);

    public Test001374() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>C6+1exOsIky7l5bafkJvOQ==" +
    "</Latest><Latest>6EYBfuuCmEWdJWB5sDAGiA==</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcefcef6837bba4d3c982215bfb6c68a1a",
                        blob: "blob1",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001430 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001430_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001430_s.txt", Encoding.UTF8);

    public Test001430() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "testc9d1fb339a22b48ac9ea9b007032ff598",
                        blob: "bbdd4f95c5-d711-494b-ab7c-1d7477945114",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001456 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001456_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001456_s.txt", Encoding.UTF8);

    public Test001456() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Latest>OTI2OGE3OWFkZjEzNDQzOGEz" +
    "NTVjMTNhMWFhOWYzYzgtMDAwMDAw</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcf5dee7c19bf94da5a9609c7bcbe0aa5b",
                        blob: "source",
                        blocks: body,
                        xMsBlobContentMd5: "JJpVfi4VMj6Y7SXgwcaZvg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001419 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001419_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001419_s.txt", Encoding.UTF8);

    public Test001419() : base(recordedRequest, recordedResponse, "xclientdev3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Latest>ZjI2YTA0OGIzMTVkNGE5YTkyZGFkOTkwNGZkM2E2NjUtMDAwMDAw</Latest><Latest>ZjI2YTA0OGIzMTVkNGE5YTkyZGFkOTkwNGZkM2E2NjUtMDAwMDAx</Latest><Latest>ZjI2YTA0OGIzMTVkNGE5YTkyZGFkOTkwNGZkM2E2NjUtMDAwMDAy</Latest><Latest>ZjI2YTA0OGIzMTVkNGE5YTkyZGFkOTkwNGZkM2E2NjUtMDAwMDAz</Latest><Latest>ZjI2YTA0OGIzMTVkNGE5YTkyZGFkOTkwNGZkM2E2NjUtMDAwMDA0</Latest><Latest>ZjI2YTA0OGIzMTVkNGE5YTkyZGFkOTkwNGZkM2E2NjUtMDAwMDA1</Latest><Latest>ZjI2YTA0OGIzMTVkNGE5YTkyZGFkOTkwNGZkM2E2NjUtMDAwMDA2</Latest><Latest>ZjI2YTA0OGIzMTVkNGE5YTkyZGFkOTkwNGZkM2E2NjUtMDAwMDA3</Latest></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcfc4b423491f14d4987f8616b9ec6a90c",
                        blob: "blob1",
                        blocks: body,
                        xMsBlobContentMd5: "pMJKOPK7nCnZFp9Zgm/uYA==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001431 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001431_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001431_s.txt", Encoding.UTF8);

    public Test001431() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "testc9d1fb339a22b48ac9ea9b007032ff598",
                        blob: "bb8552bbdf-20fb-4e45-a0ef-9ce1a54b5f99",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test001432 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001432_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001432_s.txt", Encoding.UTF8);

    public Test001432() : base(recordedRequest, recordedResponse, "xclientdev3")
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
                        accountName: "xclientdev3",
                        container: "testc9d1fb339a22b48ac9ea9b007032ff598",
                        blob: "bb30627e7f-f3b2-4b96-80db-2595dd239849",
                        blocks: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test00363 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00363_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00363_s.txt", Encoding.UTF8);

    public Test00363() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>chO4YibP0BDCjrf0Gma" +
    "ya0sk5jeQJzskvtYtd4ENCka89+wAMwt6H33TIFNib9cOhHi6RKQtFUrYlKRQoViPtA==</Uncommitt" +
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test00361 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00361_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00361_s.txt", Encoding.UTF8);

    public Test00361() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>WbjjoXmqOv89vy5f6xp" +
    "9MPaE73KAddUChxW4xcdYucXUhnQKHT0hyKOvZRNz0CGdXhTsbqHuTuPj4Rlj8XU35A==</Uncommitt" +
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test00359 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00359_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00359_s.txt", Encoding.UTF8);

    public Test00359() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>uxs/J8VNohx2uBLzsv1" +
    "yYYhYnRrbDHhshZVA6UAx1R9iUC8YqKS3I3CgDDusVjZUzsMA35ty3q+i06IvDbjbRQ==</Uncommitt" +
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test00550 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00550_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00550_s.txt", Encoding.UTF8);

    public Test00550() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>pclb0dd0kzAJtC0Nmet" +
    "rDbHd/wVxkQ5yJBe1jTHi1mAvZao6PN5lhIjXHjYcrTDV46R1xR5/IBS76a3AvgX/Jg==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers09de4071897643149fbf4a100820101e",
                        blob: "Blob8e2a29f758be41d5bf188815048bfdf9",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test00610 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00610_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00610_s.txt", Encoding.UTF8);

    public Test00610() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>URFYxCIyC1ater1WgEXhhUjQPDf9LpHYv/cF6EKH+4Im6NQEsvzlx4wOvNLCA/iWJOkXiVF8EyOAgAQrLSMTJQ==</Uncommitted><Uncommitted>3NNM63Wq73K+Frz+bsNYb3IwqtSxhDH3uZlp+pZUh9NgJUgWy57c0SOwwWlILb5furYLCYXCwFihVDHcQfXcag==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersf79e2698aa2d4f0c942dda885827014f",
                        blob: "Blob9b210ecb8a9d45809c2f375a21f8d46e",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01643 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01643_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01643_s.txt", Encoding.UTF8);

    public Test01643() : base(recordedRequest, recordedResponse, "accounts8d439fe8686a9b4")
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
                        accountName: "accounts8d439fe8686a9b4",
                        container: "containers6c25e9fb7c2d47df88a887b12f07f1ec",
                        blob: "Blob855a926d61804079841f784a30a6d942",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01669 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01669_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01669_s.txt", Encoding.UTF8);

    public Test01669() : base(recordedRequest, recordedResponse, "accounts8d439fe86c90a44")
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
                        accountName: "accounts8d439fe86c90a44",
                        container: "containers58f23d0382eb4b3381f997d89cdf4cd7",
                        blob: "Blob0ffcf491b2d14fd4be10a8614f508b49",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01727 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01727_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01727_s.txt", Encoding.UTF8);

    public Test01727() : base(recordedRequest, recordedResponse, "accounts8d439fe885181c3")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>tXCwMzg1SU6A9WBS+P8" +
    "iEt1kL55uinsgGEegbOtr0YLhO1Y3mYsyDAPGtB0CfdKyJY+M0d2PVyr1jxrwlN1iFQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439fe885181c3",
                        container: "containers63994c1819c24594a44dbdc799a32f63",
                        blob: "Blob4d68e846a59842ed8c2a5ef520aceaa6",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01711 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01711_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01711_s.txt", Encoding.UTF8);

    public Test01711() : base(recordedRequest, recordedResponse, "accounts8d439fe882b34ea")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>V5SQvl40DQTyE9WGo8k" +
    "BUci8ZohbnEXQAb0p1+JaTWpWmMl3CzxJihHWYQ9buRxSvAtJhtx8irpPv7ygCzYhmA==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439fe882b34ea",
                        container: "containers6820fdb77b93441590c5d823b5867a18",
                        blob: "Blobd870763f3d92495cb2e57d8da8a63e63",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01743 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01743_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01743_s.txt", Encoding.UTF8);

    public Test01743() : base(recordedRequest, recordedResponse, "accounts8d439fe887e5e88")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>7h7EicCTxU7BpKL+1u4" +
    "q2uTmz48MpCBUfJ1JsNneyb13IAOnDAad1A+dKpnrkdFrhTabhUyja0r+bwwjSRR14w==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439fe887e5e88",
                        container: "containers58eef8e49d394ea58d2d72595974bce1",
                        blob: "Blobcdaf1a50a41646bea70d44af3e8fc81f",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01704 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01704_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01704_s.txt", Encoding.UTF8);

    public Test01704() : base(recordedRequest, recordedResponse, "accounts8d439fe88184942")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>TWGLQjYWB5ppCC36gzr" +
    "CILLGsyHhB8tK1aVprBxI/JL/23ujRF6jguEh6g3tw2MlpzbwZwFBfUaVQGyQrVt9IQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439fe88184942",
                        container: "containersc2c473ca9fec4d77bf4e9a9f1ed55aa4",
                        blob: "Blob878ffe4177bc4896b08e53b700a9bcaa",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01631 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01631_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01631_s.txt", Encoding.UTF8);

    public Test01631() : base(recordedRequest, recordedResponse, "accounts8d439fe86662929")
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
                        accountName: "accounts8d439fe86662929",
                        container: "containersc3bd3130401d48ed8fea951b0fc36da2",
                        blob: "Blob0d0e1759d1134051bd450f23b00f15c5",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test00889 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00889_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00889_s.txt", Encoding.UTF8);

    public Test00889() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>Vt3BeWJurtqqZBd6+4lGNeye6A3k9HuxDfCbVkxZEKOqWJw7LE69gVaTB2IfsUmMmWNdzF3UgWJhD2tx01eNUA==</Uncommitted><Uncommitted>Cgmd4Wa3UO0ZklunDrzp+0NF1dc62hziS67+BbYNq+Gmn49awOr3HTB1SH0QycWbpFUQLvrLsjDsu5a3uUs2Cw==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersfeaeba6bad0c4b78a014d0a0d13d607e",
                        blob: "Blobe0325cae8faf4b37921d242006c94d1e",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01752 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01752_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01752_s.txt", Encoding.UTF8);

    public Test01752() : base(recordedRequest, recordedResponse, "accounts8d439fe889d0a5a")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>QkRw07W5qZz5eYv6J0a" +
    "+BQobfwJovTtRI/vPdwUhVmvp0qCXdLMAMdkx5M9vhEczx2TgsF4pOoUIH7C56TGW1w==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439fe889d0a5a",
                        container: "containers8885818133924aa183e98498cf8587a5",
                        blob: "Blob7c2f77986891471a8d9518f4d5fd3ac0",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01736 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01736_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01736_s.txt", Encoding.UTF8);

    public Test01736() : base(recordedRequest, recordedResponse, "accounts8d439fe8865f49b")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>3v+kUuMsQgpwQXgmZJ7" +
    "5JQsWCjkWOp+79K9Tl3F+fKeWBjYkOB/YfKlu4PCqdEQ3ZPmQXuMMRaNf6V002aqY8g==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8865f49b",
                        container: "containers05be212177754e0e97097526a99091af",
                        blob: "Blob71f67c58588445eca3cf0d949c728a74",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01759 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01759_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01759_s.txt", Encoding.UTF8);

    public Test01759() : base(recordedRequest, recordedResponse, "accounts8d439fe88d9506a")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>c35S5GDtGLFOV6l3avz" +
    "TXcNk+zCKbucNEUU50VbY/O0z3TO1tBObr7wQZw6eXjHQaJXtml37rQWXRNIbs0ZadQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439fe88d9506a",
                        container: "containers550ea20f7deb4988b9dbb88683bebac2",
                        blob: "Blobf34588b5e68e4ecea9b33977c9ef6a67",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01655 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01655_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01655_s.txt", Encoding.UTF8);

    public Test01655() : base(recordedRequest, recordedResponse, "accounts8d439fe86a63fd5")
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
                        accountName: "accounts8d439fe86a63fd5",
                        container: "containers1956c82000f844c6889e4b60a8061440",
                        blob: "Blob6a413b09536942c2904c4325ee06950a",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test01720 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01720_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01720_s.txt", Encoding.UTF8);

    public Test01720() : base(recordedRequest, recordedResponse, "accounts8d439fe883dd2cb")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>EMeO2g0PKEyAqH/atcl" +
    "K8YkRUzHFvRP/BQV/GUp0ADQcSof93FX98GH6C8pdm89x64O/j4PoElK0jtQHkA8CCw==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439fe883dd2cb",
                        container: "containersaf5546b6e8d645f2a70641ad7ee25a22",
                        blob: "Blobb400e17f5f204aa49e200a7bc4898663",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test07503 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07503_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07503_s.txt", Encoding.UTF8);

    public Test07503() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>DVvJ5p/Sj1BDvn/W0Ha" +
    "A6Wtzejblwk5MmPzH73BchDnOme8E8gU5n6z6ZmE1lWdg09aTwY86BkoMfU6iCqDf5w==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4d8c9d28d2214128ad79711bb4bafc1a",
                        blob: "Blob1418ce1d96834286a56b356c2ebce445",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test06882 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06882_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06882_s.txt", Encoding.UTF8);

    public Test06882() : base(recordedRequest, recordedResponse, "accounts8d439ff6f140393")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>VUxA1jQfWinEfecqqeM" +
    "9BK9uuCjau6oxSNBY1AvOQcfZnbdX2Jx/6mzFAsvCAedBF1+WDjKuBpmhD45kx4Ud9g==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439ff6f140393",
                        container: "containers7e26ed45fd5d47ebb7e5947e9d7c85c7",
                        blob: "Blob0a9f50d0bccc40d58c6370b6d8a9dfb0",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test07475 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07475_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07475_s.txt", Encoding.UTF8);

    public Test07475() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>0tVGxgJRZxxid5X6ges/zeRRvm+QswqlekQPhE6sqfTQuGrltwxpaTtt+RW40CyZr91VOgjt4R/KoEu+QePNtQ==</Uncommitted><Uncommitted>WRXY51U0I7n07aoXdtRwV27s4tZKGxbAqydXn0RHF6ZiF1bHfVOzub5m1bOhpssOXV5etEfyNj3+GDwt3IN1rQ==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers40af81aea86041bb9e6bf29b1aaa2121",
                        blob: "Blobec11d86f98dd454b99eb23698fc7dec5",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test06885 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06885_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06885_s.txt", Encoding.UTF8);

    public Test06885() : base(recordedRequest, recordedResponse, "accounts8d439ff6f140393")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>VUxA1jQfWinEfecqqeM9BK9uuCjau6oxSNBY1AvOQcfZnbdX2Jx/6mzFAsvCAedBF1+WDjKuBpmhD45kx4Ud9g==</Committed><Uncommitted>5isS7867FLjfbkbpF7ysNzOVK5YdtskOGyPmpwyPorHaFDEzhB5k8vLhwaFHeq/Jcb4JiSR1Di9iA9Sq1GysUA==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439ff6f140393",
                        container: "containers7e26ed45fd5d47ebb7e5947e9d7c85c7",
                        blob: "Blob0a9f50d0bccc40d58c6370b6d8a9dfb0",
                        blocks: body,
                        timeout: 30,
                        xMsBlobContentType: "application/octet-stream",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test06890 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06890_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06890_s.txt", Encoding.UTF8);

    public Test06890() : base(recordedRequest, recordedResponse, "accounts8d439ff6f2baa65")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>eLMUMTikPPQox6FzHTZ" +
    "NhhmMZQYB0YBKuR6FNHHVsWusPfkL9Ffs0dE7OjwzNrY2XsqyCKn8iaYzyngaHgeDUg==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439ff6f2baa65",
                        container: "containersbe62aef6088646fb93279105f2ab090b",
                        blob: "Blobc7c729d0bf734d17857675ef77d29d99",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test07514 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07514_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07514_s.txt", Encoding.UTF8);

    public Test07514() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>gNz8DqRmvJlcWHwJASOyswwvId+tU9fGJTOdevQbshN7T60odu8KL1er4bMNW7qUTw5Zy/U7ii0FNehxyUKkQA==</Uncommitted><Uncommitted>iTwcJPKHAnEjuMl4CCvmwucdQMWAIkEHmGUVBqENpM4IHsXRPKYDs4e74nwe+cAXvn2+S0zs9mb7FYyMcfzPFQ==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbb7065ea93e0464fa9a6883b19283422",
                        blob: "Blob8cfe823cacd84af6bfbb9bb859652e98",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test07482 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07482_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07482_s.txt", Encoding.UTF8);

    public Test07482() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>paIJBMaoF/TgaPvSWFxARqgkD4cM5PgEKs7rYOj8quvyq3tADtI+ERNCTevtxNW5DS/TGjtq2cCqBdn4vbcM4w==</Uncommitted><Uncommitted>/zjW5f1zyZcMFmb4MVK4KJCwh9G6lgn4RlRcNmot3uQo2A73/TQ99hApne5z/4xlU7stX1jbJmkv3p+pF5It3w==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa5273170a6594bd797ad1d4795fb529a",
                        blob: "Bloba4824fba656e40158059b6a1503a05ef",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test06893 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06893_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06893_s.txt", Encoding.UTF8);

    public Test06893() : base(recordedRequest, recordedResponse, "accounts8d439ff6f2baa65")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>eLMUMTikPPQox6FzHTZNhhmMZQYB0YBKuR6FNHHVsWusPfkL9Ffs0dE7OjwzNrY2XsqyCKn8iaYzyngaHgeDUg==</Committed><Uncommitted>QpHBoJM0xpdEFoJnT9anIqnBsLRT1yrf0bLKt+cm/W/X+hs48WgVyMMO7rP2s88x3C9sdBcr6Gpn4c7hag6wHg==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d439ff6f2baa65",
                        container: "containersbe62aef6088646fb93279105f2ab090b",
                        blob: "Blobc7c729d0bf734d17857675ef77d29d99",
                        blocks: body,
                        timeout: 30,
                        xMsBlobContentType: "application/octet-stream",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test07522 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07522_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07522_s.txt", Encoding.UTF8);

    public Test07522() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>3HV68ox2a3MJzpZaJwlNaoUkzbf6VU+I1qD81tWSNRuYxwobx0fnvOD7T5/TFA+lSH6BFEe1h4Ym8hzreZSedg==</Uncommitted><Uncommitted>MaI9PBHX/gavtMGRV41XESHT4z+D9dUr+0JLXdgHWFOvphfbQ9c13YmAdz5aWiIHR2V2p90gezzNEkHPjKAtpw==</Uncommitted><Uncommitted>3HV68ox2a3MJzpZaJwlNaoUkzbf6VU+I1qD81tWSNRuYxwobx0fnvOD7T5/TFA+lSH6BFEe1h4Ym8hzreZSedg==</Uncommitted><Uncommitted>3HV68ox2a3MJzpZaJwlNaoUkzbf6VU+I1qD81tWSNRuYxwobx0fnvOD7T5/TFA+lSH6BFEe1h4Ym8hzreZSedg==</Uncommitted><Uncommitted>MaI9PBHX/gavtMGRV41XESHT4z+D9dUr+0JLXdgHWFOvphfbQ9c13YmAdz5aWiIHR2V2p90gezzNEkHPjKAtpw==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersea39517e246e4ee9a5f6c6a87482542d",
                        blob: "Blob27064ecb6e324fe6b204cc95b1ce77bd",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test07491 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07491_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07491_s.txt", Encoding.UTF8);

    public Test07491() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>zxqyXKmoiocTaIEip8GpJS4OFuZ5UwAvG+yPx2BMz7U0BeJoTuZ61tSaqJvLmyGZFx//yIxtAHwZg0C8GMMnxg==</Uncommitted><Uncommitted>QddIk0AR36plZIDL9q9ATAYpxgVmTsumvb0RcuEC/61/utZItzRLWyDRtB+/8SIT5nmSoiecePIModaCAGzJYg==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers29e131e01bff44daa57bafbf66539d4b",
                        blob: "Blob629f63f624c3474b8654214ff22a8633",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test07530 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07530_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07530_s.txt", Encoding.UTF8);

    public Test07530() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>g0P3QKigx5jLaRKwGgD2pqT476zr1bcDWH2xAudrT3xxFoc8gvioOxdA3m4E6G2Y1EBZxcvDDq6M9Ogr78WwXw==</Uncommitted><Uncommitted>uiSsT7SUq/dI/m8PGS2nEoqwrgjZr40PfUxSj35UbappHxobrHUXLmK3Q/Z5G9WXCU2P5o/7nwqXnNJoQht48w==</Uncommitted><Uncommitted>i2UUmIClImyXlmF2uoYxxYcabYAQhA+jr+tHPlBls3XbhH7oe00PVnye/wZw8YiURy4Iqjh5AgZVcOmVXuMbMg==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerse4b59a9e63fb4dfdae04067e1241ec75",
                        blob: "Blobc3aac6f259d3475e960fef793e4a62a1",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test17565 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17565_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17565_s.txt", Encoding.UTF8);

    public Test17565() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>QZeAMNUB53CenW2LsJ2+okXdDoNuiOl2UIBgyPr6MaRB3BUyahYzttek/pSlcxSggdolWSBi6LmuCeBUoB51ow==</Uncommitted><Uncommitted>jDcvqVisyopV0NxswEcf1deD3vRchGE13xa5Llon3ClAF/Wj9bDIth0uWTgD5+DXVs6VRWrfLAjV+spB8pwvLQ==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers35da3d81ddab4b88902f21562cd4b654",
                        blob: "Blobb9aac015b6f74065821c30bd8c889c8f",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21629 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21629_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21629_s.txt", Encoding.UTF8);

    public Test21629() : base(recordedRequest, recordedResponse, "accounts8d43a03fa6cc46e")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>jrJEQGCjq0LxAkw9lHH" +
    "391p3fpgRNk6RaT26UeCnN6en2fTuT6uJ+mb93FjZzhyYMKOMZufOy1djstYj6VlhSg==</Uncommitt" +
    "ed></BlockList>"), out body));
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
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21693 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21693_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21693_s.txt", Encoding.UTF8);

    public Test21693() : base(recordedRequest, recordedResponse, "accounts8d43a03fb5418db")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>iaD1rmKG1vGgrXMmP/0" +
    "nJT6iMDqYdZL05pT4b8tE5LSRWhUXznm1x2qvuC7+OWGCoTaVePQB4RMNAMfOjWclXA==</Uncommitt" +
    "ed></BlockList>"), out body));
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
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21632 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21632_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21632_s.txt", Encoding.UTF8);

    public Test21632() : base(recordedRequest, recordedResponse, "accounts8d43a03fa6cc46e")
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
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21633 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21633_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21633_s.txt", Encoding.UTF8);

    public Test21633() : base(recordedRequest, recordedResponse, "accounts8d43a03fa6cc46e")
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test17558 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17558_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17558_s.txt", Encoding.UTF8);

    public Test17558() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>TPE/Nk5S8tmFTtDY0f1PAq5IXeOeT5nlG1ZTsZjBWLvbfS0WGLwRsxTIUmRw6EHvpNsuzTSPAf1XWhr3/kBAxA==</Uncommitted><Uncommitted>OenxN6nP1fw1dTIVYwy8koqGTHwwvr6iGbTTh41uWuvsH2vyPZaKvysAIuTn4Zs0hDJrjrHYn3orTx71/E1uxg==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersaf32071c2d2542bf9f41746135d43f1c",
                        blob: "Blobb3f005e1668e432ea2e57a152a5124b2",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21646 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21646_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21646_s.txt", Encoding.UTF8);

    public Test21646() : base(recordedRequest, recordedResponse, "accounts8d43a03faa11b40")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>1kMHzwPkYH7APf69iU0qtxqVdc/McYuwHlHamRSJBU9YEe36dkcqR1po27iI9JwLQfH9evU0nWW3VrGxCcZqNw==</Uncommitted><Uncommitted>L0DSay10ZJbTJym1z1gii4taI3SIQyCWeD6T/aOB2o4kqxGxKg7HvznO5C+H/DpuR6urU0ED1+wgPPLv4WbyUQ==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03faa11b40",
                        container: "containers9aad0a23f4f94749acdfa93257177e21",
                        blob: "Blob451c4e6474514d8d80bec346f204a64c",
                        blocks: body,
                        timeout: 30,
                        ifMatches: "*",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21590 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21590_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21590_s.txt", Encoding.UTF8);

    public Test21590() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>C5PmRUP+EBjhJ9VuuAXHsWKAFdKdX3SoFWuYCU6RWUHn/3OBO2KbbmcufKs7oFHZhxsgPBiSZasePjDYZgfJUA==</Uncommitted><Uncommitted>cR0pVJnHY/0xwwhfZSzepxqXSEGmIFdwJvfIVdG8vqeFld6wajEgyeJ3ziGfDAi26sVagnZAjVHFuC2i/g0sdQ==</Uncommitted><Uncommitted>YjwwRAiN67EDfcrUS1kbPjE4aL2IcQr44V//j+YTs+yiIBPJL5bHv0KL5fqziuL4GpPptamtgvAxOGKpjlzK8A==</Uncommitted><Uncommitted>Kf5C9Z4il/YzHjHmwPQw1Vi3sseETkQAMYVkIfQKLIfnd8bLmzyMIrsYZ1J3lTyX327/xFSsz9u5QsQYvnYCKA==</Uncommitted><Uncommitted>C2czOqfrEll3dGREFT5gzJbyaXo045nEoGP0xrgnz/I0fB2Kd8SiQlLgpLcrx1WokrwFVmPHUCjObppD90ugUA==</Uncommitted><Uncommitted>IniObCz1vAgqXksHQFMSube8iLtnMwY8oPzo69XBNawXpC4s46RtKxpMp/HbIBPr0N8hUcN4lO5xUswvDNAyaA==</Uncommitted><Uncommitted>oOTonhA/upDXPR9JGj7IPDB3xesIDgFm13lhXfFMRg61O8hFtlGM5SpGOxI8VwBNTCROcTgv7pHigceW3l2eig==</Uncommitted><Uncommitted>/dXWhU02YjSK9QfNp7AbK8Mi18meb4VYbyu+81dHHclM0YwhOg6QPyFRVPXX8xsi1P68Vj1HLo5PfRYieG/dQg==</Uncommitted><Uncommitted>i8eMBKL+0r34bsexdBIemXJE/9oNCMSln+Bzv/uaEtxPg7cQsXs0JCcyuyPQ9tkIcegJy5tES4MC52TBixLCXg==</Uncommitted><Uncommitted>kUZBCjg0DcoWcpkUcF3I5pPprWQBErrBknA2YhK7uiDFrs0VqFe3JgAc4J5BnWrv2O0VHb3pEn+MgHjH/aq4Ww==</Uncommitted></BlockList>"), out body));
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21594 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21594_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21594_s.txt", Encoding.UTF8);

    public Test21594() : base(recordedRequest, recordedResponse, "accounts8d43a03f9f019a4")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>pZxj25xNiSje8ChVY4T" +
    "lyE6oXiWv2Ow1hS1NbwCEwbYgk7YbFXQkQikUXkFeDoGtNremXehkdcywLVZvABkoWQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03f9f019a4",
                        container: "containersfe5f4e86eb8445bc964cd016f324b87f",
                        blob: "Blob79842b18101d4ac799f33fcf365f67c9",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21651 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21651_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21651_s.txt", Encoding.UTF8);

    public Test21651() : base(recordedRequest, recordedResponse, "accounts8d43a03fab2f5ad")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>62oWJ9ZKLsDcyR2NLy1" +
    "17Lyw+nzFTnFPIeBzYLuHZ97MDiMR7f3grqbGb1a2mGHAp+shIuEWHJz5xgb11s4FVQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fab2f5ad",
                        container: "containers58d459e80c6445cd89385f141a60a128",
                        blob: "Blob796b09bb2df541c78b4746c9f7a030f8",
                        blocks: body,
                        timeout: 30,
                        leaseId: "04b619ee-5447-4636-8dd3-be36866b9bd0",
                        ifMatches: "*",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21596 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21596_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21596_s.txt", Encoding.UTF8);

    public Test21596() : base(recordedRequest, recordedResponse, "accounts8d43a03f9f019a4")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>pZxj25xNiSje8ChVY4TlyE6oXiWv2Ow1hS1NbwCEwbYgk7YbFXQkQikUXkFeDoGtNremXehkdcywLVZvABkoWQ==</Committed><Uncommitted>ybLagxz7mnqr13arnzhI3mPNvB7pa+getUEQ7AQR7Nqw320Fy9rMadpRBFbfw2Hh33vMpHix5F3JvM7b6651mQ==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03f9f019a4",
                        container: "containersfe5f4e86eb8445bc964cd016f324b87f",
                        blob: "Blob79842b18101d4ac799f33fcf365f67c9",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21656 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21656_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21656_s.txt", Encoding.UTF8);

    public Test21656() : base(recordedRequest, recordedResponse, "accounts8d43a03fac45aed")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>ZkT9tfKGGCb36tfXwBr1eNdBtkPsYlKUQBy+3i19diMVNe8cQQstg0vYxuV0/T/EJSCwPfx14wPyaHXVyDn4eg==</Uncommitted><Uncommitted>2DbMEzL3E5ttH0Ld+bkNzDgmn1LrKtmVV7oR4ExwwDu0mU3p5CnJftBohEgy+M+A6608jSI4P61dNrt45TNO/Q==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fac45aed",
                        container: "containers62e5be775bed47ab8cf6123c303e9f14",
                        blob: "Blob5e8ca2ae20dd407b8f49c5750c1b2e63",
                        blocks: body,
                        timeout: 30,
                        ifNoneMatch: "*",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21660 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21660_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21660_s.txt", Encoding.UTF8);

    public Test21660() : base(recordedRequest, recordedResponse, "accounts8d43a03fad523fb")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>K89vFcjFLjABtbwGzNN" +
    "cjFQ/sMkr7qsFy5Y6oAuJ5WkepziPfHws2QUDF8admb/aEcVDXWm9vjwjaUkxi40ldw==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fad523fb",
                        container: "containers23fbbc20d2ea4766a1010ad13201c6ea",
                        blob: "Blobc60f2a081b6d48b7adbe699684d55118",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21600 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21600_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21600_s.txt", Encoding.UTF8);

    public Test21600() : base(recordedRequest, recordedResponse, "accounts8d43a03fa035383")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>Q8ihFpxpQ6IlbUz2N33" +
    "d+r2i7VOiOvzEuwgCfBDVGLv7JvsoPhhwHwKlPZCvGAOSLvbAie4XyAjM3VqTZsaSTw==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fa035383",
                        container: "containers162fc75b76ad44899bb9aadb13977c14",
                        blob: "Blob4222a59382fd4000ad1e5386b86fa56d",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21662 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21662_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21662_s.txt", Encoding.UTF8);

    public Test21662() : base(recordedRequest, recordedResponse, "accounts8d43a03fad523fb")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>K89vFcjFLjABtbwGzNNcjFQ/sMkr7qsFy5Y6oAuJ5WkepziPfHws2QUDF8admb/aEcVDXWm9vjwjaUkxi40ldw==</Committed><Uncommitted>zA/YE9bEKNfkaDHXX45FRogAYen7bBMy+k133Z/2SrGZP0W2akqS+ZVlPgAYWiv/3zFIUoY8n2D7phiITEo37g==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fad523fb",
                        container: "containers23fbbc20d2ea4766a1010ad13201c6ea",
                        blob: "Blobc60f2a081b6d48b7adbe699684d55118",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21602 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21602_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21602_s.txt", Encoding.UTF8);

    public Test21602() : base(recordedRequest, recordedResponse, "accounts8d43a03fa035383")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>Q8ihFpxpQ6IlbUz2N33d+r2i7VOiOvzEuwgCfBDVGLv7JvsoPhhwHwKlPZCvGAOSLvbAie4XyAjM3VqTZsaSTw==</Committed><Uncommitted>tbylMc1R/f1rFKIEcE4aFY7M417yW2C93Lk8Eu07Hx3yEHk5G1chxsoLYci4j/Z3dznGwxeyj1lb51UUFeoPLw==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fa035383",
                        container: "containers162fc75b76ad44899bb9aadb13977c14",
                        blob: "Blob4222a59382fd4000ad1e5386b86fa56d",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21666 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21666_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21666_s.txt", Encoding.UTF8);

    public Test21666() : base(recordedRequest, recordedResponse, "accounts8d43a03faed8e1d")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>lxwLtU9WCuQf6Qky6Ix" +
    "4ZtRMyD8mVeGAZNUXC2O6CGfcMIKEFsKuGKQSC3OWstE3uaLY/mURvEE7i1F6Pv6BZA==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03faed8e1d",
                        container: "containers4a83b786b8b8483fa57ae02f7c194de3",
                        blob: "Blob3213a8b1b6ca415b828371235ed64519",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21668 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21668_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21668_s.txt", Encoding.UTF8);

    public Test21668() : base(recordedRequest, recordedResponse, "accounts8d43a03faed8e1d")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>lxwLtU9WCuQf6Qky6Ix4ZtRMyD8mVeGAZNUXC2O6CGfcMIKEFsKuGKQSC3OWstE3uaLY/mURvEE7i1F6Pv6BZA==</Committed><Uncommitted>81ARnbCaE0pt6rED4FLA4QoBy3RASYpxM9mmkaeT9FwZLMVSx2C1dqj3zaCfd16swILWoIlEyarFn2rW9IGj2g==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03faed8e1d",
                        container: "containers4a83b786b8b8483fa57ae02f7c194de3",
                        blob: "Blob3213a8b1b6ca415b828371235ed64519",
                        blocks: body,
                        timeout: 30,
                        ifMatches: "*",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21606 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21606_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21606_s.txt", Encoding.UTF8);

    public Test21606() : base(recordedRequest, recordedResponse, "accounts8d43a03fa1e7cd0")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>M32WopY/kBj5H6hfw+M" +
    "IUVBPW7uaftHetgLGNJ1rs+rIxdHPLCEEc+RDDCDYvxtQ+bxgkKB1OLWrt+yUeVt6jg==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fa1e7cd0",
                        container: "containersc70f88e00ebc479087228bd3040dc336",
                        blob: "Blob6898925c86434e90911e43b5ff9a7254",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21672 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21672_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21672_s.txt", Encoding.UTF8);

    public Test21672() : base(recordedRequest, recordedResponse, "accounts8d43a03fb0b287a")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>So2rH1FnLFQ0eYAv282" +
    "uW/uwfhyighVQceHzs23To/WHP4cuz9l/vZH/nlvi67FZR4KGdtXWCMh4Wq5vdHjnYQ==</Uncommitt" +
    "ed></BlockList>"), out body));
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
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21678 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21678_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21678_s.txt", Encoding.UTF8);

    public Test21678() : base(recordedRequest, recordedResponse, "accounts8d43a03fb1dc633")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>5CNUaAgtwWGSkq3SjvF" +
    "QC2Zwf1Us92z7pRR3wm6M+Z1rsx6tGKMS+RyJuRzdLFB905Bxab02p+22WcPztv/yBQ==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fb1dc633",
                        container: "containersd8ce214aa567431b80fe95dd32b066d3",
                        blob: "Blob7e044c5c5f7c4636bbbce9ec8ef1556d",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21679 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21679_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21679_s.txt", Encoding.UTF8);

    public Test21679() : base(recordedRequest, recordedResponse, "accounts8d43a03fb1dc633")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>5CNUaAgtwWGSkq3SjvFQC2Zwf1Us92z7pRR3wm6M+Z1rsx6tGKMS+RyJuRzdLFB905Bxab02p+22WcPztv/yBQ==</Committed><Committed>5CNUaAgtwWGSkq3SjvFQC2Zwf1Us92z7pRR3wm6M+Z1rsx6tGKMS+RyJuRzdLFB905Bxab02p+22WcPztv/yBQ==</Committed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fb1dc633",
                        container: "containersd8ce214aa567431b80fe95dd32b066d3",
                        blob: "Blob7e044c5c5f7c4636bbbce9ec8ef1556d",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21683 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21683_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21683_s.txt", Encoding.UTF8);

    public Test21683() : base(recordedRequest, recordedResponse, "accounts8d43a03fb2fa09b")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>G4/fNQwx9r/gHkMcl7S" +
    "DzMZ1qjCerQs3/ASvZjtKL7wRFOoJMDDOoawz4z9CHAyJzFCzT06+P22EqDgHgY+Dlg==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fb2fa09b",
                        container: "containers6a5fc952c13a4dcd886864fe180740d5",
                        blob: "Blobb180846185fa4aa1b46a5775bffcbbf1",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21684 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21684_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21684_s.txt", Encoding.UTF8);

    public Test21684() : base(recordedRequest, recordedResponse, "accounts8d43a03fb2fa09b")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>G4/fNQwx9r/gHkMcl7SDzMZ1qjCerQs3/ASvZjtKL7wRFOoJMDDOoawz4z9CHAyJzFCzT06+P22EqDgHgY+Dlg==</Committed><Committed>G4/fNQwx9r/gHkMcl7SDzMZ1qjCerQs3/ASvZjtKL7wRFOoJMDDOoawz4z9CHAyJzFCzT06+P22EqDgHgY+Dlg==</Committed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fb2fa09b",
                        container: "containers6a5fc952c13a4dcd886864fe180740d5",
                        blob: "Blobb180846185fa4aa1b46a5775bffcbbf1",
                        blocks: body,
                        timeout: 30,
                        ifMatches: "*",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21688 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21688_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21688_s.txt", Encoding.UTF8);

    public Test21688() : base(recordedRequest, recordedResponse, "accounts8d43a03fb421770")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>luBtU9R8hYj4xx8dsEx" +
    "QuxGJv1O0HahFOtWiuLNYD1v1mP8OGbitTfMTnd/pZrp9fDnObmZGNXk3Jxj/2c3Unw==</Uncommitt" +
    "ed></BlockList>"), out body));
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
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21622 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21622_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21622_s.txt", Encoding.UTF8);

    public Test21622() : base(recordedRequest, recordedResponse, "accounts8d43a03fa567d1c")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Uncommitted>wTmjulaSHeUV/Y+iOQU" +
    "1/k1zgVj8/cAnLECDDy+TXPu2T2ckvn8YW0tL85iLRmIcqVIFqbd27sN5e40VDg22gg==</Uncommitt" +
    "ed></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fa567d1c",
                        container: "containers8ba9612a71f24672a8430574fa193671",
                        blob: "Blob02c7d8dc33db4f4097f4c8cb3d59dd91",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21624 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21624_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21624_s.txt", Encoding.UTF8);

    public Test21624() : base(recordedRequest, recordedResponse, "accounts8d43a03fa567d1c")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Committed>wTmjulaSHeUV/Y+iOQU1/" +
    "k1zgVj8/cAnLECDDy+TXPu2T2ckvn8YW0tL85iLRmIcqVIFqbd27sN5e40VDg22gg==</Committed><" +
    "/BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fa567d1c",
                        container: "containers8ba9612a71f24672a8430574fa193671",
                        blob: "Blob02c7d8dc33db4f4097f4c8cb3d59dd91",
                        blocks: body,
                        timeout: 30,
                        xMsBlobContentType: "application/octet-stream",
                        ifNoneMatch: "\"0x8D43A03FA639C99",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21625 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21625_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21625_s.txt", Encoding.UTF8);

    public Test21625() : base(recordedRequest, recordedResponse, "accounts8d43a03fa567d1c")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><BlockList><Committed>wTmjulaSHeUV/Y+iOQU1/" +
    "k1zgVj8/cAnLECDDy+TXPu2T2ckvn8YW0tL85iLRmIcqVIFqbd27sN5e40VDg22gg==</Committed><" +
    "/BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a03fa567d1c",
                        container: "containers8ba9612a71f24672a8430574fa193671",
                        blob: "Blob02c7d8dc33db4f4097f4c8cb3d59dd91",
                        blocks: body,
                        timeout: 30,
                        xMsBlobContentType: "application/octet-stream",
                        ifNoneMatch: "0x8D43A03FA639C99\"",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21730 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21730_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21730_s.txt", Encoding.UTF8);

    public Test21730() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Uncommitted>dOr/qIfGadas4ReyKbzWYshefz9nWHw2/CsDf2UQhH8Dy4s9YbVxCDBI6xO5HNshdYHvlN1FExxtyaxbw+lwnA==</Uncommitted><Uncommitted>NhXVlN+Go+kf4I/U0jfrZwP6pee+i2Cu2cjMKdmXh3itKohPDp5vm3hgUmyzLjBsEvh8wtYWy6q1J7oWuXkQiA==</Uncommitted><Uncommitted>KM9l5VcwkFYDbJQsrr5Mj8l7xAmL5qD5E7J7nyKl71sQ0nSnRT/8Ey1BcjzdRmRs1cpPdgDWd0EvbNGktfA0XQ==</Uncommitted><Uncommitted>pHgDkb1nBC89yp/l9TgON77AzWFtZ/zz+YCAu1D815bjOBPm+TcXpcfFWDrte02xc7EdQO0qIDx7EJg950jeQQ==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerseea03b67738a44d3bbc03a76323186dd",
                        blob: "Blob1150f68c5a20468b84bd0678de7a7cc4",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21737 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21737_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21737_s.txt", Encoding.UTF8);

    public Test21737() : base(recordedRequest, recordedResponse, "testaccount1")
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
            System.Collections.Generic.IList<string> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => (string)e), "Latest"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><BlockList><Committed>dOr/qIfGadas4ReyKbzWYshefz9nWHw2/CsDf2UQhH8Dy4s9YbVxCDBI6xO5HNshdYHvlN1FExxtyaxbw+lwnA==</Committed><Committed>NhXVlN+Go+kf4I/U0jfrZwP6pee+i2Cu2cjMKdmXh3itKohPDp5vm3hgUmyzLjBsEvh8wtYWy6q1J7oWuXkQiA==</Committed><Committed>KM9l5VcwkFYDbJQsrr5Mj8l7xAmL5qD5E7J7nyKl71sQ0nSnRT/8Ey1BcjzdRmRs1cpPdgDWd0EvbNGktfA0XQ==</Committed><Committed>pHgDkb1nBC89yp/l9TgON77AzWFtZ/zz+YCAu1D815bjOBPm+TcXpcfFWDrte02xc7EdQO0qIDx7EJg950jeQQ==</Committed><Uncommitted>1VKNkeFeye+x32ymWag87WhMFld3JjDx65r/Od3+EQ1MkN24jwzo7kugaXadxJNtV8qEP5hGRa4hnKZGX48Ssg==</Uncommitted><Uncommitted>JgeR4hJ50nQFSy6X82aij7yNtqg+a8qi1G0p3HA6bfFnSIA+za3/OPvqU3yc7Gr1wJhQSQcRFbo97w2lUPYEyw==</Uncommitted><Uncommitted>6AIzG9fqJOlWM8UB3p9a5wXliJ5fvL8QXdZBu4ljwaLv6iWiHdss4blT2HcgYeNvNJWnbY+upStDI70BqGhg8g==</Uncommitted></BlockList>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.PutBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerseea03b67738a44d3bbc03a76323186dd",
                        blob: "Blob1150f68c5a20468b84bd0678de7a7cc4",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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

public class Test21742 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21742_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21742_s.txt", Encoding.UTF8);

    public Test21742() : base(recordedRequest, recordedResponse, "testaccount1")
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
                        container: "containers1e74122d684744bfa48a6f0080a32bb0",
                        blob: "Blob5e2000c39a8a465e86ff5a7378cfc267",
                        blocks: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
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
