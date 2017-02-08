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

public class Test00264 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00264_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00264_s.txt", Encoding.UTF8);

    public Test00264() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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

public class Test00266 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00266_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00266_s.txt", Encoding.UTF8);

    public Test00266() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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

public class Test00262 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00262_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00262_s.txt", Encoding.UTF8);

    public Test00262() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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

public class Test00267 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00267_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00267_s.txt", Encoding.UTF8);

    public Test00267() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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

public class Test00263 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00263_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00263_s.txt", Encoding.UTF8);

    public Test00263() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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

public class Test00268 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00268_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00268_s.txt", Encoding.UTF8);

    public Test00268() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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

public class Test00265 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00265_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00265_s.txt", Encoding.UTF8);

    public Test00265() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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

public class Test00261 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00261_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00261_s.txt", Encoding.UTF8);

    public Test00261() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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

public class Test01207 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01207_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01207_s.txt", Encoding.UTF8);

    public Test01207() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        container: "containers55d2d6b0305a4fa2adc57f74340abfc6",
                        blob: "AppendBlob1ca02d3420174ea28aa544f1f8962c7f",
                        timeout: 30,
                        xMsBlobContentType: "binary",
                        leaseId: "e800801b-ef65-48cd-a11c-13463e41416f",
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

public class Test00865 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00865_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00865_s.txt", Encoding.UTF8);

    public Test00865() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        container: "containersd1b198cbefd247848559c2fae01c9dd3",
                        blob: "Blob2a12e3fa3dac416f95b157900a9c56ca",
                        timeout: 30,
                        xMsBlobContentLength: 512,
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

public class Test01170 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01170_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01170_s.txt", Encoding.UTF8);

    public Test01170() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        container: "containers9cfb9a08d9a2469babbc82e438629212",
                        blob: "AppendBlobfaaaf8b12d944c9d9d67177c1ba3d044",
                        timeout: 30,
                        xMsBlobContentType: "binary",
                        leaseId: "b246b0b1-7a5b-4831-aacf-c0e976f7263b",
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

