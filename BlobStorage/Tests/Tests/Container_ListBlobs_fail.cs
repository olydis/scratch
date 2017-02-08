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

public class Test001292 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001292_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001292_s.txt", Encoding.UTF8);

    public Test001292() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc7af05eb93fa04815a478675b009858ea",
                        delimiter: "/",
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

public class Test001300 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001300_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001300_s.txt", Encoding.UTF8);

    public Test001300() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc7af05eb93fa04815a478675b009858ea",
                        delimiter: "/",
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

public class Test001188 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001188_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001188_s.txt", Encoding.UTF8);

    public Test001188() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcd1d1e8c1479748a7acad9071420d7879",
                        delimiter: "/",
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

public class Test001476 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001476_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001476_s.txt", Encoding.UTF8);

    public Test001476() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc1f2cfd35c042487ca2db2a283798114f",
                        delimiter: "/",
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

public class Test001185 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001185_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001185_s.txt", Encoding.UTF8);

    public Test001185() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcd1d1e8c1479748a7acad9071420d7879",
                        delimiter: "/",
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

public class Test00200 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00200_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00200_s.txt", Encoding.UTF8);

    public Test00200() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers3adaac58de1f470d83842275e8c70712",
                        include: "snapshots,uncommittedblobs,metadata,copy",
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

public class Test00199 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00199_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00199_s.txt", Encoding.UTF8);

    public Test00199() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers3adaac58de1f470d83842275e8c70712",
                        include: "snapshots,uncommittedblobs,metadata,copy",
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

public class Test00194 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00194_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00194_s.txt", Encoding.UTF8);

    public Test00194() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers3adaac58de1f470d83842275e8c70712",
                        include: "snapshots,uncommittedblobs,metadata,copy",
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

public class Test00196 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00196_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00196_s.txt", Encoding.UTF8);

    public Test00196() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers3adaac58de1f470d83842275e8c70712",
                        include: "snapshots,uncommittedblobs,metadata,copy",
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

public class Test001473 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001473_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001473_s.txt", Encoding.UTF8);

    public Test001473() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testc1f2cfd35c042487ca2db2a283798114f",
                        delimiter: "/",
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

public class Test00195 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00195_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00195_s.txt", Encoding.UTF8);

    public Test00195() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers3adaac58de1f470d83842275e8c70712",
                        include: "snapshots,uncommittedblobs,metadata,copy",
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

public class Test00193 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00193_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00193_s.txt", Encoding.UTF8);

    public Test00193() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers3adaac58de1f470d83842275e8c70712",
                        include: "snapshots,uncommittedblobs,metadata,copy",
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

public class Test00198 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00198_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00198_s.txt", Encoding.UTF8);

    public Test00198() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers3adaac58de1f470d83842275e8c70712",
                        include: "snapshots,uncommittedblobs,metadata,copy",
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

public class Test00197 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00197_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00197_s.txt", Encoding.UTF8);

    public Test00197() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers3adaac58de1f470d83842275e8c70712",
                        include: "snapshots,uncommittedblobs,metadata,copy",
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

public class Test17820 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17820_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17820_s.txt", Encoding.UTF8);

    public Test17820() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersc9cecafee49646feb888b876174c377b",
                        marker: "something",
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

public class Test17821 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17821_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17821_s.txt", Encoding.UTF8);

    public Test17821() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersc9cecafee49646feb888b876174c377b",
                        delimiter: "",
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

public class Test17822 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17822_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17822_s.txt", Encoding.UTF8);

    public Test17822() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersc9cecafee49646feb888b876174c377b",
                        prefix: "prefix",
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

public class Test17823 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17823_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17823_s.txt", Encoding.UTF8);

    public Test17823() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersc9cecafee49646feb888b876174c377b",
                        marker: "",
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

public class Test17824 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17824_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17824_s.txt", Encoding.UTF8);

    public Test17824() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersc9cecafee49646feb888b876174c377b",
                        delimiter: "1234dfgdgxyz",
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

public class Test17830 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17830_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17830_s.txt", Encoding.UTF8);

    public Test17830() : base(recordedRequest, recordedResponse, "accounts8d43a0239b372e6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "accounts8d43a0239b372e6",
                        container: "containers0283955ff35348eba2a260d75ebc2f92",
                        marker: Encoding.UTF8.GetString(new byte[]{230,188,162,229,173,151,230,177,137,229,173,151,233,184,161}),
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

public class Test17804 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17804_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17804_s.txt", Encoding.UTF8);

    public Test17804() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers55558a633e4c44bdb012cf549e770366",
                        marker: Encoding.UTF8.GetString(new byte[]{50,33,49,48,56,33,77,68,65,119,77,68,77,50,73,85,74,115,98,50,73,120,89,84,108,104,77,71,77,119,79,84,81,50,78,71,85,48,78,68,103,52,79,68,77,50,89,106,78,109,77,71,78,107,77,87,74,104,90,84,100,106,90,67,69,119,77,68,65,119,118,239,191,189,103,104,79,84,107,53,79,83,48,120,77,105,48,122,77,86,81,121,77,122,111,49,79,84,111,49,79,83,52,53,79,84,107,53,79,84,107,53,87,105,69,45}),
                        maxresults: 5,
                        include: "snapshots,uncommittedblobs,metadata,copy",
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

public class Test17807 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17807_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17807_s.txt", Encoding.UTF8);

    public Test17807() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers22d1f48ddee64b53b273a2ab6a7bda3e",
                        maxresults: -1,
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

public class Test17808 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17808_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17808_s.txt", Encoding.UTF8);

    public Test17808() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers22d1f48ddee64b53b273a2ab6a7bda3e",
                        maxresults: 0,
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

public class Test17834 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17834_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17834_s.txt", Encoding.UTF8);

    public Test17834() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "cd9d014e3bad490383fac086f0de4bf5",
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

public class Test17811 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17811_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17811_s.txt", Encoding.UTF8);

    public Test17811() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers22d1f48ddee64b53b273a2ab6a7bda3e",
                        include: "snapshotscopy",
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

public class Test17812 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17812_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17812_s.txt", Encoding.UTF8);

    public Test17812() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers22d1f48ddee64b53b273a2ab6a7bda3e",
                        delimiter: "/",
                        include: "snapshots",
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

public class Test17816 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17816_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17816_s.txt", Encoding.UTF8);

    public Test17816() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbd37674aa1dd4537917dfc906bb46ee5",
                        marker: Encoding.UTF8.GetString(new byte[]{50,33,49,48,56,33,77,68,65,119,77,68,77,50,73,85,74,115,98,50,73,120,89,84,108,104,77,71,77,119,79,84,81,50,78,71,85,48,78,68,103,52,79,68,77,50,89,106,78,109,77,71,78,107,77,87,74,104,90,84,100,106,90,67,69,119,77,68,65,119,118,239,191,189,103,104,79,84,107,53,79,83,48,120,77,105,48,122,77,86,81,121,77,122,111,49,79,84,111,49,79,83,52,53,79,84,107,53,79,84,107,53,87,105,69,45}),
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

public class Test19800 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19800_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19800_s.txt", Encoding.UTF8);

    public Test19800() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersca5d4c83935e446685d5061cc13200d9",
                        prefix: "TestTest",
                        include: "snapshots,uncommittedblobs,metadata,copy",
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

public class Test19801 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19801_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19801_s.txt", Encoding.UTF8);

    public Test19801() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.ListBlobsWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersca5d4c83935e446685d5061cc13200d9",
                        prefix: "TestTest",
                        include: "snapshots,uncommittedblobs,metadata,copy",
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
