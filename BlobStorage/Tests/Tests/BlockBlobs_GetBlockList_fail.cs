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

public class Test00388 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00388_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00388_s.txt", Encoding.UTF8);

    public Test00388() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers37afee7d4d91492090561cc9aca17d2e",
                        blob: "Blob2639ea91ab244be1a7aec80cfc3451be",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test00386 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00386_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00386_s.txt", Encoding.UTF8);

    public Test00386() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers37afee7d4d91492090561cc9aca17d2e",
                        blob: "Blob2639ea91ab244be1a7aec80cfc3451be",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test00384 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00384_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00384_s.txt", Encoding.UTF8);

    public Test00384() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers37afee7d4d91492090561cc9aca17d2e",
                        blob: "Blob2639ea91ab244be1a7aec80cfc3451be",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test00389 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00389_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00389_s.txt", Encoding.UTF8);

    public Test00389() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers37afee7d4d91492090561cc9aca17d2e",
                        blob: "Blob2639ea91ab244be1a7aec80cfc3451be",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test00383 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00383_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00383_s.txt", Encoding.UTF8);

    public Test00383() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers37afee7d4d91492090561cc9aca17d2e",
                        blob: "Blob2639ea91ab244be1a7aec80cfc3451be",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test00387 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00387_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00387_s.txt", Encoding.UTF8);

    public Test00387() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers37afee7d4d91492090561cc9aca17d2e",
                        blob: "Blob2639ea91ab244be1a7aec80cfc3451be",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test00382 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00382_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00382_s.txt", Encoding.UTF8);

    public Test00382() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers37afee7d4d91492090561cc9aca17d2e",
                        blob: "Blob2639ea91ab244be1a7aec80cfc3451be",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test00385 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00385_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00385_s.txt", Encoding.UTF8);

    public Test00385() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers37afee7d4d91492090561cc9aca17d2e",
                        blob: "Blob2639ea91ab244be1a7aec80cfc3451be",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test00898 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00898_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00898_s.txt", Encoding.UTF8);

    public Test00898() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers504be5e4792646d4a19fd8e81066b7d0",
                        blob: "Blob021c8f139c024479969b11b1000f5c07",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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