public class Test03652 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03652_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03652_s.txt", Encoding.UTF8);

    public Test03652() : base(recordedRequest, recordedResponse, "accounts8d439fea03dca8d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        accountName: "accounts8d439fea03dca8d",
                        container: "containersb1774f3bf8b8480d96cb489ecbc9d495",
                        blob: "PageBlob7482437690354ad8ad399d3e8f19d3b0",
                        timeout: 30,
                        xMsBlobContentType: "foo",
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

public class Test03660 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03660_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03660_s.txt", Encoding.UTF8);

    public Test03660() : base(recordedRequest, recordedResponse, "accounts8d439fea05682dd")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        accountName: "accounts8d439fea05682dd",
                        container: "containers43a2953c39f9496fbf32c14fdfdd376a",
                        blob: "PageBlob424a31bbd6654f30bba64693f8121455",
                        timeout: 30,
                        xMsBlobContentType: "foo",
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

public class Test03673 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03673_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03673_s.txt", Encoding.UTF8);

    public Test03673() : base(recordedRequest, recordedResponse, "accounts8d439fea07a85e8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        accountName: "accounts8d439fea07a85e8",
                        container: "containers8191e25b06a746b1b20661258b777a2e",
                        blob: "PageBlob21b2c8922bf24abd85eb87316f3ebec5",
                        timeout: 30,
                        xMsBlobContentType: "foo",
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

public class Test04136 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04136_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04136_s.txt", Encoding.UTF8);

    public Test04136() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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

public class Test04156 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04156_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04156_s.txt", Encoding.UTF8);

    public Test04156() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        blob: "PageBlob8dbee30303564cb1af008e8d157efc92",
                        timeout: 30,
                        leaseId: "c20c8884-9e3a-4410-8ee2-e42c8ad29868",
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

public class Test03665 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03665_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03665_s.txt", Encoding.UTF8);

    public Test03665() : base(recordedRequest, recordedResponse, "accounts8d439fea05682dd")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        accountName: "accounts8d439fea05682dd",
                        container: "containers43a2953c39f9496fbf32c14fdfdd376a",
                        blob: "PageBlob424a31bbd6654f30bba64693f8121455",
                        timeout: 30,
                        xMsBlobContentType: "foo",
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

public class Test04142 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04142_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04142_s.txt", Encoding.UTF8);

    public Test04142() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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

public class Test03680 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03680_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03680_s.txt", Encoding.UTF8);

    public Test03680() : base(recordedRequest, recordedResponse, "accounts8d439fea08fbbbc")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        accountName: "accounts8d439fea08fbbbc",
                        container: "containersf6378b8e47e14abaa8e0fa006fbda2cb",
                        blob: "Blob61ddd08940fa4c6d8c78fbd72a1de613",
                        timeout: 30,
                        xMsBlobContentType: "foo",
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

public class Test04145 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04145_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04145_s.txt", Encoding.UTF8);

    public Test04145() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        leaseId: "7125da00-97de-4d35-99c0-ec343d30de7e",
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

public class Test18416 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18416_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18416_s.txt", Encoding.UTF8);

    public Test18416() : base(recordedRequest, recordedResponse, "accounts8d43a024456e9b0")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        accountName: "accounts8d43a024456e9b0",
                        container: "containers0b3a4dfac8014af2bcc4e8c2ebe69408",
                        blob: "PageBlob7f3997f9d5a344eabaa74bdbeea469d1",
                        timeout: 30,
                        leaseId: "d9706cdb-4d60-4f2d-93d6-716364802dac",
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

public class Test21175 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21175_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21175_s.txt", Encoding.UTF8);

    public Test21175() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "",
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

public class Test21176 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21176_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21176_s.txt", Encoding.UTF8);

    public Test21176() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: Encoding.UTF8.GetString(new byte[]{97,239,191,189,98}),
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

public class Test21177 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21177_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21177_s.txt", Encoding.UTF8);

    public Test21177() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\0b",
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

public class Test21178 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21178_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21178_s.txt", Encoding.UTF8);

    public Test21178() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "ab",
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

public class Test21179 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21179_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21179_s.txt", Encoding.UTF8);

    public Test21179() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "ab",
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

public class Test21180 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21180_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21180_s.txt", Encoding.UTF8);

    public Test21180() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "ab",
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

public class Test21181 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21181_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21181_s.txt", Encoding.UTF8);

    public Test21181() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "ab",
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

public class Test21182 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21182_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21182_s.txt", Encoding.UTF8);

    public Test21182() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "ab",
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

public class Test21183 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21183_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21183_s.txt", Encoding.UTF8);

    public Test21183() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "ab",
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

public class Test21184 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21184_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21184_s.txt", Encoding.UTF8);

    public Test21184() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "ab",
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

public class Test21185 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21185_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21185_s.txt", Encoding.UTF8);

    public Test21185() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "ab",
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

public class Test21189 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21189_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21189_s.txt", Encoding.UTF8);

    public Test21189() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21190 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21190_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21190_s.txt", Encoding.UTF8);

    public Test21190() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21191 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21191_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21191_s.txt", Encoding.UTF8);

    public Test21191() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,a\rb",
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

public class Test21192 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21192_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21192_s.txt", Encoding.UTF8);

    public Test21192() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21193 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21193_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21193_s.txt", Encoding.UTF8);

    public Test21193() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21194 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21194_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21194_s.txt", Encoding.UTF8);

    public Test21194() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21195 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21195_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21195_s.txt", Encoding.UTF8);

    public Test21195() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21196 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21196_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21196_s.txt", Encoding.UTF8);

    public Test21196() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21197 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21197_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21197_s.txt", Encoding.UTF8);

    public Test21197() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21198 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21198_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21198_s.txt", Encoding.UTF8);

    public Test21198() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21199 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21199_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21199_s.txt", Encoding.UTF8);

    public Test21199() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21200 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21200_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21200_s.txt", Encoding.UTF8);

    public Test21200() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21201 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21201_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21201_s.txt", Encoding.UTF8);

    public Test21201() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21202 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21202_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21202_s.txt", Encoding.UTF8);

    public Test21202() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21203 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21203_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21203_s.txt", Encoding.UTF8);

    public Test21203() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21204 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21204_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21204_s.txt", Encoding.UTF8);

    public Test21204() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21205 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21205_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21205_s.txt", Encoding.UTF8);

    public Test21205() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21206 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21206_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21206_s.txt", Encoding.UTF8);

    public Test21206() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21207 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21207_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21207_s.txt", Encoding.UTF8);

    public Test21207() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21208 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21208_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21208_s.txt", Encoding.UTF8);

    public Test21208() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21209 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21209_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21209_s.txt", Encoding.UTF8);

    public Test21209() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: "a\tb,ab",
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

public class Test21400 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21400_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21400_s.txt", Encoding.UTF8);

    public Test21400() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: @"a	b,a b,a!b,a""b,a#b,a$b,a%b,a&b,a'b,a(b,a)b,a*b,a+b,a,b,a-b,a.b,a/b,a0b,a1b,a2b,a3b,a4b,a5b,a6b,a7b,a8b,a9b,a:b,a;b,a<b,a=b,a>b,a?b,a@b,aAb,aBb,aCb,aDb,aEb,aFb,aGb,aHb,aIb,aJb,aKb,aLb,aMb,aNb,aOb,aPb,aQb,aRb,aSb,aTb,aUb,aVb,aWb,aXb,aYb,aZb,a[b,a\b,a]b,a^b,a_b,a`b,aab,abb,acb,adb,aeb,afb,agb,ahb,aib,ajb,akb,alb,amb,anb,aob,apb,aqb,arb,asb,atb,aub,avb,awb,axb,ayb,azb,a{b,a|b,a}b,a~b,ab",
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

public class Test21401 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21401_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21401_s.txt", Encoding.UTF8);

    public Test21401() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
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
                        xMsBlobContentLanguage: Encoding.UTF8.GetString(new byte[]{97,9,98,44,97,32,98,44,97,33,98,44,97,34,98,44,97,35,98,44,97,36,98,44,97,37,98,44,97,38,98,44,97,39,98,44,97,40,98,44,97,41,98,44,97,42,98,44,97,43,98,44,97,44,98,44,97,45,98,44,97,46,98,44,97,47,98,44,97,48,98,44,97,49,98,44,97,50,98,44,97,51,98,44,97,52,98,44,97,53,98,44,97,54,98,44,97,55,98,44,97,56,98,44,97,57,98,44,97,58,98,44,97,59,98,44,97,60,98,44,97,61,98,44,97,62,98,44,97,63,98,44,97,64,98,44,97,65,98,44,97,66,98,44,97,67,98,44,97,68,98,44,97,69,98,44,97,70,98,44,97,71,98,44,97,72,98,44,97,73,98,44,97,74,98,44,97,75,98,44,97,76,98,44,97,77,98,44,97,78,98,44,97,79,98,44,97,80,98,44,97,81,98,44,97,82,98,44,97,83,98,44,97,84,98,44,97,85,98,44,97,86,98,44,97,87,98,44,97,88,98,44,97,89,98,44,97,90,98,44,97,91,98,44,97,92,98,44,97,93,98,44,97,94,98,44,97,95,98,44,97,96,98,44,97,97,98,44,97,98,98,44,97,99,98,44,97,100,98,44,97,101,98,44,97,102,98,44,97,103,98,44,97,104,98,44,97,105,98,44,97,106,98,44,97,107,98,44,97,108,98,44,97,109,98,44,97,110,98,44,97,111,98,44,97,112,98,44,97,113,98,44,97,114,98,44,97,115,98,44,97,116,98,44,97,117,98,44,97,118,98,44,97,119,98,44,97,120,98,44,97,121,98,44,97,122,98,44,97,123,98,44,97,124,98,44,97,125,98,44,97,126,98,44,97,239,191,189,98}),
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
