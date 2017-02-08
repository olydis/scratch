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

public class Test00176 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00176_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:43:31 GMT
ETag: ""0x8D439FDEC435E67""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa554-0001-0000-02e6-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:43:31 GMT

0

";

    public Test00176() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerscec1cd7b80d2420fa4a10bdf1c117f8f",
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

public class Test00175 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00175_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:43:31 GMT
ETag: ""0x8D439FDEC435E67""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa553-0001-0000-01e6-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:43:31 GMT

0

";

    public Test00175() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerscec1cd7b80d2420fa4a10bdf1c117f8f",
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

public class Test00174 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00174_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:43:31 GMT
ETag: ""0x8D439FDEC435E67""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa552-0001-0000-80e6-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:43:31 GMT

0

";

    public Test00174() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerscec1cd7b80d2420fa4a10bdf1c117f8f",
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

public class Test04611 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04611_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05FA3622""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3b3-0001-0000-28e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a)b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04611() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04595 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04595_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05EACCAF""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3a3-0001-0000-18e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a!b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04595() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04342 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04342_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:50:13 GMT
ETag: ""0x8D439FEDB80A6AC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac18c-0001-0000-60e7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:50:12 GMT

0

";

    public Test04342() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers5d47e488c1d142f9a5e7e8352da910eb",
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

public class Test04627 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04627_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF0607CAD9""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3c3-0001-0000-38e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a1b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04627() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04763 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04763_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF068F7247""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac44d-0001-0000-41e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aub
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04763() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04675 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04675_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06345950""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3f3-0001-0000-68e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aIb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04675() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04643 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04643_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF0615FBAC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3d3-0001-0000-48e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a9b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04643() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04659 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04659_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06253E06""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3e3-0001-0000-58e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aAb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04659() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04715 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04715_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF065C53FF""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac41c-0001-0000-11e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a]b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04715() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04731 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04731_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF066D6B1F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac42c-0001-0000-21e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aeb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04731() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04699 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04699_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF064BB20A""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac40c-0001-0000-01e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aUb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04699() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04779 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04779_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF06A25E29""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac45d-0001-0000-51e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a}b
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04779() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04691 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04691_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0643C2C4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac403-0001-0000-78e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aQb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04691() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04747 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04747_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF067DE5F6""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac43c-0001-0000-31e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: amb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04747() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05115 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05115_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BCEE5AE""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac605-0001-0000-6de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: awb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05115() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04875 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04875_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AF35129""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac50c-0001-0000-75e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a'b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04875() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04923 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04923_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B1E3213""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac53f-0001-0000-28e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a7b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04923() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04971 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04971_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B4EB849""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac570-0001-0000-59e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aGb
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04971() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04860 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04860_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AE631BE""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac4fc-0001-0000-65e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a""b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04860() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05067 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05067_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1BA3B6B6""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5d3-0001-0000-3be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: agb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05067() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04677 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04677_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06362E16""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3f5-0001-0000-6ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aJb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04677() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04908 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04908_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1B109D5D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac52f-0001-0000-18e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a2b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04908() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05019 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05019_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B79991D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5a1-0001-0000-0ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aWb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05019() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04645 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04645_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF0617A95D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3d5-0001-0000-4ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a:b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04645() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04597 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04597_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05ECC87C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3a5-0001-0000-1ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a""b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04597() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04956 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04956_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B3CB706""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac560-0001-0000-49e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aBb
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04956() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04613 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04613_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05FC0AE4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3b5-0001-0000-2ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a*b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04613() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05085 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05085_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BB3BC58""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5e7-0001-0000-4fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: amb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05085() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05004 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05004_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B6CEED9""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac592-0001-0000-7be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aRb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05004() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04765 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04765_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0694C97B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac44f-0001-0000-43e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: avb
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04765() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04055 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04055_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:40 GMT
ETag: ""0x8D439FEA404765A""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aabf2c-0001-0000-51e7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:48:39 GMT

0

";

    public Test04055() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers36689e70fe33448e93ec28ff855c90bf",
                        timeout: 30,
                        leaseId: "be5475b3-a520-4327-96f6-5386f4c3cef7",
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

