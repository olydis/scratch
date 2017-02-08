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

public class Test07293 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07293_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07293_s.txt", Encoding.UTF8);

    public Test07293() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers649c1296d04b4000a4d7786dec1fcbdd",
                        blob: "Blob57041643aa374a7391075d1a08a0d696",
                        copySource: "http://127.0.0.1:10004/testaccount1/share6cfb0a7b0c7847789c56b0bed7b6e01e/Fileab6" +
    "108f64fda4f9b9a33fedbcdb93cc9",
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

public class Test07356 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07356_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07356_s.txt", Encoding.UTF8);

    public Test07356() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa01591e0c91e4116ad76e20a6324c3b7",
                        blob: "Blob127182b068ac4b0897871fbea340a5fd",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containersfbf39813a8e34e37905ce623ad2f8a34/Blob930a0e4b5ac24ff6a26e95329d04a04c?snapshot=2017-01-11T08%3A57%3A45.7575432Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=%2FvbUL6dFXYCBiDHg7%2B6ezfM9ywsFqdKkGIFZ3LWd1zE%3D&timeout=30",
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

public class Test07389 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07389_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07389_s.txt", Encoding.UTF8);

    public Test07389() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerse9e1b7c61beb4c45a4d5a4d8bf3925fc",
                        blob: "Blob8b289259747944da88f471a967597c03",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers25969a209e734f2999595e738b9ea050/Blobea3dd1894e7f4a6caad60a8b0d947b05?snapshot=2017-01-11T08%3A58%3A03.5390325Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=Yo8ivPw5oQ%2FXMKYK6aVVyN8lK2QJEFO4j7zLyo5s0cg%3D&timeout=30",
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

public class Test07311 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07311_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07311_s.txt", Encoding.UTF8);

    public Test07311() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers58cea56898634547a34c635fa440ecb1",
                        blob: "Blobda6e70ff77a54410b03cc398c0a788c0",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers60f18c04edc44f72a41cdc7c2ba048a4/Blob58070cf91b1b4265bd461b510528115a?snapshot=2017-01-11T08%3A57%3A38.6123432Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=SNFNn%2FF1W%2FjyHMIWBkTSXrGv19L%2FW%2FgeAaGDBRLN%2Byg%3D&timeout=30",
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

public class Test07280 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07280_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07280_s.txt", Encoding.UTF8);

    public Test07280() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa3c6687f6bc84891b8ebd677a86f7f87",
                        blob: "Blob9d8769bef55c46dd94a51f950debc723",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containerse8365f2936864df2a8691bd89ab" +
    "fb99f/Blob6d708721361240af84d2f09cd2df2714?se=9999-12-31T23%3A59%3A59.9999999Z&s" +
    "v=2016-05-31&sr=c&sp=r&sig=W%2FG1GfatgCTL0te3TIttUQKpHezaB22O81%2FWTniz7uc%3D&ti" +
    "meout=30",
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

public class Test07470 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07470_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07470_s.txt", Encoding.UTF8);

    public Test07470() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa94a572fc4f34411935588fd4089a11f",
                        blob: "Blob8564b30f885e45ba9546d17fed8731af",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers530ff8a779eb480d879472419854d4f9/Blobfe3f07eb29c246faba23f8928899d8c1?snapshot=2017-01-11T08%3A58%3A26.6036693Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=ofEY8XiWlB5TIBeZwXzZUGa1SO9ZJqXWhR0%2FzAkeDXk%3D&timeout=30",
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

public class Test07407 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07407_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07407_s.txt", Encoding.UTF8);

    public Test07407() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers0fa43d0060274c1d844edf7c94008792",
                        blob: "Blobcafd1583143141e7b50439647d059326",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers4782d74409654103821f55656baf0596/Blob9b7c878f3b624f818e193e3dcc6f85e0?snapshot=2017-01-11T08%3A58%3A08.1101591Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=rwd&sig=q06Fl%2BFcHyHXV8Oc4i9tWoeSCF3CI4CpfVMNkRdItZk%3D&timeout=30",
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

public class Test07441 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07441_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07441_s.txt", Encoding.UTF8);

    public Test07441() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb7a7c09b48db440abe2183fbf271f846",
                        blob: "Blobe962a6b87f324e3987a7a0dea162e270",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containersda15a66da56f451a85a3d555ea04e04b/Blobef7a23955e9e4c02864242c7d98cbd07?snapshot=2017-01-11T08%3A58%3A17.7024242Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=fgI9N9dJGqq4CJJ1e9YojlP5wzMU2En%2FsqWfdVm%2F0Yc%3D&timeout=30",
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

public class Test07302 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07302_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07302_s.txt", Encoding.UTF8);

    public Test07302() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb2cbbbba827d4a70938d8bf6b2b7af76",
                        blob: "Blobf0bd47d684ea4d8ca39ccc4e248a3293",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers2eab493c0ee74365bc2d3610b35bea40/Blob02c96064d6e04e00b478ef73b0ae68e1?snapshot=2017-01-11T08%3A57%3A38.3143362Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=8B9WyjmOhiPCpCt4ahRzeQj0Ymyln33%2BI4Py0pAY%2FEE%3D&timeout=30",
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

public class Test07331 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07331_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07331_s.txt", Encoding.UTF8);

    public Test07331() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersc6d10b18e2b94b1db15feca9259390ff",
                        blob: "Blob9452cff5a2634bc7a0c3ccf88d3fa078",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers71fb05a899f949cea2806b027206e89f/Blob185ace34e7d143a2ab3783504372ff0b?snapshot=2017-01-11T08%3A57%3A39.1403612Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=7qgRCUpISo4Uj5JMnYIw3iInBS6lBQoeTp8LT%2FqYjB4%3D&timeout=30",
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

