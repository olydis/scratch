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

public class Test000409 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000409_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000409_s.txt", Encoding.UTF8);

    public Test000409() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc34cd97e6f6d54441b6793e56a755ed41",
                        blob: "blob4f3fc5df-42cb-4a84-841d-e06b15ad7b88",
                        xMsBlobContentMd5: "Uc5xixyESMQMZb6rG0nfNg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000401 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000401_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000401_s.txt", Encoding.UTF8);

    public Test000401() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc34cd97e6f6d54441b6793e56a755ed41",
                        blob: "blob671bd542-bcd6-4399-b6f9-cac58823d4c0",
                        xMsBlobContentMd5: "l2/NaZM1koKRkjqi6LyznQ==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000397 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000397_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000397_s.txt", Encoding.UTF8);

    public Test000397() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc34cd97e6f6d54441b6793e56a755ed41",
                        blob: "blobac02a341-87e0-4376-9351-26334ecb5840",
                        xMsBlobContentMd5: "IgVktixUt7/DV8oZrnutvg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000405 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000405_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000405_s.txt", Encoding.UTF8);

    public Test000405() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc34cd97e6f6d54441b6793e56a755ed41",
                        blob: "blobd24cac4c-b550-4006-a6bf-1ab23ca84652",
                        xMsBlobContentMd5: "g+f3oeJ3X41KFJVxcd1SHw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test001448 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001448_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001448_s.txt", Encoding.UTF8);

    public Test001448() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc15012f04d72e432d908c08c19ba0f211",
                        blob: "blob1",
                        xMsBlobCacheControl: "no-transform",
                        xMsBlobContentType: "text/html",
                        xMsBlobContentMd5: "MDAwMDAwMDA=",
                        xMsBlobContentEncoding: "gzip",
                        xMsBlobContentLanguage: "tr,en",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test001551 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001551_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001551_s.txt", Encoding.UTF8);

    public Test001551() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testce3330e2ae59e40fcb9c841c4d2706dcd",
                        blob: "blob862f599b-9e39-481f-b2aa-7ea2b9b81d84",
                        xMsBlobContentMd5: "icowtKF0h3emVPBKYQ6omQ==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test001571 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001571_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001571_s.txt", Encoding.UTF8);

    public Test001571() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testce3330e2ae59e40fcb9c841c4d2706dcd",
                        blob: "blob34670391-0473-415e-95eb-25976a73fe66",
                        xMsBlobContentMd5: "xeaA0Y+3AUxMbCo3N7sjAg==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test001581 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001581_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001581_s.txt", Encoding.UTF8);

    public Test001581() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testce3330e2ae59e40fcb9c841c4d2706dcd",
                        blob: "blob744d72b1-cf36-42bd-b30f-87a27b8bc01b",
                        xMsBlobContentMd5: "VQEvD+HvrLjG7FABsrY+/A==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test001561 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001561_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001561_s.txt", Encoding.UTF8);

    public Test001561() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testce3330e2ae59e40fcb9c841c4d2706dcd",
                        blob: "blob243297ba-a57e-4ebe-b3da-c8503cb3b039",
                        xMsBlobContentMd5: "urFS0zwDlb4zvBggZtdJkw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00259 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00259_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00259_s.txt", Encoding.UTF8);

    public Test00259() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersf2de3c21bef74c40a75dc0dc8aabf6ec",
                        blob: "Blob58c3567ad7504a11824225ce68004fd4",
                        timeout: 30,
                        xMsBlobContentType: "text/plain; charset=UTF-8",
                        xMsBlobContentLanguage: "English-US",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00258 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00258_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00258_s.txt", Encoding.UTF8);

    public Test00258() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersf2de3c21bef74c40a75dc0dc8aabf6ec",
                        blob: "Blob58c3567ad7504a11824225ce68004fd4",
                        timeout: 30,
                        xMsBlobContentType: "text/plain; charset=UTF-8",
                        xMsBlobContentLanguage: "English-US",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00260 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00260_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00260_s.txt", Encoding.UTF8);

    public Test00260() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersf2de3c21bef74c40a75dc0dc8aabf6ec",
                        blob: "Blob58c3567ad7504a11824225ce68004fd4",
                        timeout: 30,
                        xMsBlobContentType: "text/plain; charset=UTF-8",
                        xMsBlobContentLanguage: "English-US",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00879 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00879_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00879_s.txt", Encoding.UTF8);

    public Test00879() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers1339dfddf5e44242bee66b8f1b68969c",
                        blob: "Blob74f08d730b50464b80f312d0c699b937",
                        timeout: 30,
                        xMsBlobContentMd5: "EhXlCHB/G1VXUvDXa+vcKw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test01152 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01152_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01152_s.txt", Encoding.UTF8);

    public Test01152() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersdfb625f2345e4fefba5baae14be3827d",
                        blob: "AppendBlob133a7026c7ff456db978bc3cc475b1eb",
                        timeout: 30,
                        xMsBlobContentType: "binary",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04148 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04148_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04148_s.txt", Encoding.UTF8);

    public Test04148() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersab388e0abc2742e491a160a47dc0ee9e",
                        blob: "PageBlob04aadc05d4334b6dba78b5cf945e1265",
                        timeout: 30,
                        leaseId: "c924b14d-2dff-4d88-84ed-15288230025f",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test05916 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05916_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05916_s.txt", Encoding.UTF8);

    public Test05916() : base(recordedRequest, recordedResponse, "accounts8d439ff28242e2e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff28242e2e",
                        container: "containersea1d27939a374feda08cd3c0ef9f62d2",
                        blob: "PageBlob82c42dc021cd40e0bfedee701e262a54",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test05948 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05948_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05948_s.txt", Encoding.UTF8);

    public Test05948() : base(recordedRequest, recordedResponse, "accounts8d439ff287498a5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff287498a5",
                        container: "containersd6ff98225588450d9cb8b0968ccd88b2",
                        blob: "BlockBlob4f263104c9cc4e6cb76304f24e46344a",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test05933 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05933_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05933_s.txt", Encoding.UTF8);

    public Test05933() : base(recordedRequest, recordedResponse, "accounts8d439ff284fd264")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff284fd264",
                        container: "containers88036a1ff5c04bd78c9d3b864bf9f99d",
                        blob: "BlockBlobf4efec5df2eb446c9e29852bfdd6b33c",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentType: "binary",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test05926 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05926_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05926_s.txt", Encoding.UTF8);

    public Test05926() : base(recordedRequest, recordedResponse, "accounts8d439ff283dd0d1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff283dd0d1",
                        container: "containers16f061351c5d400fbd55665058df00e7",
                        blob: "PageBlob13d32106998948a79162b70b428e8bf8",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test05906 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05906_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05906_s.txt", Encoding.UTF8);

    public Test05906() : base(recordedRequest, recordedResponse, "accounts8d439ff2809ef58")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2809ef58",
                        container: "containers2ea2bc6c87f645a1bd0233fb8581df0d",
                        blob: "PageBlob047d62e638874804a058d3c3fd2b94a8",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentType: "binary",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test05874 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05874_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05874_s.txt", Encoding.UTF8);

    public Test05874() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers29aac548564c490193dbe830fea9b09c",
                        blob: "PageBlob1138e9065709424ba83cd384f8c837f3",
                        timeout: 30,
                        xMsBlobContentType: "application/octet-stream",
                        xMsBlobContentLanguage: "English-US",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test05941 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05941_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05941_s.txt", Encoding.UTF8);

    public Test05941() : base(recordedRequest, recordedResponse, "accounts8d439ff2863f6c3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2863f6c3",
                        container: "containers925a10adaa144cc2b9ce5ef03cd8089a",
                        blob: "BlockBlobd3b6b28ec5ce4d7e8b0d6e25f4505e9c",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test05876 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05876_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05876_s.txt", Encoding.UTF8);

    public Test05876() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers29aac548564c490193dbe830fea9b09c",
                        blob: "PageBlob1138e9065709424ba83cd384f8c837f3",
                        timeout: 30,
                        xMsBlobContentType: "application-json",
                        xMsBlobContentLanguage: "English-US",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test05878 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05878_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05878_s.txt", Encoding.UTF8);

    public Test05878() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers29aac548564c490193dbe830fea9b09c",
                        blob: "PageBlob1138e9065709424ba83cd384f8c837f3",
                        timeout: 30,
                        xMsBlobContentType: "application-json",
                        xMsBlobContentLanguage: "English-US",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test06955 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06955_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06955_s.txt", Encoding.UTF8);

    public Test06955() : base(recordedRequest, recordedResponse, "accounts8d439ff90a45290")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff90a45290",
                        container: "containers70717ea0c0b141d285715e30cb5ec564",
                        blob: "PageBlob82d8ef725ec44cd482ea7497ce7f1371",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test06945 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06945_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06945_s.txt", Encoding.UTF8);

    public Test06945() : base(recordedRequest, recordedResponse, "accounts8d439ff9089ec8f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff9089ec8f",
                        container: "containersaf8f7f58ce7b4ffda9571a469ced0818",
                        blob: "PageBlobd426679a401848c787d1bce90346436e",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test06834 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06834_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06834_s.txt", Encoding.UTF8);

    public Test06834() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers2ff3a1af5b174e89b2d08da73a4b8f9f",
                        blob: "Blobc4e5307cf6ad41c7aa8a4a64681423a3",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07261 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07261_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07261_s.txt", Encoding.UTF8);

    public Test07261() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersf32db546d36040f4994c6b6915446821",
                        blob: "9fa0bf41-2bdc-4b17-aa8e-83cd85708cf7",
                        timeout: 30,
                        xMsBlobContentType: "text/plain; charset=UTF-8",
                        xMsBlobContentLanguage: "English-US",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test06962 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06962_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06962_s.txt", Encoding.UTF8);

    public Test06962() : base(recordedRequest, recordedResponse, "accounts8d439ff90b76582")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff90b76582",
                        container: "containers55c9aa9cafd04d1a8edc39c8b066bd8e",
                        blob: "BlockBlob341f37acf48b4a86bf7e7c4fb1074173",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentType: "binary",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07074 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07074_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07074_s.txt", Encoding.UTF8);

    public Test07074() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8d7575ee34724bb28d1382d01f131c6b",
                        blob: "PageBlob623ff268bbff40a6b531e22fe8047c43",
                        timeout: 30,
                        xMsBlobContentMd5: "Nr95XP2eEjDvs9iv2U87bw==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07060 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07060_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07060_s.txt", Encoding.UTF8);

    public Test07060() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8329352c5eaf490da983de8961d0d541",
                        blob: "PageBlob51d551ceff0843b5bde6578f2fea0b48",
                        timeout: 30,
                        xMsBlobContentMd5: "xHekpViCDvaHZP1i9d7HHQ==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test06822 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06822_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06822_s.txt", Encoding.UTF8);

    public Test06822() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers0be247666ad848e18d9ca32fa08e46a0",
                        blob: "Blob9f0516be634d49b5b2570ac29f0e763f",
                        timeout: 30,
                        xMsBlobContentType: "text/plain; charset=UTF-8",
                        xMsBlobContentLanguage: "English-US",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test06970 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06970_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06970_s.txt", Encoding.UTF8);

    public Test06970() : base(recordedRequest, recordedResponse, "accounts8d439ff90ca5169")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff90ca5169",
                        container: "containers1cfee2ec93944bfc88fb40fa2a2474d7",
                        blob: "BlockBlob4baea0c3dd7345e1973cdcbf28349c3b",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentType: "binary",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test07066 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07066_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07066_s.txt", Encoding.UTF8);

    public Test07066() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa36719ae2bf6480cb7e0950dc3120f41",
                        blob: "PageBlob3e7304819efd466fbf65bd92269dbfa4",
                        timeout: 30,
                        xMsBlobContentMd5: "aFNr7N5vJcYUYVHkvJr9AA==",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test06977 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06977_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06977_s.txt", Encoding.UTF8);

    public Test06977() : base(recordedRequest, recordedResponse, "accounts8d439ff90dca0f8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff90dca0f8",
                        container: "containersf620f8c2ee1744f7bac3495ee6b430cc",
                        blob: "BlockBlobdf0d5ffacd4140c3b05edf991fbe792e",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test06935 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06935_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06935_s.txt", Encoding.UTF8);

    public Test06935() : base(recordedRequest, recordedResponse, "accounts8d439ff906d3c8f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d439ff906d3c8f",
                        container: "containers6e269a1813ca4ad1955c6927bd0bba01",
                        blob: "PageBlob606dee87721f4b569c0949287da19b30",
                        timeout: 30,
                        xMsBlobCacheControl: "CacheControl",
                        xMsBlobContentType: "binary",
                        xMsBlobContentEncoding: "ContentEncoding",
                        xMsBlobContentLanguage: "ContentLanguage",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21340 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21340_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21340_s.txt", Encoding.UTF8);

    public Test21340() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21405 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21405_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21405_s.txt", Encoding.UTF8);

    public Test21405() : base(recordedRequest, recordedResponse, "accounts8d43a03ea0a9eec")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a03ea0a9eec",
                        container: "containerscda5d6868c67424cb2299372c9e25705",
                        blob: "b95bde43-fe3f-408a-b6b4-04e59fb182bf.vhd",
                        timeout: 30,
                        xMsBlobContentType: "text/plain; charset=UTF-8",
                        xMsBlobContentLanguage: "English-US",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21276 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21276_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21276_s.txt", Encoding.UTF8);

    public Test21276() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21212 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21212_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21212_s.txt", Encoding.UTF8);

    public Test21212() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21278 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21278_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21278_s.txt", Encoding.UTF8);

    public Test21278() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21244 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21244_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21244_s.txt", Encoding.UTF8);

    public Test21244() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21214 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21214_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21214_s.txt", Encoding.UTF8);

    public Test21214() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21280 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21280_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21280_s.txt", Encoding.UTF8);

    public Test21280() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21342 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21342_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21342_s.txt", Encoding.UTF8);

    public Test21342() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21216 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21216_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21216_s.txt", Encoding.UTF8);

    public Test21216() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21344 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21344_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21344_s.txt", Encoding.UTF8);

    public Test21344() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21246 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21246_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21246_s.txt", Encoding.UTF8);

    public Test21246() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21282 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21282_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21282_s.txt", Encoding.UTF8);

    public Test21282() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21218 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21218_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21218_s.txt", Encoding.UTF8);

    public Test21218() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21248 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21248_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21248_s.txt", Encoding.UTF8);

    public Test21248() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21346 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21346_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21346_s.txt", Encoding.UTF8);

    public Test21346() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21348 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21348_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21348_s.txt", Encoding.UTF8);

    public Test21348() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21220 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21220_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21220_s.txt", Encoding.UTF8);

    public Test21220() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21284 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21284_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21284_s.txt", Encoding.UTF8);

    public Test21284() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21416 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21416_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21416_s.txt", Encoding.UTF8);

    public Test21416() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers98cc65957c4f48e99347da7107cb63ca",
                        blob: "Blob8e143eb8bbcc489eb7c7304a3000f5ad",
                        timeout: 30,
                        xMsBlobContentType: "text/plain; charset=UTF-8",
                        xMsBlobContentLanguage: "English-US",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21222 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21222_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21222_s.txt", Encoding.UTF8);

    public Test21222() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21286 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21286_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21286_s.txt", Encoding.UTF8);

    public Test21286() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21350 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21350_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21350_s.txt", Encoding.UTF8);

    public Test21350() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21250 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21250_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21250_s.txt", Encoding.UTF8);

    public Test21250() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21288 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21288_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21288_s.txt", Encoding.UTF8);

    public Test21288() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21224 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21224_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21224_s.txt", Encoding.UTF8);

    public Test21224() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21290 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21290_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21290_s.txt", Encoding.UTF8);

    public Test21290() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21352 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21352_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21352_s.txt", Encoding.UTF8);

    public Test21352() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21252 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21252_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21252_s.txt", Encoding.UTF8);

    public Test21252() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21226 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21226_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21226_s.txt", Encoding.UTF8);

    public Test21226() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test18421 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18421_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18421_s.txt", Encoding.UTF8);

    public Test18421() : base(recordedRequest, recordedResponse, "accounts8d43a02446ce2cb")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a02446ce2cb",
                        container: "containers36e932929a5b4c69a95364a0ac1fca3b",
                        blob: "PageBlobf64ea412a53843c5b38a0c3207175f7b",
                        timeout: 30,
                        leaseId: "8019478a-332a-4fbc-b093-bc66db67e82a",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21292 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21292_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21292_s.txt", Encoding.UTF8);

    public Test21292() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21354 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21354_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21354_s.txt", Encoding.UTF8);

    public Test21354() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21228 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21228_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21228_s.txt", Encoding.UTF8);

    public Test21228() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21254 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21254_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21254_s.txt", Encoding.UTF8);

    public Test21254() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21294 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21294_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21294_s.txt", Encoding.UTF8);

    public Test21294() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21356 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21356_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21356_s.txt", Encoding.UTF8);

    public Test21356() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21230 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21230_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21230_s.txt", Encoding.UTF8);

    public Test21230() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21256 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21256_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21256_s.txt", Encoding.UTF8);

    public Test21256() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21171 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21171_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21171_s.txt", Encoding.UTF8);

    public Test21171() : base(recordedRequest, recordedResponse, "accounts8d43a03d50acd0e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a03d50acd0e",
                        container: "containers86dd230836c44512afabd50b9427fafb",
                        blob: "d4260e79-a84f-4a00-826e-c549d841e6b5.vhd",
                        timeout: 30,
                        xMsBlobContentType: "text/plain; charset=UTF-8",
                        xMsBlobContentLanguage: "English-US",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21296 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21296_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21296_s.txt", Encoding.UTF8);

    public Test21296() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21232 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21232_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21232_s.txt", Encoding.UTF8);

    public Test21232() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21358 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21358_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21358_s.txt", Encoding.UTF8);

    public Test21358() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21234 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21234_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21234_s.txt", Encoding.UTF8);

    public Test21234() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21298 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21298_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21298_s.txt", Encoding.UTF8);

    public Test21298() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21258 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21258_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21258_s.txt", Encoding.UTF8);

    public Test21258() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21360 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21360_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21360_s.txt", Encoding.UTF8);

    public Test21360() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21236 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21236_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21236_s.txt", Encoding.UTF8);

    public Test21236() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21260 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21260_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21260_s.txt", Encoding.UTF8);

    public Test21260() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21300 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21300_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21300_s.txt", Encoding.UTF8);

    public Test21300() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21186 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21186_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21186_s.txt", Encoding.UTF8);

    public Test21186() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21362 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21362_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21362_s.txt", Encoding.UTF8);

    public Test21362() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21238 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21238_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21238_s.txt", Encoding.UTF8);

    public Test21238() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21262 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21262_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21262_s.txt", Encoding.UTF8);

    public Test21262() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21364 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21364_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21364_s.txt", Encoding.UTF8);

    public Test21364() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21302 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21302_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21302_s.txt", Encoding.UTF8);

    public Test21302() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21264 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21264_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21264_s.txt", Encoding.UTF8);

    public Test21264() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21188 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21188_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21188_s.txt", Encoding.UTF8);

    public Test21188() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21240 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21240_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21240_s.txt", Encoding.UTF8);

    public Test21240() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21366 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21366_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21366_s.txt", Encoding.UTF8);

    public Test21366() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21304 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21304_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21304_s.txt", Encoding.UTF8);

    public Test21304() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21242 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21242_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21242_s.txt", Encoding.UTF8);

    public Test21242() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21266 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21266_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21266_s.txt", Encoding.UTF8);

    public Test21266() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21368 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21368_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21368_s.txt", Encoding.UTF8);

    public Test21368() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21268 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21268_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21268_s.txt", Encoding.UTF8);

    public Test21268() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21306 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21306_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21306_s.txt", Encoding.UTF8);

    public Test21306() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21370 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21370_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21370_s.txt", Encoding.UTF8);

    public Test21370() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21372 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21372_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21372_s.txt", Encoding.UTF8);

    public Test21372() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21308 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21308_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21308_s.txt", Encoding.UTF8);

    public Test21308() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21270 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21270_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21270_s.txt", Encoding.UTF8);

    public Test21270() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21374 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21374_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21374_s.txt", Encoding.UTF8);

    public Test21374() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21310 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21310_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21310_s.txt", Encoding.UTF8);

    public Test21310() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21376 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21376_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21376_s.txt", Encoding.UTF8);

    public Test21376() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21272 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21272_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21272_s.txt", Encoding.UTF8);

    public Test21272() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21210 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21210_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21210_s.txt", Encoding.UTF8);

    public Test21210() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21312 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21312_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21312_s.txt", Encoding.UTF8);

    public Test21312() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21378 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21378_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21378_s.txt", Encoding.UTF8);

    public Test21378() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21274 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21274_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21274_s.txt", Encoding.UTF8);

    public Test21274() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21380 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21380_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21380_s.txt", Encoding.UTF8);

    public Test21380() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb,aub",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21314 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21314_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21314_s.txt", Encoding.UTF8);

    public Test21314() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21316 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21316_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21316_s.txt", Encoding.UTF8);

    public Test21316() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21382 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21382_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21382_s.txt", Encoding.UTF8);

    public Test21382() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb,aub,avb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21384 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21384_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21384_s.txt", Encoding.UTF8);

    public Test21384() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb,aub,avb,awb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21318 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21318_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21318_s.txt", Encoding.UTF8);

    public Test21318() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21320 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21320_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21320_s.txt", Encoding.UTF8);

    public Test21320() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21386 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21386_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21386_s.txt", Encoding.UTF8);

    public Test21386() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb,aub,avb,awb,axb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21322 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21322_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21322_s.txt", Encoding.UTF8);

    public Test21322() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21388 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21388_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21388_s.txt", Encoding.UTF8);

    public Test21388() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb,aub,avb,awb,axb,ayb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21324 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21324_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21324_s.txt", Encoding.UTF8);

    public Test21324() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21390 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21390_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21390_s.txt", Encoding.UTF8);

    public Test21390() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb,aub,avb,awb,axb,ayb,azb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21326 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21326_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21326_s.txt", Encoding.UTF8);

    public Test21326() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21328 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21328_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21328_s.txt", Encoding.UTF8);

    public Test21328() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a" +
    "[b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21392 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21392_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21392_s.txt", Encoding.UTF8);

    public Test21392() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb,aub,avb,awb,axb,ayb,azb,a{b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21330 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21330_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21330_s.txt", Encoding.UTF8);

    public Test21330() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a" +
    "[b,a\\b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21394 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21394_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21394_s.txt", Encoding.UTF8);

    public Test21394() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb,aub,avb,awb,axb,ayb,azb,a{b,a|b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21396 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21396_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21396_s.txt", Encoding.UTF8);

    public Test21396() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb,aub,avb,awb,axb,ayb,azb,a{b,a|b,a}b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21332 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21332_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21332_s.txt", Encoding.UTF8);

    public Test21332() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a" +
    "[b,a\\b,a]b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21334 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21334_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21334_s.txt", Encoding.UTF8);

    public Test21334() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: "a\tb,a b,a!b,a\"b,a#b,a$b,a%b,a&b,a\'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a" +
    "3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,a" +
    "Gb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a" +
    "[b,a\\b,a]b,a^b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21398 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21398_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21398_s.txt", Encoding.UTF8);

    public Test21398() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb,aub,avb,awb,axb,ayb,azb,a{b,a|b,a}b,a~b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21336 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21336_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21336_s.txt", Encoding.UTF8);

    public Test21336() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21338 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21338_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21338_s.txt", Encoding.UTF8);

    public Test21338() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbca151ea336040c5b54374f1569b6711",
                        blob: "Bloba63277a4bdf447ea86333b37cc1e7aa8",
                        timeout: 30,
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}
