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

public class Test00408 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00408_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00408_s.txt", Encoding.UTF8);

    public Test00408() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbf2702cde30a4f168205f97253956233",
                        blob: "Blob91de83c1997d42a98ad8fe3a29ddc747",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00410 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00410_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00410_s.txt", Encoding.UTF8);

    public Test00410() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbf2702cde30a4f168205f97253956233",
                        blob: "Blob91de83c1997d42a98ad8fe3a29ddc747",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00409 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00409_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00409_s.txt", Encoding.UTF8);

    public Test00409() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbf2702cde30a4f168205f97253956233",
                        blob: "Blob91de83c1997d42a98ad8fe3a29ddc747",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04166 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04166_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04166_s.txt", Encoding.UTF8);

    public Test04166() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersccf6947f5ccf4d8aa7f56329a267a4ec",
                        blob: "PageBlob8249523e9cd44b73acb3280024ddaec0",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04168 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04168_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04168_s.txt", Encoding.UTF8);

    public Test04168() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersccf6947f5ccf4d8aa7f56329a267a4ec",
                        blob: "PageBlob8249523e9cd44b73acb3280024ddaec0",
                        timeout: 30,
                        leaseId: "33cfb304-a8c8-4c65-a39c-42512b775b8b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07243 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07243_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07243_s.txt", Encoding.UTF8);

    public Test07243() : base(recordedRequest, recordedResponse, "accounts8d439ffe3390af6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3390af6",
                        container: "containersfe5fb7027d7e448aaad759a3fbd1880a",
                        blob: "Blob082b57522b88456998d25f67c2bbaa7b",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07244 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07244_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07244_s.txt", Encoding.UTF8);

    public Test07244() : base(recordedRequest, recordedResponse, "accounts8d439ffe3390af6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3390af6",
                        container: "containersfe5fb7027d7e448aaad759a3fbd1880a",
                        blob: "Blob082b57522b88456998d25f67c2bbaa7b",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07245 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07245_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07245_s.txt", Encoding.UTF8);

    public Test07245() : base(recordedRequest, recordedResponse, "accounts8d439ffe3390af6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3390af6",
                        container: "containersfe5fb7027d7e448aaad759a3fbd1880a",
                        blob: "Blob082b57522b88456998d25f67c2bbaa7b",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07102 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07102_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07102_s.txt", Encoding.UTF8);

    public Test07102() : base(recordedRequest, recordedResponse, "accounts8d439ffdaf5f6b6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffdaf5f6b6",
                        container: "containers2d9b0995385f4be29bfb7b6c94c681c1",
                        blob: "Blobb7332b60a9334c43b8891bd1f5478565",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07246 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07246_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07246_s.txt", Encoding.UTF8);

    public Test07246() : base(recordedRequest, recordedResponse, "accounts8d439ffe3390af6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3390af6",
                        container: "containersfe5fb7027d7e448aaad759a3fbd1880a",
                        blob: "Blob082b57522b88456998d25f67c2bbaa7b",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07247 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07247_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07247_s.txt", Encoding.UTF8);

    public Test07247() : base(recordedRequest, recordedResponse, "accounts8d439ffe3390af6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3390af6",
                        container: "containersfe5fb7027d7e448aaad759a3fbd1880a",
                        blob: "Blob082b57522b88456998d25f67c2bbaa7b",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07248 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07248_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07248_s.txt", Encoding.UTF8);

    public Test07248() : base(recordedRequest, recordedResponse, "accounts8d439ffe3390af6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3390af6",
                        container: "containersfe5fb7027d7e448aaad759a3fbd1880a",
                        blob: "Blob082b57522b88456998d25f67c2bbaa7b",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07109 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07109_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07109_s.txt", Encoding.UTF8);

    public Test07109() : base(recordedRequest, recordedResponse, "accounts8d439ffdb0a4225")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffdb0a4225",
                        container: "containers4b532a9214e340e691655e121d39c9db",
                        blob: "Blob55c39e4174c74a5794d5c6a8c948d541",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07249 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07249_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07249_s.txt", Encoding.UTF8);

    public Test07249() : base(recordedRequest, recordedResponse, "accounts8d439ffe3390af6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3390af6",
                        container: "containersfe5fb7027d7e448aaad759a3fbd1880a",
                        blob: "Blob082b57522b88456998d25f67c2bbaa7b",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07250 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07250_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07250_s.txt", Encoding.UTF8);

    public Test07250() : base(recordedRequest, recordedResponse, "accounts8d439ffe3390af6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3390af6",
                        container: "containersfe5fb7027d7e448aaad759a3fbd1880a",
                        blob: "Blob082b57522b88456998d25f67c2bbaa7b",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07251 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07251_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07251_s.txt", Encoding.UTF8);

    public Test07251() : base(recordedRequest, recordedResponse, "accounts8d439ffe3390af6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3390af6",
                        container: "containersfe5fb7027d7e448aaad759a3fbd1880a",
                        blob: "Blob082b57522b88456998d25f67c2bbaa7b",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07252 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07252_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07252_s.txt", Encoding.UTF8);

    public Test07252() : base(recordedRequest, recordedResponse, "accounts8d439ffe3390af6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3390af6",
                        container: "containersfe5fb7027d7e448aaad759a3fbd1880a",
                        blob: "Blob082b57522b88456998d25f67c2bbaa7b",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07116 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07116_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07116_s.txt", Encoding.UTF8);

    public Test07116() : base(recordedRequest, recordedResponse, "accounts8d439ffdb1eb4b1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffdb1eb4b1",
                        container: "containersc92e25d856ae4d32a49561628f2bea0d",
                        blob: "Blob9b8eb839ffef492cb81ed29e2e2fe4b9",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07230 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07230_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07230_s.txt", Encoding.UTF8);

    public Test07230() : base(recordedRequest, recordedResponse, "accounts8d439ffe3264620")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3264620",
                        container: "containersfd62785af7904aa3aec503a175aea68d",
                        blob: "Blobd82db4da8bce409fbeeddc740b258b2a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07192 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07192_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07192_s.txt", Encoding.UTF8);

    public Test07192() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers133b9a8264fe4390a99e09b957d11df1",
                        blob: "Blob0fbb3dc6176944b29a239fd808baf6d3",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07096 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07096_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07096_s.txt", Encoding.UTF8);

    public Test07096() : base(recordedRequest, recordedResponse, "accounts8d439ffda48294e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffda48294e",
                        container: "containers90c96c5cf0314aafb9c6be3ec2e651d0",
                        blob: "Blob0e210bd047ca4ad8bfec42e77d8eb49d",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07097 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07097_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07097_s.txt", Encoding.UTF8);

    public Test07097() : base(recordedRequest, recordedResponse, "accounts8d439ffda48294e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffda48294e",
                        container: "containers90c96c5cf0314aafb9c6be3ec2e651d0",
                        blob: "Blob0e210bd047ca4ad8bfec42e77d8eb49d",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07242 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07242_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07242_s.txt", Encoding.UTF8);

    public Test07242() : base(recordedRequest, recordedResponse, "accounts8d439ffe3390af6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d439ffe3390af6",
                        container: "containersfe5fb7027d7e448aaad759a3fbd1880a",
                        blob: "Blob082b57522b88456998d25f67c2bbaa7b",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18684 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18684_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18684_s.txt", Encoding.UTF8);

    public Test18684() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: " a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18621 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18621_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18621_s.txt", Encoding.UTF8);

    public Test18621() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "@",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19195 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19195_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19195_s.txt", Encoding.UTF8);

    public Test19195() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "%",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19132 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19132_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19132_s.txt", Encoding.UTF8);

    public Test19132() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "-",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18558 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18558_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18558_s.txt", Encoding.UTF8);

    public Test18558() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "$root",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18594 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18594_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18594_s.txt", Encoding.UTF8);

    public Test18594() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "=",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19168 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19168_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19168_s.txt", Encoding.UTF8);

    public Test19168() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "*",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18531 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18531_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18531_s.txt", Encoding.UTF8);

    public Test18531() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "validBlobName",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18657 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18657_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18657_s.txt", Encoding.UTF8);

    public Test18657() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "^",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18976 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18976_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18976_s.txt", Encoding.UTF8);

    public Test18976() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19105 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19105_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19105_s.txt", Encoding.UTF8);

    public Test19105() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "validBlobName",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19359 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19359_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19359_s.txt", Encoding.UTF8);

    public Test19359() : base(recordedRequest, recordedResponse, "accounts8d43a02499eb9db")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a02499eb9db",
                        container: "$root",
                        blob: " a ",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18630 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18630_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18630_s.txt", Encoding.UTF8);

    public Test18630() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "#",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18410 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18410_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18410_s.txt", Encoding.UTF8);

    public Test18410() : base(recordedRequest, recordedResponse, "accounts8d43a024444c10d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a024444c10d",
                        container: "containers9579ec0c08c94d3f82bd1a4d586643c3",
                        blob: "PageBlob61d5879a6ad04698856a470c6a37e016",
                        timeout: 30,
                        leaseId: "2138b584-9a32-4087-81e8-2f1dc1fe2014",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18567 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18567_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18567_s.txt", Encoding.UTF8);

    public Test18567() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18411 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18411_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18411_s.txt", Encoding.UTF8);

    public Test18411() : base(recordedRequest, recordedResponse, "accounts8d43a024444c10d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a024444c10d",
                        container: "containers9579ec0c08c94d3f82bd1a4d586643c3",
                        blob: "PageBlob61d5879a6ad04698856a470c6a37e016",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18693 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18693_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18693_s.txt", Encoding.UTF8);

    public Test18693() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "a ",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18985 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18985_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18985_s.txt", Encoding.UTF8);

    public Test18985() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19204 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19204_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19204_s.txt", Encoding.UTF8);

    public Test19204() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "^",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23133 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23133_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23133_s.txt", Encoding.UTF8);

    public Test23133() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersc11941826276434facd809ee7e04fce8",
                        blob: "PageBlob5622fe7387034e9f855513cfafd7a369",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19141 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19141_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19141_s.txt", Encoding.UTF8);

    public Test19141() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: " ",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18603 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18603_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18603_s.txt", Encoding.UTF8);

    public Test18603() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "~",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18666 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18666_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18666_s.txt", Encoding.UTF8);

    public Test18666() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: " ",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21446 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21446_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21446_s.txt", Encoding.UTF8);

    public Test21446() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers48771f88575e4515915e87d6b2aed9d9",
                        blob: "Blobc5cc572d47f04d11af96df70fb23327a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19559 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19559_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19559_s.txt", Encoding.UTF8);

    public Test19559() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerse70e0964710a4b7e98f006177011f4cb",
                        blob: "ABC",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19177 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19177_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19177_s.txt", Encoding.UTF8);

    public Test19177() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "@",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19114 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19114_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19114_s.txt", Encoding.UTF8);

    public Test19114() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "zzz",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18639 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18639_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18639_s.txt", Encoding.UTF8);

    public Test18639() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "$",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18576 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18576_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18576_s.txt", Encoding.UTF8);

    public Test18576() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "-",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19150 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19150_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19150_s.txt", Encoding.UTF8);

    public Test19150() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "=",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18612 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18612_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18612_s.txt", Encoding.UTF8);

    public Test18612() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "*",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18675 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18675_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18675_s.txt", Encoding.UTF8);

    public Test18675() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "  ",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18549 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18549_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18549_s.txt", Encoding.UTF8);

    public Test18549() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "zzz",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18702 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18702_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18702_s.txt", Encoding.UTF8);

    public Test18702() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "  a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19568 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19568_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19568_s.txt", Encoding.UTF8);

    public Test19568() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerse70e0964710a4b7e98f006177011f4cb",
                        blob: "abc",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19186 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19186_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19186_s.txt", Encoding.UTF8);

    public Test19186() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "$",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19123 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19123_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19123_s.txt", Encoding.UTF8);

    public Test19123() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "$root",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18585 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18585_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18585_s.txt", Encoding.UTF8);

    public Test18585() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: " ",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19159 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19159_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19159_s.txt", Encoding.UTF8);

    public Test19159() : base(recordedRequest, recordedResponse, "accounts8d43a0248897754")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0248897754",
                        container: "$root",
                        blob: "~",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18940 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18940_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18940_s.txt", Encoding.UTF8);

    public Test18940() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18648 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18648_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18648_s.txt", Encoding.UTF8);

    public Test18648() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: "%",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19577 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19577_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19577_s.txt", Encoding.UTF8);

    public Test19577() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerse70e0964710a4b7e98f006177011f4cb",
                        blob: Encoding.UTF8.GetString(new byte[]{224,174,181,224,174,191,224,174,169,224,175,141,224,174,159,224,175,139,224,174,184,224,175,141}),
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23118 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23118_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23118_s.txt", Encoding.UTF8);

    public Test23118() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers28ab964f2ab04d08994828b9dbb10750",
                        blob: "PageBlobcadb17c23b3f4d80b030820092a31b24",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19323 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19323_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19323_s.txt", Encoding.UTF8);

    public Test19323() : base(recordedRequest, recordedResponse, "accounts8d43a02499eb9db")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a02499eb9db",
                        container: "$root",
                        blob: "a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18711 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18711_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18711_s.txt", Encoding.UTF8);

    public Test18711() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8bf0ade78d5c44debb2207edecfd6fd7",
                        blob: " a ",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18949 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18949_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18949_s.txt", Encoding.UTF8);

    public Test18949() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19332 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19332_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19332_s.txt", Encoding.UTF8);

    public Test19332() : base(recordedRequest, recordedResponse, "accounts8d43a02499eb9db")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a02499eb9db",
                        container: "$root",
                        blob: " a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18958 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18958_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18958_s.txt", Encoding.UTF8);

    public Test18958() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19341 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19341_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19341_s.txt", Encoding.UTF8);

    public Test19341() : base(recordedRequest, recordedResponse, "accounts8d43a02499eb9db")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a02499eb9db",
                        container: "$root",
                        blob: "a ",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18967 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18967_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18967_s.txt", Encoding.UTF8);

    public Test18967() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4b6ccbd70ce54b43862febf1401d5a89",
                        blob: "a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test19350 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19350_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19350_s.txt", Encoding.UTF8);

    public Test19350() : base(recordedRequest, recordedResponse, "accounts8d43a02499eb9db")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.GetPageRangesWithHttpMessagesAsync(
                        accountName: "accounts8d43a02499eb9db",
                        container: "$root",
                        blob: "  a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var strBodyExpected = XElement.Parse(RawResponseBody).ToString();
                var strBodyActual = result.Body.ToString();
                Assert.Equal(strBodyExpected, strBodyActual);

            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}