public class Test04733 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04733_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF066F8E06""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac42e-0001-0000-23e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: afb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04733() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04629 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04629_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06099F84""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3c5-0001-0000-3ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a2b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04629() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05052 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05052_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B96BE49""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5c3-0001-0000-2be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: abb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05052() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04701 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04701_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF064DFC01""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac40e-0001-0000-03e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aVb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04701() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04893 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04893_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1B03A4F5""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac51f-0001-0000-08e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a-b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04893() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05100 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05100_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BC102D8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5f6-0001-0000-5ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: arb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05100() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05133 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05133_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BDF6081""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac617-0001-0000-7fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a}b
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05133() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04989 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04989_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B5F3329""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac583-0001-0000-6ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aMb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test04989() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04781 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04781_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF06A45A11""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac45f-0001-0000-53e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a~b
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04781() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04661 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04661_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF062739D8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3e5-0001-0000-5ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aBb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04661() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04749 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04749_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF068056FD""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac43e-0001-0000-33e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: anb
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04749() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04717 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04717_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF065E76DC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac41e-0001-0000-13e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a^b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04717() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04693 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04693_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0645BE91""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac405-0001-0000-7ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aRb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04693() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04941 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04941_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B2E5EC1""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac551-0001-0000-3ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a=b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04941() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05037 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05037_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B89ECEC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5b4-0001-0000-1ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a]b
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05037() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04615 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04615_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05FDB89A""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3b7-0001-0000-2ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a+b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04615() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04926 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04926_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B20CA2A""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac542-0001-0000-2be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a8b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04926() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04679 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04679_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF063829E8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3f7-0001-0000-6ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aKb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04679() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04647 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04647_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF0619A52F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3d7-0001-0000-4ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a;b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04647() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04599 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04599_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05EEC452""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3a7-0001-0000-1ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a#b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04599() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04767 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04767_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0696C563""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac451-0001-0000-45e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: awb
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04767() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04974 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04974_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B517767""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac573-0001-0000-5ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aHb
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04974() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05055 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05055_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B995660""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5c7-0001-0000-2fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: acb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05055() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05088 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05088_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BB67B88""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5ea-0001-0000-52e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: anb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05088() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04878 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04878_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AF6104C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac50f-0001-0000-78e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a(b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04878() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05118 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05118_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BD1A4D5""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac608-0001-0000-70e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: axb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05118() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04569 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04569_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:03 GMT
ETag: ""0x8D439FEF93B0779""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac36c-0001-0000-68e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a	b
Date: Wed, 11 Jan 2017 08:51:03 GMT

0

";

    public Test04569() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04703 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04703_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF064FF7D3""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac410-0001-0000-05e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aWb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04703() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04911 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04911_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1B135C84""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac532-0001-0000-1be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a3b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04911() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04601 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04601_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05F0C024""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3a9-0001-0000-1ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a$b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04601() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04751 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04751_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0682A0F8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac440-0001-0000-35e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aob
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04751() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05103 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05103_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BC39AF3""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5f9-0001-0000-61e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: asb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05103() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04663 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04663_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06290E9E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3e7-0001-0000-5ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aCb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04663() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05007 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05007_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B6FADFB""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac595-0001-0000-7ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aSb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05007() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05774 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05774_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:10 GMT
ETag: ""0x8D439FF216E7371""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac996-0001-0000-2be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-color: blue
Date: Wed, 11 Jan 2017 08:52:10 GMT

0

";

    public Test05774() : base(recordedRequest, recordedResponse, "accounts8d439ff2165249e")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2165249e",
                        container: "containers3022d866d3f04b6d852e8b5e70ea8607",
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

public class Test04719 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04719_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF066072B2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac420-0001-0000-15e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a_b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04719() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04769 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04769_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0698C135""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac453-0001-0000-47e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: axb
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04769() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04735 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04735_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF067189D7""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac430-0001-0000-25e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: agb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04735() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04959 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04959_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B4123CD""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac563-0001-0000-4ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aCb
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04959() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04631 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04631_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF060B2633""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3c7-0001-0000-3ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a3b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04631() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04681 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04681_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF063A25BE""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3f9-0001-0000-6ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aLb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04681() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04863 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04863_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AE8F0D8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac500-0001-0000-69e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a#b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04863() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05022 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05022_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B7C583F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5a4-0001-0000-0de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aXb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05022() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04695 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04695_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF06479353""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac407-0001-0000-7ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aSb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04695() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05136 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05136_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BE1F8A0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac61a-0001-0000-02e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a~b
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05136() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05058 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05058_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B9C1579""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5ca-0001-0000-32e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: adb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05058() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04992 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04992_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B61F24B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac586-0001-0000-6fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aNb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test04992() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05070 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05070_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1BA64EC8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5d6-0001-0000-3ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: ahb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05070() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04896 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04896_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1B063D0B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac522-0001-0000-0be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a.b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04896() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04721 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04721_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0662BCA4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac422-0001-0000-17e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a`b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04721() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04603 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04603_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05F26DF5""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3ab-0001-0000-20e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a%b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04603() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04617 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04617_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05FF3F3B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3b9-0001-0000-2ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a,b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04617() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04633 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04633_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF060CFAF4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3c9-0001-0000-3ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a4b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04633() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05040 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05040_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B8C84FA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5b7-0001-0000-1fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a^b
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05040() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04665 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04665_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF062B0A70""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3e9-0001-0000-5ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aDb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04665() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04649 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04649_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF061B79FE""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3d9-0001-0000-4ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a<b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04649() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04929 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04929_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B23622F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac545-0001-0000-2ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a9b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04929() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04944 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04944_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B316C11""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac554-0001-0000-3de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a>b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04944() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04737 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04737_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0673ACB5""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac432-0001-0000-27e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: ahb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04737() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04635 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04635_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF060EA8A1""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3cb-0001-0000-40e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a5b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04635() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05010 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05010_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B721F02""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac598-0001-0000-01e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aTb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05010() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05121 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05121_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BD48B03""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac60b-0001-0000-73e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: ayb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05121() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04683 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04683_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF063BD36B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3fb-0001-0000-70e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aMb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04683() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05091 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05091_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BB93AAA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5ed-0001-0000-55e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aob
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05091() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04637 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04637_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06107D6C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3cd-0001-0000-42e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a6b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04637() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04914 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04914_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1B15CD86""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac535-0001-0000-1ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a4b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04914() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04899 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04899_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1B08AE1F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac525-0001-0000-0ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a/b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04899() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04605 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04605_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05F469EA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3ad-0001-0000-22e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a&b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04605() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04542 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04542_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:50:53 GMT
ETag: ""0x8D439FEF3938A66""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac33d-0001-0000-40e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:50:52 GMT

0

";

    public Test04542() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersd0a26acfc4bd425f8e5c3549243245a3",
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

public class Test04723 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04723_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0665069B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac424-0001-0000-19e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aab
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04723() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04977 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04977_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B545DA2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac576-0001-0000-5fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aIb
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04977() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04771 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04771_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF069A95FB""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac455-0001-0000-49e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: ayb
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04771() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04753 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04753_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF06849CAE""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac442-0001-0000-37e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: apb
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04753() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04705 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04705_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF065241D2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac412-0001-0000-07e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aXb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04705() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04881 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04881_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AF944B0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac512-0001-0000-7be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a)b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04881() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05061 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05061_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B9E5F70""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5cd-0001-0000-35e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aeb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05061() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04619 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04619_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF0600ECED""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3bb-0001-0000-30e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a-b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04619() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04995 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04995_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B64B16E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac589-0001-0000-72e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aOb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test04995() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05025 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05025_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B7F1766""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5a7-0001-0000-10e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aYb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05025() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05106 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05106_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BC65A15""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5fc-0001-0000-64e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: atb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05106() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04697 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04697_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0649B63D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac40a-0001-0000-7fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aTb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04697() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04651 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04651_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF061D75D0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3db-0001-0000-50e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a=b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04651() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04667 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04667_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF062CB825""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3eb-0001-0000-60e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aEb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04667() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04685 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04685_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF063DCF4F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3fd-0001-0000-72e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aNb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04685() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04962 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04962_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B44CD0D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac567-0001-0000-50e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aDb
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04962() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04725 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04725_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0667297D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac426-0001-0000-1be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: abb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04725() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04866 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04866_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AEBAFFA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac503-0001-0000-6ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a$b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04866() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04739 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04739_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0675A88B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac434-0001-0000-29e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aib
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04739() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04707 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04707_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF06543D9F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac414-0001-0000-09e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aYb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04707() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04932 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04932_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B25FA45""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac548-0001-0000-31e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a:b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04932() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04639 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04639_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06125224""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3cf-0001-0000-44e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a7b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04639() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04607 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04607_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05F66582""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3af-0001-0000-24e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a'b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04607() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05124 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05124_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BD74A25""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac60e-0001-0000-76e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: azb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05124() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04755 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04755_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0686BF9E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac444-0001-0000-39e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aqb
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04755() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04049 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04049_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:40 GMT
ETag: ""0x8D439FEA3F9C7FA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aabf26-0001-0000-4be7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:48:39 GMT

0

";

    public Test04049() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers36689e70fe33448e93ec28ff855c90bf",
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

public class Test04773 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04773_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF069C91BB""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac457-0001-0000-4be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: azb
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04773() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04947 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04947_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B345243""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac557-0001-0000-40e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a?b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04947() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05043 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05043_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B8F4425""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5ba-0001-0000-22e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a_b
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05043() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05073 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05073_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1BA8BFCF""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5da-0001-0000-42e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aib
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05073() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04902 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04902_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1B0B6D3D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac528-0001-0000-11e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a0b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04902() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04621 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04621_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06029A95""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3bd-0001-0000-32e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a.b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04621() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04917 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04917_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B18B3F7""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac539-0001-0000-22e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a5b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04917() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04546 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04546_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:50:53 GMT
ETag: ""0x8D439FEF39ADD71""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac342-0001-0000-44e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: val	ue1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:50:52 GMT

0

";

    public Test04546() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersf63467344e564301aefbcfb9aecaea62",
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

public class Test04854 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04854_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AE0B371""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac4f6-0001-0000-5fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04854() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04653 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04653_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF061F4A9F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3dd-0001-0000-52e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a>b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04653() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04980 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04980_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B571CC0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac579-0001-0000-62e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aJb
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04980() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04884 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04884_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AFC03D3""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac515-0001-0000-7ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a*b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04884() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05013 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05013_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B74900D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac59b-0001-0000-04e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aUb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05013() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04687 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04687_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF063FCB20""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3ff-0001-0000-74e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aOb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04687() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04741 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04741_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0677CB68""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac436-0001-0000-2be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: ajb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04741() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05028 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05028_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B8224BF""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5aa-0001-0000-13e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aZb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05028() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04623 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04623_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF0603FA2B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3bf-0001-0000-34e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a/b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04623() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04727 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04727_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0669255C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac428-0001-0000-1de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: acb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04727() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04709 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04709_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0656608E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac416-0001-0000-0be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aZb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04709() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05094 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05094_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BBBD2B3""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5f0-0001-0000-58e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: apb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05094() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04669 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04669_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF062E8CF4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3ed-0001-0000-62e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aFb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04669() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04757 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04757_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF068909A1""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac446-0001-0000-3be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: arb
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04757() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04806 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04806_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:38 GMT
ETag: ""0x8D439FF0E02B1F2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac490-0001-0000-7ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a	b
Date: Wed, 11 Jan 2017 08:51:38 GMT

0

";

    public Test04806() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04641 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04641_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06144DFA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3d1-0001-0000-46e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a8b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04641() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04609 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04609_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05F86154""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3b1-0001-0000-26e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a(b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04609() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05064 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05064_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1BA11EC7""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5d0-0001-0000-38e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: afb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05064() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04998 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04998_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B674984""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac58c-0001-0000-75e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aPb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test04998() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05127 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05127_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BDA305C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac611-0001-0000-79e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a{b
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05127() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05109 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05109_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BC94074""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5ff-0001-0000-67e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aub
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05109() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04935 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04935_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B290788""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac54b-0001-0000-34e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a;b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04935() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04775 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04775_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF069E6681""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac459-0001-0000-4de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a{b
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04775() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04689 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04689_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0641EE10""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac401-0001-0000-76e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aPb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04689() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04869 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04869_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AEE4811""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac506-0001-0000-6fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a%b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04869() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04743 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04743_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF0679C73E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac438-0001-0000-2de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: akb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04743() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05076 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05076_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1BAB57D3""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5dd-0001-0000-45e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: ajb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05076() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04905 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04905_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1B0DDE44""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac52c-0001-0000-15e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a1b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04905() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04965 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04965_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B484FA4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac56a-0001-0000-53e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aEb
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04965() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04625 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04625_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06061D0D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3c1-0001-0000-36e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a0b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04625() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04950 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04950_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B37116A""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac55a-0001-0000-43e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a@b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04950() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04857 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04857_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AE399A8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac4f9-0001-0000-62e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a!b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04857() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04759 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04759_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF068B2C7F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac448-0001-0000-3de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: asb
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04759() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05016 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05016_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B770113""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac59e-0001-0000-07e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aVb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05016() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04729 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04729_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF066B212D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac42a-0001-0000-1fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: adb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04729() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04920 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04920_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B1B4BDC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac53c-0001-0000-25e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a6b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04920() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04655 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04655_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06214663""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3df-0001-0000-54e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a?b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04655() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04593 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04593_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF05E85BA9""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3a1-0001-0000-16e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04593() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04671 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04671_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF063088C6""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3ef-0001-0000-64e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aGb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04671() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04887 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04887_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AFE9BEE""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac519-0001-0000-02e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a+b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04887() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04983 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04983_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B59DBE2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac57c-0001-0000-65e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aKb
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04983() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04711 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04711_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF06585C5C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac418-0001-0000-0de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a[b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04711() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05031 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05031_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B84E3D8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5ad-0001-0000-16e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a[b
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05031() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05046 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05046_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B918E17""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5bd-0001-0000-25e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a`b
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05046() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04777 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04777_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF06A06253""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac45b-0001-0000-4fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a|b
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04777() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04938 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04938_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B2BC6AF""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac54e-0001-0000-37e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a<b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04938() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04745 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04745_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF067BEA24""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac43a-0001-0000-2fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: alb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04745() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05001 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05001_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B6A08A2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac58f-0001-0000-78e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aQb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05001() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05097 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05097_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BBE6AC5""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5f3-0001-0000-5be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aqb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05097() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04968 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04968_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B4C202E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac56d-0001-0000-56e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aFb
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04968() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05130 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05130_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BDCA163""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac614-0001-0000-7ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a|b
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05130() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04657 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04657_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF06231B20""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3e1-0001-0000-56e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a@b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04657() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05112 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05112_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BCC2690""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac602-0001-0000-6ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: avb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05112() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04673 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04673_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:24 GMT
ETag: ""0x8D439FF0632849C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac3f1-0001-0000-66e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aHb
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04673() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04761 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04761_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF068D7675""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac44a-0001-0000-3fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: atb
Date: Wed, 11 Jan 2017 08:51:25 GMT

0

";

    public Test04761() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test04953 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04953_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B39A981""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac55d-0001-0000-46e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aAb
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04953() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04872 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04872_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1AF0B913""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac509-0001-0000-72e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a&b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04872() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04986 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04986_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B5C4CF2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac580-0001-0000-69e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aLb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test04986() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04713 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04713_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:25 GMT
ETag: ""0x8D439FF065A582D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac41a-0001-0000-0fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a\b
Date: Wed, 11 Jan 2017 08:51:24 GMT

0

";

    public Test04713() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb62ddbf164f54d1990375553aeaa2be7",
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

public class Test05034 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05034_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B872DD3""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5b0-0001-0000-19e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a\b
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05034() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05049 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05049_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1B942637""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5c0-0001-0000-28e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aab
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05049() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05079 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05079_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:00 GMT
ETag: ""0x8D439FF1BADEFE6""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5e0-0001-0000-48e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: akb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05079() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test04890 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04890_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:51:59 GMT
ETag: ""0x8D439FF1B0133E1""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac51c-0001-0000-05e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a,b
Date: Wed, 11 Jan 2017 08:51:59 GMT

0

";

    public Test04890() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test05082 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05082_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:52:01 GMT
ETag: ""0x8D439FF1BB0FD36""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aac5e4-0001-0000-4ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: alb
Date: Wed, 11 Jan 2017 08:52:00 GMT

0

";

    public Test05082() : base(recordedRequest, recordedResponse, "testaccount1")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4332d3a73bcd4d3db2dc8fc3572e64c1",
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

public class Test19714 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19714_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:50 GMT
ETag: ""0x8D43A024C0FBE43""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab157b-0001-0000-40eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:50 GMT

0

";

    public Test19714() : base(recordedRequest, recordedResponse, "accounts8d43a024c06bd90")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "accounts8d43a024c06bd90",
                        container: "abc",
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

public class Test19597 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19597_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:49 GMT
ETag: ""0x8D43A024BA4C6B6""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab14fe-0001-0000-46eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:49 GMT

0

";

    public Test19597() : base(recordedRequest, recordedResponse, "accounts8d43a024b9a186c")
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
                var result = serviceClient.Container.GetMetadataWithHttpMessagesAsync(
                        accountName: "accounts8d43a024b9a186c",
                        container: "foo",
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
