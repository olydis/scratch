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

public class Test00272 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00272_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:43:32 GMT
ETag: ""0x8D439FDECD60271""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa5c6-0001-0000-65e6-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:43:32 GMT

0

";

    public Test00272() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00274 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00274_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:43:32 GMT
ETag: ""0x8D439FDECD60271""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa5c8-0001-0000-67e6-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:43:32 GMT

0

";

    public Test00274() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00273 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00273_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:43:32 GMT
ETag: ""0x8D439FDECD60271""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa5c7-0001-0000-66e6-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:43:32 GMT

0

";

    public Test00273() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test01348 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01348_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84556DE0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae76-0001-0000-74e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aKb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01348() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test00526 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00526_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:43:35 GMT
ETag: ""0x8D439FDEE920D8C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa711-0001-0000-73e6-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-m1: foo
Date: Wed, 11 Jan 2017 08:43:35 GMT

0

";

    public Test00526() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerse7deab1677db4652a49b74e84dbeae40",
                        blob: "Blob568b441c8bbd4c5fb8b7ce583d1c1076",
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

public class Test01220 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01220_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:12 GMT
ETag: ""0x8D439FE6FD50609""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaad8f-0001-0000-1be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:11 GMT

0

";

    public Test01220() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers71fca7f0ad284c47aa3dcb0e23024362",
                        blob: "Blob9b07c99f2c6c4655991cd3623233d213",
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

public class Test01388 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01388_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84861B14""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaea0-0001-0000-1ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a_b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01388() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01404 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01404_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8499A33B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaeb0-0001-0000-2ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: agb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01404() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01276 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01276_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE84063BDD""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae2b-0001-0000-29e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a'b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01276() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01284 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01284_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE840E793F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae33-0001-0000-31e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a+b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01284() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01428 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01428_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84B71683""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaec9-0001-0000-47e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: asb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01428() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01300 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01300_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE841FDEA8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae44-0001-0000-42e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a3b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01300() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01340 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01340_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE844C942B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae6e-0001-0000-6ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aGb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01340() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01324 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01324_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE843AB9BF""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae5e-0001-0000-5ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a?b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01324() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01237 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01237_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:25 GMT
ETag: ""0x8D439FE772DDFB8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaadb2-0001-0000-3be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a	b
Date: Wed, 11 Jan 2017 08:47:25 GMT

0

