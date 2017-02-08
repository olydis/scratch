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

public class Test00276 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00276_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = "HTTP/1.1 403 This request is not authorized to perform this operation using this " +
    "service.\r\nTransfer-Encoding: chunked\r\nServer: Microsoft-HTTPAPI/2.0\r\nx-ms-reques" +
    "t-id: 11aaa5ca-0001-0000-69e6-6b3467000000\r\nDate: Wed, 11 Jan 2017 08:43:32 GMT\r" +
    "\n\r\n0\r\n\r\n";

    public Test00276() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9e6da7eb83314668bc2a3c94054a77e8",
                        blob: "Blobe1c71e6ad25b43adaa474f0d3cfaf3ba",
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

public class Test00275 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00275_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = "HTTP/1.1 403 This request is not authorized to perform this operation using this " +
    "service.\r\nTransfer-Encoding: chunked\r\nServer: Microsoft-HTTPAPI/2.0\r\nx-ms-reques" +
    "t-id: 11aaa5c9-0001-0000-68e6-6b3467000000\r\nDate: Wed, 11 Jan 2017 08:43:32 GMT\r" +
    "\n\r\n0\r\n\r\n";

    public Test00275() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9e6da7eb83314668bc2a3c94054a77e8",
                        blob: "Blobe1c71e6ad25b43adaa474f0d3cfaf3ba",
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

public class Test00280 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00280_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 403 This request is not authorized to perform this operation using this permission.
Transfer-Encoding: chunked
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa5cf-0001-0000-6ee6-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:43:32 GMT

0

";

    public Test00280() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9e6da7eb83314668bc2a3c94054a77e8",
                        blob: "Blobe1c71e6ad25b43adaa474f0d3cfaf3ba",
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

public class Test00277 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00277_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = "HTTP/1.1 403 This request is not authorized to perform this operation using this " +
    "service.\r\nTransfer-Encoding: chunked\r\nServer: Microsoft-HTTPAPI/2.0\r\nx-ms-reques" +
    "t-id: 11aaa5cb-0001-0000-6ae6-6b3467000000\r\nDate: Wed, 11 Jan 2017 08:43:32 GMT\r" +
    "\n\r\n0\r\n\r\n";

    public Test00277() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9e6da7eb83314668bc2a3c94054a77e8",
                        blob: "Blobe1c71e6ad25b43adaa474f0d3cfaf3ba",
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

public class Test00281 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00281_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 403 This request is not authorized to perform this operation using this resource type.
Transfer-Encoding: chunked
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa5d0-0001-0000-6fe6-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:43:32 GMT

0

";

    public Test00281() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9e6da7eb83314668bc2a3c94054a77e8",
                        blob: "Blobe1c71e6ad25b43adaa474f0d3cfaf3ba",
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

public class Test00278 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00278_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 403 This request is not authorized to perform this operation using this permission.
Transfer-Encoding: chunked
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa5cc-0001-0000-6be6-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:43:32 GMT

0

";

    public Test00278() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9e6da7eb83314668bc2a3c94054a77e8",
                        blob: "Blobe1c71e6ad25b43adaa474f0d3cfaf3ba",
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

public class Test00282 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00282_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 403 This request is not authorized to perform this operation using this resource type.
Transfer-Encoding: chunked
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa5d1-0001-0000-70e6-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:43:32 GMT

0

";

    public Test00282() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9e6da7eb83314668bc2a3c94054a77e8",
                        blob: "Blobe1c71e6ad25b43adaa474f0d3cfaf3ba",
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

public class Test00279 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00279_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 403 This request is not authorized to perform this operation using this permission.
Transfer-Encoding: chunked
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa5cd-0001-0000-6ce6-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:43:32 GMT

0

";

    public Test00279() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9e6da7eb83314668bc2a3c94054a77e8",
                        blob: "Blobe1c71e6ad25b43adaa474f0d3cfaf3ba",
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

public class Test01194 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01194_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 412 The lease ID specified did not match the lease ID for the blob.
Transfer-Encoding: chunked
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaad6c-0001-0000-80e7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:47:11 GMT

0

";

    public Test01194() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers31d5372ea1f44d42aa9dbb50052a40e7",
                        blob: "AppendBlob704fb0dc4d7443b9b4546270a50321df",
                        timeout: 30,
                        leaseId: "469593cc-2bc4-40d7-b3de-ec6d3d3e3927",
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

public class Test04083 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04083_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 412 There is currently no lease on the blob.
Transfer-Encoding: chunked
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aabf4f-0001-0000-6ee7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:48:40 GMT

0

";

    public Test04083() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9dc5de3bcf46479783add32dd129d9ad",
                        blob: "PageBlob0c4ee64a567748dd9de05f6c1f0989ca",
                        timeout: 30,
                        leaseId: "99999999-9999-9999-9999-999999999999",
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

public class Test04228 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04228_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 400 The request includes an unsatisfiable condition for this operation.
Transfer-Encoding: chunked
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aabffa-0001-0000-05e7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:48:41 GMT

0

";

    public Test04228() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9da40a2023e34c4590a04f3c26f1c77d",
                        blob: "Blobb76f81d3b43b401aab3778bfbc70bdd5",
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

public class Test04103 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04103_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 412 The lease ID specified did not match the lease ID for the blob.
Transfer-Encoding: chunked
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aabf67-0001-0000-02e7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:48:40 GMT

0

";

    public Test04103() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers197edd27f3d74b9c8cffaa145daf3fdd",
                        blob: "PageBlob99114ea46156494883c1a6073745f9fb",
                        timeout: 30,
                        leaseId: "c9e40325-5137-4b81-8c2f-24bc205abbce",
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

public class Test04231 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04231_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 400 The request includes an unsatisfiable condition for this operation.
Transfer-Encoding: chunked
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aabffd-0001-0000-08e7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:48:41 GMT

0

";

    public Test04231() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9da40a2023e34c4590a04f3c26f1c77d",
                        blob: "Blobb76f81d3b43b401aab3778bfbc70bdd5",
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

public class Test04126 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04126_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 412 A lease ID was specified, but the lease for the blob has expired.
Transfer-Encoding: chunked
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aabf85-0001-0000-1ce7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:48:40 GMT

0

";

    public Test04126() : base(recordedRequest, recordedResponse, "testaccount1")
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
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers7e04560dcff1462ca684a2f395530c20",
                        blob: "PageBlob79daa01177c54b19ab625f7d50ca1fd4",
                        timeout: 30,
                        leaseId: "def4fade-0725-4b53-b01f-9277d15a13de",
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