public class Test07284 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07284_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07284_s.txt", Encoding.UTF8);

    public Test07284() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers252580f4d4e845cab12ba964158d028f",
                        blob: "Blob1b311829a1684017ba10de2d16df70ad",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containerse8365f2936864df2a8691bd89abfb99f/Blob6d708721361240af84d2f09cd2df2714?se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=W%2FG1GfatgCTL0te3TIttUQKpHezaB22O81%2FWTniz7uc%3D&timeout=30&snapshot=1%2F11%2F2017%208%3A57%3A37%20AM",
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

public class Test07271 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07271_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07271_s.txt", Encoding.UTF8);

    public Test07271() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers8e13afe92955438c9bdffa9989fbbc97",
                        blob: "Blob578514365f14436c98aa5f01d9181acb",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers2dc2702ecf564c01af0cc88b4680f4a6/Blob0291c2c7229f433faab212836d0c9cd8?snapshot=2017-01-11T08%3A57%3A37.5013136Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=psMuUx0Ny0xmrp1JK7V1%2BU6wxMvSYJndWDZ8jIOFKtE%3D&timeout=30",
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

public class Test07290 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07290_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07290_s.txt", Encoding.UTF8);

    public Test07290() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers7055395fb6a849eebaf377a1b9e9be32",
                        blob: "Blobe6df3f8a31e744c3acdc925b3980c0c6",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersb9da998b882f4b2e925cd077dc4" +
    "e345b/Blobf96ede4d52ed4f8e87102bea2d7e65d4",
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

public class Test07398 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07398_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07398_s.txt", Encoding.UTF8);

    public Test07398() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers61c8323a20d64c118b4d43230580a38d",
                        blob: "Blob2a85a796d28e47609617f10d5ea0f550",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers019379b3e01843d0839b42822805568d/Blobfe5e412e2838467ab5e78261661e74e3?snapshot=2017-01-11T08%3A58%3A05.8290961Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=vbY31Czbb%2B40fDF3qTfKo25GKpeO3eGCwpjkhFnXbAw%3D&timeout=30",
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

public class Test07320 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07320_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07320_s.txt", Encoding.UTF8);

    public Test07320() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers17e427c9f979454793f0d6b1e12577a1",
                        blob: "Blobb3178ab408104abc962ed2b7e2d76b4d",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containersb5a04df0973c4e90acae5cf6ed8abce1/Blob0e136893692c411892e24eade5cf3152?snapshot=2017-01-11T08%3A57%3A38.9183529Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=4lwbIgoDDB4eFXV3%2BagRRF%2BvK5LawSVtViKcZfp%2FhtU%3D&timeout=30",
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

public class Test07416 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07416_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07416_s.txt", Encoding.UTF8);

    public Test07416() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers16118c29c57b4e14ac8a3fd3ef374877",
                        blob: "Blobb2478bf32dc9405eb9f0db87d90c9b87",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers0c847cd992944189a2907aba4bf18202/Blobe23705c6519049bd8095edbbdbddf6d0?snapshot=2017-01-11T08%3A58%3A10.3662208Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=mKmzJNnSCoucrstz9Gd0TrQ7qEAbPE0deAseP9mTt3E%3D&timeout=30",
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

public class Test07450 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07450_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07450_s.txt", Encoding.UTF8);

    public Test07450() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersf89fc38bdaf341b5916dd83a062160b9",
                        blob: "Blob648709a490044b73a058416d7abb95b1",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers8015ef2176cc485d81d4cee033f14985/Blob1f49fcc8eb1d40a693c04d2bb6ded4e7?snapshot=2017-01-11T08%3A58%3A22.0135407Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=sEE6OecDMXJPFJffYZO2Bmcs1QFLPMLnQgmOLgxgkL4%3D&timeout=30",
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

public class Test07343 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07343_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07343_s.txt", Encoding.UTF8);

    public Test07343() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers326918967ec34869a688b2a82675d62c",
                        blob: "Blobbeeaf2ab822646959ee2529382396489",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containersb9a4bfa207bc4540b972b789fe08be35/Blobdf72940464b247d79112f7cac044f723?snapshot=2017-01-11T08%3A57%3A41.4324234Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=qyuCdk9quab5bsYenwFJzG0vu99CEp9SAw1%2FE2ytwms%3D&timeout=30",
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

public class Test07427 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07427_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07427_s.txt", Encoding.UTF8);

    public Test07427() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9bd3add3f1bd43a7bcd7beb8e37e46e1",
                        blob: "Blob0926d5ad95784d76bd139a74ff62cd6c",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers0cc71fe325eb446f9cdbd58e490e66b9/Blobd14a9ef9fc314853acf1050d1c6724e1?snapshot=2017-01-11T08%3A58%3A12.6092842Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=MAFABpnean7iY8Pimnfhco6LadXLfbY9%2FhOMzPfmo9s%3D&timeout=30",
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

public class Test07461 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07461_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\07461_s.txt", Encoding.UTF8);

    public Test07461() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.PageBlobs.IncrementalCopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers85c901b4523741e1bc0a94e4e2db154b",
                        blob: "Blobe8c8f2a455764b8294dd098240012e13",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers7e9246b9f0814c619a4883bb37e5f16c/Blob82867a06ab504dbbb4ef05ed826dd0c3?snapshot=2017-01-11T08%3A58%3A24.2986100Z&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=un9MD7BrURSEFRcRtUVQHNFGnyYDbCa%2BwMRY1VWbRws%3D&timeout=30",
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