";

    public Test01237() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01316 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01316_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE84327C42""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae56-0001-0000-54e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a;b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01316() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01412 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01412_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84A403BA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaeb8-0001-0000-36e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: akb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01412() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01380 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01380_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE847C7E21""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae98-0001-0000-16e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a[b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01380() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01420 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01420_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84AD044D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaec0-0001-0000-3ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aob
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01420() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01292 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01292_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE84177A04""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae3c-0001-0000-3ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a/b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01292() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01436 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01436_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84C03E9B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaed1-0001-0000-4fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: awb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01436() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01364 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01364_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8469441E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae88-0001-0000-06e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aSb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01364() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01308 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01308_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE842A65E2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae4e-0001-0000-4ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a7b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01308() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01342 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01342_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE844EDE14""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae70-0001-0000-6ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aHb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01342() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01747 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01747_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:54 GMT
ETag: ""0x8D439FE88934664""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab07a-0001-0000-2fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:53 GMT

0

";

    public Test01747() : base(recordedRequest, recordedResponse, "accounts8d439fe887e5e88")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe887e5e88",
                        container: "containers58eef8e49d394ea58d2d72595974bce1",
                        blob: "Blobcdaf1a50a41646bea70d44af3e8fc81f",
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

public class Test01645 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01645_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:50 GMT
ETag: ""0x8D439FE8692DECB""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaafd1-0001-0000-30e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:50 GMT

0

";

    public Test01645() : base(recordedRequest, recordedResponse, "accounts8d439fe8686a9b4")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe8686a9b4",
                        container: "containers6c25e9fb7c2d47df88a887b12f07f1ec",
                        blob: "Blob855a926d61804079841f784a30a6d942",
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

public class Test01763 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01763_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:55 GMT
ETag: ""0x8D439FE890F54ED""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab094-0001-0000-43e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:54 GMT

0

";

    public Test01763() : base(recordedRequest, recordedResponse, "accounts8d439fe88d9506a")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe88d9506a",
                        container: "containers550ea20f7deb4988b9dbb88683bebac2",
                        blob: "Blobf34588b5e68e4ecea9b33977c9ef6a67",
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

public class Test01699 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01699_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:53 GMT
ETag: ""0x8D439FE88145157""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab032-0001-0000-79e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:52 GMT

0

";

    public Test01699() : base(recordedRequest, recordedResponse, "accounts8d439fe87c5bb87")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe87c5bb87",
                        container: "containers20484a9081814af2bc7b1d50b85279f2",
                        blob: "Blobcd2a16a23c514196b0535dc32da9e092",
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

public class Test01390 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01390_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84883E0C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaea2-0001-0000-20e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a`b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01390() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01613 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01613_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:50 GMT
ETag: ""0x8D439FE863F3FF0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaafa0-0001-0000-0fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:49 GMT

0

";

    public Test01613() : base(recordedRequest, recordedResponse, "accounts8d439fe8631843b")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe8631843b",
                        container: "containersa8d57abf5cd0468eb491a281c6767f06",
                        blob: "Blob70281f5d3c2540a98669e856e0291992",
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

public class Test01430 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01430_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84B9878E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaecb-0001-0000-49e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: atb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01430() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01326 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01326_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE843CDCA1""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae60-0001-0000-5ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a@b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01326() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01350 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01350_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8457B7CE""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae78-0001-0000-76e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aLb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01350() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01286 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01286_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE84109C2F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae35-0001-0000-33e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a,b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01286() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01302 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01302_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE8422C4BB""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae46-0001-0000-44e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a4b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01302() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01318 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01318_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE84349F28""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae58-0001-0000-56e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a<b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01318() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01294 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01294_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE841975D2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae3e-0001-0000-3ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a0b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01294() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test00874 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00874_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:43:53 GMT
ETag: ""0x8D439FDF91CCBF4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaa93c-0001-0000-16e6-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-foo: bar
x-ms-meta-baz: qux
Date: Wed, 11 Jan 2017 08:43:52 GMT

0

";

    public Test00874() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers50e2781db41a4bbe89ac860721149658",
                        blob: "Blobbee6739f4f3c46f29fed34628062bb19",
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

public class Test01731 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01731_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:53 GMT
ETag: ""0x8D439FE8861D5A0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab060-0001-0000-1be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:53 GMT

0

";

    public Test01731() : base(recordedRequest, recordedResponse, "accounts8d439fe885181c3")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe885181c3",
                        container: "containers63994c1819c24594a44dbdc799a32f63",
                        blob: "Blob4d68e846a59842ed8c2a5ef520aceaa6",
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

public class Test01414 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01414_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84A67498""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaeba-0001-0000-38e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: alb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01414() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01406 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01406_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE849C3B52""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaeb2-0001-0000-30e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: ahb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01406() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01262 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01262_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE83F524B4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae1c-0001-0000-1ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01262() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01422 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01422_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84AF754B""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaec2-0001-0000-40e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: apb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01422() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01627 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01627_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:50 GMT
ETag: ""0x8D439FE866258AC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaafb4-0001-0000-1de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:49 GMT

0

";

    public Test01627() : base(recordedRequest, recordedResponse, "accounts8d439fe86558739")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe86558739",
                        container: "containers457f88b3cd904069bd2de7d05abf1b00",
                        blob: "Blob9635a379f00c41e697be952421811fe6",
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

public class Test01190 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01190_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:11 GMT
ETag: ""0x8D439FE6F6B46FA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaad68-0001-0000-7ce7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:47:11 GMT

0

";

    public Test01190() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test01691 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01691_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:52 GMT
ETag: ""0x8D439FE87C19CEA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab023-0001-0000-6de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:52 GMT

0

";

    public Test01691() : base(recordedRequest, recordedResponse, "accounts8d439fe87750306")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe87750306",
                        container: "containers988bd26effa04c71af34248a2ab379a6",
                        blob: "Bloba287cecd51a243dc8acced9ef0f2d7ad",
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

public class Test01278 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01278_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE840837AE""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae2d-0001-0000-2be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a(b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01278() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01599 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01599_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:50 GMT
ETag: ""0x8D439FE8619DD53""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaf8b-0001-0000-80e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:49 GMT

0

";

    public Test01599() : base(recordedRequest, recordedResponse, "accounts8d439fe860d814f")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe860d814f",
                        container: "containersbeb14fb466da44bcb204a1fc51dd1a48",
                        blob: "Blob47dbc850cc674fcdb9a78f60a25d2577",
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

public class Test01382 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01382_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE847EC80E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae9a-0001-0000-18e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a\b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01382() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01662 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01662_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:51 GMT
ETag: ""0x8D439FE86C14209""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaafec-0001-0000-42e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:47:50 GMT

0

";

    public Test01662() : base(recordedRequest, recordedResponse, "accounts8d439fe86b66c8b")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe86b66c8b",
                        container: "containers94ff712e80dd464aa421e2c0bb501c67",
                        blob: "Blob88a44942fdbf4be093fdeaf8b75381d3",
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

public class Test01366 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01366_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE846B8E61""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae8a-0001-0000-08e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aTb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01366() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01679 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01679_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:51 GMT
ETag: ""0x8D439FE872E3575""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab009-0001-0000-59e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:51 GMT

0

";

    public Test01679() : base(recordedRequest, recordedResponse, "accounts8d439fe86dbf633")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe86dbf633",
                        container: "containersd653d6caebcc41b9af4e6de10e3f3d59",
                        blob: "Blobfcd0d5ed15084bba8d2be20db5b40b7c",
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

public class Test01344 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01344_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8450B2D6""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae72-0001-0000-70e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aIb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01344() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01670 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01670_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:51 GMT
ETag: ""0x8D439FE86D391B8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaff8-0001-0000-4be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:47:50 GMT

0

";

    public Test01670() : base(recordedRequest, recordedResponse, "accounts8d439fe86c90a44")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe86c90a44",
                        container: "containers58f23d0382eb4b3381f997d89cdf4cd7",
                        blob: "Blob0ffcf491b2d14fd4be10a8614f508b49",
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

public class Test01352 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01352_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE845A28D0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae7b-0001-0000-79e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aMb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01352() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01310 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01310_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE842C61B3""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae50-0001-0000-4ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a8b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01310() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01438 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01438_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84C26148""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaed3-0001-0000-51e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: axb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01438() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01392 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01392_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE848AFD1D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaea4-0001-0000-22e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aab
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01392() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01328 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01328_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE843F4DAC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae62-0001-0000-60e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aAb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01328() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01432 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01432_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84BBAA6C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaecd-0001-0000-4be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aub
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01432() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01304 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01304_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE842535BD""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae48-0001-0000-46e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a5b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01304() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01728 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01728_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:53 GMT
ETag: ""0x8D439FE885E7A7C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab05d-0001-0000-18e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:47:53 GMT

0

";

    public Test01728() : base(recordedRequest, recordedResponse, "accounts8d439fe885181c3")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe885181c3",
                        container: "containers63994c1819c24594a44dbdc799a32f63",
                        blob: "Blob4d68e846a59842ed8c2a5ef520aceaa6",
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

public class Test01296 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01296_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE841BBFCC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae40-0001-0000-3ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a1b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01296() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02363 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02363_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:08 GMT
ETag: ""0x8D439FE90DF0D25""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab49f-0001-0000-50e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:08 GMT

0

";

    public Test02363() : base(recordedRequest, recordedResponse, "accounts8d439fe90d214b3")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe90d214b3",
                        container: "containers5d356dee201b46aba562d28ffe26d664",
                        blob: "Blob06f9fcbb3b6a4bfbbd7b7cb76c9b8511",
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

public class Test01416 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01416_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84A8BEDF""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaebc-0001-0000-3ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: amb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01416() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01408 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01408_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE849F4899""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaeb4-0001-0000-32e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aib
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01408() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02380 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02380_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:08 GMT
ETag: ""0x8D439FE910F1E26""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab4bb-0001-0000-63e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:48:08 GMT

0

";

    public Test02380() : base(recordedRequest, recordedResponse, "accounts8d439fe910448ad")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe910448ad",
                        container: "containers6f266ec9247d4281a38513f8909d365e",
                        blob: "Blobad33d94f4dfb446884b6fc487db50cb5",
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

public class Test01712 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01712_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:53 GMT
ETag: ""0x8D439FE8837DF25""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab046-0001-0000-07e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:47:52 GMT

0

";

    public Test01712() : base(recordedRequest, recordedResponse, "accounts8d439fe882b34ea")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe882b34ea",
                        container: "containers6820fdb77b93441590c5d823b5867a18",
                        blob: "Blobd870763f3d92495cb2e57d8da8a63e63",
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

public class Test01424 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01424_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84B2A9D8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaec5-0001-0000-43e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aqb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01424() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01320 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01320_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE843673E9""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae5a-0001-0000-58e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a=b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01320() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01280 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01280_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE840A0C6C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae2f-0001-0000-2de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a)b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01280() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01264 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01264_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE83F7BCD3""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae1e-0001-0000-1ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a!b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01264() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02349 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02349_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:07 GMT
ETag: ""0x8D439FE90BBF488""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab48a-0001-0000-41e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:07 GMT

0

";

    public Test02349() : base(recordedRequest, recordedResponse, "accounts8d439fe90b0349c")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe90b0349c",
                        container: "containers63aa1293ff82402fba67dc78bf6ea678",
                        blob: "Blob752e23670095448ab4f3a202d63e6fb7",
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

public class Test01288 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01288_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE8412E61C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae37-0001-0000-35e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a-b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01288() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01298 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01298_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE841E09C7""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae42-0001-0000-40e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a2b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01298() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01585 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01585_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:49 GMT
ETag: ""0x8D439FE85F760F7""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaf77-0001-0000-72e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:49 GMT

0

";

    public Test01585() : base(recordedRequest, recordedResponse, "accounts8d439fe85e75b59")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe85e75b59",
                        container: "containersdf6b7044bb2347a5a753558251cbd31c",
                        blob: "Blobd55f0ee5db2145659ce88f251674399d",
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

public class Test01384 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01384_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8481120D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae9c-0001-0000-1ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a]b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01384() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01368 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01368_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE846E2627""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae8c-0001-0000-0ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aUb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01368() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01706 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01706_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:53 GMT
ETag: ""0x8D439FE88278B62""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab03d-0001-0000-01e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:52 GMT

0

";

    public Test01706() : base(recordedRequest, recordedResponse, "accounts8d439fe88184942")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe88184942",
                        container: "containersc2c473ca9fec4d77bf4e9a9f1ed55aa4",
                        blob: "Blob878ffe4177bc4896b08e53b700a9bcaa",
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

public class Test01312 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01312_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE842E5D97""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae52-0001-0000-50e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a9b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01312() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01330 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01330_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE84414970""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae64-0001-0000-62e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aBb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01330() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01354 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01354_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE845CE804""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae7d-0001-0000-7be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aNb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01354() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01346 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01346_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8452FCCC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae74-0001-0000-72e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aJb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01346() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01434 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01434_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84BDCD4E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaecf-0001-0000-4de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: avb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01434() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01394 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01394_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE848D9538""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaea6-0001-0000-24e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: abb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01394() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01306 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01306_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE8427A6C4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae4b-0001-0000-49e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a6b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01306() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01665 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01665_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:51 GMT
ETag: ""0x8D439FE86C51293""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaafef-0001-0000-45e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:50 GMT

0

";

    public Test01665() : base(recordedRequest, recordedResponse, "accounts8d439fe86b66c8b")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe86b66c8b",
                        container: "containers94ff712e80dd464aa421e2c0bb501c67",
                        blob: "Blob88a44942fdbf4be093fdeaf8b75381d3",
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

public class Test01440 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01440_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84C4AB35""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaed5-0001-0000-53e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: ayb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01440() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01418 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01418_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84AB08CC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaebe-0001-0000-3ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: anb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01418() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01744 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01744_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:54 GMT
ETag: ""0x8D439FE888F4EAE""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab076-0001-0000-2be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:47:53 GMT

0

";

    public Test01744() : base(recordedRequest, recordedResponse, "accounts8d439fe887e5e88")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe887e5e88",
                        container: "containers58eef8e49d394ea58d2d72595974bce1",
                        blob: "Blobcdaf1a50a41646bea70d44af3e8fc81f",
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

public class Test02357 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02357_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:08 GMT
ETag: ""0x8D439FE90CE6B2C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab495-0001-0000-49e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:07 GMT

0

";

    public Test02357() : base(recordedRequest, recordedResponse, "accounts8d439fe90bfc517")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe90bfc517",
                        container: "containers66a627cb5b734ef49a222db04ccb1c53",
                        blob: "Blob8a4a818784134beea473d4a50411f1ce",
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

public class Test02335 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02335_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:07 GMT
ETag: ""0x8D439FE909A145E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab473-0001-0000-30e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:07 GMT

0

";

    public Test02335() : base(recordedRequest, recordedResponse, "accounts8d439fe908ca6ca")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe908ca6ca",
                        container: "containers4221f21423694d5c945aa361b6dbe537",
                        blob: "Blob28ef2f15a47d41aa85fe38a8a1f6a708",
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

public class Test01410 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01410_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84A1E0B4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaeb6-0001-0000-34e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: ajb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01410() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01760 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01760_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:54 GMT
ETag: ""0x8D439FE890BD27A""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab091-0001-0000-40e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:47:54 GMT

0

";

    public Test01760() : base(recordedRequest, recordedResponse, "accounts8d439fe88d9506a")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe88d9506a",
                        container: "containers550ea20f7deb4988b9dbb88683bebac2",
                        blob: "Blobf34588b5e68e4ecea9b33977c9ef6a67",
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

public class Test01386 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01386_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8483AA20""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae9e-0001-0000-1ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a^b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01386() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01651 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01651_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:50 GMT
ETag: ""0x8D439FE86A2BD9C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaafdb-0001-0000-37e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:50 GMT

0

";

    public Test01651() : base(recordedRequest, recordedResponse, "accounts8d439fe86968891")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe86968891",
                        container: "containersa25dd68146404b15b95c84670963990a",
                        blob: "Blob765a41ed4ba84e51882c88619da08aa1",
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

public class Test02321 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02321_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:07 GMT
ETag: ""0x8D439FE9075EA59""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab45f-0001-0000-22e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:07 GMT

0

";

    public Test02321() : base(recordedRequest, recordedResponse, "accounts8d439fe9068f1e8")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe9068f1e8",
                        container: "containers92a0a0ebf564474499b8599c158bd547",
                        blob: "Blobd8fd05c8e6324ea4ade13cc150af6e22",
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

public class Test01426 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01426_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84B51AB2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaec7-0001-0000-45e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: arb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01426() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01356 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01356_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE845F31F1""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae7f-0001-0000-7de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aOb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01356() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01282 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01282_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE840C5662""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae31-0001-0000-2fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a*b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01282() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01738 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01738_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:54 GMT
ETag: ""0x8D439FE887A8DF0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab06d-0001-0000-25e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:53 GMT

0

";

    public Test01738() : base(recordedRequest, recordedResponse, "accounts8d439fe8865f49b")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe8865f49b",
                        container: "containers05be212177754e0e97097526a99091af",
                        blob: "Blob71f67c58588445eca3cf0d949c728a74",
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

public class Test01322 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01322_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE843896D0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae5c-0001-0000-5ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a>b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01322() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02383 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02383_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:08 GMT
ETag: ""0x8D439FE9112A09D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab4be-0001-0000-66e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:08 GMT

0

";

    public Test02383() : base(recordedRequest, recordedResponse, "accounts8d439fe910448ad")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe910448ad",
                        container: "containers6f266ec9247d4281a38513f8909d365e",
                        blob: "Blobad33d94f4dfb446884b6fc487db50cb5",
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

public class Test01604 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01604_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:50 GMT
ETag: ""0x8D439FE86291FC0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaf93-0001-0000-05e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:47:49 GMT

0

";

    public Test01604() : base(recordedRequest, recordedResponse, "accounts8d439fe861e9859")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe861e9859",
                        container: "containers974ac4dece38479b822c0666884aac61",
                        blob: "Blob361fc4bf5b9a40c2b853fbdbc8c41514",
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

public class Test01618 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01618_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:50 GMT
ETag: ""0x8D439FE864DBEF1""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaafa8-0001-0000-14e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:47:49 GMT

0

";

    public Test01618() : base(recordedRequest, recordedResponse, "accounts8d439fe8642e977")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe8642e977",
                        container: "containers8032a2f2372443ef812d01762cc3941b",
                        blob: "Blobcd9f95fb3324435a8eee7a199a235a5e",
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

public class Test01754 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01754_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:54 GMT
ETag: ""0x8D439FE88D5CDF7""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab087-0001-0000-39e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:53 GMT

0

";

    public Test01754() : base(recordedRequest, recordedResponse, "accounts8d439fe889d0a5a")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe889d0a5a",
                        container: "containers8885818133924aa183e98498cf8587a5",
                        blob: "Blob7c2f77986891471a8d9518f4d5fd3ac0",
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

public class Test01370 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01370_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84709729""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae8e-0001-0000-0ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aVb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01370() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02369 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02369_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:08 GMT
ETag: ""0x8D439FE90EFD625""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab4a8-0001-0000-56e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:08 GMT

0

";

    public Test02369() : base(recordedRequest, recordedResponse, "accounts8d439fe90e2ddb8")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe90e2ddb8",
                        container: "containersfafddcd27d944f619b65090f60dbaa20",
                        blob: "Blob058d7a74d7394dd182150cb93999184e",
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

public class Test01396 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01396_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE848FDF7F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaea8-0001-0000-26e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: acb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01396() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01290 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01290_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE8415571E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae39-0001-0000-37e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a.b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01290() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01314 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01314_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE84305969""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae54-0001-0000-52e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a:b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01314() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01633 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01633_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:50 GMT
ETag: ""0x8D439FE8672D371""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaafbd-0001-0000-23e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:50 GMT

0

";

    public Test01633() : base(recordedRequest, recordedResponse, "accounts8d439fe86662929")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe86662929",
                        container: "containersc3bd3130401d48ed8fea951b0fc36da2",
                        blob: "Blob0d0e1759d1134051bd450f23b00f15c5",
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

public class Test01332 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01332_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE84439366""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae66-0001-0000-64e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aCb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01332() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01696 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01696_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:53 GMT
ETag: ""0x8D439FE880F96AB""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab02f-0001-0000-76e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:47:52 GMT

0

";

    public Test01696() : base(recordedRequest, recordedResponse, "accounts8d439fe87c5bb87")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe87c5bb87",
                        container: "containers20484a9081814af2bc7b1d50b85279f2",
                        blob: "Blobcd2a16a23c514196b0535dc32da9e092",
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

public class Test01442 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01442_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84C6A6EC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaed7-0001-0000-55e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: azb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01442() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02980 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02980_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:20 GMT
ETag: ""0x8D439FE9863B21A""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab8a0-0001-0000-62e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:48:20 GMT

0

";

    public Test02980() : base(recordedRequest, recordedResponse, "accounts8d439fe985978c6")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe985978c6",
                        container: "containersdf065fe908f94f6ebf2df298e4fa1b5d",
                        blob: "Blob19f9d95ef64b44be94ee74fc9bebfd37",
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

public class Test01673 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01673_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:51 GMT
ETag: ""0x8D439FE86D7D784""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaffc-0001-0000-4fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:50 GMT

0

";

    public Test01673() : base(recordedRequest, recordedResponse, "accounts8d439fe86c90a44")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe86c90a44",
                        container: "containers58f23d0382eb4b3381f997d89cdf4cd7",
                        blob: "Blob0ffcf491b2d14fd4be10a8614f508b49",
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

public class Test01715 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01715_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:53 GMT
ETag: ""0x8D439FE883AC565""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab049-0001-0000-0ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:52 GMT

0

";

    public Test01715() : base(recordedRequest, recordedResponse, "accounts8d439fe882b34ea")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe882b34ea",
                        container: "containers6820fdb77b93441590c5d823b5867a18",
                        blob: "Blobd870763f3d92495cb2e57d8da8a63e63",
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

public class Test01266 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01266_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE83FA2DCC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae20-0001-0000-1ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a""b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01266() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test03015 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03015_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:21 GMT
ETag: ""0x8D439FE98C29B9F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab8d6-0001-0000-08e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:21 GMT

0

";

    public Test03015() : base(recordedRequest, recordedResponse, "accounts8d439fe98b57c30")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe98b57c30",
                        container: "containers1516724586e14ba786dd52d5882b1df3",
                        blob: "Blob9803e927f1cb44ae89aaa69c14dfe6e4",
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

public class Test01685 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01685_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:52 GMT
ETag: ""0x8D439FE87710B5E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab015-0001-0000-62e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:51 GMT

0

";

    public Test01685() : base(recordedRequest, recordedResponse, "accounts8d439fe8732543a")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe8732543a",
                        container: "containers458dd7890f5b4b4abe7b5d6065e3488e",
                        blob: "Blob5fe3cc2cb9ad4f3bbd410daee2dee4a9",
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

public class Test02997 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02997_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:20 GMT
ETag: ""0x8D439FE988B107A""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab8b9-0001-0000-74e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:20 GMT

0

";

    public Test02997() : base(recordedRequest, recordedResponse, "accounts8d439fe987cdf88")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe987cdf88",
                        container: "containers67094ca54b64462b8b2b0f39bd04f6b9",
                        blob: "Blob0260bddc2f694d9cb9f4391ef9edb8b0",
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

public class Test02966 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02966_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:20 GMT
ETag: ""0x8D439FE98404B54""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab88c-0001-0000-54e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:48:20 GMT

0

";

    public Test02966() : base(recordedRequest, recordedResponse, "accounts8d439fe9834b27c")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe9834b27c",
                        container: "containersb34ac1d390ef49fb851e89559e1871c8",
                        blob: "Blobd6845af30ba240aebca71dfc6ff22534",
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

public class Test02354 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02354_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:07 GMT
ETag: ""0x8D439FE90CAE8C6""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab492-0001-0000-46e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:48:07 GMT

0

";

    public Test02354() : base(recordedRequest, recordedResponse, "accounts8d439fe90bfc517")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe90bfc517",
                        container: "containers66a627cb5b734ef49a222db04ccb1c53",
                        blob: "Blob8a4a818784134beea473d4a50411f1ce",
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

public class Test01334 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01334_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE8445B690""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae68-0001-0000-66e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aDb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01334() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01268 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01268_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE83FCC5EC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae22-0001-0000-20e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a#b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01268() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01358 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01358_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84617BF5""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae81-0001-0000-7fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aPb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01358() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01398 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01398_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84925039""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaeaa-0001-0000-28e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: adb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01398() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01372 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01372_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8472E117""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae90-0001-0000-0ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aWb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01372() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02340 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02340_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:07 GMT
ETag: ""0x8D439FE90A8E196""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab47b-0001-0000-35e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:48:07 GMT

0

";

    public Test02340() : base(recordedRequest, recordedResponse, "accounts8d439fe909de4f6")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe909de4f6",
                        container: "containersfbc81383157a4ac2b9359832e5c13727",
                        blob: "Blob032f663c38ed4afab4aa391d027624c5",
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

public class Test01590 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01590_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:49 GMT
ETag: ""0x8D439FE8606071E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaf7f-0001-0000-77e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:47:49 GMT

0

";

    public Test01590() : base(recordedRequest, recordedResponse, "accounts8d439fe85fb589f")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe85fb589f",
                        container: "containers95b0ba4bd1184abe88241df4a3d1685d",
                        blob: "Blob80d7198502c64e74a24160a9c58895fc",
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

public class Test01607 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01607_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:50 GMT
ETag: ""0x8D439FE862D3E6A""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaf96-0001-0000-08e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:49 GMT

0

";

    public Test01607() : base(recordedRequest, recordedResponse, "accounts8d439fe861e9859")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe861e9859",
                        container: "containers974ac4dece38479b822c0666884aac61",
                        blob: "Blob361fc4bf5b9a40c2b853fbdbc8c41514",
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

public class Test01444 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01444_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84C8C9FB""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaed9-0001-0000-57e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a{b
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01444() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02983 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02983_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:20 GMT
ETag: ""0x8D439FE9867A9CB""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab8a3-0001-0000-65e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:20 GMT

0

";

    public Test02983() : base(recordedRequest, recordedResponse, "accounts8d439fe985978c6")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe985978c6",
                        container: "containersdf065fe908f94f6ebf2df298e4fa1b5d",
                        blob: "Blob19f9d95ef64b44be94ee74fc9bebfd37",
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

public class Test01336 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01336_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE84480062""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae6a-0001-0000-68e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aEb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01336() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01270 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01270_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE83FF0FD9""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae24-0001-0000-22e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a$b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01270() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01621 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01621_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:50 GMT
ETag: ""0x8D439FE8651DDB1""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaafab-0001-0000-17e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:49 GMT

0

";

    public Test01621() : base(recordedRequest, recordedResponse, "accounts8d439fe8642e977")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe8642e977",
                        container: "containers8032a2f2372443ef812d01762cc3941b",
                        blob: "Blobcd9f95fb3324435a8eee7a199a235a5e",
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

public class Test01639 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01639_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:50 GMT
ETag: ""0x8D439FE8682B241""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaafc6-0001-0000-29e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:50 GMT

0

";

    public Test01639() : base(recordedRequest, recordedResponse, "accounts8d439fe86762eea")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe86762eea",
                        container: "containers8bf324a723fe408da600ca0e9e29afb4",
                        blob: "Blob7ef2f37787c44ec9bc0f3d69c970f709",
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

public class Test02961 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02961_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:20 GMT
ETag: ""0x8D439FE983108F5""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab884-0001-0000-4fe7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:20 GMT

0

";

    public Test02961() : base(recordedRequest, recordedResponse, "accounts8d439fe9823c26c")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe9823c26c",
                        container: "containersc4e7b7ff39214fac8947f096e846f23a",
                        blob: "Blob5adcebe09214490ab805f444f55c61a7",
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

public class Test01338 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01338_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE844A4A35""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae6c-0001-0000-6ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aFb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01338() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01360 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01360_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE846413FA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae84-0001-0000-02e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aQb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01360() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02969 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02969_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:20 GMT
ETag: ""0x8D439FE98446A07""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab88f-0001-0000-57e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:20 GMT

0

";

    public Test02969() : base(recordedRequest, recordedResponse, "accounts8d439fe9834b27c")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe9834b27c",
                        container: "containersb34ac1d390ef49fb851e89559e1871c8",
                        blob: "Blobd6845af30ba240aebca71dfc6ff22534",
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

public class Test01593 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01593_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:49 GMT
ETag: ""0x8D439FE8609D7B1""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaf82-0001-0000-7ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:49 GMT

0

";

    public Test01593() : base(recordedRequest, recordedResponse, "accounts8d439fe85fb589f")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe85fb589f",
                        container: "containers95b0ba4bd1184abe88241df4a3d1685d",
                        blob: "Blob80d7198502c64e74a24160a9c58895fc",
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

public class Test01446 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01446_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84CB13D2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaedb-0001-0000-59e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a|b
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01446() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01400 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01400_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8494E86F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaeac-0001-0000-2ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aeb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01400() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test03020 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03020_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:21 GMT
ETag: ""0x8D439FE98D51251""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab8df-0001-0000-0ee7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:48:21 GMT

0

";

    public Test03020() : base(recordedRequest, recordedResponse, "accounts8d439fe98c66c32")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe98c66c32",
                        container: "containerseec37365109344eea03dabf6d7b9b28d",
                        blob: "Blob52d2a2034c4c495daf72ccaacd1ef6e9",
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

public class Test03003 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03003_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:21 GMT
ETag: ""0x8D439FE989BD983""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab8c3-0001-0000-7be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:20 GMT

0

";

    public Test03003() : base(recordedRequest, recordedResponse, "accounts8d439fe988ee117")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe988ee117",
                        container: "containers2d837681e1d948d49a8d7fa7e89be6b8",
                        blob: "Blob3d46448c83e447c5aab984d216cbd70e",
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

public class Test01374 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01374_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84755219""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae92-0001-0000-10e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aXb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01374() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01657 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01657_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:51 GMT
ETag: ""0x8D439FE86B29BFD""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaafe4-0001-0000-3de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:50 GMT

0

";

    public Test01657() : base(recordedRequest, recordedResponse, "accounts8d439fe86a63fd5")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe86a63fd5",
                        container: "containers1956c82000f844c6889e4b60a8061440",
                        blob: "Blob6a413b09536942c2904c4325ee06950a",
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

public class Test01198 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01198_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:11 GMT
ETag: ""0x8D439FE6F6B46FA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaad70-0001-0000-04e7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:47:11 GMT

0

";

    public Test01198() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        leaseId: "d61aa142-e086-493b-86eb-e895132cfe7d",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test01272 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01272_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE840159D4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae26-0001-0000-24e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a%b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01272() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02343 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02343_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:07 GMT
ETag: ""0x8D439FE90AC8B1D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab47e-0001-0000-38e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:07 GMT

0

";

    public Test02343() : base(recordedRequest, recordedResponse, "accounts8d439fe909de4f6")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe909de4f6",
                        container: "containersfbc81383157a4ac2b9359832e5c13727",
                        blob: "Blob032f663c38ed4afab4aa391d027624c5",
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

public class Test02326 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02326_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:07 GMT
ETag: ""0x8D439FE908505A4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab467-0001-0000-27e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:48:07 GMT

0

";

    public Test02326() : base(recordedRequest, recordedResponse, "accounts8d439fe907a0908")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe907a0908",
                        container: "containersc3761e5e80e04feaad4e27b4bfb72b22",
                        blob: "Blob1e306a310db14730a88ffa59b029ca6e",
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

public class Test02375 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02375_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:08 GMT
ETag: ""0x8D439FE91007810""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab4b2-0001-0000-5de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:08 GMT

0

";

    public Test02375() : base(recordedRequest, recordedResponse, "accounts8d439fe90f37fa8")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe90f37fa8",
                        container: "containers53bda54836bf4de2994ea208aa1b5966",
                        blob: "Blob687ac5163ab14342ad5b988b67300ba4",
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

public class Test01402 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01402_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8497323E""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaeae-0001-0000-2ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: afb
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01402() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test03640 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03640_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:33 GMT
ETag: ""0x8D439FEA027AA54""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aabcd6-0001-0000-1ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-make: xaysdf
x-ms-meta-c18934304: valuesdfsd
x-ms-meta-currenttime: 1/11/2017 8:48:33 AM
x-ms-meta-asdf: a:b
Date: Wed, 11 Jan 2017 08:48:33 GMT

0

";

    public Test03640() : base(recordedRequest, recordedResponse, "accounts8d439fea019c794")
    { }

    [Fact]
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
                        accountName: "accounts8d439fea019c794",
                        container: "containers3812c20ebaca498281669fc87601c241",
                        blob: "Blob3b6564fca45443b69a99510024670102",
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

public class Test01722 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01722_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:53 GMT
ETag: ""0x8D439FE884B6759""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab053-0001-0000-11e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:47:52 GMT

0

";

    public Test01722() : base(recordedRequest, recordedResponse, "accounts8d439fe883dd2cb")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe883dd2cb",
                        container: "containersaf5546b6e8d645f2a70641ad7ee25a22",
                        blob: "Blobb400e17f5f204aa49e200a7bc4898663",
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

public class Test01376 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01376_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8477EA2F""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae94-0001-0000-12e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aYb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01376() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01362 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01362_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE8466FA24""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae86-0001-0000-04e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aRb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01362() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01274 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01274_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:46 GMT
ETag: ""0x8D439FE8403A3C2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae28-0001-0000-26e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a&b
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01274() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test01448 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01448_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84CD36B8""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaedd-0001-0000-5be7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a}b
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01448() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02989 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02989_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:20 GMT
ETag: ""0x8D439FE9878E7E5""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab8ae-0001-0000-6ce7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:20 GMT

0

";

    public Test02989() : base(recordedRequest, recordedResponse, "accounts8d439fe986ba165")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe986ba165",
                        container: "containers42c225d3b009492289bc940df2697c0f",
                        blob: "Bloba20318a8c96b454d8e719654aaf74c81",
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

public class Test03023 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03023_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:21 GMT
ETag: ""0x8D439FE98D9A62C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab8e2-0001-0000-11e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:21 GMT

0

";

    public Test03023() : base(recordedRequest, recordedResponse, "accounts8d439fe98c66c32")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe98c66c32",
                        container: "containerseec37365109344eea03dabf6d7b9b28d",
                        blob: "Blob52d2a2034c4c495daf72ccaacd1ef6e9",
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

public class Test01378 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01378_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE847A5B74""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaae96-0001-0000-14e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: aZb
Date: Wed, 11 Jan 2017 08:47:46 GMT

0

";

    public Test01378() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test03009 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03009_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:21 GMT
ETag: ""0x8D439FE98B1AB93""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab8cd-0001-0000-02e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:21 GMT

0

";

    public Test03009() : base(recordedRequest, recordedResponse, "accounts8d439fe989f8302")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe989f8302",
                        container: "containers0b3211abb69e41fcbb64ff460f7463ca",
                        blob: "Blob941a8b786c3d41a0b124c5818f08e75b",
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

public class Test02975 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02975_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:20 GMT
ETag: ""0x8D439FE9855A841""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab898-0001-0000-5de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:20 GMT

0

";

    public Test02975() : base(recordedRequest, recordedResponse, "accounts8d439fe98483a9a")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe98483a9a",
                        container: "containersa5997d04c45c4cd18e41c804e3ea7a97",
                        blob: "Bloba5c0e7b03ba545aeb95a09b705b9e1b2",
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

public class Test01450 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01450_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:47:47 GMT
ETag: ""0x8D439FE84CF59A7""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aaaedf-0001-0000-5de7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-key: a~b
Date: Wed, 11 Jan 2017 08:47:47 GMT

0

";

    public Test01450() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerscb98345bb0544cf3aa8654d24e085c4b",
                        blob: "Blob3b1cc56b35f444c59b64711e87df7d0d",
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

public class Test02329 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02329_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:07 GMT
ETag: ""0x8D439FE9088AF30""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab46a-0001-0000-2ae7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadata1: value1
x-ms-meta-metadata2: value2
Date: Wed, 11 Jan 2017 08:48:07 GMT

0

";

    public Test02329() : base(recordedRequest, recordedResponse, "accounts8d439fe907a0908")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe907a0908",
                        container: "containersc3761e5e80e04feaad4e27b4bfb72b22",
                        blob: "Blob1e306a310db14730a88ffa59b029ca6e",
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

public class Test04114 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04114_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:40 GMT
ETag: ""0x8D439FEA46079AD""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aabf75-0001-0000-0ee7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:48:40 GMT

0

";

    public Test04114() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containersf98cc2c1732546ee8ccc6f63889df560",
                        blob: "PageBlobea81bd77c84042abbd04c60b7f89fa89",
                        timeout: 30,
                        leaseId: "637c7456-dc7b-404a-9550-d7470c972eec",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test02994 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02994_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:20 GMT
ETag: ""0x8D439FE988718CA""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aab8b6-0001-0000-71e7-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-metadataWithPutRequest1: valueWithPutRequest1
Date: Wed, 11 Jan 2017 08:48:20 GMT

0

";

    public Test02994() : base(recordedRequest, recordedResponse, "accounts8d439fe987cdf88")
    { }

    [Fact]
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
                        accountName: "accounts8d439fe987cdf88",
                        container: "containers67094ca54b64462b8b2b0f39bd04f6b9",
                        blob: "Blob0260bddc2f694d9cb9f4391ef9edb8b0",
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

public class Test04092 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04092_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 08:48:40 GMT
ETag: ""0x8D439FEA4402029""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11aabf5a-0001-0000-77e7-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 08:48:40 GMT

0

";

    public Test04092() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers310449a6234c4d1cb7e4c7a9ebb94ffb",
                        blob: "PageBlob9424451ed63c412994ddb811442e4efe",
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

public class Test18491 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18491_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:39 GMT
ETag: ""0x8D43A024541C082""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab103a-0001-0000-36eb-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 09:14:39 GMT

0

";

    public Test18491() : base(recordedRequest, recordedResponse, "accounts8d43a024537120b")
    { }

    [Fact]
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
                        accountName: "accounts8d43a024537120b",
                        container: "containers16573c1e0ac84f65a0120bd1a7881349",
                        blob: "PageBlob6bc78fa8c3c2483793181cba061713ae",
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

public class Test18652 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18652_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:41 GMT
ETag: ""0x8D43A02464F3AC4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab10f5-0001-0000-5deb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18652() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "^",
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

public class Test18526 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18526_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A0245BF55C7""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1072-0001-0000-5aeb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:39 GMT

0

";

    public Test18526() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "validBlobName",
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

public class Test18589 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18589_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A0246075BC7""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab10b3-0001-0000-1beb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18589() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "=",
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

public class Test18971 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18971_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:43 GMT
ETag: ""0x8D43A0247DBD112""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1243-0001-0000-29eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:43 GMT

0

";

    public Test18971() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
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

public class Test19163 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19163_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:45 GMT
ETag: ""0x8D43A0248DB8F93""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1313-0001-0000-76eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:45 GMT

0

";

    public Test19163() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "*",
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

public class Test19100 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19100_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:44 GMT
ETag: ""0x8D43A02489696CC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab12d0-0001-0000-33eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:44 GMT

0

";

    public Test19100() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "validBlobName",
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

public class Test18625 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18625_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A02462F2F61""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab10d9-0001-0000-41eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18625() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "#",
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

public class Test18688 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18688_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:41 GMT
ETag: ""0x8D43A02467BC952""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab111c-0001-0000-04eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:41 GMT

0

";

    public Test18688() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "a ",
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

public class Test18562 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18562_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A0245E94C43""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1097-0001-0000-7feb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18562() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "a",
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

public class Test19199 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19199_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:45 GMT
ETag: ""0x8D43A02490C8AF0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1338-0001-0000-1beb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:45 GMT

0

";

    public Test19199() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "^",
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

public class Test19136 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19136_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:45 GMT
ETag: ""0x8D43A0248BD8001""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab12f5-0001-0000-58eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:44 GMT

0

";

    public Test19136() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: " ",
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

public class Test19554 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19554_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:49 GMT
ETag: ""0x8D43A024B67BD44""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab14ca-0001-0000-18eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:49 GMT

0

";

    public Test19554() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerse70e0964710a4b7e98f006177011f4cb",
                        blob: "ABC",
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

public class Test18598 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18598_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A024610F8CD""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab10bc-0001-0000-24eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18598() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "~",
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

public class Test18980 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18980_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:43 GMT
ETag: ""0x8D43A0247E6585D""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab124c-0001-0000-32eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:43 GMT

0

";

    public Test18980() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
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

public class Test18661 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18661_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:41 GMT
ETag: ""0x8D43A0246599B12""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab10fe-0001-0000-66eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18661() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: " ",
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

public class Test19172 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19172_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:45 GMT
ETag: ""0x8D43A0248E8AF10""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab131c-0001-0000-7feb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:45 GMT

0

";

    public Test19172() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "@",
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

public class Test19109 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19109_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:44 GMT
ETag: ""0x8D43A0248A081EE""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab12d9-0001-0000-3ceb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:44 GMT

0

";

    public Test19109() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "zzz",
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

public class Test18634 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18634_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A02463968AC""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab10e2-0001-0000-4aeb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18634() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "$",
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

public class Test18571 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18571_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A0245F35E79""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab10a1-0001-0000-09eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18571() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "-",
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

public class Test18488 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18488_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:39 GMT
ETag: ""0x8D43A024541C082""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1037-0001-0000-33eb-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 09:14:39 GMT

0

";

    public Test18488() : base(recordedRequest, recordedResponse, "accounts8d43a024537120b")
    { }

    [Fact]
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
                        accountName: "accounts8d43a024537120b",
                        container: "containers16573c1e0ac84f65a0120bd1a7881349",
                        blob: "PageBlob6bc78fa8c3c2483793181cba061713ae",
                        timeout: 30,
                        leaseId: "d9f2d60b-afc5-4168-a7fe-86b5452faf14",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19145 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19145_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:45 GMT
ETag: ""0x8D43A0248C6F5F2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab12fe-0001-0000-61eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:45 GMT

0

";

    public Test19145() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "=",
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

public class Test18489 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18489_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:39 GMT
ETag: ""0x8D43A024541C082""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1038-0001-0000-34eb-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 09:14:39 GMT

0

";

    public Test18489() : base(recordedRequest, recordedResponse, "accounts8d43a024537120b")
    { }

    [Fact]
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
                        accountName: "accounts8d43a024537120b",
                        container: "containers16573c1e0ac84f65a0120bd1a7881349",
                        blob: "PageBlob6bc78fa8c3c2483793181cba061713ae",
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

public class Test18670 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18670_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:41 GMT
ETag: ""0x8D43A024664BEA2""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1108-0001-0000-70eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:41 GMT

0

";

    public Test18670() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "  ",
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

public class Test18697 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18697_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:41 GMT
ETag: ""0x8D43A0246871405""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1125-0001-0000-0deb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:41 GMT

0

";

    public Test18697() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "  a",
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

public class Test18544 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18544_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A0245D3C858""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1084-0001-0000-6ceb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18544() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "zzz",
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

public class Test18607 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18607_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A02461A47BF""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab10c6-0001-0000-2eeb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18607() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "*",
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

public class Test19563 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19563_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:49 GMT
ETag: ""0x8D43A024B7096F9""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab14d3-0001-0000-21eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:49 GMT

0

";

    public Test19563() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerse70e0964710a4b7e98f006177011f4cb",
                        blob: "abc",
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

public class Test19181 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19181_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:45 GMT
ETag: ""0x8D43A0248F8187A""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1325-0001-0000-08eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:45 GMT

0

";

    public Test19181() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "$",
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

public class Test18490 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18490_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:39 GMT
ETag: ""0x8D43A024541C082""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1039-0001-0000-35eb-6b3467000000
x-ms-version: 2016-05-31
Date: Wed, 11 Jan 2017 09:14:39 GMT

0

";

    public Test18490() : base(recordedRequest, recordedResponse, "accounts8d43a024537120b")
    { }

    [Fact]
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
                        accountName: "accounts8d43a024537120b",
                        container: "containers16573c1e0ac84f65a0120bd1a7881349",
                        blob: "PageBlob6bc78fa8c3c2483793181cba061713ae",
                        timeout: 30,
                        leaseId: "d9f2d60b-afc5-4168-a7fe-86b5452faf14",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19118 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19118_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:44 GMT
ETag: ""0x8D43A0248A9D0CF""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab12e2-0001-0000-45eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:44 GMT

0

";

    public Test19118() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "$root",
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

public class Test18643 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18643_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A0246443E37""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab10ec-0001-0000-54eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18643() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "%",
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

public class Test18580 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18580_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A0245FD2286""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab10aa-0001-0000-12eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18580() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: " ",
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

public class Test18935 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18935_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:43 GMT
ETag: ""0x8D43A0247AECD39""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab121d-0001-0000-03eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:43 GMT

0

";

    public Test18935() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
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

public class Test19154 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19154_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:45 GMT
ETag: ""0x8D43A0248D0E145""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1309-0001-0000-6ceb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:45 GMT

0

";

    public Test19154() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "~",
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

public class Test18616 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18616_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A02462480F4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab10d0-0001-0000-38eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18616() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "@",
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

public class Test18679 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18679_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:41 GMT
ETag: ""0x8D43A0246703080""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1113-0001-0000-7beb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:41 GMT

0

";

    public Test18679() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: " a",
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

public class Test18553 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18553_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:40 GMT
ETag: ""0x8D43A0245DDDA80""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab108d-0001-0000-75eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:40 GMT

0

";

    public Test18553() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "$root",
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

public class Test19318 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19318_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:46 GMT
ETag: ""0x8D43A0249AB3D1C""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab13b9-0001-0000-18eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:46 GMT

0

";

    public Test19318() : base(recordedRequest, recordedResponse, "accounts8d43a02499eb9db")
    { }

    [Fact]
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
                        accountName: "accounts8d43a02499eb9db",
                        container: "$root",
                        blob: "a",
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

public class Test19190 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19190_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:45 GMT
ETag: ""0x8D43A02490251AE""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab132f-0001-0000-12eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:45 GMT

0

";

    public Test19190() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "%",
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

public class Test19572 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19572_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:49 GMT
ETag: ""0x8D43A024B79BEC9""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab14dd-0001-0000-2beb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:49 GMT

0

";

    public Test19572() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containerse70e0964710a4b7e98f006177011f4cb",
                        blob: Encoding.UTF8.GetString(new byte[]{224,174,181,224,174,191,224,174,169,224,175,141,224,174,159,224,175,139,224,174,184,224,175,141}),
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

public class Test18706 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18706_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:41 GMT
ETag: ""0x8D43A0246919B62""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab112e-0001-0000-16eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:41 GMT

0

";

    public Test18706() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: " a ",
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

public class Test19127 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19127_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:45 GMT
ETag: ""0x8D43A0248B3BBFD""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab12ec-0001-0000-4feb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:44 GMT

0

";

    public Test19127() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "-",
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

public class Test18944 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18944_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:43 GMT
ETag: ""0x8D43A0247B9C9D4""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1227-0001-0000-0deb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:43 GMT

0

";

    public Test18944() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
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

public class Test19327 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19327_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:46 GMT
ETag: ""0x8D43A0249B4DA14""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab13c2-0001-0000-21eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:46 GMT

0

";

    public Test19327() : base(recordedRequest, recordedResponse, "accounts8d43a02499eb9db")
    { }

    [Fact]
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
                        accountName: "accounts8d43a02499eb9db",
                        container: "$root",
                        blob: " a",
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

public class Test18953 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18953_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:43 GMT
ETag: ""0x8D43A0247C562A7""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab1230-0001-0000-16eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:43 GMT

0

";

    public Test18953() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
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

public class Test19336 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19336_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:46 GMT
ETag: ""0x8D43A0249BE28F0""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab13cc-0001-0000-2beb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:46 GMT

0

";

    public Test19336() : base(recordedRequest, recordedResponse, "accounts8d43a02499eb9db")
    { }

    [Fact]
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
                        accountName: "accounts8d43a02499eb9db",
                        container: "$root",
                        blob: "a ",
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

public class Test18962 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18962_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:43 GMT
ETag: ""0x8D43A0247D1228A""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab123a-0001-0000-20eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:43 GMT

0

";

    public Test18962() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
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

public class Test19345 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19345_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:46 GMT
ETag: ""0x8D43A0249C750D3""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab13d5-0001-0000-34eb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:46 GMT

0

";

    public Test19345() : base(recordedRequest, recordedResponse, "accounts8d43a02499eb9db")
    { }

    [Fact]
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
                        accountName: "accounts8d43a02499eb9db",
                        container: "$root",
                        blob: "  a",
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

public class Test19354 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19354_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = @"HTTP/1.1 200 OK
Transfer-Encoding: chunked
Last-Modified: Wed, 11 Jan 2017 09:14:46 GMT
ETag: ""0x8D43A0249D07896""
Server: Windows-Azure-Blob/1.0 Microsoft-HTTPAPI/2.0
x-ms-request-id: 11ab13de-0001-0000-3deb-6b3467000000
x-ms-version: 2016-05-31
x-ms-meta-Key: Value
Date: Wed, 11 Jan 2017 09:14:46 GMT

0

";

    public Test19354() : base(recordedRequest, recordedResponse, "accounts8d43a02499eb9db")
    { }

    [Fact]
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
                        accountName: "accounts8d43a02499eb9db",
                        container: "$root",
                        blob: " a ",
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
