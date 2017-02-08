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

public class Test00333 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00333_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00333_s.txt", Encoding.UTF8);

    public Test00333() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa179b3f47c19489d9291c1ddfd9ab033",
                        blob: "Blob92cb140558eb4625b5f32116936266c6",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersa179b3f47c19489d9291c1ddfd9" +
    "ab033/Blobf4c3dd7f86ff4e16a64b68a4712b6dc7?se=2017-01-11T09%3A43%3A33.4300164Z&s" +
    "v=2016-05-31&sr=c&sp=rwd&sig=dRZLuTPWITrYFpZNwb9kG%2FIFVTKnaiEn13wyPRgSy%2BA%3D&" +
    "timeout=30",
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

public class Test00339 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00339_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00339_s.txt", Encoding.UTF8);

    public Test00339() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersfdc07298c9d54dd48b9c2e9cdb75e855",
                        blob: "Blobae05dd080d1c41c7a6bfeab82eae3830",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersfdc07298c9d54dd48b9c2e9cdb7" +
    "5e855/Blob9009a33db5734779a5875a6f7702fcf5?se=2017-01-11T09%3A43%3A33.5940199Z&s" +
    "v=2016-05-31&sr=c&sp=rwd&sig=XKZi%2FnzbB6ASrOyp3eh%2FMHWRlNx1IEPOKzlpAIa5K8o%3D&" +
    "timeout=30",
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

public class Test00979 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00979_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00979_s.txt", Encoding.UTF8);

    public Test00979() : base(recordedRequest, recordedResponse, "accounts8d439fdf9df5a12")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fdf9df5a12",
                        container: "containersdbd4ee155f9b4eff85f44bab99375d92",
                        blob: "Blob45877eba03af4346b807f3a7fe1d8d97",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439fdf9df5a12/containersc7981876da914919aebd4df77b5d22a9/Blob855f220d0cb54ba495d0ea8c515f8360?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=LtgTHZwonAe0rn5ZJrAoTVfXCB63MtKkQO%2FijOXMrKI%3D&timeout=30",
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

public class Test00988 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00988_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00988_s.txt", Encoding.UTF8);

    public Test00988() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers46b8a2b902a342318f6b9f7eb80c5ca5",
                        blob: "Blobca2a4b66d521412c80b3df8e45ad8c25",
                        copySource: "https://non-existing-host-name-for-copy-blob-test.com",
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

public class Test00950 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00950_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00950_s.txt", Encoding.UTF8);

    public Test00950() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers90130160ec2f4f3da34c2db5d3e1cf98",
                        blob: "Blob33eaab27d18f4054900035dff338bf01",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers90130160ec2f4f3da34c2db5d3e" +
    "1cf98/Blob33eaab27d18f4054900035dff338bf01",
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

public class Test00982 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00982_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00982_s.txt", Encoding.UTF8);

    public Test00982() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers47e5187fed9145e0b58f1b68b267a99a",
                        blob: "Blob60b481d561c14078855392df29fb5336",
                        copySource: "http://127.0.0.6:10000/test/%01abc/test_file",
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

public class Test00958 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00958_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00958_s.txt", Encoding.UTF8);

    public Test00958() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersd1b2abc148c04ce1b3d1b8c1fd7c4690",
                        blob: "Blobefd2bd88b6bc47d485b910f75fa008f8",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers4c448ec68435452985538526880" +
    "b5050/Blob3cff3dfce82a43bbbfd508e80e515917",
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

public class Test01172 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01172_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01172_s.txt", Encoding.UTF8);

    public Test01172() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9cfb9a08d9a2469babbc82e438629212",
                        blob: "AppendBlobfaaaf8b12d944c9d9d67177c1ba3d044",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersf1ff2a1ccdb64bc2bf6ca23be6a" +
    "95f82/AppendBlobb47c494e7aa94b1f8883e76c244dc3dc",
                        timeout: 30,
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

public class Test01013 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01013_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01013_s.txt", Encoding.UTF8);

    public Test01013() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersba6d0a4970b94063b83a1e833bdafa13",
                        blob: "Blob620cf52554a240159c5987f1eca13f06",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersba6d0a4970b94063b83a1e833bd" +
    "afa13/Blob620cf52554a240159c5987f1eca13f06?snapshot=2017-01-11T08%3A43%3A58.5917" +
    "093Z",
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

public class Test00945 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00945_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00945_s.txt", Encoding.UTF8);

    public Test00945() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerse4d7bf55cc904ef8a1adc81dd969bf7a",
                        blob: "Blob984fb7d9f36a490d8e059c2ae77ee6e8",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersa495df775cff474483b26014eb6" +
    "9d1b9/Blob70272fe4f7ac4ae795c83b4c446d926e?snapshot=2017-01-11T08%3A43%3A54.3905" +
    "933Z",
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

public class Test00985 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00985_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00985_s.txt", Encoding.UTF8);

    public Test00985() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers99759d04e27345a2b87be8b8cd543a56",
                        blob: "Blob39a01cddae1b406c81164e31b83392e3",
                        copySource: "http://127.0.0.6:10000/%01abc/test/test_file",
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

public class Test01208 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01208_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01208_s.txt", Encoding.UTF8);

    public Test01208() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers55d2d6b0305a4fa2adc57f74340abfc6",
                        blob: "AppendBlob1ca02d3420174ea28aa544f1f8962c7f",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containerscfeb54ee637a4456bf7cd57dca2" +
    "bb73d/AppendBloba3a52f01ddd84753b33c891e4f4e8a7f",
                        timeout: 30,
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

public class Test00967 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00967_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00967_s.txt", Encoding.UTF8);

    public Test00967() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers50811d49dfbc42afb40b4c3f741eb090",
                        blob: "Blobd832cc15c6c04632a5abffc17d848f40",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers00632d8b71ae405d9cadf15dec9" +
    "c2499/Blobeef22c146a9745508531d66122a92387",
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

public class Test01827 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01827_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01827_s.txt", Encoding.UTF8);

    public Test01827() : base(recordedRequest, recordedResponse, "accounts8d439fe89c40077")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe89c40077",
                        container: "containers3bed37975cd54d07938d66c38ae4e93a",
                        blob: "Blobe858efe612af4d88b4dd4cd272e21223",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe89c40077/containerseea9abfc3192424bb22ba41ca0ad6945/Blob006a286f6ead4efb9e82317b150187bc?se=2017-01-11T10%3A47%3A56.3772728Z&sv=2016-05-31&sr=c&sp=rwd&sig=RQK64ZZfzJ64Dz32OERIbKWJ%2ByR63JzveiIMwKMo7y8%3D&timeout=30",
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

public class Test01018 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01018_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01018_s.txt", Encoding.UTF8);

    public Test01018() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersc0be6edae9204ea68f5d6dd798627503",
                        blob: "Blob93ace1eb2302440a9431ad547c3f7033",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersc0be6edae9204ea68f5d6dd7986" +
    "27503/Blob7f46260bdddb45cebe13bd2b6cbfa2a6",
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

public class Test01156 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01156_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01156_s.txt", Encoding.UTF8);

    public Test01156() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersdfb625f2345e4fefba5baae14be3827d",
                        blob: "AppendBlob133a7026c7ff456db978bc3cc475b1eb",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers265fbc0ea9ad4f219b7b6db4ae7" +
    "cb474/AppendBlob93efbda37b9e4dfdb307c515bbedea1e",
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

public class Test02035 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02035_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02035_s.txt", Encoding.UTF8);

    public Test02035() : base(recordedRequest, recordedResponse, "accounts8d439fe8c57a81b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8c57a81b",
                        container: "containers8155d4b475ad4d289c3aa5da31034d59",
                        blob: "Bloba49833cebdbc49d09587aa170717e896",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8c5d9b90/containers756676db121d47f495c2cd1b2150a4cb/Blob277fcb007d3f4c8eac5c87a529e34c26?se=2017-01-11T10%3A48%3A00.6763989Z&sv=2016-05-31&sr=c&sp=rwd&sig=OiZVaHMl19uSdScX55ReBl8ihhiCluzQXQbEilVZrJE%3D&timeout=30",
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

public class Test02139 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02139_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02139_s.txt", Encoding.UTF8);

    public Test02139() : base(recordedRequest, recordedResponse, "accounts8d439fe8dc878cd")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8dc878cd",
                        container: "containers8b9024c762fc4e2a8fb7a5d2de73e9e1",
                        blob: "Blob100ab6ed34414a4f9b96bd0a8388886f",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8dc2101a/containers86608554e36e4bb398ca2d80770bce51/Blob1ee6927377b349c893b2b046277140b9?se=2017-01-11T10%3A48%3A03.0694589Z&sv=2016-05-31&sr=c&sp=rwd&sig=Hnf9F2N%2F%2Bs5ke3sV5qgp4u1FBtTwPDdLDOFhxR1mMiw%3D&timeout=30",
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

public class Test02211 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02211_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02211_s.txt", Encoding.UTF8);

    public Test02211() : base(recordedRequest, recordedResponse, "accounts8d439fe8ede096b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8ede096b",
                        container: "containers6126f906ea274091978b00f8d5427a80",
                        blob: "Blob909e6898185f4ac0936014f36cabae50",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8ed11103/containersb2dcf69d786b4f1790b2c40f5c891b80/Blob5afe7e9b3db94087bd3021aa33c71cc5?se=2017-01-11T10%3A48%3A04.8805082Z&sv=2016-05-31&sr=c&sp=rwd&sig=qCNkndttgyYGjZ%2BPzhe5j2RnC9Q5gbqaK9EtxOPaiVU%3D&timeout=30",
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

public class Test01782 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01782_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01782_s.txt", Encoding.UTF8);

    public Test01782() : base(recordedRequest, recordedResponse, "accounts8d439fe894161c9")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe894161c9",
                        container: "containersea69e03e3a804ea8bb19cb778f32f016",
                        blob: "Blob9c9e64920c274a9284260d49636cbc31",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe894161c9/containersb2ca6bac504140db968edf509a075b9f/Blob5a016b3f8f074e57a11edab8def03c45?se=2017-01-11T10%3A47%3A55.4582511Z&sv=2016-05-31&sr=c&sp=rwd&sig=mjY5a80%2FVav81F%2FRGz2w7gNSaKoh%2FSCE3iCOuBXoTIU%3D&timeout=30",
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

public class Test01854 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01854_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01854_s.txt", Encoding.UTF8);

    public Test01854() : base(recordedRequest, recordedResponse, "accounts8d439fe8a1443a4")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8a1443a4",
                        container: "containers7a7a99d1c1244b02af1bab085b40a9c9",
                        blob: "Blob1dea9c5c61f94ffaa4e9f359af3218dd",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8a1443a4/containers2758a2e1140142959ac693f862b1c9ac/Blob1ccd510801c247f68737c526deee4e53?se=2017-01-11T10%3A47%3A56.8342854Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2BaKo6rNvFdgWJp85g75%2BkbO8ApjnuilNfwlbkgIuI1U%3D&timeout=30",
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

public class Test01773 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01773_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01773_s.txt", Encoding.UTF8);

    public Test01773() : base(recordedRequest, recordedResponse, "accounts8d439fe89137393")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe89137393",
                        container: "containers2e966582d2264d2091c54f86c9d0bc55",
                        blob: "Blobb218b38416a241ac964fcdba9db75f5c",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe89137393/containers27b4363f584f481c9e77b9687c4d30c2/Blob8564fdd9f00b45718c2463fb0471b11f?se=2017-01-11T10%3A47%3A55.2852435Z&sv=2016-05-31&sr=c&sp=rwd&sig=TiZhWBqnDO2rn1Vnl%2F6pNZIMIhLU9V7z2AmkRL3HLik%3D&timeout=30",
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

public class Test01908 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01908_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01908_s.txt", Encoding.UTF8);

    public Test01908() : base(recordedRequest, recordedResponse, "accounts8d439fe8ab45558")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8ab45558",
                        container: "containersa6de70bbbcb84916a568077ece73d3d6",
                        blob: "Blob82308019e681476ea1d5699577132bb5",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8ab45558/containersb75fbd6a587b4f799d742927d317485d/Blob3db15a66f45e4c8f8e8bdb9b67e9681d?se=2017-01-11T10%3A47%3A57.8753136Z&sv=2016-05-31&sr=c&sp=rwd&sig=J7tyS7%2B3es6RqbIA1%2BusuhXDqdqaqWF%2BxONLxmGeDMs%3D&timeout=30",
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

public class Test01836 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01836_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01836_s.txt", Encoding.UTF8);

    public Test01836() : base(recordedRequest, recordedResponse, "accounts8d439fe89e62e7a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe89e62e7a",
                        container: "containersbf3672e71d3d44d681bcdb9633f41a00",
                        blob: "Blob01e0110dca744d9a881c2ce7f677f526",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe89e62e7a/containers0675c4751feb4e379ec0db8ea31d41ac/Blob12b77d69a1c04ed09583fb7c039150d6?se=2017-01-11T10%3A47%3A56.5342846Z&sv=2016-05-31&sr=c&sp=rwd&sig=APBaOiGEYglXEpZo06UZz7bpuZlCMI9FG9G6mLTo5TE%3D&timeout=30",
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

public class Test01932 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01932_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01932_s.txt", Encoding.UTF8);

    public Test01932() : base(recordedRequest, recordedResponse, "accounts8d439fe8af9ea95")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8af9ea95",
                        container: "containersa1c704d7d6534159be892d659ee13b59",
                        blob: "Blob9f2cb2efe8074d50a18f165b603cd0f0",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8af9ea95/containersa1c704d7d6534159be892d659ee13b59/Blob9f2cb2efe8074d50a18f165b603cd0f0?se=2017-01-11T10%3A47%3A58.3493291Z&sv=2016-05-31&sr=c&sp=rwd&sig=Q27UZIN%2BQdgFqBOes%2FqTgbRTw6lUrZbxHBkVyVPpk9g%3D&snapshot=2017-01-11T08%3A47%3A58.3123322Z&timeout=30",
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

public class Test01940 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01940_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01940_s.txt", Encoding.UTF8);

    public Test01940() : base(recordedRequest, recordedResponse, "accounts8d439fe8b131815")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8b131815",
                        container: "containers78ec1779071646f1992e1b174875d195",
                        blob: "Bloba8ca946124d7447a88804038c2bd710b",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8b131815/containers78ec1779071646f1992e1b174875d195/Bloba8ca946124d7447a88804038c2bd710b?se=2017-01-11T10%3A47%3A58.5113392Z&sv=2016-05-31&sr=c&sp=rwd&sig=T8YfSqzJv18dfigHu7KRQ7T8k5JEjTJ7mYgA%2FnMsQd4%3D&snapshot=2017-01-11T08%3A47%3A58.4773374Z&timeout=30",
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

public class Test01791 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01791_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01791_s.txt", Encoding.UTF8);

    public Test01791() : base(recordedRequest, recordedResponse, "accounts8d439fe8959cc01")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8959cc01",
                        container: "containers137b3d72db6f4156a889677c3b52433c",
                        blob: "Blobf83d6957b58540238d1c68206f0ad606",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8959cc01/containerse65b801cf0ff4552b9c5f8100b29281f/Blob4c4edefff76d4485b6e35469015202e1?se=2017-01-11T10%3A47%3A55.6172518Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2Bpr9yRGUQGeEXVAuvy6TxcraN6jFsgUPe0QExlp7uNo%3D&timeout=30",
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

public class Test02068 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02068_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02068_s.txt", Encoding.UTF8);

    public Test02068() : base(recordedRequest, recordedResponse, "accounts8d439fe8ccf49d5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8ccf49d5",
                        container: "containers706480c662724d4992820b388bb70103",
                        blob: "Blob7d946af495924930802936ef9e3c30d4",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8cd675f8/containers064527c16f8e44529b3c797fb9de8f93/Blob3928592a93c7466ea470576797e597bd?se=2017-01-11T10%3A48%3A01.4674145Z&sv=2016-05-31&sr=c&sp=rwd&sig=FeLqwGw%2FdyhXA8fz%2FNIrMzHGKReCOsZl2to7EMwJwA0%3D&timeout=30",
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

public class Test02052 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02052_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02052_s.txt", Encoding.UTF8);

    public Test02052() : base(recordedRequest, recordedResponse, "accounts8d439fe8c94b196")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8c94b196",
                        container: "containersf5fb840fc79a4d6fa708143953861579",
                        blob: "Blob3402760467454d29a77e37152df53d2e",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8c9a7dfb/containers98c7e7635e614a94aac51f4b99222ce9/Blob461a81c17fdf4181a168bbc740bccf8d?se=2017-01-11T10%3A48%3A01.0684022Z&sv=2016-05-31&sr=c&sp=rwd&sig=ZZ5uJTf7LaqyjMKmik7ZnqDItPVG5l6QkQpR3nwDte4%3D&timeout=30",
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

public class Test01916 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01916_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01916_s.txt", Encoding.UTF8);

    public Test01916() : base(recordedRequest, recordedResponse, "accounts8d439fe8acb3925")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8acb3925",
                        container: "containers110e1c7df74b4f558a1f50b53ec4c12d",
                        blob: "Blobf0a6d30e1c934c17886226dc185e61e1",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8acb3925/containers110e1c7df74b4f558a1f50b53ec4c12d/Blobf0a6d30e1c934c17886226dc185e61e1?se=2017-01-11T10%3A47%3A58.0333250Z&sv=2016-05-31&sr=c&sp=rwd&sig=cbgEMUPV8yBFETwQPsmEZev25MjG0c5rEnc9ieD1%2FOk%3D&snapshot=2017-01-11T08%3A47%3A57.9983254Z&timeout=30",
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

public class Test01809 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01809_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01809_s.txt", Encoding.UTF8);

    public Test01809() : base(recordedRequest, recordedResponse, "accounts8d439fe89882fc0")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe89882fc0",
                        container: "containers99fc9b7c761141eaa8c0686577906a66",
                        blob: "Blob8eac350cb2c54b3a8cfbfddbcfa74e4a",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe89882fc0/containers60c48d52474c4e908b7fd5d7d9ec3ad7/Blobb5aefb730fb042f3967978bdb8b3ea54?se=2017-01-11T10%3A47%3A55.9522659Z&sv=2016-05-31&sr=c&sp=rwd&sig=EbSkJu0xrriVq1f01YEv63f8leYDpn40jFSqD568cYg%3D&timeout=30",
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

public class Test02316 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02316_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02316_s.txt", Encoding.UTF8);

    public Test02316() : base(recordedRequest, recordedResponse, "accounts8d439fe90525c8c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe90525c8c",
                        container: "containersaa09e8b753d14cc49d7eea93f04e97e2",
                        blob: "Blobbc9b28db7aed4260b2d393c0bd71daad",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe904cde4c/containers7ce9c7840b1a4bcfa35a2835ce97dfd3/Blob0800a7ee3675456783f15df067cdeb69?se=2017-01-11T10%3A48%3A07.2985743Z&sv=2016-05-31&sr=c&sp=rwd&sig=EnsLmu%2BgIgTFDKVHtDh8lv5MpUB3wwB67RVpOYdszPc%3D&timeout=30",
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

public class Test02148 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02148_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02148_s.txt", Encoding.UTF8);

    public Test02148() : base(recordedRequest, recordedResponse, "accounts8d439fe8de8d24c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8de8d24c",
                        container: "containers1c4a66549f0941a79274266f7f6f9874",
                        blob: "Blobab824a94d7064f629c41ded0e25f4e4e",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8de305d1/containersafb3aee07707436592d2c03e33321603/Blobb67686c7b5204de1802a2e79aaa7ce3e?se=2017-01-11T10%3A48%3A03.3154652Z&sv=2016-05-31&sr=c&sp=rwd&sig=opXZu82ZW2RkdR9IvBU5ruwkUB6MnxKu%2FpSmqJ7y5Aw%3D&timeout=30",
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

public class Test01800 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01800_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01800_s.txt", Encoding.UTF8);

    public Test01800() : base(recordedRequest, recordedResponse, "accounts8d439fe897172ce")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe897172ce",
                        container: "containers93201c06ccca4b428ec746dd7af4eedb",
                        blob: "Blob0124408babd34a05900297a3a92acfd8",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe897172ce/containersf0979cfed24c4fad8b26d5a5bf109580/Blob7ebc7d5695bb4fbea2a20c107a234049?se=2017-01-11T10%3A47%3A55.7642599Z&sv=2016-05-31&sr=c&sp=rwd&sig=RBBxSoNix2hlsRJO3vrSkYUXOexN0FCNpC5tEYWMdf4%3D&timeout=30",
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

public class Test02300 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02300_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02300_s.txt", Encoding.UTF8);

    public Test02300() : base(recordedRequest, recordedResponse, "accounts8d439fe901a0e09")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe901a0e09",
                        container: "containers03e68444154e48daaf4881295864c388",
                        blob: "Blob071aa2c921a94010af8920d549ab17a7",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe901441bb/containersed59016641864f00944052efcba4abf2/Blobeef4a2e727bb46d2aa803c684394f33e?se=2017-01-11T10%3A48%3A06.9215649Z&sv=2016-05-31&sr=c&sp=rwd&sig=PQstlatJ2KusVzjNTrSJcwbiyLfI1UIORK1s5N%2FQbGg%3D&timeout=30",
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

public class Test02085 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02085_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02085_s.txt", Encoding.UTF8);

    public Test02085() : base(recordedRequest, recordedResponse, "accounts8d439fe8d0f3995")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8d0f3995",
                        container: "containersb78d50d1150d480fbb6e07c32010530d",
                        blob: "Blob477ce58a8b6042ad9f2bae14a04c6c07",
                        copySource: @"http://localhost.fiddler:10000/rdfepirv28d439fe8d152d17/containers9d30144082c443619f4cbaff325160c1/Blobb81414cf0570480893283be5adeff566?se=2017-01-11T10%3A48%3A01.9004263Z&sv=2016-05-31&sr=c&sp=rwd&sig=NAEiM4CEVdpkspXqOxezEwJmMNoyRmcCYPPkGmYMCBk%3D&timeout=30",
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

public class Test01976 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01976_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01976_s.txt", Encoding.UTF8);

    public Test01976() : base(recordedRequest, recordedResponse, "accounts8d439fe8b8cb586")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8b8cb586",
                        container: "containers9d1a2d5e9db84190adcef80456626b71",
                        blob: "Blobee674be98bac40dab492647d115cbd71",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8b86e957/containersb97e4805e9b54dcab2f262d0c58e8366/Blob28b53563a0814f94807ce40ff7d3afd0?se=2017-01-11T10%3A47%3A59.3073535Z&sv=2016-05-31&sr=c&sp=rwd&sig=7zdU%2Fiqujw7rPcI8POey5j%2FrSVQSqaC6ZgQXkoCLuc8%3D&timeout=30",
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

public class Test02404 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02404_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02404_s.txt", Encoding.UTF8);

    public Test02404() : base(recordedRequest, recordedResponse, "accounts8d439fe91308911")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe91308911",
                        container: "containersde9bc9ca0c724833969f7e197cc0e10a",
                        blob: "Blob7260f44c949d4ae58d29847e9937bfe3",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe91308911/containers67e7ae281d234a72a1d306644d915ae3/Blob2132d8f8de5a460ca175c59ee3f4959d?se=2017-01-11T10%3A48%3A08.7586146Z&sv=2016-05-31&sr=c&sp=rwd&sig=8NEydISTTYRAgaettJT%2BlSW97uBErRCwZcmJsZAf1oI%3D&timeout=30",
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

public class Test02260 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02260_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02260_s.txt", Encoding.UTF8);

    public Test02260() : base(recordedRequest, recordedResponse, "accounts8d439fe8f8b3a8a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8f8b3a8a",
                        container: "containers246db14ce5d046d3a88e5817d16483ac",
                        blob: "Blobc89e87a106ed45dba30e2a36d0a9e958",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8f85bc46/containers9bdb9820b6b04d72a29782488b02dff8/Blobea7227e33a54457ebfffc6f920b7120e?se=2017-01-11T10%3A48%3A05.9905382Z&sv=2016-05-31&sr=c&sp=rwd&sig=bq0BeYuuoMGunZqZ2Hf%2BYuI60UUtQjnUtv61y0IDClU%3D&timeout=30",
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

public class Test01872 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01872_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01872_s.txt", Encoding.UTF8);

    public Test01872() : base(recordedRequest, recordedResponse, "accounts8d439fe8a4a2121")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8a4a2121",
                        container: "containersa3836180341849f092af08fdfae6e7c8",
                        blob: "Blob0093bd76c5ee419a9735ffa9ab8dd723",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8a4a2121/containerse51521f88e6e433ab4b640759e261f9a/Blobc08f4f41090e46ec86eba78f9aeb9cd5?se=2017-01-11T10%3A47%3A57.2423049Z&sv=2016-05-31&sr=c&sp=rwd&sig=usNKw1XcojhADiNdNvO10j7x8G1HScc%2B6nVcuLjMvdI%3D&timeout=30",
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

public class Test00935 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00935_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00935_s.txt", Encoding.UTF8);

    public Test00935() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers3148a5cb74724dc998ef459199a64bcd",
                        blob: "Blob56d91926cd3e48a9bf8c5bb07c5cbad3",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersd4f7eb4728e54db292357913a1b" +
    "644de/Blob86e9afad636044f595350d353a721d45",
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

public class Test02460 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02460_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02460_s.txt", Encoding.UTF8);

    public Test02460() : base(recordedRequest, recordedResponse, "accounts8d439fe91b8f3f4")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe91b8f3f4",
                        container: "containersfc18aa891af44915bde5fd28a10865d0",
                        blob: "Blob5b9d6d1617ae4fdaba64c2337ee753f7",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe91b8f3f4/containers8b92a78446fc41a0aaf5cb4c16b67284/Blobfb479091bc8c4d3387c98eeb934c9fc9?se=2017-01-11T10%3A48%3A09.6516391Z&sv=2016-05-31&sr=c&sp=rwd&sig=IMutQwdjwN6PbEwG4j8XrmjiUD0suKrvdkoLULHBvt4%3D&timeout=30",
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

public class Test02508 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02508_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02508_s.txt", Encoding.UTF8);

    public Test02508() : base(recordedRequest, recordedResponse, "accounts8d439fe9232dfda")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9232dfda",
                        container: "containers797c5aeec2bf421790d982a9d4260178",
                        blob: "Blob1be647ea52914ac2aeb0cdaaf149f955",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9232dfda/containersa334a7cac5854b0db7f74517796b622a/Bloba60d4bdddcd14478af9e78c74508ccf3?se=2017-01-11T10%3A48%3A10.4626616Z&sv=2016-05-31&sr=c&sp=rwd&sig=1QP6ExanVuVez4spUGJpC%2Frp0XZEEGbXiZVrplSS4YI%3D&timeout=30",
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

public class Test02252 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02252_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02252_s.txt", Encoding.UTF8);

    public Test02252() : base(recordedRequest, recordedResponse, "accounts8d439fe8f701146")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8f701146",
                        container: "containersfffad2e7c4b649b4b063dc62dd0e5c51",
                        blob: "Blob05a8a08fb5a54ed9bef657399e2ea188",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8f6aba09/containers39ecabff3afb4a4ca4de69ff84e52f07/Blobb3ccb37d40c94cf789a1c3380c6e70fd?se=2017-01-11T10%3A48%3A05.8145332Z&sv=2016-05-31&sr=c&sp=rwd&sig=qQfnhDFdSwSvE1v7qIshsezfopoPjKJaWqcTZW63kLo%3D&timeout=30",
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

public class Test02292 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02292_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02292_s.txt", Encoding.UTF8);

    public Test02292() : base(recordedRequest, recordedResponse, "accounts8d439fe8ffd8534")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8ffd8534",
                        container: "containers633dc260c69040e9ad3661299590884a",
                        blob: "Blobf686caeac063459fad12f258bd439ddf",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8ff80705/containersc3a9d36df27047a495385cc07b3697ef/Blobc749709ee09e409eb0de04d10526908b?se=2017-01-11T10%3A48%3A06.7455591Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2Bta0%2F0vlrDDpxwhkBQWy%2BsVmHp4s0RH%2FGV%2BaKsnWIEE%3D&timeout=30",
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

public class Test02236 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02236_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02236_s.txt", Encoding.UTF8);

    public Test02236() : base(recordedRequest, recordedResponse, "accounts8d439fe8f38fb44")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8f38fb44",
                        container: "containers3804a3fdea4a486ba7545dd0fc11bf14",
                        blob: "Blob7109b906bb4d4643a0d95b93a72c30be",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8f33a410/containersdcd0369c83bd49c0956409d028b48e86/Blob05c043e13b404642873d3cc1f2f38640?se=2017-01-11T10%3A48%3A05.4555241Z&sv=2016-05-31&sr=c&sp=rwd&sig=Vg2LnnIQerwO0M4CT2gH7Tw%2FFaLkiHouX59s6H5S5f8%3D&timeout=30",
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

public class Test02175 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02175_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02175_s.txt", Encoding.UTF8);

    public Test02175() : base(recordedRequest, recordedResponse, "accounts8d439fe8e4f35e8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8e4f35e8",
                        container: "containers0b2b1394186346aebfa2769666141634",
                        blob: "Blob4546dfc52ea748a0ba517790ccd450e5",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8e491b5a/containersb8c24d6b6b474d86b5119d243bdb9ca6/Blob76320b2fc6954dc7a91177c817e47f43?se=2017-01-11T10%3A48%3A03.9474832Z&sv=2016-05-31&sr=c&sp=rwd&sig=Duyt3GZ7EOoZPBTJAt2PB4ukhj9uoWTZa3SCvQK4%2Br8%3D&timeout=30",
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

public class Test02157 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02157_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02157_s.txt", Encoding.UTF8);

    public Test02157() : base(recordedRequest, recordedResponse, "accounts8d439fe8e0fbb78")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8e0fbb78",
                        container: "containers5c3db2b6c5ac442aa299d4c89348814c",
                        blob: "Blobd69b6c5fbd794dcc85241c555a22de5b",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8e0952c5/containers8e07e52b84234fbdb4d5b93efca590cc/Blob9cceb135a33d437c9d8d2606faf554e4?se=2017-01-11T10%3A48%3A03.5364712Z&sv=2016-05-31&sr=c&sp=rwd&sig=gmbpcbK%2Fooq0SuKSqx%2BotQvB4Xa3tjKJthJp9q7tDjk%3D&timeout=30",
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

public class Test02228 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02228_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02228_s.txt", Encoding.UTF8);

    public Test02228() : base(recordedRequest, recordedResponse, "accounts8d439fe8f1ce79b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8f1ce79b",
                        container: "containers428356881d7744f6ae546dc883974a6e",
                        blob: "Blobb83b8ee322184ccaa85b6a171296582e",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8f171b2d/containers0329c21018a04dc5a31a7b38be810883/Blobcfef69e45ce9487bbf704ed23c5c0124?se=2017-01-11T10%3A48%3A05.2755196Z&sv=2016-05-31&sr=c&sp=rwd&sig=fAiH9GK99sBOgiKLUIXkmxPEd8BWLucFtxExRgFytLs%3D&timeout=30",
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

public class Test01924 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01924_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01924_s.txt", Encoding.UTF8);

    public Test01924() : base(recordedRequest, recordedResponse, "accounts8d439fe8ae2dfb8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8ae2dfb8",
                        container: "containers7a249d2dca0243b68ea5bf4568d62b12",
                        blob: "Blob434cd3a2a8764583907e63357c22e0af",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8ae2dfb8/containers7a249d2dca0243b68ea5bf4568d62b12/Blob434cd3a2a8764583907e63357c22e0af?se=2017-01-11T10%3A47%3A58.1813260Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2BSX5xwvaFds%2F1Bilxm9Rq7rH9FT5o0vLBgmU3r7PAfk%3D&snapshot=2017-01-11T08%3A47%3A58.1533288Z&timeout=30",
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

public class Test02017 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02017_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02017_s.txt", Encoding.UTF8);

    public Test02017() : base(recordedRequest, recordedResponse, "accounts8d439fe8c160ab7")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8c160ab7",
                        container: "containers0411ee467f4342e991b2c64521f2e8be",
                        blob: "Blob5d14b5a15ce34b7e970826ad69092d30",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8c1b891b/containers6a0af44e434741f4aadd47ca4597e70a/Blob418f19c43a2d4c55959a89b40ec3ac84?se=2017-01-11T10%3A48%3A00.2603824Z&sv=2016-05-31&sr=c&sp=rwd&sig=SieXgGgB5651f7RLEOMzZOCgIwEMUSO5vQjH2cSm4AI%3D&timeout=30",
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

public class Test01958 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01958_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01958_s.txt", Encoding.UTF8);

    public Test01958() : base(recordedRequest, recordedResponse, "accounts8d439fe8b506f6d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8b506f6d",
                        container: "containers47a5995552264f5792c99f2e774f70d0",
                        blob: "Blob5df9fa72bc1140cfb148da76b6d1bb6a",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8b4aca10/containerse1a0512f2a364182afc2f60a599fa00e/Blobef46a8672c4b4a3b8b8752805d6488a6?se=2017-01-11T10%3A47%3A58.9123435Z&sv=2016-05-31&sr=c&sp=rwd&sig=mUrF%2FyLtzpRaewcP7dK6IdVHSD5%2FA3G1wWgeyQHXJqE%3D&timeout=30",
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

public class Test02276 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02276_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02276_s.txt", Encoding.UTF8);

    public Test02276() : base(recordedRequest, recordedResponse, "accounts8d439fe8fc44c59")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8fc44c59",
                        container: "containers0e398d978a30494094a4cfb8be87c960",
                        blob: "Blobd70933f04d5b40cfa917657a4af2535d",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8fbe7ff9/containers372e3f85cdc642cf911500686e4e0f3d/Blob1dc880212a0a4fada77b32c426a3426e?se=2017-01-11T10%3A48%3A06.3725489Z&sv=2016-05-31&sr=c&sp=rwd&sig=BUehfw6X8xDkH0iSNO83LLLDdGcgG%2FRgBqDWby0kHQ0%3D&timeout=30",
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

public class Test01984 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01984_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01984_s.txt", Encoding.UTF8);

    public Test01984() : base(recordedRequest, recordedResponse, "accounts8d439fe8bab3a36")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8bab3a36",
                        container: "containers8bd52fef2b524b678630d774526ce506",
                        blob: "Blob2d8132ba23014849ae18ff761abe5a78",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8ba5bbed/containers832506027843495f838083637595584a/Blobca0b97b6b5d54708b5726c70343364be?se=2017-01-11T10%3A47%3A59.4923595Z&sv=2016-05-31&sr=c&sp=rwd&sig=tkmJPIHBo3H%2BwJmwGISzgys9RQxqyuVTPD%2FclsjEeWM%3D&timeout=30",
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

public class Test02668 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02668_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02668_s.txt", Encoding.UTF8);

    public Test02668() : base(recordedRequest, recordedResponse, "accounts8d439fe9421baec")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9421baec",
                        container: "containersb8d3e4229fb943d9a9c3b4785b3de3da",
                        blob: "Blob20e69f9203d64ba4b35dc5a4ebea26be",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9428239f/containersc053a1740be64096961ce27c1bd059fc/Blob242c5f2b5bf9469c873fb63dd8124fee?se=2017-01-11T10%3A48%3A13.7427532Z&sv=2016-05-31&sr=c&sp=rwd&sig=6hUFgbdNTk0tDI7U2VU3jpDKjFZ1PMlF69HwFlM%2B6Ag%3D&timeout=30",
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

public class Test02000 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02000_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02000_s.txt", Encoding.UTF8);

    public Test02000() : base(recordedRequest, recordedResponse, "accounts8d439fe8be29e65")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8be29e65",
                        container: "containersa1778c0598fc45049910dd74f28e97bb",
                        blob: "Blobc9238a73e289420ca99217918f6d8b0b",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8bdcf903/containers926afce1937e4a7685c3a7f72c3eaddd/Blobd96c99ec77d14403a1551a36d9eeb423?se=2017-01-11T10%3A47%3A59.8603692Z&sv=2016-05-31&sr=c&sp=rwd&sig=05zQe0C5aG0zuoQjZ426uynCrdaE5IaeWUIHk7wpGa4%3D&timeout=30",
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

public class Test01881 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01881_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01881_s.txt", Encoding.UTF8);

    public Test01881() : base(recordedRequest, recordedResponse, "accounts8d439fe8a6a05a5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8a6a05a5",
                        container: "containersa5677437cc0d45899b74f4e3a73c0d12",
                        blob: "Blob074cb1b0354f45a9bd62609817235941",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8a6a05a5/containersa38eed4d98c94434971ccab42915e916/Blobecb94749d68d4a839bce3f4715d3482b?se=2017-01-11T10%3A47%3A57.4073017Z&sv=2016-05-31&sr=c&sp=rwd&sig=NvnqliOhKO4VN6u9V3%2B1YuGw%2B%2BtQwVjVDOtRM8cgBIQ%3D&timeout=30",
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

public class Test02731 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02731_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02731_s.txt", Encoding.UTF8);

    public Test02731() : base(recordedRequest, recordedResponse, "accounts8d439fe95020a5c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe95020a5c",
                        container: "containers8ad8ae82288f486bbb3aa49f4ccbb913",
                        blob: "Blobd48bc9ad6a66455695eb8347a7ef623d",
                        copySource: @"http://localhost.fiddler:10000/ardfepirv28d439fe9508730/containers735f7afdbb2845539508b5ba12b91083/Blob6bca1fd42dd14d1c831f685b48e8ff45?se=2017-01-11T10%3A48%3A15.2177937Z&sv=2016-05-31&sr=c&sp=rwd&sig=aiRUV70jzQdcfF1megGu759qOATUjHY6IXgUlpm%2FH7o%3D&timeout=30",
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

public class Test02094 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02094_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02094_s.txt", Encoding.UTF8);

    public Test02094() : base(recordedRequest, recordedResponse, "accounts8d439fe8d3140c5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8d3140c5",
                        container: "containers87dc639206c146c6b8b9c718a1e3bcec",
                        blob: "Blobc200d11023d8407bb9f65333de1f6a4e",
                        copySource: @"http://localhost.fiddler:10000/rdfepirv28d439fe8d37a981/containers04640d0577944fd1a7d9a6bc91616e40/Blob1fb3a1b5451b4d13b46956080d1520aa?se=2017-01-11T10%3A48%3A02.1164349Z&sv=2016-05-31&sr=c&sp=rwd&sig=ggy3Jm9diwK%2BeuPN7b7ACFX%2BSnAA%2F4HoaQ6iymC5V2s%3D&timeout=30",
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

public class Test02112 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02112_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02112_s.txt", Encoding.UTF8);

    public Test02112() : base(recordedRequest, recordedResponse, "accounts8d439fe8d72b702")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8d72b702",
                        container: "containerse991e92a577645a9861b4fcf362ceab0",
                        blob: "Blobb1e7c27531604e46babeb013c38422c4",
                        copySource: @"http://localhost.fiddler:10000/rdfepirv28d439fe8d76fccf/containers91c6586024ea475f83d4927385cb9ecb/Blob54787114dc4c479a9bbfe269ffa5cca8?se=2017-01-11T10%3A48%3A02.5054431Z&sv=2016-05-31&sr=c&sp=rwd&sig=NbovXuJBAV5NLL5aIkRjVK%2B8e1%2BT6MVzsVTNvGzrkmo%3D&timeout=30",
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

public class Test01818 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01818_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01818_s.txt", Encoding.UTF8);

    public Test01818() : base(recordedRequest, recordedResponse, "accounts8d439fe89a6b401")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe89a6b401",
                        container: "containersa1a40bdeb22d40a18013cda4c2761eeb",
                        blob: "Blob0f165f96e0644cfe8aae4883ffbafae7",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe89a6b401/containers9982ed9be3584edf8554b77f938ef18b/Blob2379cb54a5204a1c904e88a508b58a37?se=2017-01-11T10%3A47%3A56.1522654Z&sv=2016-05-31&sr=c&sp=rwd&sig=pfZH0u2zjrw7u9YJeiLuLvwn1exMtTviICbwHViM7kQ%3D&timeout=30",
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

public class Test02931 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02931_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02931_s.txt", Encoding.UTF8);

    public Test02931() : base(recordedRequest, recordedResponse, "accounts8d439fe97b4ac30")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe97b4ac30",
                        container: "containers2297fcec0fca4c368c745e28f66f735c",
                        blob: "Blobcaec9f4f809a451c858636de8eb0362e",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe97af550e/containersa6b3db01f6e6487e8bdad8cf07ef7f86/Blobe435383e1a6a4f0ba3578fc67a6ec1ac?se=2017-01-11T10%3A48%3A19.6939168Z&sv=2016-05-31&sr=c&sp=rwd&sig=P%2BkALzuEK6imf%2BLqB8IiCuZlb7qfaAjZA%2BklIQULL1I%3D&timeout=30",
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

public class Test02422 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02422_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02422_s.txt", Encoding.UTF8);

    public Test02422() : base(recordedRequest, recordedResponse, "accounts8d439fe915cc983")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe915cc983",
                        container: "containers6e7b960e4f7f442387f573fe173c69e8",
                        blob: "Bloba1e7bbb4ed30481d8fa9e8b3ee998ef1",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe915cc983/containersa4db90f61a5c434aa56c52849c5d1fc7/Blob87112ca2d23d4494a2ec2c0cd68c428c?se=2017-01-11T10%3A48%3A09.0216256Z&sv=2016-05-31&sr=c&sp=rwd&sig=T1lJHt1ANshXIXHpHXsPL3DBWUhDmBafA4OXdxzTz0c%3D&timeout=30",
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

public class Test02184 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02184_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02184_s.txt", Encoding.UTF8);

    public Test02184() : base(recordedRequest, recordedResponse, "accounts8d439fe8e70048e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8e70048e",
                        container: "containersa82d19c4765b4b93942327ce8b60a0d5",
                        blob: "Blobf7ce4bc3a18b4a1e9a9a755c9b8b0860",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8e699be9/containers074fccbc07ed4013932ab831e81edb75/Blob2b0f5c19d8eb458682f154e6207cb1b3?se=2017-01-11T10%3A48%3A04.1784893Z&sv=2016-05-31&sr=c&sp=rwd&sig=QkNM5nJzshjSybt07THGaVy8YGZiXnd%2FWuDiVWmBYp0%3D&timeout=30",
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

public class Test02845 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02845_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02845_s.txt", Encoding.UTF8);

    public Test02845() : base(recordedRequest, recordedResponse, "accounts8d439fe969186ce")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe969186ce",
                        container: "containers9ff70f55d684418895e74f82ba33bc6a",
                        blob: "Blob7b2de510b0674c28b134e5676fe4aed4",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe968be17a/containersbbe7cad8356f424eb21a41cadae5915b/Blobae23ad7884894748aadd8c04c0d716a7?se=2017-01-11T10%3A48%3A17.7788639Z&sv=2016-05-31&sr=c&sp=rwd&sig=tMg499raje8HjnR1FVmhE%2BppPTxBD%2FAsapq3FiC1CyQ%3D&timeout=30",
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

public class Test03115 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03115_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03115_s.txt", Encoding.UTF8);

    public Test03115() : base(recordedRequest, recordedResponse, "accounts8d439fe99a534fd")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe99a534fd",
                        container: "containersf64acf1a0c96460397fe35f902188158",
                        blob: "Blob8c2662d8505946fd958cdb07db7765e4",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe99a534fd/containers126f9c957891446e8ad586eb438e0d65/Blob6b7bd3b6fd4a44769dc1bf67d7d39027?se=2017-01-11T10%3A48%3A22.9300055Z&sv=2016-05-31&sr=c&sp=rwd&sig=QM%2FWalTplNqa533d3%2BAZM4X1btiC%2FUY8Yo3KCrTHZKQ%3D&timeout=30",
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

public class Test02498 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02498_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02498_s.txt", Encoding.UTF8);

    public Test02498() : base(recordedRequest, recordedResponse, "accounts8d439fe92198b33")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe92198b33",
                        container: "containers0d32115be0a449878af18aa4c84ef9c6",
                        blob: "Blobc588046af15e41a2a6296a6efb1caeb8",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe92198b33/containersf6433e6ecb4b48c7b67a2478b7cc55cc/Blobfcd410d3f631416b96cda66d5b413291?se=2017-01-11T10%3A48%3A10.2866567Z&sv=2016-05-31&sr=c&sp=rwd&sig=a8oeo6oYig5xjOW5kpIk4COsMueLozGZxwM%2F%2BogqZEo%3D&timeout=30",
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

public class Test02130 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02130_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02130_s.txt", Encoding.UTF8);

    public Test02130() : base(recordedRequest, recordedResponse, "accounts8d439fe8daade6c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8daade6c",
                        container: "containers537248ad3a0b4ddc96ee3d12547dad13",
                        blob: "Blobe38f945ce3834c2bb9d5d483fc5845c5",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8da64a88/containers45e16adadb034865840be0703d410ed6/Blob47fce1f2f2394ebeb711091eeae541b6?se=2017-01-11T10%3A48%3A02.8514529Z&sv=2016-05-31&sr=c&sp=rwd&sig=WNC02soUq0lT2G6QasAfRfU0fPKFpmXOt%2BNbayI04ms%3D&timeout=30",
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

public class Test02044 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02044_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02044_s.txt", Encoding.UTF8);

    public Test02044() : base(recordedRequest, recordedResponse, "accounts8d439fe8c75deab")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8c75deab",
                        container: "containers6d8a5c51809445f38a0ee16e9cf33545",
                        blob: "Blobb9094edabea44f6583490f46c69f6c1f",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8c7bd229/containers12b9024ee6e24871aac89acdc9478b1c/Blob6c9c4c9c31624f1abfe45932f6c1b894?se=2017-01-11T10%3A48%3A00.8803975Z&sv=2016-05-31&sr=c&sp=rwd&sig=uyvJsyNqw7E%2BT22lp7Ssxw4OMMbdYUchemBfKoUw6C0%3D&timeout=30",
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

public class Test02702 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02702_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02702_s.txt", Encoding.UTF8);

    public Test02702() : base(recordedRequest, recordedResponse, "accounts8d439fe949f0228")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe949f0228",
                        container: "containersbf82d80689a04cb79a5a78431d4163a6",
                        blob: "Blob9949b24a57e0419cae076c35ddeff6c9",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe94a4f59d/containers1f2b21cdf7e8483d844a794737eb6271/Blob7a36917abadb48509a9234f125b01057?se=2017-01-11T10%3A48%3A14.5657763Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2Bkl1maFONpjxffI1aUWPL4EnM%2BhN74FOl0xljrLer74%3D&timeout=30",
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

public class Test02605 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02605_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02605_s.txt", Encoding.UTF8);

    public Test02605() : base(recordedRequest, recordedResponse, "accounts8d439fe9342a40a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9342a40a",
                        container: "containers906961e0fcff4b69b4d6677d8fe6673f",
                        blob: "Blob69a38de62e50492cbd077b19e15ad271",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe933cd78f/containers40b483da311543c8a4b0a04fad0c37fc/Blobece4ccd7e1104fcdb53a0f1aceae0079?se=2017-01-11T10%3A48%3A12.2527111Z&sv=2016-05-31&sr=c&sp=rwd&sig=SyJIAn2gd6m9IjvnaA4Py4eYRwpmcrMrnu6RO0wjDFs%3D&timeout=30",
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

public class Test02527 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02527_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02527_s.txt", Encoding.UTF8);

    public Test02527() : base(recordedRequest, recordedResponse, "accounts8d439fe9267abb4")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9267abb4",
                        container: "containers2ef392c44b1040a28643c1d87fd20815",
                        blob: "Blob8f56677268724201871b546dc74c6776",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9267abb4/containersc24363105e6c45beb4096994cc3098c2/Blob637d3bd9a1bc49d7a567af2c3ca688bf?se=2017-01-11T10%3A48%3A10.7946713Z&sv=2016-05-31&sr=c&sp=rwd&sig=KLPeoEDxt1hrwhRBD%2BJbMW0WKYE6KLa2Xp%2Fobp7moiQ%3D&timeout=30",
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

public class Test01899 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01899_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01899_s.txt", Encoding.UTF8);

    public Test01899() : base(recordedRequest, recordedResponse, "accounts8d439fe8a9c6067")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8a9c6067",
                        container: "containerse83ee36da2614e1896b02f9cb60881af",
                        blob: "Blob418fd10d62c9440e87050eeb434250c7",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8a9c6067/containers3b5b40ccf81e40ee921c45bf36a6a15c/Blobb9ba8a1330834ac6988b95b0dd7c8b95?se=2017-01-11T10%3A47%3A57.7293094Z&sv=2016-05-31&sr=c&sp=rwd&sig=xS2f6aQha5SwzAQZODxba3oT%2BWpbUTBfAQc1K72CjOE%3D&timeout=30",
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

public class Test02220 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02220_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02220_s.txt", Encoding.UTF8);

    public Test02220() : base(recordedRequest, recordedResponse, "accounts8d439fe8efe14ca")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8efe14ca",
                        container: "containerse1c8662d150f4ea2bc1919381441e6ed",
                        blob: "Blobb67cef767753444390f89debea6d43c2",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8ef7fa38/containersf52ceae3509648879f16542bcdd1b3e2/Blob5c1571d3b9df4c3e8dd606350d4654a2?se=2017-01-11T10%3A48%3A05.0875131Z&sv=2016-05-31&sr=c&sp=rwd&sig=PvnIeAYt2wox49xXYn%2F2KYFFNCq9rUsoZUn%2BYi0Lk4U%3D&timeout=30",
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

public class Test02750 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02750_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02750_s.txt", Encoding.UTF8);

    public Test02750() : base(recordedRequest, recordedResponse, "accounts8d439fe954b6fff")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe954b6fff",
                        container: "containers174c6e7d254d4186b9cffe9a014d2a13",
                        blob: "Blob3ec81c68e20c437683b9a9e4c86c2422",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe95452e61/containers7245d5bc0f1e42a6b8a3fe38814e1f3a/Blob3507950014194bc6b58aa442404dc4bc?se=2017-01-11T10%3A48%3A15.6648066Z&sv=2016-05-31&sr=c&sp=rwd&sig=Enlc65AddTcCeQzeAn0SFzTdEOI0rERkXWVU6JNOepk%3D&timeout=30",
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

public class Test02640 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02640_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02640_s.txt", Encoding.UTF8);

    public Test02640() : base(recordedRequest, recordedResponse, "accounts8d439fe93be8b9f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe93be8b9f",
                        container: "containersbe22451dfc654c509699a09384962de5",
                        blob: "Blob60c42f2407b5441e92f02b2ae8a67ed6",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe93c4a636/containers0aa37dbbd27f434ba511bc9a8834d61d/Blob9e6effa4f6304d98b7f8ad380f9b1d0f?se=2017-01-11T10%3A48%3A13.1057356Z&sv=2016-05-31&sr=c&sp=rwd&sig=fHoiNoR0I61lDVCAZfGLgrPwRTcNUB5dasZMWxwX%2FtY%3D&timeout=30",
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

public class Test03155 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03155_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03155_s.txt", Encoding.UTF8);

    public Test03155() : base(recordedRequest, recordedResponse, "accounts8d439fe9a173186")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9a173186",
                        container: "containers95e6669661364c8da05861a370fc7d54",
                        blob: "Blob4fe30d1587d04a14b4438fdc2d06e320",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9a173186/containers80ba6232224f4a33a981c6e0dd222d8b/Blob01f06070a1f8423d88bfbe664f0d4bd7?se=2017-01-11T10%3A48%3A23.6890278Z&sv=2016-05-31&sr=c&sp=rwd&sig=qUyTwdVyUDHo35eT76W4sXSUO%2F5aJ0wqEBECSs2756Y%3D&timeout=30",
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

public class Test02556 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02556_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02556_s.txt", Encoding.UTF8);

    public Test02556() : base(recordedRequest, recordedResponse, "accounts8d439fe92b11157")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe92b11157",
                        container: "containers18b95412895e405c8f66704e8adccac6",
                        blob: "Blob84b7da004583406c9d7133b5ef6bd75b",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe92b11157/containers18b95412895e405c8f66704e8adccac6/Blob84b7da004583406c9d7133b5ef6bd75b?se=2017-01-11T10%3A48%3A11.3036855Z&sv=2016-05-31&sr=c&sp=rwd&sig=kcjku6FWya%2Bi093jKV9Wjav0MRIn975u9dnxZnVPafQ%3D&snapshot=2017-01-11T08%3A48%3A11.2796852Z&timeout=30",
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

public class Test02202 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02202_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02202_s.txt", Encoding.UTF8);

    public Test02202() : base(recordedRequest, recordedResponse, "accounts8d439fe8eb4d640")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8eb4d640",
                        container: "containers6f152521300b43709a55cf817730a580",
                        blob: "Blob16a447af00064215a9413a3a7bc298ef",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8eaee2c7/containersdccc4b7fe7a9472f8470a58969fb652a/Blob6081156a61a24d23a2b960cf2a3f9d43?se=2017-01-11T10%3A48%3A04.6285014Z&sv=2016-05-31&sr=c&sp=rwd&sig=jddOUJsCY%2BfhXftFDfmz4xw0qNnawhq1SQ%2F4EfjgVYY%3D&timeout=30",
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

public class Test01949 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01949_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01949_s.txt", Encoding.UTF8);

    public Test01949() : base(recordedRequest, recordedResponse, "accounts8d439fe8b31c3f4")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8b31c3f4",
                        container: "containers67d5e27e2ba84e34ac4ed4af3faf3c44",
                        blob: "Blobdd38ca666bd94f77b08f76347ac43e22",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8b2b8240/containers5256853218d6409eaf254251f33708b3/Blobe70f1a89338543aa9fd1e21613cf5c34?se=2017-01-11T10%3A47%3A58.7163383Z&sv=2016-05-31&sr=c&sp=rwd&sig=jBRTJ9uuGQU%2FUT8QADvXO3CowBFe2CCFrWCdGGrguF8%3D&timeout=30",
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

public class Test02622 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02622_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02622_s.txt", Encoding.UTF8);

    public Test02622() : base(recordedRequest, recordedResponse, "accounts8d439fe93866442")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe93866442",
                        container: "containersd2bb58dbec4744fe8211d5aa1765ab11",
                        blob: "Blobdd8cb43a51aa46518e0ef683d27771bc",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe937ffb8b/containers870496757b414680a5e32560694e19df/Blobab60c6a53518462e97b453adbb8d2b09?se=2017-01-11T10%3A48%3A12.6877239Z&sv=2016-05-31&sr=c&sp=rwd&sig=5I6ObhUDW64egvwg85HN0F44edlqheerQSY5BdCwJwY%3D&timeout=30",
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

public class Test02060 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02060_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02060_s.txt", Encoding.UTF8);

    public Test02060() : base(recordedRequest, recordedResponse, "accounts8d439fe8cb18890")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8cb18890",
                        container: "containers9f9c03971b294060a7c8cf446f560b77",
                        blob: "Blobd67da4c725e64895bd1488880073c100",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8cb6dfdb/containers62fac88e974d40bbb068014df9a757b2/Blob79c63bab9f234d2cb9fb2421bce52275?se=2017-01-11T10%3A48%3A01.2564073Z&sv=2016-05-31&sr=c&sp=rwd&sig=U%2B3%2ByWunDiqJ91GSwtxy5U0eT2wr7rx1oP1habE%2FmBg%3D&timeout=30",
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

public class Test02413 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02413_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02413_s.txt", Encoding.UTF8);

    public Test02413() : base(recordedRequest, recordedResponse, "accounts8d439fe91487e10")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe91487e10",
                        container: "containers42ee852594254a13a5b05d3b9129b2b4",
                        blob: "Bloba99346b6ca8a40dc83b5926facdddae9",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe91487e10/containersaa8ce1bcaeaf4efb87a18b4681833440/Blobe14fb25599e341fbab3cb213ed3de68a?se=2017-01-11T10%3A48%3A08.8966186Z&sv=2016-05-31&sr=c&sp=rwd&sig=n1hvywzc%2Bwq1EbgNv1egHuQ2gfhqeyc5FtKKhFtKXLQ%3D&timeout=30",
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

public class Test03086 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03086_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03086_s.txt", Encoding.UTF8);

    public Test03086() : base(recordedRequest, recordedResponse, "accounts8d439fe995d07ec")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe995d07ec",
                        container: "containers05bdb739f7394bb3ad4563bb3e9c324b",
                        blob: "Blob463ed955f813421baffe84665e5bc057",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe995d07ec/containers34427b253e6c4d37b44bdccb19f85949/Blob1ce3adeae5064db382a25a2499845038?se=2017-01-11T10%3A48%3A22.4539944Z&sv=2016-05-31&sr=c&sp=rwd&sig=Ob%2B1RLCmBfzbqSceH204Cqm32vlhR0E7nbEWQzyA%2Fdk%3D&timeout=30",
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

public class Test02432 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02432_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02432_s.txt", Encoding.UTF8);

    public Test02432() : base(recordedRequest, recordedResponse, "accounts8d439fe917051a6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe917051a6",
                        container: "containers8536c73ac58b439aa29e5b14bdff74ec",
                        blob: "Blob7cef22b3f2c943759b2bc2dd5231a1d7",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe917051a6/containers839e6d9b136e46aa9639f43d74877399/Blobc930d1f2d01c43488f2fa63fd72ea246?se=2017-01-11T10%3A48%3A09.1566327Z&sv=2016-05-31&sr=c&sp=rwd&sig=peTI5mLNh%2BVOtxyD1mf8HBU7aXdCpdMvizcLfS53KFM%3D&timeout=30",
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

public class Test02798 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02798_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02798_s.txt", Encoding.UTF8);

    public Test02798() : base(recordedRequest, recordedResponse, "accounts8d439fe95f71a81")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe95f71a81",
                        container: "containers04c91f1302924b6882538011c7c72839",
                        blob: "Blobd3f5a8023ebf446a9ca3a968c1084da9",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe95f0ffef/containers388e452a74954fb1905345d589156918/Blob4938831fdd114f21a3fe68e8b25249a0?se=2017-01-11T10%3A48%3A16.7808362Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2Bzqn4luhwKV0o0YjnkbTlUW%2Fp2rYJhgZAUeWxjC2Gx4%3D&timeout=30",
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

public class Test03046 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03046_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03046_s.txt", Encoding.UTF8);

    public Test03046() : base(recordedRequest, recordedResponse, "accounts8d439fe98f9d8a3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe98f9d8a3",
                        container: "containersb77803cf048e41bb98e06fd2204e4db0",
                        blob: "Blob331abea0dc5e49b2a5e1cab126779eef",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe98f9d8a3/containers34e76e9b814540ed866dbd34b2045e0a/Blob262b9e6cb735455a9ffc3fd12e5799a7?se=2017-01-11T10%3A48%3A21.7929747Z&sv=2016-05-31&sr=c&sp=rwd&sig=ZphrFB3AGjGM%2BqoFFOzxXBrWrQKagFNIQcswTr1%2BqPw%3D&timeout=30",
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

public class Test02650 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02650_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02650_s.txt", Encoding.UTF8);

    public Test02650() : base(recordedRequest, recordedResponse, "accounts8d439fe93e12f0b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe93e12f0b",
                        container: "containers7ce5ce3fa9c046258e5046803c1dae6c",
                        blob: "Blobd612b4c8a9e54ee988386909d7243e56",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe93e7499e/containers84033c7a6d144958bf617b4ec1e7630c/Blobc0e32c363e2647f0a8e9864dd23782a0?se=2017-01-11T10%3A48%3A13.3267415Z&sv=2016-05-31&sr=c&sp=rwd&sig=H%2FCy5jqskMRW9J9C8AovrGp4MaIaAIF88vZ2xjJ98xc%3D&timeout=30",
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

public class Test02586 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02586_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02586_s.txt", Encoding.UTF8);

    public Test02586() : base(recordedRequest, recordedResponse, "accounts8d439fe930413f2")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe930413f2",
                        container: "containersee59b2c0309b4ac0843653241b5ac5f0",
                        blob: "Blob28b838f81bdd405e9e361a5cb8452508",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe92fe95a0/containersbbf824bc61f64800b71e218153209e3e/Blob4e1fdbde1e7d4948a0c5d4e661883999?se=2017-01-11T10%3A48%3A11.8296994Z&sv=2016-05-31&sr=c&sp=rwd&sig=JrfHnr13II5uBxQWGo1h2zXfxm6g0xsOsD2JmYG7%2FZ0%3D&timeout=30",
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

public class Test01863 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01863_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01863_s.txt", Encoding.UTF8);

    public Test01863() : base(recordedRequest, recordedResponse, "accounts8d439fe8a2b2733")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8a2b2733",
                        container: "containers183859afe9f84830931b73f62f55e7ee",
                        blob: "Blob821233cc02204f2799b546c4ab0877be",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8a2b2733/containersbfddf14bd78a43f3b3eda71c0c2fedc5/Blobeeb96c5dbad84d0d80529e76ec38ec6d?se=2017-01-11T10%3A47%3A57.0252950Z&sv=2016-05-31&sr=c&sp=rwd&sig=rTcdY8%2BVmyPPPWeoOdxQ76B8wWzY51hh92RYIlF%2BQYQ%3D&timeout=30",
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

public class Test02686 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02686_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02686_s.txt", Encoding.UTF8);

    public Test02686() : base(recordedRequest, recordedResponse, "accounts8d439fe94610e50")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe94610e50",
                        container: "containersaec3da38bb71498c9a9079b3397d5b90",
                        blob: "Blob9918caa647624287bcbd225d8aafc1ca",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe946701db/containers074ef12020544ad99c334822e617ff8f/Blob1d45e2dc77bd4a1aa471e34a26090c7f?se=2017-01-11T10%3A48%3A14.1577643Z&sv=2016-05-31&sr=c&sp=rwd&sig=09VBhhPyL7P7M2v6m%2FMvA%2F4vkARZAx8Ig5nOCJO6dj0%3D&timeout=30",
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

public class Test02244 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02244_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02244_s.txt", Encoding.UTF8);

    public Test02244() : base(recordedRequest, recordedResponse, "accounts8d439fe8f5499d4")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8f5499d4",
                        container: "containers755ed4e7114d4b46a023ca2565c38a29",
                        blob: "Blob8741ae82fe1a400ca7e94d4bd081c333",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8f4f1b8b/containersb8d3bbe67f2e4b9ebe9a906fbd3d9581/Blob671438f754714d0e816297860441a800?se=2017-01-11T10%3A48%3A05.6375287Z&sv=2016-05-31&sr=c&sp=rwd&sig=XfwQmx%2BPVNf5ocr3kA0fjGNG%2BP%2Fsoc3KxiAl7sxHUOQ%3D&timeout=30",
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

public class Test02076 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02076_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02076_s.txt", Encoding.UTF8);

    public Test02076() : base(recordedRequest, recordedResponse, "accounts8d439fe8cef0726")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8cef0726",
                        container: "containers3a7cdfbff24148368dadeea95d2dea4f",
                        blob: "Blobac00646e5a6f4423be22b0a77e77cbf0",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8cf5be02/containers3651cce4d60c442991bfcef791889de7/Blob03b4772a58534b11a46b52680f3fe1bb?se=2017-01-11T10%3A48%3A01.6774217Z&sv=2016-05-31&sr=c&sp=rwd&sig=TxruckWQx73okqtNlen5KKLrAQceciq4YNKEFY1ZXyQ%3D&timeout=30",
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

public class Test03166 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03166_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03166_s.txt", Encoding.UTF8);

    public Test03166() : base(recordedRequest, recordedResponse, "accounts8d439fe9a35b63a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9a35b63a",
                        container: "containersf2e80549639e45b9addf7f4269d763fe",
                        blob: "Blob970c706d776846fa95f49210c9438699",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9a35b63a/containers9d79dac8a9584dbc94fe69cc9d197197/Blob0358aa86c4984c9889dd36db7ab84ca5?se=2017-01-11T10%3A48%3A23.8980336Z&sv=2016-05-31&sr=c&sp=rwd&sig=oFTXl0Q2ram29K%2B8letgSKD4qj2Cll7xIpcvjhU16xw%3D&timeout=30",
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

public class Test02480 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02480_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02480_s.txt", Encoding.UTF8);

    public Test02480() : base(recordedRequest, recordedResponse, "accounts8d439fe91e8dde0")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe91e8dde0",
                        container: "containers47e0e3681fec4e6097b4401bb1007142",
                        blob: "Blob9cc97379e1e24b7c815e9743d86e9b90",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe91e8dde0/containersa00d9dc9bc2941bd819a61b1e7c26227/Blob847f7134423043688de511b22cabd862?se=2017-01-11T10%3A48%3A09.9666543Z&sv=2016-05-31&sr=c&sp=rwd&sig=lGzNKjmhoRxzlVWDes7K3TeQt4R5UzoWSmgXzvlPkck%3D&timeout=30",
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

public class Test02308 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02308_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02308_s.txt", Encoding.UTF8);

    public Test02308() : base(recordedRequest, recordedResponse, "accounts8d439fe9034e948")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9034e948",
                        container: "containersdc06b4ea201a453fabd49686979e55f3",
                        blob: "Blob51abebfdfdd048f090f45e309f63931e",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe902f920f/containers5f1e9b2560bd4eba88af3c63fd53365b/Blob929955a8214641f0b2eceb62f7872cff?se=2017-01-11T10%3A48%3A07.1105705Z&sv=2016-05-31&sr=c&sp=rwd&sig=no5Zelhy1VDM6HwV8ZOPPT9%2BwX4lTqmb2h5EhNWGvqc%3D&timeout=30",
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

public class Test02566 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02566_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02566_s.txt", Encoding.UTF8);

    public Test02566() : base(recordedRequest, recordedResponse, "accounts8d439fe92cb9e68")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe92cb9e68",
                        container: "containers3a40347921104c7fbdb34d16b5502408",
                        blob: "Blobff0d3691dee74dec977c74c4c1da5aed",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe92cb9e68/containers3a40347921104c7fbdb34d16b5502408/Blobff0d3691dee74dec977c74c4c1da5aed?se=2017-01-11T10%3A48%3A11.4826900Z&sv=2016-05-31&sr=c&sp=rwd&sig=ld5BOm%2BWPRTz7lltohpESH0q9XJGGUlWxotxNaKtQSg%3D&snapshot=2017-01-11T08%3A48%3A11.4596906Z&timeout=30",
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

public class Test03412 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03412_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03412_s.txt", Encoding.UTF8);

    public Test03412() : base(recordedRequest, recordedResponse, "accounts8d439fe9d3d0852")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9d3d0852",
                        container: "containers7e1dfdcd764b4146ab4a93d3969b763b",
                        blob: "Blob2558a25dbe4a48fcad09dbcaf0e5f066",
                        copySource: @"http://localhost.fiddler:10000/zrdfepirv28d439fe9d41751/containersfb5a7ae626ba4cd7a6c9b616b0f7e6c2/Blob3e424ebeb3ec457286b4d51f60a025d2?se=2017-01-11T10%3A48%3A28.9611737Z&sv=2016-05-31&sr=c&sp=rwd&sig=q%2FmdHAiI595sPiMZdzY0ac8SjCujJYjjsFJt0YLIe8A%3D&timeout=30",
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

public class Test03246 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03246_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03246_s.txt", Encoding.UTF8);

    public Test03246() : base(recordedRequest, recordedResponse, "accounts8d439fe9b26a7ac")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9b26a7ac",
                        container: "containers14f4ddebd24f463889808b8e47221446",
                        blob: "Blobb891832925b7420c95c7370eed468568",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9b20db3a/containers3214c598422f419a811bbfb8393a4e5b/Blob6a6820df62ea4ea989cdd73888175ddf?se=2017-01-11T10%3A48%3A25.4760781Z&sv=2016-05-31&sr=c&sp=rwd&sig=Zkkno78JGC6aUG8AQrqOCJl4ojtTokYU3LAl8jmPyBQ%3D&timeout=30",
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

public class Test02470 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02470_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02470_s.txt", Encoding.UTF8);

    public Test02470() : base(recordedRequest, recordedResponse, "accounts8d439fe91d0e8e5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe91d0e8e5",
                        container: "containersee4c941d7def44ff87743972e3e648b6",
                        blob: "Blob365e0ff914024606887c049b2a6d081a",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe91d0e8e5/containersbc47122b98ff466e8468caaf27f45bb9/Blob763456a5d5ef4e0aabc328b924c0fe10?se=2017-01-11T10%3A48%3A09.8086438Z&sv=2016-05-31&sr=c&sp=rwd&sig=IKEIeNWZD5TZpzR5O3fwQeLYpBkBhJio1O8FfjHisYg%3D&timeout=30",
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

public class Test03443 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03443_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03443_s.txt", Encoding.UTF8);

    public Test03443() : base(recordedRequest, recordedResponse, "accounts8d439fe9d911c4d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9d911c4d",
                        container: "containers152f8054009849c4b41c259f00587c11",
                        blob: "Blob1b450185990643dd9fc553cd9135c4bd",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9d8cd685/containers14adc32844294716adc8facde7fae6df/Blobb121a7e06f854deab87b9814855e7018?se=2017-01-11T10%3A48%3A29.4781866Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2BYr3lLy1jrEB2CAG2uBmvsDjQkysX3JYFsmjFNHVWnU%3D&timeout=30",
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

public class Test02956 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02956_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02956_s.txt", Encoding.UTF8);

    public Test02956() : base(recordedRequest, recordedResponse, "accounts8d439fe980c1b92")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe980c1b92",
                        container: "containers0c63343ed554400695463325544b911c",
                        blob: "Blob2962fcac09a745f493ba8c8446c13d33",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9806c459/containersc749a15d805e4519a20c8b2cc8070095/Bloba13ba36c88fe4d248095ef476c84f5f6?se=2017-01-11T10%3A48%3A20.2639322Z&sv=2016-05-31&sr=c&sp=rwd&sig=iPOnT9tbG7XCyf29fpSWkLpnOfrBlxDIYaG09ny%2BGew%3D&timeout=30",
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

public class Test03356 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03356_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03356_s.txt", Encoding.UTF8);

    public Test03356() : base(recordedRequest, recordedResponse, "accounts8d439fe9c8b1c36")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9c8b1c36",
                        container: "containerscaee2805176946e1b9d6dbe22bf7cc90",
                        blob: "Blob8249d5a8a27d432baf2286e41c16fd9c",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9c904c52/containers68509c4c84ba4997afc19c467977f775/Blob913b32dfbba246c49031a49499ae49b2?se=2017-01-11T10%3A48%3A27.8181410Z&sv=2016-05-31&sr=c&sp=rwd&sig=BRBROOLLEa2QhyljdfrJhJqWxt0g8lqsQOH1%2FjcOmyQ%3D&timeout=30",
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

public class Test01845 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01845_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01845_s.txt", Encoding.UTF8);

    public Test01845() : base(recordedRequest, recordedResponse, "accounts8d439fe89fd601b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe89fd601b",
                        container: "containers7d077e80c991473fa855b994cf1e66bc",
                        blob: "Blob190e8b3aacc04708984a299b9231634b",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe89fd601b/containers312806738b4e445992d07aaaf602e7d4/Blob7d01cc8f876d47588b5ce54fd07a3f39?se=2017-01-11T10%3A47%3A56.6862817Z&sv=2016-05-31&sr=c&sp=rwd&sig=Y51CBimjGuRh48J%2BYx5DIuJQXthyHV%2BNvuYIa9ISb%2FQ%3D&timeout=30",
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

public class Test02816 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02816_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02816_s.txt", Encoding.UTF8);

    public Test02816() : base(recordedRequest, recordedResponse, "accounts8d439fe9635aa90")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9635aa90",
                        container: "containersdc9c2ef92ac74157bd9812823068d4ac",
                        blob: "Blobefdd4bf16c824c5c997745725bffde2d",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe96300537/containers61c94539f16642f19cf753a174b9caa4/Blobf965d07da3c849e18daa39877d5d4ca5?se=2017-01-11T10%3A48%3A17.1788472Z&sv=2016-05-31&sr=c&sp=rwd&sig=WQP6%2FdHE4YNaf%2B%2FjmbY9FU1UV2j8fC9opXoR7eYzq2A%3D&timeout=30",
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

public class Test02769 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02769_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02769_s.txt", Encoding.UTF8);

    public Test02769() : base(recordedRequest, recordedResponse, "accounts8d439fe958df7ad")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe958df7ad",
                        container: "containersb0cd4dccb754484b9b1587351d03c57c",
                        blob: "Blob15dd8cb5a1d04f77a7f6ad6644dd8c6d",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9587dd28/containersb60493a230954985b470a225e8d44196/Blobf7fb97cd5b1e49259953a41930a14dfa?se=2017-01-11T10%3A48%3A16.0908184Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2B02twtgSihK37bHKAhnhOS%2Bf5ounbik7vzGNJ3lDWiM%3D&timeout=30",
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

public class Test02166 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02166_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02166_s.txt", Encoding.UTF8);

    public Test02166() : base(recordedRequest, recordedResponse, "accounts8d439fe8e2fedde")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8e2fedde",
                        container: "containers8fdfdda04b9d45d6ab513f9232d8ace2",
                        blob: "Blob03872edee8cf4d0b990b0dddf685e091",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8e29d350/containersb8497aafa0a34572bf8d6416c2c0bcd3/Blob38d0aee5038744b6bd83c79038242b3c?se=2017-01-11T10%3A48%3A03.7374769Z&sv=2016-05-31&sr=c&sp=rwd&sig=k2oi5tVWf1nidDoOWxdHVP5t6FED%2BcMECttYmFb7gj0%3D&timeout=30",
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

public class Test02863 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02863_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02863_s.txt", Encoding.UTF8);

    public Test02863() : base(recordedRequest, recordedResponse, "accounts8d439fe96cd7ecb")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe96cd7ecb",
                        container: "containerse151ef6e6c6249b2a0722c9d47dc68f1",
                        blob: "Blob06496ed63b9846798c68dfe9dcb485bd",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe96c7b262/containers3584529997b04b3d87f1c9b0650c3638/Blob6b32343c2ac54618b3f73e6840c25169?se=2017-01-11T10%3A48%3A18.1858781Z&sv=2016-05-31&sr=c&sp=rwd&sig=yCsA6WRtUgKUh0rC9rnqP%2Bd3cip7iqZdNT69eeBC6Uo%3D&timeout=30",
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

public class Test01992 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01992_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01992_s.txt", Encoding.UTF8);

    public Test01992() : base(recordedRequest, recordedResponse, "accounts8d439fe8bc726dd")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8bc726dd",
                        container: "containers2b1852dfcd1d418685dd03c83d16f6c9",
                        blob: "Blob0ba5d541127349d6ad9319aadd827dbd",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8bc1335f/containers33f5c6a679b047bbafbafe10080cd80c/Blob00a7ba9c891d4fd385b0782d6b2d38eb?se=2017-01-11T10%3A47%3A59.6733636Z&sv=2016-05-31&sr=c&sp=rwd&sig=nxfks2C7HWCzJHdailsdWkDaVBqTf6I1%2BaEsy6514rQ%3D&timeout=30",
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

public class Test02596 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02596_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02596_s.txt", Encoding.UTF8);

    public Test02596() : base(recordedRequest, recordedResponse, "accounts8d439fe93230dd7")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe93230dd7",
                        container: "containers2a77000fb94f41b9b8d3e47ddbfedad5",
                        blob: "Blobaa37a8bb9e464f44b6ca3e65c2556b4d",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe931db695/containersf4ed1ab2a7fd45a38f0f97904a9da3db/Blob57a6c2daf16f44d090295a981eee2ee3?se=2017-01-11T10%3A48%3A12.0347052Z&sv=2016-05-31&sr=c&sp=rwd&sig=XG0GNjmj5WxFhNXZ%2FqB%2BMH1aUyOchEsLAvjNQOS77u8%3D&timeout=30",
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

public class Test03492 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03492_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03492_s.txt", Encoding.UTF8);

    public Test03492() : base(recordedRequest, recordedResponse, "accounts8d439fe9e208c11")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9e208c11",
                        container: "containers37788d17943f4b5cab8fb1974ae95267",
                        blob: "Blob98cf45120df3461e9e74fa6f1c7b254d",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9e1ae6c0/containers2cab199311d9433488b26d89172fd5f2/Blob2a887ced160d46118e2a4c8a8c21b8d2?se=2017-01-11T10%3A48%3A30.4342137Z&sv=2016-05-31&sr=c&sp=rwd&sig=rWoEJgF4t38E%2FaG82IicpEkzwpwxb%2ByKSPulVcW1J00%3D&timeout=30",
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

public class Test02026 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02026_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02026_s.txt", Encoding.UTF8);

    public Test02026() : base(recordedRequest, recordedResponse, "accounts8d439fe8c386004")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8c386004",
                        container: "containers506aedecb81c4f48a744042fdfe372a4",
                        blob: "Blob699b307d6d3148dbaaea4492ad805bc0",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8c3e538f/containerse10146fe26e9483bad9a89b1d0ec870c/Blob36600657865b4400a60c06b5b71f17d1?se=2017-01-11T10%3A48%3A00.4783861Z&sv=2016-05-31&sr=c&sp=rwd&sig=IQKSSAdoMxnHkBqkEbOXpRZvV%2FQNdE88HHC%2B35taqLc%3D&timeout=30",
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

public class Test02948 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02948_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02948_s.txt", Encoding.UTF8);

    public Test02948() : base(recordedRequest, recordedResponse, "accounts8d439fe97f007ed")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe97f007ed",
                        container: "containers8169873126784aea929d17eed9e1ffe3",
                        blob: "Blobb0f57571a37644e9a7058c093d7fbcd5",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe97ea6286/containers598db0d0c41c481c9bebbb0c7c9ace15/Blob5c105357d2b6449e83035a58c3a33b16?se=2017-01-11T10%3A48%3A20.0809271Z&sv=2016-05-31&sr=c&sp=rwd&sig=ocpWP63UtG%2BTPw6bHEDzEsXfpi97Hc%2Bg0XFfHsorp54%3D&timeout=30",
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

public class Test03523 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03523_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03523_s.txt", Encoding.UTF8);

    public Test03523() : base(recordedRequest, recordedResponse, "accounts8d439fe9e8282e6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9e8282e6",
                        container: "containersd07801a9b0b143ebbfb9304310cec288",
                        blob: "Blob966ba6ff685c45708843f56c23cecc50",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9e7d0498/containers979690ae52ab4d3ba53a69fd433ceeea/Blob7b58c6c4875a4be2ba6e933ba9abefa4?se=2017-01-11T10%3A48%3A31.0782319Z&sv=2016-05-31&sr=c&sp=rwd&sig=1vn56Jewp3w4uKrWtmanpXxaBpfSbCMJNx%2BEgTQ5cug%3D&timeout=30",
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

public class Test02677 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02677_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02677_s.txt", Encoding.UTF8);

    public Test02677() : base(recordedRequest, recordedResponse, "accounts8d439fe9441c661")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9441c661",
                        container: "containersba048ef1f1c4462bab390e54cf7f8852",
                        blob: "Blobc352ce5f61c44518aed518e99697ccef",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe944807f2/containerse247e7330f6640c699263755a7a54015/Blobd1072d3feb3c4a30b739e98bc70f88e8?se=2017-01-11T10%3A48%3A13.9637592Z&sv=2016-05-31&sr=c&sp=rwd&sig=1OZcABxqJUeuo41%2BuIME0SGk2IuUXMSmcrWHBJ6W%2FYA%3D&timeout=30",
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

public class Test03372 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03372_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03372_s.txt", Encoding.UTF8);

    public Test03372() : base(recordedRequest, recordedResponse, "accounts8d439fe9cc454fb")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9cc454fb",
                        container: "containers29a6919145c146a492120220e5e62970",
                        blob: "Blob5c62d973ed3348c8ba6d883ad33399b5",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9cc9fa58/containers22a4d43ccb0044be92ae339b860d07c2/Blob87095d27a8294bfaa659cb1b0f6a7024?se=2017-01-11T10%3A48%3A28.1961517Z&sv=2016-05-31&sr=c&sp=rwd&sig=9hkfNbw9cbGnwva5kFezIspZ5UP%2F4Dgar4D%2FyU4cJT8%3D&timeout=30",
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

public class Test02888 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02888_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02888_s.txt", Encoding.UTF8);

    public Test02888() : base(recordedRequest, recordedResponse, "accounts8d439fe97264dd9")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe97264dd9",
                        container: "containersa52d4153747a464e9a47feedc31120d6",
                        blob: "Blob095d596114474f65accae1c846e13861",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe97208162/containers8fd6cf9230b94da696e53f948dc0be04/Blob7356defc8b8d4574958618e59966d710?se=2017-01-11T10%3A48%3A18.7568912Z&sv=2016-05-31&sr=c&sp=rwd&sig=yoLV67eTFCWAQ1rQgNe%2FIrigJ3yLNqCwqy6LZYG6FYY%3D&timeout=30",
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

public class Test02268 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02268_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02268_s.txt", Encoding.UTF8);

    public Test02268() : base(recordedRequest, recordedResponse, "accounts8d439fe8fa63cde")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8fa63cde",
                        container: "containers9773cb7567db457884e486b50529b45d",
                        blob: "Blob725b9e9d3eac4fda997657bc772b51ea",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8fa07067/containers2992dee021bc45f9baa5b9c1b24d3e0c/Blobd193c7de1c194c0989ffd5eace5da1a2?se=2017-01-11T10%3A48%3A06.1775482Z&sv=2016-05-31&sr=c&sp=rwd&sig=Xd%2FMzSBA0dLza7osg%2B%2F2FQyLi4FCmDsJnpCmT4WO1Ek%3D&timeout=30",
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

public class Test02451 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02451_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02451_s.txt", Encoding.UTF8);

    public Test02451() : base(recordedRequest, recordedResponse, "accounts8d439fe91a089c4")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe91a089c4",
                        container: "containersa902af7c256d4521ba5a1fe6f49a1e04",
                        blob: "Blob8e68cec0f4324fb093f8f9ba6c9a7891",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe91a089c4/containers92b6143f655c464181b2e1a7ef90079e/Blob934b95cd58cd4d999b116b233373a1e1?se=2017-01-11T10%3A48%3A09.4886357Z&sv=2016-05-31&sr=c&sp=rwd&sig=IQIDSgq0ryw5gME0UOxnkDD3tOB0bdrtbLquz0JX%2BjM%3D&timeout=30",
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

public class Test01967 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01967_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01967_s.txt", Encoding.UTF8);

    public Test01967() : base(recordedRequest, recordedResponse, "accounts8d439fe8b6e09c1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8b6e09c1",
                        container: "containers79186a24cb3c40598a201abba98fc684",
                        blob: "Blob9326f23c27104f52a9ce66ca9a45de6f",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8b68645f/containers5bff3d68565c4b6eb49cb6ab8a9fad89/Bloba871be8374074b6db444c9b635ac96e2?se=2017-01-11T10%3A47%3A59.1123492Z&sv=2016-05-31&sr=c&sp=rwd&sig=UyAcZJ1hmlNnOgv77MeWsyXhTwadb2LmGvLzvXElEQk%3D&timeout=30",
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

public class Test02872 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02872_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02872_s.txt", Encoding.UTF8);

    public Test02872() : base(recordedRequest, recordedResponse, "accounts8d439fe96ec51b2")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe96ec51b2",
                        container: "containerscb90188830584ba697f4d3021f350c9c",
                        blob: "Blob5da0eb6b4d014f458826cf68a12e785b",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe96e6d376/containersf4010a7af669420aa6aa361aa47be9a1/Blobc2ee834e208341f89a35d81418f2f605?se=2017-01-11T10%3A48%3A18.3888807Z&sv=2016-05-31&sr=c&sp=rwd&sig=Aq5DXJwyl07XfU1bqIyC7o4m5OGB46NctC6AF9v4lO0%3D&timeout=30",
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

public class Test02121 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02121_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02121_s.txt", Encoding.UTF8);

    public Test02121() : base(recordedRequest, recordedResponse, "accounts8d439fe8d913bcd")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8d913bcd",
                        container: "containers2eb1c09af40c48bdac962a44e43f20e6",
                        blob: "Blob06696bf055344229ab975fdac3e39aef",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8d8cf5f8/containers7e0d83f5261a4f349dcfc7ae90cf82b5/Blob2891e2f3656143b5a3cdaa596be149e5?se=2017-01-11T10%3A48%3A02.6714452Z&sv=2016-05-31&sr=c&sp=rwd&sig=Na1a6d8NG38ltZZKyC08vj6Ust4uL8tCxvhSqMdebIw%3D&timeout=30",
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

public class Test02836 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02836_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02836_s.txt", Encoding.UTF8);

    public Test02836() : base(recordedRequest, recordedResponse, "accounts8d439fe96723ece")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe96723ece",
                        container: "containers78095da8cab64c25a41bfc7afbc3a63c",
                        blob: "Blob18450d0f37ec42c9b491fec305133f7e",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe966d0e9c/containersf87b0a5aed384093a3c51ae8e8944cfb/Blob63d7f72c205d4e50b35b4a03efa93f29?se=2017-01-11T10%3A48%3A17.5838582Z&sv=2016-05-31&sr=c&sp=rwd&sig=cNzU1fmD8QgohsTyG6puvauGeYDu5p6IyrlLDUCDJgk%3D&timeout=30",
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

public class Test02284 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02284_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02284_s.txt", Encoding.UTF8);

    public Test02284() : base(recordedRequest, recordedResponse, "accounts8d439fe8fe0fc67")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8fe0fc67",
                        container: "containers30ffafd5c6a741b093acd8f80e3806e0",
                        blob: "Blob219f4aca94be4c0cb37229794542c3e1",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8fdb56e6/containers8f4a02c152624834b0f2d3131b98c2af/Blob3dfb89d1a45e4fd7bcebfecea9ffe411?se=2017-01-11T10%3A48%3A06.5605545Z&sv=2016-05-31&sr=c&sp=rwd&sig=u7nhAgKowLiHHTqcwyc%2Bbev6VWbuLGpz4E0BzKTFKa4%3D&timeout=30",
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

public class Test02008 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02008_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02008_s.txt", Encoding.UTF8);

    public Test02008() : base(recordedRequest, recordedResponse, "accounts8d439fe8bff9c6b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8bff9c6b",
                        container: "containersf60105334232408caf300865586f7d48",
                        blob: "Blob38d8c7e33d6c4e02a680600e600ddc86",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8bf9f70e/containersd8ea3b0b699c41e2b920182c5596daa7/Blobb065edbd9ce3421d9487ec96652cf713?se=2017-01-11T10%3A48%3A00.0503743Z&sv=2016-05-31&sr=c&sp=rwd&sig=vHtpi0IljwynYoCWfQsX5%2Fb%2FL4HCb8xexFETa9VomwQ%3D&timeout=30",
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

public class Test03541 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03541_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03541_s.txt", Encoding.UTF8);

    public Test03541() : base(recordedRequest, recordedResponse, "accounts8d439fe9ebf3e33")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9ebf3e33",
                        container: "containers1363d987dd984749a552bba2f5cdeba2",
                        blob: "Blobf102fe4800a34bb08e33599513f17a6e",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9eb998d6/containerscbb5e235a722409c92af768d536da7c2/Blobff2aeda5242741f69f30fa9d4e384a98?se=2017-01-11T10%3A48%3A31.4862420Z&sv=2016-05-31&sr=c&sp=rwd&sig=TvDrc96GNVXQo%2FovcgxVl6vZOVHKTbrWRWK1M3zs3Ek%3D&timeout=30",
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

public class Test02722 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02722_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02722_s.txt", Encoding.UTF8);

    public Test02722() : base(recordedRequest, recordedResponse, "accounts8d439fe94e02a49")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe94e02a49",
                        container: "containers03da933d658b4c88b9cd4615ef948df1",
                        blob: "Blob50cfb755b18d46bd8eff8dac44374c50",
                        copySource: @"http://localhost.fiddler:10000/ardfepirv28d439fe94e644d/containers02f94c7054474a439aa33bfc71084ada/Blobf8996222ab7c47fcb33cc21f304b0046?se=2017-01-11T10%3A48%3A15.0007895Z&sv=2016-05-31&sr=c&sp=rwd&sig=ca%2BKlf%2BBPoy%2F3Yw%2FQzqLTxAe2RvD%2BbvD3ukPFPWMv7E%3D&timeout=30",
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

public class Test02659 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02659_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02659_s.txt", Encoding.UTF8);

    public Test02659() : base(recordedRequest, recordedResponse, "accounts8d439fe9401fdbb")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9401fdbb",
                        container: "containers5764375796834c15b04d5998e35a8c4c",
                        blob: "Blobea84247af43149d9ad26eed973315624",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe94081852/containers40e3e17026224e5da301ca413bc0aa68/Blob6d47efbd363a45439d71b857207f9bbd?se=2017-01-11T10%3A48%3A13.5297477Z&sv=2016-05-31&sr=c&sp=rwd&sig=pYIJJYpcBzTAZox3kqk5YmKGp5hgZU46chwqEXGNBU0%3D&timeout=30",
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

public class Test02906 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02906_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02906_s.txt", Encoding.UTF8);

    public Test02906() : base(recordedRequest, recordedResponse, "accounts8d439fe975f5fa3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe975f5fa3",
                        container: "containersea47d109a1884dcab4c393bd1234310d",
                        blob: "Blob1b92492f7d194ded8656fd5468229db7",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe975a0858/containersb183f6b50dd84af8b7cd23be21881720/Blobaa556cf6247a4da0a5730fe678067424?se=2017-01-11T10%3A48%3A19.1379024Z&sv=2016-05-31&sr=c&sp=rwd&sig=jmfGS%2Fc6iFA2xeIwJUm2zoWUg%2ByhktEheWlcjPYmIKw%3D&timeout=30",
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

public class Test03064 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03064_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03064_s.txt", Encoding.UTF8);

    public Test03064() : base(recordedRequest, recordedResponse, "accounts8d439fe992a10b9")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe992a10b9",
                        container: "containers1b22f2b31f544f4396d38b485cd4144b",
                        blob: "Blobee49f88b00174f1fac0ada5b366e81ec",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe992a10b9/containers91c9d8d2dfdd4adcaf3630092cdbda57/Blob94a3738333454c69a45067953ec9181b?se=2017-01-11T10%3A48%3A22.1109833Z&sv=2016-05-31&sr=c&sp=rwd&sig=qk9Wm5%2BJ%2B5h0m%2F9uoQVSqaPltvoBTqEhcw%2FFasbSVbg%3D&timeout=30",
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

public class Test03104 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03104_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03104_s.txt", Encoding.UTF8);

    public Test03104() : base(recordedRequest, recordedResponse, "accounts8d439fe998e7887")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe998e7887",
                        container: "containers31f66827647c41b38fa36b00af21d782",
                        blob: "Blob4b68712e57e7492ea701b89742a19b75",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe998e7887/containersedee42ad35664625a6949841e1921484/Blobce061dc52d124593b9a89db3274ea035?se=2017-01-11T10%3A48%3A22.7660011Z&sv=2016-05-31&sr=c&sp=rwd&sig=CBXWCQqmgKj96%2Bm5MloIH4taviZ18vxemaRfdlM4rqY%3D&timeout=30",
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

public class Test03383 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03383_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03383_s.txt", Encoding.UTF8);

    public Test03383() : base(recordedRequest, recordedResponse, "accounts8d439fe9ce1530a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9ce1530a",
                        container: "containers4f09fd6319d842afbd677897c8f072c0",
                        blob: "Blobe6f7d1b5401e44578e79f58591e3ebf5",
                        copySource: @"http://localhost.fiddler:10000/zrdfepirv28d439fe9ce71f8/containers84ced2b0bdd147939c38abc94593567a/Bloba5a70e4d575942f9bcfa04ac1b95dc4b?se=2017-01-11T10%3A48%3A28.4031571Z&sv=2016-05-31&sr=c&sp=rwd&sig=oTVEIZdDgN3nLaPu0T5G7SvVidHD%2BZf8S6nj%2FdGeLcQ%3D&timeout=30",
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

public class Test03035 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03035_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03035_s.txt", Encoding.UTF8);

    public Test03035() : base(recordedRequest, recordedResponse, "accounts8d439fe98deaf49")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe98deaf49",
                        container: "containersb68148f20da54ae4b9f4875beb30763a",
                        blob: "Blob5a0d7722f99e4e16a204914e5f4064b6",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe98deaf49/containers69903a03584f4b3d976576a40bf04154/Blobad9a7005fd464fb199b22c0ac6e08172?se=2017-01-11T10%3A48%3A21.6379705Z&sv=2016-05-31&sr=c&sp=rwd&sig=b%2FKkO5Esm9LAlQW7vKexgUOcg4b8oXAo0LcdWf8H5hU%3D&timeout=30",
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

public class Test02614 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02614_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02614_s.txt", Encoding.UTF8);

    public Test02614() : base(recordedRequest, recordedResponse, "accounts8d439fe93640efa")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe93640efa",
                        container: "containersecd694de49e047c5a3f3467f1e141061",
                        blob: "Blob1bbd00c6209e4d7dae80bff93cf9b15f",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe935edebb/containersf377580b2b6a4f8585bcaa2a7cec2add/Blob81741be1c6b84517bbe4addf8a29add4?se=2017-01-11T10%3A48%3A12.4527177Z&sv=2016-05-31&sr=c&sp=rwd&sig=JPQkzArMlwImu7PZO1%2FHTPFo7tEs0Zc6rSmKIOyIK38%3D&timeout=30",
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

public class Test03135 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03135_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03135_s.txt", Encoding.UTF8);

    public Test03135() : base(recordedRequest, recordedResponse, "accounts8d439fe99dc23e1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe99dc23e1",
                        container: "containersc11a42d69d914178adeec473c594c87f",
                        blob: "Blob90879f47a7ed4873acbd45da4366d7d7",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe99dc23e1/containersec333413d8b64025aac409843b49f4a9/Blobe9c5cf5df360429ca3482518308eb78e?se=2017-01-11T10%3A48%3A23.3390179Z&sv=2016-05-31&sr=c&sp=rwd&sig=X58%2FTeLtwLwZ8BAKQ%2Bld0p8Nj%2BQx6XotpXVMUual1AI%3D&timeout=30",
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

public class Test03320 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03320_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03320_s.txt", Encoding.UTF8);

    public Test03320() : base(recordedRequest, recordedResponse, "accounts8d439fe9c13c870")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9c13c870",
                        container: "containers7b4d214e93fe4a7db19fa3cd9d0f8813",
                        blob: "Blobd4fd81429c5c4cf0aba6e2134de7e71c",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9c1994e7/containersfb1550dee6ad4cba9b3cfe6c34bbd5f1/Blobb0b975e9db294e80afc42c5ea7fe5054?se=2017-01-11T10%3A48%3A27.0501213Z&sv=2016-05-31&sr=c&sp=rwd&sig=sTlFBvmZ57TI241sXLsokqLHtYy0TnCs7PR%2Bgc3lE0M%3D&timeout=30",
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

public class Test02788 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02788_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02788_s.txt", Encoding.UTF8);

    public Test02788() : base(recordedRequest, recordedResponse, "accounts8d439fe95d401ce")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe95d401ce",
                        container: "containers23df54d7ac4042d69f448ca97b64f125",
                        blob: "Blob4c22913b5edd47c6be417ac0924abc81",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe95cd9936/containers473499019eac416d977ea591cba1503b/Blob735bdd44eaf64c7d81c65de33fac1ab0?se=2017-01-11T10%3A48%3A16.5678312Z&sv=2016-05-31&sr=c&sp=rwd&sig=TlOTOys%2F7e8dp9qUoeEvO4LQXyGtRTKp77jmX5A8qeQ%3D&timeout=30",
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

public class Test03463 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03463_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03463_s.txt", Encoding.UTF8);

    public Test03463() : base(recordedRequest, recordedResponse, "accounts8d439fe9dc28ce3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9dc28ce3",
                        container: "containers7fbfc5c90cc2471a90e093de556afd6b",
                        blob: "Blob8f5eef7561174628a0ca6d23d4ad6c66",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9dbe9537/containers145d3f4f1e8b4854950310fe3b13c5db/Blob13d54c90996f418b99b10ba0d5809b21?se=2017-01-11T10%3A48%3A29.8071971Z&sv=2016-05-31&sr=c&sp=rwd&sig=w9XStw4%2FAdua5Rv2s912tDWLBPBDGjiHzlwo52aeTlY%3D&timeout=30",
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

public class Test03184 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03184_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03184_s.txt", Encoding.UTF8);

    public Test03184() : base(recordedRequest, recordedResponse, "accounts8d439fe9a7027ac")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9a7027ac",
                        container: "containersefccc0db2ec84aa895faabb39799af70",
                        blob: "Blob9cfe0a959b29483f970a8f235e62b85e",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9a7027ac/containers41c73b0844504a80b65f81d62f9b660c/Blob641989844aa34647b9fbdd803e21bd0f?se=2017-01-11T10%3A48%3A24.2650437Z&sv=2016-05-31&sr=c&sp=rwd&sig=zuByfpUJYvNgpifNwpSAHgE%2B3OJWbKNXw4mRmZQuv7M%3D&timeout=30",
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

public class Test01890 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01890_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01890_s.txt", Encoding.UTF8);

    public Test01890() : base(recordedRequest, recordedResponse, "accounts8d439fe8a830be4")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8a830be4",
                        container: "containersa7b3fc9821fa4a8da9408619df836009",
                        blob: "Blob7ceaffedb6e043c5a1bdd30572e49fea",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8a830be4/containers741eae9b41cc4c93b904ee6ef62f92b6/Blob9a20973188e24b2e83ae377aaf7af6b4?se=2017-01-11T10%3A47%3A57.5703065Z&sv=2016-05-31&sr=c&sp=rwd&sig=sQPM4eec5TbseiAlsrVy3gze2aUs4LcY2aO%2Bwz4KGzw%3D&timeout=30",
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

public class Test02740 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02740_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02740_s.txt", Encoding.UTF8);

    public Test02740() : base(recordedRequest, recordedResponse, "accounts8d439fe9523c387")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9523c387",
                        container: "containers62a52fa965f14156a99d840d5ac25f13",
                        blob: "Blob4f93c30462d74c26afebac607b9174bd",
                        copySource: @"http://localhost.fiddler:10000/ardfepirv28d439fe952a2c1/containers89eb7e3d6e3949768b7d32592eb3f39c/Bloba93bdc763aeb4c39ad78ca68ee90e854?se=2017-01-11T10%3A48%3A15.4398001Z&sv=2016-05-31&sr=c&sp=rwd&sig=eAH5WiPWsA%2F%2BK7ZyV3%2FquTh3cohwh1xUq%2B6wX0VGi1w%3D&timeout=30",
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

public class Test02922 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02922_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02922_s.txt", Encoding.UTF8);

    public Test02922() : base(recordedRequest, recordedResponse, "accounts8d439fe9799a9ea")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9799a9ea",
                        container: "containers1caceb5e704145eb9ba4e0562acf5239",
                        blob: "Blobc296aa10a46e4586869272548eecb6cf",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe97942ba5/containers22595b334e0f4cefb74711672bcdedcc/Blobae7f44665e714eb38fbd62dacdaab3a3?se=2017-01-11T10%3A48%3A19.5109113Z&sv=2016-05-31&sr=c&sp=rwd&sig=27pNOqh2H0HmiT%2B2Mna3ZE%2B4%2FQ95H5J%2FDrQg%2FkCAb%2Fo%3D&timeout=30",
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

public class Test03329 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03329_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03329_s.txt", Encoding.UTF8);

    public Test03329() : base(recordedRequest, recordedResponse, "accounts8d439fe9c35a88c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9c35a88c",
                        container: "containersc7229343f14a4775b84a84529e6509a3",
                        blob: "Blob3c7a705df03c4300b5d9c9773f0b8f40",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9c3bea2f/containersf0e692496dd340a0ae287c7b53e01597/Blob8e50932531244d458dfea59cf3dd644e?se=2017-01-11T10%3A48%3A27.2631267Z&sv=2016-05-31&sr=c&sp=rwd&sig=cOrnvoy0t5HtsYm%2Btm%2BtGiyVa2eBXZ0vg9c7nwvIOsE%3D&timeout=30",
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

public class Test02940 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02940_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02940_s.txt", Encoding.UTF8);

    public Test02940() : base(recordedRequest, recordedResponse, "accounts8d439fe97d13518")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe97d13518",
                        container: "containers6d9ef95fdc254e85bde702fd9fdf0e82",
                        blob: "Blob5968e19e48dc4c38ad61e1a94dad0b48",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe97cbddd1/containers5bc7ea4815c24c4ab633b2a54f665641/Blobc96763879876479c85c940808848b8bb?se=2017-01-11T10%3A48%3A19.8859237Z&sv=2016-05-31&sr=c&sp=rwd&sig=x45W8kyQ4XB%2BH7dvKAySzG3hEkcW0DUM0wgvVsqzF2E%3D&timeout=30",
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

public class Test03264 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03264_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03264_s.txt", Encoding.UTF8);

    public Test03264() : base(recordedRequest, recordedResponse, "accounts8d439fe9b6ba07b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9b6ba07b",
                        container: "containersf9f1e083d691467ab5d3a2f7ed6fdd20",
                        blob: "Blob851bae9f73e9476a9bb3e6b5ea7442f5",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9b662213/containers92054542b152464c832f944247c743a8/Blob5f734321f0964defbda4c6ae048a4e35?se=2017-01-11T10%3A48%3A25.9020886Z&sv=2016-05-31&sr=c&sp=rwd&sig=mKwTKw2JAFBK0c8Qz0pO6AU6TL31VhNl9huIZ8zeAc4%3D&timeout=30",
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

public class Test02103 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02103_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02103_s.txt", Encoding.UTF8);

    public Test02103() : base(recordedRequest, recordedResponse, "accounts8d439fe8d52abcc")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8d52abcc",
                        container: "containers8da30e610e374e1db66311adb445143b",
                        blob: "Blob20daa589a9da43208d134b94b133fc8a",
                        copySource: @"http://localhost.fiddler:10000/rdfepirv28d439fe8d58c651/containersa1ce0f23a1334497864913b1ef24c978/Blobaa5fb98937c646edb9bb7b594fc7627c?se=2017-01-11T10%3A48%3A02.3324377Z&sv=2016-05-31&sr=c&sp=rwd&sig=iYc%2BfUDgbFUaUIsVcIyBHkBwRYbjwLx%2Bpcc2QumwaKo%3D&timeout=30",
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

public class Test03558 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03558_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03558_s.txt", Encoding.UTF8);

    public Test03558() : base(recordedRequest, recordedResponse, "accounts8d439fe9ef98895")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9ef98895",
                        container: "containers5a33f235c4594f97a770a1043c818e69",
                        blob: "Blob67f2e2e3411d4dc69afe666c6507713f",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9ef40a31/containersc81d498a547040d7a10599db9cf0785a/Blobdfb377b1dcb54e3c890bb76d9d571005?se=2017-01-11T10%3A48%3A31.8582536Z&sv=2016-05-31&sr=c&sp=rwd&sig=l6grj19rvti0Bes6NInPuBk9tlghAygDpekAzeeEeSE%3D&timeout=30",
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

public class Test02760 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02760_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02760_s.txt", Encoding.UTF8);

    public Test02760() : base(recordedRequest, recordedResponse, "accounts8d439fe956d7722")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe956d7722",
                        container: "containersa76f279c3eb140bf8d54139de2b8ebe3",
                        blob: "Blob0506a94f7e6f408d97776420563291cf",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe956783ad/containersf7abd15030314716b2216aa6a13897af/Blob164d942d067245f4a1d469641582c558?se=2017-01-11T10%3A48%3A15.8808121Z&sv=2016-05-31&sr=c&sp=rwd&sig=MXsuN%2FdlStvHTdXGg7QfuGGQyta2cxyCg6QrickRg6Q%3D&timeout=30",
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

public class Test02854 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02854_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02854_s.txt", Encoding.UTF8);

    public Test02854() : base(recordedRequest, recordedResponse, "accounts8d439fe96af2130")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe96af2130",
                        container: "containers7d6cb511347540bdaf20c60f1c6d7cf1",
                        blob: "Blob55c35727edd740deabebd7419f44ee03",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe96a954b9/containers0d57923d55664a92be1c346d44fcfe73/Bloba837e7927ac24da58d7ff3002e79e9c2?se=2017-01-11T10%3A48%3A17.9768691Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2FfwxImLmHXOY%2F2%2BRxykV3Rb8PEOprnY4QsW3oJcR6G0%3D&timeout=30",
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

public class Test03273 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03273_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03273_s.txt", Encoding.UTF8);

    public Test03273() : base(recordedRequest, recordedResponse, "accounts8d439fe9b8a4c33")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9b8a4c33",
                        container: "containers0e2f3b4b935e4ff59005c5c406e52b15",
                        blob: "Blobf72ef9bf177947fab655495f37d25b67",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9b84f51d/containers6444553fc96a4181bfda45f3c0a04a47/Blobd96cfea672824f328a65eabb1a4c71f0?se=2017-01-11T10%3A48%3A26.1050943Z&sv=2016-05-31&sr=c&sp=rwd&sig=8vosNXhB6YZSff8eQhf4H9Mpf48mhLNay0xS91M9%2B2w%3D&timeout=30",
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

public class Test02193 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02193_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02193_s.txt", Encoding.UTF8);

    public Test02193() : base(recordedRequest, recordedResponse, "accounts8d439fe8e93e081")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe8e93e081",
                        container: "containersfe65f4e453a24566a7ca46d3fcbf6e75",
                        blob: "Blobe0a50079c1254ec39a9a39b697e41ecf",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe8e8d9ee7/containers275312aeea484064991ccdf7ef94e5c4/Blob3bd391b67bf141d8a3a913dcc246f582?se=2017-01-11T10%3A48%3A04.4034953Z&sv=2016-05-31&sr=c&sp=rwd&sig=7%2BzcUu5SBvgMd89Ve72n2x2%2BrOjNjfA91YPuSM5aWd4%3D&timeout=30",
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

public class Test02536 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02536_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02536_s.txt", Encoding.UTF8);

    public Test02536() : base(recordedRequest, recordedResponse, "accounts8d439fe927feed3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe927feed3",
                        container: "containers0584b9b95bcd4b44b51578396e23f857",
                        blob: "Blobd8edb142b9c74d08b86f2254037148a1",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe927feed3/containers0041b43323184cbebf354f6cd80ee489/Blob07c534e08fce42bbb9e2a67bcb9d87bc?se=2017-01-11T10%3A48%3A10.9516756Z&sv=2016-05-31&sr=c&sp=rwd&sig=7WyRRzw5%2Fe%2F42jYYK40bSfNgF9JUR8wYBNc9lK0GLkU%3D&timeout=30",
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

public class Test03860 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03860_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03860_s.txt", Encoding.UTF8);

    public Test03860() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersac7492bbec75428d85e73463b4a0eb2b",
                        blob: "PageBlob03f1d616ab7b4fd6997edd20c2e30b68",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersac7492bbec75428d85e73463b4a" +
    "0eb2b/PageBlob2932d6e3629c429c920efdc0be5e86f1",
                        timeout: 30,
                        sourceIfMatches: "invalidETag",
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

public class Test03290 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03290_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03290_s.txt", Encoding.UTF8);

    public Test03290() : base(recordedRequest, recordedResponse, "accounts8d439fe9bbf662d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9bbf662d",
                        container: "containers40867dfbb34e4cd09b41dbd61829171d",
                        blob: "Blob540e04a5772741d3a474da6adb0bd3b3",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9bbb6ea0/containers0338c6af1bfb475987ba2097db4f613a/Blobfee274f8012844ee82fe2b2515e84f25?se=2017-01-11T10%3A48%3A26.4271034Z&sv=2016-05-31&sr=c&sp=rwd&sig=kUqNmVj9EuHhpGLSXxdB9oOd4k%2FWPOex9OOdHudgnQY%3D&timeout=30",
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

public class Test03075 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03075_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03075_s.txt", Encoding.UTF8);

    public Test03075() : base(recordedRequest, recordedResponse, "accounts8d439fe9941dec3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9941dec3",
                        container: "containers3ffbc3513f46424e8d7772d6f250b673",
                        blob: "Blob0cc49de04683498887c1cea110f6135e",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9941dec3/containers5d7a470959294d369fbaba8be7bdb1de/Blob25e9883d34aa48499f33ae60276545c4?se=2017-01-11T10%3A48%3A22.2769881Z&sv=2016-05-31&sr=c&sp=rwd&sig=XXUFz8ydq87PkniNq0Cq2K%2FGXuWS3SUu0Ou%2BVv9SNUQ%3D&timeout=30",
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

public class Test03338 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03338_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03338_s.txt", Encoding.UTF8);

    public Test03338() : base(recordedRequest, recordedResponse, "accounts8d439fe9c54c981")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9c54c981",
                        container: "containersd26846339887445ba0517e5a25dca468",
                        blob: "Blob1a5cf4e4f4b64906941c617eb8d3e1af",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9c589a19/containers3868688c845c4931b2c49f3cb8b638ca/Blob12bd771c7e714a9ba548d68aac1a2a06?se=2017-01-11T10%3A48%3A27.4291311Z&sv=2016-05-31&sr=c&sp=rwd&sig=i2ZcbVJrR91uViWvdzmyH677OTQlGjxzJmr3yOnUD1A%3D&timeout=30",
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

public class Test02546 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02546_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02546_s.txt", Encoding.UTF8);

    public Test02546() : base(recordedRequest, recordedResponse, "accounts8d439fe929858fa")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe929858fa",
                        container: "containersffd02da71fb04cdaad8dbb65408b9e61",
                        blob: "Blobbe5005b0194a48c7a4cf2a285ee48729",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe929858fa/containersffd02da71fb04cdaad8dbb65408b9e61/Blobbe5005b0194a48c7a4cf2a285ee48729?se=2017-01-11T10%3A48%3A11.1306806Z&sv=2016-05-31&sr=c&sp=rwd&sig=dXzyuWlOlDMX9cnWCRNrPpI0EzBB8sfKonsQlS7gZXE%3D&snapshot=2017-01-11T08%3A48%3A11.1076794Z&timeout=30",
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

public class Test02489 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02489_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02489_s.txt", Encoding.UTF8);

    public Test02489() : base(recordedRequest, recordedResponse, "accounts8d439fe9201480b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9201480b",
                        container: "containersde3edcc001e0408bbf79b30542fc1d9b",
                        blob: "Blob284c29de546d419096e38401a91493fc",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9201480b/containers23937a5e77df4318a41d44ba3b22c230/Blob265f62530a1949efbd0c6851eed8915b?se=2017-01-11T10%3A48%3A10.1216523Z&sv=2016-05-31&sr=c&sp=rwd&sig=fCdxSfnJ8U7KHCyWuhtCzRTEeiLIyBicG%2F7Zdd19TFs%3D&timeout=30",
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

public class Test02518 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02518_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02518_s.txt", Encoding.UTF8);

    public Test02518() : base(recordedRequest, recordedResponse, "accounts8d439fe924d6cc8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe924d6cc8",
                        container: "containers3689a5db1371469d90b8c998d51c2961",
                        blob: "Blobf4ee09bc6df542e2b3dd3423a9464d01",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe924d6cc8/containers2f4809f92fef4fc389dcbd3153236a30/Blobfdde60ebc6ff4d9e8a5e3a01c5e4f8cc?se=2017-01-11T10%3A48%3A10.6346665Z&sv=2016-05-31&sr=c&sp=rwd&sig=Guj%2B%2BZIO6H4TyEMtQ9vtv%2BXVklrC97otPGA9h27%2FElM%3D&timeout=30",
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

public class Test03309 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03309_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03309_s.txt", Encoding.UTF8);

    public Test03309() : base(recordedRequest, recordedResponse, "accounts8d439fe9bf19a2f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9bf19a2f",
                        container: "containers7ef0810de27741119d2ce2b9356cb1c0",
                        blob: "Blobf39bf103d53543318a8722d662d34373",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9bf73fa8/containerse78de51da70e442495a0ee51963a4681/Bloba6fdfb47508d4d4c8f6efe192176a9b0?se=2017-01-11T10%3A48%3A26.8231143Z&sv=2016-05-31&sr=c&sp=rwd&sig=egczUm5klz1aaDSmbdfWASAS1eNAnmFj%2FWdlw4EX35w%3D&timeout=30",
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

public class Test02712 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02712_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02712_s.txt", Encoding.UTF8);

    public Test02712() : base(recordedRequest, recordedResponse, "accounts8d439fe94bdade8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe94bdade8",
                        container: "containers296e6b97ea744d338a1b247cd9ddea18",
                        blob: "Blobd586f186175242a099753ab1900830cf",
                        copySource: @"http://localhost.fiddler:10000/ardfepirv28d439fe94c3ef9/containersf87b19391b0f48a0af3f0217a4239523/Blobb55bda62daad4ef296117585533d6bf1?se=2017-01-11T10%3A48%3A14.7787853Z&sv=2016-05-31&sr=c&sp=rwd&sig=aV%2Bx17Gl8OdZ1R%2FNM2tnCNbk2HqKUEpNsTH127NGvQg%3D&timeout=30",
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

public class Test03592 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03592_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03592_s.txt", Encoding.UTF8);

    public Test03592() : base(recordedRequest, recordedResponse, "accounts8d439fe9f6ce490")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9f6ce490",
                        container: "containers0040b86188a34e10950e2964de3d5f3e",
                        blob: "Blob1a6af398a0084ed8802c03c67f38fb85",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9f673f37/containersd0d671c5c1a24c4abe838e2f46866d3a/Blob902fa3242cc04446a70280aa139056fb?se=2017-01-11T10%3A48%3A32.6162732Z&sv=2016-05-31&sr=c&sp=rwd&sig=uK6rmTpMA46RAwzpTFihgnBwVXokehsISoCgH5%2F83%2FE%3D&timeout=30",
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

public class Test03403 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03403_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03403_s.txt", Encoding.UTF8);

    public Test03403() : base(recordedRequest, recordedResponse, "accounts8d439fe9d205849")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9d205849",
                        container: "containers856c37a055764fad99c4b363c831bad4",
                        blob: "Blob0a259a4fe03843cb8b94d4ac4e68e30d",
                        copySource: @"http://localhost.fiddler:10000/zrdfepirv28d439fe9d24ec4/containers1b245bd2f60f47a7b4cd411c3de7b470/Blob39dde2426eda442b9fa526b2aab23dd7?se=2017-01-11T10%3A48%3A28.7861678Z&sv=2016-05-31&sr=c&sp=rwd&sig=fnMuiPsCXYwz7J9UYqVzHpwBjS5o7LOYX1KYv9fUcto%3D&timeout=30",
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

public class Test03235 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03235_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03235_s.txt", Encoding.UTF8);

    public Test03235() : base(recordedRequest, recordedResponse, "accounts8d439fe9b027da3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9b027da3",
                        container: "containers28b4418691d9448baf68a0aad3c54723",
                        blob: "Blobfea3a8bb373d476483932cb2606b1378",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9afc3bf7/containersb4aeb786c7a440ba9e210a9197b4d316/Blob0899b103db1f43e287323f157e18d987?se=2017-01-11T10%3A48%3A25.2300701Z&sv=2016-05-31&sr=c&sp=rwd&sig=8UC15pB7W6JhZHBotAcS5O%2FndZ9WMFt0WJaPM6mFBGI%3D&timeout=30",
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

public class Test03566 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03566_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03566_s.txt", Encoding.UTF8);

    public Test03566() : base(recordedRequest, recordedResponse, "accounts8d439fe9f157521")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9f157521",
                        container: "containers5ec10f39edb7488e9cc14820489c9a19",
                        blob: "Blobe6fe3620494d4bb5b10530ec559a77cf",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9f0ff6cb/containers7b7e36afd0cf437abf1b71c9a930517d/Blobd0caf084e6bb49dda4543744eac5a7c8?se=2017-01-11T10%3A48%3A32.0432573Z&sv=2016-05-31&sr=c&sp=rwd&sig=5kO1YgKTQjemb6F3Iwbiw0KU3eK50aHoBM1M5X%2B4TCw%3D&timeout=30",
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

public class Test03584 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03584_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03584_s.txt", Encoding.UTF8);

    public Test03584() : base(recordedRequest, recordedResponse, "accounts8d439fe9f4f7144")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9f4f7144",
                        container: "containersfddaf60ddc6b43a1b49d1d865bb81b85",
                        blob: "Blobce7555f1ce0145fdb2509b4342e15888",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9f49f2ff/containers6cdaf31762b74533b306956c2a74b1d6/Blobb353d3c412a5401f95c30361b6f523c1?se=2017-01-11T10%3A48%3A32.4282690Z&sv=2016-05-31&sr=c&sp=rwd&sig=RxxMO%2BpW9lzBvBuSqkQ6Hz%2FJIkc86tsP9qLkS7O%2Fg0U%3D&timeout=30",
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

public class Test02630 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02630_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02630_s.txt", Encoding.UTF8);

    public Test02630() : base(recordedRequest, recordedResponse, "accounts8d439fe93a55e23")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe93a55e23",
                        container: "containerse6ab9663a8794656b02c9884df8ca154",
                        blob: "Blob43e65906770d460e8daaed6345820f21",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe939f4390/containersf8df3592f1b649fc8913e504a7115647/Blobda58514022b44490bb1f3dd702fb1045?se=2017-01-11T10%3A48%3A12.8957302Z&sv=2016-05-31&sr=c&sp=rwd&sig=QF9fmfAa71kyoC2xIZL1CEKgTked91ybpCqs2YxNjN8%3D&timeout=30",
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

public class Test03055 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03055_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03055_s.txt", Encoding.UTF8);

    public Test03055() : base(recordedRequest, recordedResponse, "accounts8d439fe991269df")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe991269df",
                        container: "containersf4b004c9a69f45a9abdb016324a2fc5c",
                        blob: "Bloba06b2f3cb99b4d68bb8f83f178c344d2",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe991269df/containersae870af9c10e40c6a41001c1ae1fd6a4/Blobd647cbafcb144a98bbb9dedf6e619687?se=2017-01-11T10%3A48%3A21.9569800Z&sv=2016-05-31&sr=c&sp=rwd&sig=5xi6rimoF2shcdXIPE5lZCIQS6%2FQEnHL9lB8Te60so0%3D&timeout=30",
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

public class Test03483 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03483_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03483_s.txt", Encoding.UTF8);

    public Test03483() : base(recordedRequest, recordedResponse, "accounts8d439fe9dfb2979")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9dfb2979",
                        container: "containersa7e1e9e9f1044ae0a7c953ad9cad01d9",
                        blob: "Blobb590f00c0bbc403ab4f8f3466fb61594",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9df5ab2b/containers4d902b4e94db47c8aebaffbc77610f0f/Blob617a0df5ebf3476887cf9c1ac7b84088?se=2017-01-11T10%3A48%3A30.2332075Z&sv=2016-05-31&sr=c&sp=rwd&sig=tPyYrhFFOiT7u12OYJlofLcvgfjG31R9vSJe4O3goAs%3D&timeout=30",
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

public class Test03175 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03175_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03175_s.txt", Encoding.UTF8);

    public Test03175() : base(recordedRequest, recordedResponse, "accounts8d439fe9a560fb9")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9a560fb9",
                        container: "containers88a239a0cb8a41538d64de49fcb1b0c1",
                        blob: "Blobfa6d74ec65364d71b368eff60dc034a8",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9a560fb9/containers110e3332402848c0af0467dd64a4c9f4/Blob314db3721c4646c5b2875a2da3b3a190?se=2017-01-11T10%3A48%3A24.0880410Z&sv=2016-05-31&sr=c&sp=rwd&sig=38SVMHFS94%2F9bjl6yuQVtUAKSgyonOTlCvn0S3zDZVk%3D&timeout=30",
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

public class Test02880 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02880_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02880_s.txt", Encoding.UTF8);

    public Test02880() : base(recordedRequest, recordedResponse, "accounts8d439fe970a1323")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe970a1323",
                        container: "containersa946f20f733847eea0cd9212f718299f",
                        blob: "Blob739e35217b654998bc7dc6459b60bb6d",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9704e2e0/containers8b3f8f0a7226496fa909ef08ac227e29/Blob0d538cf7f786495e9c8f4f1e3c7792a4?se=2017-01-11T10%3A48%3A18.5718853Z&sv=2016-05-31&sr=c&sp=rwd&sig=vuzvt%2ByN3Tq7rbGADWNrmEIr6eevt35aZtHjGcPfACQ%3D&timeout=30",
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

public class Test02442 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02442_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02442_s.txt", Encoding.UTF8);

    public Test02442() : base(recordedRequest, recordedResponse, "accounts8d439fe9187354f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9187354f",
                        container: "containersfd73e38d8d754fa2be38b3774b06781a",
                        blob: "Blobe3e5666046484f18984bd69a8d892b6e",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9187354f/containers59166c1eba834cb3b7b7b17561538c0f/Blob78822ae5a5be498fa1dd1948a94ee428?se=2017-01-11T10%3A48%3A09.3306305Z&sv=2016-05-31&sr=c&sp=rwd&sig=JHbxc35huHNu8tXYGINzmAB5stW5au%2B%2Fiw3tPq8IOd0%3D&timeout=30",
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

public class Test03204 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03204_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03204_s.txt", Encoding.UTF8);

    public Test03204() : base(recordedRequest, recordedResponse, "accounts8d439fe9aa9fcb1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9aa9fcb1",
                        container: "containers70c93840c1c64ae7b778d12db3edbbc4",
                        blob: "Blob17c3ae63a34649b3a800b7084fd69525",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9aa9fcb1/containers70c93840c1c64ae7b778d12db3edbbc4/Blob17c3ae63a34649b3a800b7084fd69525?se=2017-01-11T10%3A48%3A24.6680548Z&sv=2016-05-31&sr=c&sp=rwd&sig=5IJOS8d6KCpTh5nznbOyRIcHDTCNfk6i1lvhXlBh9jk%3D&snapshot=2017-01-11T08%3A48%3A24.6630551Z&timeout=30",
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

public class Test03214 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03214_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03214_s.txt", Encoding.UTF8);

    public Test03214() : base(recordedRequest, recordedResponse, "accounts8d439fe9ac63781")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9ac63781",
                        container: "containersb0cb7f145ada40b99f842d50ba240c22",
                        blob: "Blobd7fd6fdfad98417bb0b366322ef592a3",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9ac63781/containersb0cb7f145ada40b99f842d50ba240c22/Blobd7fd6fdfad98417bb0b366322ef592a3?se=2017-01-11T10%3A48%3A24.8520598Z&sv=2016-05-31&sr=c&sp=rwd&sig=yGd%2BsBAy%2BHm%2FwKjUz12fL%2F5Oyfpyv1l8AHuMGmBxlq8%3D&snapshot=2017-01-11T08%3A48%3A24.8450597Z&timeout=30",
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

public class Test03434 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03434_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03434_s.txt", Encoding.UTF8);

    public Test03434() : base(recordedRequest, recordedResponse, "accounts8d439fe9d757dcf")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9d757dcf",
                        container: "containerseed11bcb778d4a75ac53885bfe8c02c7",
                        blob: "Blob37a6f32cf7a040df91b3a23b48987689",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9d715f0e/containerse52dfb7bc2664a7cbfc9d98e18532a74/Blob3a744a9dc878464fba9c1100733b201b?se=2017-01-11T10%3A48%3A29.3001816Z&sv=2016-05-31&sr=c&sp=rwd&sig=Ey4c67%2Fof3AcNaMQsdi5%2B05LnPssoDDx9UNrJJaX5b0%3D&timeout=30",
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

public class Test03095 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03095_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03095_s.txt", Encoding.UTF8);

    public Test03095() : base(recordedRequest, recordedResponse, "accounts8d439fe99771fcd")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe99771fcd",
                        container: "containers18228255b0ab4068b8aaf4f4a2aa8cbc",
                        blob: "Blob4682c118d97a4d299aca0252a6d77df2",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe99771fcd/containersa8097179e5de4c8fb805f81bb36cda7a/Blob17c9520686824cbb8b78ff73e4e33ca8?se=2017-01-11T10%3A48%3A22.6149974Z&sv=2016-05-31&sr=c&sp=rwd&sig=h%2BboAH0wKwaG%2BSFPxM%2F3REPNwT2NkDbvFv5%2B7Rg9d1I%3D&timeout=30",
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

public class Test02778 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02778_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02778_s.txt", Encoding.UTF8);

    public Test02778() : base(recordedRequest, recordedResponse, "accounts8d439fe95aeed71")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe95aeed71",
                        container: "containers7b0dd3b54b2d4acdb3fa6ecbc47b4f59",
                        blob: "Blob03eb28549f7d45cdb1bfc9ce7e8d9df1",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe95a8abd3/containers4e7e1a6cc6d74f93b3527204d4e2355c/Bloba90019548bb04f9bbf6df8f13ea9921d?se=2017-01-11T10%3A48%3A16.3308228Z&sv=2016-05-31&sr=c&sp=rwd&sig=qYCXM80ksSa4TyhhJiTOe%2FoOLT5IpQJx7oZ10lK87x4%3D&timeout=30",
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

public class Test03514 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03514_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03514_s.txt", Encoding.UTF8);

    public Test03514() : base(recordedRequest, recordedResponse, "accounts8d439fe9e625077")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9e625077",
                        container: "containersaa67a54683ab4928bedb324741c4f3ee",
                        blob: "Blobe27cc0ce802f46ee842e3ef7da2ae639",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9e5cd22e/containerse9b303392d8947bd8c3546246a6acb71/Blobb8f84633f41449ad956e1b1adc427628?se=2017-01-11T10%3A48%3A30.8742310Z&sv=2016-05-31&sr=c&sp=rwd&sig=Lk%2Becp8%2FrOUdKsi7uXAYLNYtpz%2BsN9T29%2FDV9TjP1bE%3D&timeout=30",
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

public class Test03452 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03452_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03452_s.txt", Encoding.UTF8);

    public Test03452() : base(recordedRequest, recordedResponse, "accounts8d439fe9daa97e9")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9daa97e9",
                        container: "containers2aa603a22340475eb8865eb22bb2987d",
                        blob: "Blobcaafd5c7234d43e2942d46c424885ad1",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9da60409/containers2af44418415b43d3a1380fac83e8a117/Blob6603e033d94f459b887197c5018e8339?se=2017-01-11T10%3A48%3A29.6441919Z&sv=2016-05-31&sr=c&sp=rwd&sig=qP5Inq0EITb5UeCZVJLe6dgTwWGJJsB8pL2yMmUDe4s%3D&timeout=30",
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

public class Test03126 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03126_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03126_s.txt", Encoding.UTF8);

    public Test03126() : base(recordedRequest, recordedResponse, "accounts8d439fe99c0ac6f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe99c0ac6f",
                        container: "containersb66c990016244394839678af5650a97c",
                        blob: "Blobd599f3f0720944ffb95cd443b7e80e55",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe99c0ac6f/containers910c3d20cd344893892e3f22a09a4261/Blobbcda813f22634a7cb399677251807964?se=2017-01-11T10%3A48%3A23.1100105Z&sv=2016-05-31&sr=c&sp=rwd&sig=WrgTbWs79ViK0aqLnBW7ZCsYt1x0VrUYTNxJ6gf3uvA%3D&timeout=30",
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

public class Test02807 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02807_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02807_s.txt", Encoding.UTF8);

    public Test02807() : base(recordedRequest, recordedResponse, "accounts8d439fe961725d3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe961725d3",
                        container: "containers73bf895889af4120ad7f5809619dcc78",
                        blob: "Blobd7a1d953e093485b94515714433c742e",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9611325e/containers1f7a8614c72d40cda35f1d67d31d1670/Blob02c5dd6286904ee38f46417953a587b4?se=2017-01-11T10%3A48%3A16.9808415Z&sv=2016-05-31&sr=c&sp=rwd&sig=J%2FIrjhxt4NzBS8UPO0PgpF8iQy35mBdjMSJwkcQ25OY%3D&timeout=30",
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

public class Test03347 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03347_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03347_s.txt", Encoding.UTF8);

    public Test03347() : base(recordedRequest, recordedResponse, "accounts8d439fe9c6e451d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9c6e451d",
                        container: "containers02a3d9a82e4447bca8f951380a110f2b",
                        blob: "Blob381951932bf44ab197309411aa3d33bd",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9c737541/containers36d40b064337442aa7e832cafbc4538e/Blob0b736f4dc07f496bb6577e31529a43d0?se=2017-01-11T10%3A48%3A27.6311355Z&sv=2016-05-31&sr=c&sp=rwd&sig=zcvZl3hgJ1qQA1i7KEJ8XHCwBR9w2QpkSVbclTvq1zE%3D&timeout=30",
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

public class Test03255 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03255_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03255_s.txt", Encoding.UTF8);

    public Test03255() : base(recordedRequest, recordedResponse, "accounts8d439fe9b4c7f67")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9b4c7f67",
                        container: "containers4abbfeac02b94e99819782db811f4819",
                        blob: "Blob42034f69fb384763b50989eb47567c58",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9b46da09/containers919ad7c0ce5f4ec3bdd9c2e77cec957a/Blob522a1cfb5be54810a566998f56234c16?se=2017-01-11T10%3A48%3A25.6960837Z&sv=2016-05-31&sr=c&sp=rwd&sig=AIYZpuWAzRngLk9xZIZmKb2jVMyQ3jONtMBo1yF%2Bp9U%3D&timeout=30",
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

public class Test03626 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03626_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03626_s.txt", Encoding.UTF8);

    public Test03626() : base(recordedRequest, recordedResponse, "accounts8d439fe9fe6a981")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9fe6a981",
                        container: "containers16aaa61394064c308953f958812d6b28",
                        blob: "Blobc274559b77874083b4ebba3f539065c6",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9fe103ee/containers5d7a20edfa4044c7a6afb4a44da33b52/Blobcedbfe38176c4ffd94dd60f2c5140fa3?se=2017-01-11T10%3A48%3A33.4132955Z&sv=2016-05-31&sr=c&sp=rwd&sig=Qc6wa0Je925ebeCUscdU9%2FpItEuZGmECc4tuWe4hOC8%3D&timeout=30",
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

public class Test02394 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02394_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02394_s.txt", Encoding.UTF8);

    public Test02394() : base(recordedRequest, recordedResponse, "accounts8d439fe91164a25")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe91164a25",
                        container: "containers0568848ecab046cebbb14270a8747784",
                        blob: "Blob9f979f42314d4a73ae7c9ad3f110c3ee",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe91164a25/containersaab888ea04fb4ee8af7aa0a1f7007378/Blobdfb5cf7d1496470994f6eb12af7a6ccf?se=2017-01-11T10%3A48%3A08.5986103Z&sv=2016-05-31&sr=c&sp=rwd&sig=OLmF6kqcRh2CBhLmpuWZ8%2F%2BK4XBpJDXFt9%2Fxd8FPA7M%3D&timeout=30",
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

public class Test03423 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03423_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03423_s.txt", Encoding.UTF8);

    public Test03423() : base(recordedRequest, recordedResponse, "accounts8d439fe9d5a5479")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9d5a5479",
                        container: "containersc3ad8a5a0378453fb9fcc2ad5bfc255b",
                        blob: "Blob032ef730afd8457b8308fe30169ffa7f",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9d5635d7/containers36d4893fc8664074b1719ce34605f1d8/Blob941b28234f794d639ee10b645e943f1c?se=2017-01-11T10%3A48%3A29.1261771Z&sv=2016-05-31&sr=c&sp=rwd&sig=pNCIMGoDq%2B3s1kw%2Ff3PgXOv%2B0u75VrnkjVgagjv8m1Y%3D&timeout=30",
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

public class Test03144 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03144_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03144_s.txt", Encoding.UTF8);

    public Test03144() : base(recordedRequest, recordedResponse, "accounts8d439fe99fd67bc")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe99fd67bc",
                        container: "containers160c8ba7d88c49c9b8a5971f30dab4ac",
                        blob: "Blobaa18e9b7e3664deb9e8f75b1adc9ca3f",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe99fd67bc/containers278d0404f94c465692d9353329991d6d/Blobbbc94354cce54d9cb96a7a0ddea02f20?se=2017-01-11T10%3A48%3A23.5020236Z&sv=2016-05-31&sr=c&sp=rwd&sig=iqRzF8Po7IylmgzWAypH2KTi9P%2BhHtaPMM%2FxOPCdA9M%3D&timeout=30",
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

public class Test03503 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03503_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03503_s.txt", Encoding.UTF8);

    public Test03503() : base(recordedRequest, recordedResponse, "accounts8d439fe9e3e9b95")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9e3e9b95",
                        container: "containerscb09ab8683c146b7acbc0f7024062e2f",
                        blob: "Blob5bb6221795a2412c9100f1dc986fb322",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9e38f637/containers1007d8ebbc1d496eb19623b0770e8237/Blobee84f54db9bb41bf98eb283226ba5363?se=2017-01-11T10%3A48%3A30.6602189Z&sv=2016-05-31&sr=c&sp=rwd&sig=2HN7c8zFr8LkvzB%2F00KirY5wJESePkey%2B8nGwMH6IR8%3D&timeout=30",
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

public class Test03609 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03609_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03609_s.txt", Encoding.UTF8);

    public Test03609() : base(recordedRequest, recordedResponse, "accounts8d439fe9fa50bfa")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9fa50bfa",
                        container: "containersb72aa47a368140f896798f49ea52b423",
                        blob: "Blob71b3199db5aa4b7ca141690338e3c63a",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9f9f6698/containersb8856378c17f41d5ae0e76c48cdda490/Blob95df624f77b44d829d3778ba387d8295?se=2017-01-11T10%3A48%3A33.0242829Z&sv=2016-05-31&sr=c&sp=rwd&sig=mUOaYN%2BL%2FwrNGaICVZLR17MLRrK%2Ba1iabBUxMLY4MdM%3D&timeout=30",
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

public class Test02826 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02826_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02826_s.txt", Encoding.UTF8);

    public Test02826() : base(recordedRequest, recordedResponse, "accounts8d439fe96539300")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe96539300",
                        container: "containers02045d4da3a44bd48ecb3aa971fe6291",
                        blob: "Blob0a892992aca44d56b14b1dac8b8b7602",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe964e3bcb/containers404fa5de1ce74f64a4513d864bcd4f82/Blobacda5f4989304ccca6214e7d7b81480e?se=2017-01-11T10%3A48%3A17.3828538Z&sv=2016-05-31&sr=c&sp=rwd&sig=mzmN0ez8qOuYh0MTsMSuhuCQ2CzRljw1QmiLRaJFpsw%3D&timeout=30",
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

public class Test03282 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03282_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03282_s.txt", Encoding.UTF8);

    public Test03282() : base(recordedRequest, recordedResponse, "accounts8d439fe9ba6ae06")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9ba6ae06",
                        container: "containersb7747c91e8ae42dda0bbfcce012c2606",
                        blob: "Blob6c7fea57684247e9a126305ecd86e904",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9ba2410e/containers474f2f4281984a3d9e7a857e6066be56/Blob36e6df5795f8409ba00e66007c524bf9?se=2017-01-11T10%3A48%3A26.2760988Z&sv=2016-05-31&sr=c&sp=rwd&sig=vJudWTXg2KyQY1uRfb2CsLMkY1sHIDgtVEjkaWXUvN8%3D&timeout=30",
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

public class Test02897 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02897_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02897_s.txt", Encoding.UTF8);

    public Test02897() : base(recordedRequest, recordedResponse, "accounts8d439fe9742afb5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9742afb5",
                        container: "containers7939781f97d54ce991194f75954d4f40",
                        blob: "Blob54156e294f61496db6345ab28b008906",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe973d0a57/containersd9c677d557c1400cb10ba1d1071bf34f/Blob43912d7c9d374a3f847e8285e8d691ef?se=2017-01-11T10%3A48%3A18.9468959Z&sv=2016-05-31&sr=c&sp=rwd&sig=x%2BSp2wtn98T1nhBBKxxj%2BWY6k5ixiR470lLy66DptJ8%3D&timeout=30",
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

public class Test02694 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02694_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02694_s.txt", Encoding.UTF8);

    public Test02694() : base(recordedRequest, recordedResponse, "accounts8d439fe947fe12e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe947fe12e",
                        container: "containerse1bb79694e724785998596739c554db3",
                        blob: "Blob40a683460a95495a8588386526c06072",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe948649e1/containers73a8b0362bed4dc8b0ac190b2d781306/Blobd925a61c606f4d37aaa18d4b22ee7b7a?se=2017-01-11T10%3A48%3A14.3647706Z&sv=2016-05-31&sr=c&sp=rwd&sig=xFtNtgGRfOL56L9JDdg%2F9iN4bGrNxU38RHumxfcnAzg%3D&timeout=30",
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

public class Test02914 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02914_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02914_s.txt", Encoding.UTF8);

    public Test02914() : base(recordedRequest, recordedResponse, "accounts8d439fe977d481c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe977d481c",
                        container: "containers7e924d7d4f2c4c7ea997a40319d8e2cd",
                        blob: "Blob631c983a70834722acf8ab217174c5d7",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9777a2ac/containers1d10f3be159240ed83b299a063daffaf/Blobb828b72f34714a7aa320b452ab31de4b?se=2017-01-11T10%3A48%3A19.3279067Z&sv=2016-05-31&sr=c&sp=rwd&sig=1vxrzFqD9vPKNZZVSsWMqB4hEwh5B2Iued7%2BOC3S%2Fn8%3D&timeout=30",
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

public class Test03532 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03532_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03532_s.txt", Encoding.UTF8);

    public Test03532() : base(recordedRequest, recordedResponse, "accounts8d439fe9ea155b6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9ea155b6",
                        container: "containers997eac8833814c31969ca48dc5510cd5",
                        blob: "Blob14b813c75429405e8c61098b87da12b5",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9e9bd76d/containersab4ca03870b34b14800f94385071990d/Blobee61f4b11a9e402cbdd5e70a1008a5db?se=2017-01-11T10%3A48%3A31.2792362Z&sv=2016-05-31&sr=c&sp=rwd&sig=EVqnxRe8lDRUL6x3KGnGi8uSxuqx%2BRSTWP1sCmtHya8%3D&timeout=30",
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

public class Test03550 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03550_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03550_s.txt", Encoding.UTF8);

    public Test03550() : base(recordedRequest, recordedResponse, "accounts8d439fe9edc8a6c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9edc8a6c",
                        container: "containersf823b50d484447f9acb40be0b1d46944",
                        blob: "Blob91846152e0624ec6ae3420f1bdc26e9c",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9ed6bdf0/containersdb4b3588378f4093b986665630dae412/Blobe649408c1c1447dbb4cda3058ec115fa?se=2017-01-11T10%3A48%3A31.6762472Z&sv=2016-05-31&sr=c&sp=rwd&sig=AXoOhYvk5cJVAMZ%2BKJxXBf1S9LdVmLXdMNlHJctYYog%3D&timeout=30",
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

public class Test03394 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03394_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03394_s.txt", Encoding.UTF8);

    public Test03394() : base(recordedRequest, recordedResponse, "accounts8d439fe9d03814a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9d03814a",
                        container: "containers8d94b30258b843629dd642aff8d87271",
                        blob: "Blobb74def399e3241259f4a79aa536630b6",
                        copySource: @"http://localhost.fiddler:10000/zrdfepirv28d439fe9d07c71/containers09f1a1374beb458ca10a8d62ba352c64/Blobb5e65c0b21b94768839fcf1f7be4d0e9?se=2017-01-11T10%3A48%3A28.5981641Z&sv=2016-05-31&sr=c&sp=rwd&sig=RR8PNS%2F3vJO24BjkNeywrt3OeTq0qHOF3xoX041%2BQM4%3D&timeout=30",
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

public class Test03364 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03364_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03364_s.txt", Encoding.UTF8);

    public Test03364() : base(recordedRequest, recordedResponse, "accounts8d439fe9ca708c7")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9ca708c7",
                        container: "containers81e2c192f56b48febdd7044cba51c7bd",
                        blob: "Blobb8e5bba85a8b4f36b505e02ec4b6dd5f",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9cac38f4/containersfbc34669198c41849a95e3e56e6864b0/Blobe6228674856844e9ab46af59de6e03a8?se=2017-01-11T10%3A48%3A28.0021465Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2B9mWPDIy9doLsDFWAzIgTX3MhReoYSf7bGG9ZL1KjRk%3D&timeout=30",
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

public class Test04221 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04221_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04221_s.txt", Encoding.UTF8);

    public Test04221() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersfb205ec10bb2405ab343d60ec9aff645",
                        blob: "Blob6584c18998f44abb8560e8d03aee341a",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersfb205ec10bb2405ab343d60ec9a" +
    "ff645/Blob6584c18998f44abb8560e8d03aee341a",
                        timeout: 30,
                        leaseId: "abc",
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

public class Test02576 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02576_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\02576_s.txt", Encoding.UTF8);

    public Test02576() : base(recordedRequest, recordedResponse, "accounts8d439fe92e6a0c9")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe92e6a0c9",
                        container: "containers8f247302356d40c8806731d2f1f6ccdb",
                        blob: "Blob6f40f00f42084046b04244f9c517b9c4",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe92e6a0c9/containers8f247302356d40c8806731d2f1f6ccdb/Blob6f40f00f42084046b04244f9c517b9c4?se=2017-01-11T10%3A48%3A11.6406974Z&sv=2016-05-31&sr=c&sp=rwd&sig=I1zuv83Zd9QM2iZn2KATJZxupucb6a6z82h3%2BvD%2FtGM%3D&snapshot=2017-01-11T08%3A48%3A11.6186936Z&timeout=30",
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

public class Test03575 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03575_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03575_s.txt", Encoding.UTF8);

    public Test03575() : base(recordedRequest, recordedResponse, "accounts8d439fe9f3188cf")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9f3188cf",
                        container: "containers29825282c713433ca7adc8bf32d4d2fa",
                        blob: "Blob565f32919c4a4d829572dd6b9d77340c",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9f2c0a7d/containersbf0fdc095a1540f3b9c320987a9b62a3/Blob3abb7e31dc454cbeac989a0e4396cfd0?se=2017-01-11T10%3A48%3A32.2352638Z&sv=2016-05-31&sr=c&sp=rwd&sig=1wwzVPZKCPX1Qjt8I3OZ55piOE%2FFfsR37wZxCW0rHF8%3D&timeout=30",
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

public class Test03474 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03474_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03474_s.txt", Encoding.UTF8);

    public Test03474() : base(recordedRequest, recordedResponse, "accounts8d439fe9ddddd45")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9ddddd45",
                        container: "containers1308dd3f06154262a374b6c2687cddcd",
                        blob: "Blob4fdac12857bf47e9953eb90343ba993a",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9dd9977d/containers5bc2544b73634e1699c00230521e253a/Blob3ebee8698e26489691268a6fe4b9299c?se=2017-01-11T10%3A48%3A29.9842007Z&sv=2016-05-31&sr=c&sp=rwd&sig=dRNFLMSobM%2FuPCvsfWXf4inWGHo9QUUNkCq4nEhQdGk%3D&timeout=30",
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

public class Test04224 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04224_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04224_s.txt", Encoding.UTF8);

    public Test04224() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersfb205ec10bb2405ab343d60ec9aff645",
                        blob: "PageBlobdb9ab7832d06444e882378562207f425",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersfb205ec10bb2405ab343d60ec9a" +
    "ff645/Blob6584c18998f44abb8560e8d03aee341a",
                        timeout: 30,
                        leaseId: "c6b591a4-7a56-4ee4-8f5a-1983d89e113c",
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

public class Test03298 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03298_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03298_s.txt", Encoding.UTF8);

    public Test03298() : base(recordedRequest, recordedResponse, "accounts8d439fe9bd9571d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9bd9571d",
                        container: "containersee2fcdab19a441ca9af92a78297eddf7",
                        blob: "Blob3ecf5f7bb5ff46de98837d1fc2c86185",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9bd3b1bb/containers089248a1e71241c581e61237158969f2/Blobf520388443dd4aed904e5637c0752c99?se=2017-01-11T10%3A48%3A26.6241095Z&sv=2016-05-31&sr=c&sp=rwd&sig=n4Zw%2BoZ5D%2BZWjXF89RKDqevWW8MGsi3XGR37N0FGxQg%3D&timeout=30",
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

public class Test03600 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03600_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03600_s.txt", Encoding.UTF8);

    public Test03600() : base(recordedRequest, recordedResponse, "accounts8d439fe9f88f843")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9f88f843",
                        container: "containers22687067d74d4535b5ea0d216fc8ac2d",
                        blob: "Blob27fbfd5d7f374dceb1be87fd32ef4106",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9f83a0fc/containersfae831c55d17457ebaf5a771494189f4/Blobad478982d29b4ecaa8b1789b5feac2ee?se=2017-01-11T10%3A48%3A32.8002782Z&sv=2016-05-31&sr=c&sp=rwd&sig=hrThJFVXB74gv3pA%2FrPHAHAnCjPDT0wfyyWqFOwce9E%3D&timeout=30",
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

public class Test03194 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03194_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03194_s.txt", Encoding.UTF8);

    public Test03194() : base(recordedRequest, recordedResponse, "accounts8d439fe9a8e371f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9a8e371f",
                        container: "containers94dec587dc8e4398a56491028c961634",
                        blob: "Blobd0a2892ac8fc4e73972ef27f1ad67b08",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9a8e371f/containers94dec587dc8e4398a56491028c961634/Blobd0a2892ac8fc4e73972ef27f1ad67b08?se=2017-01-11T10%3A48%3A24.4830501Z&sv=2016-05-31&sr=c&sp=rwd&sig=7THJ5q9BCitiWNwcdDi%2FDZPHtb7SdJrW0yCsYbgYWq4%3D&snapshot=2017-01-11T08%3A48%3A24.4770483Z&timeout=30",
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

public class Test05579 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05579_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05579_s.txt", Encoding.UTF8);

    public Test05579() : base(recordedRequest, recordedResponse, "accounts8d439ff1f37e072")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1f37e072",
                        container: "containers4c4c13b9df654694bd26836c71d772c4",
                        blob: "Blob81f8c918e1164afa8e962112bce3fff7",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1f2d802a/containerscd2c624773f24bd6ad8ba8fd86f2a54d/Blob526ce10ef0af407ca8cfd1d952954bde?se=2017-01-11T10%3A52%3A07.0351920Z&sv=2016-05-31&sr=c&sp=rwd&sig=8ByiKNf%2FPUCoApMcSzDKY1HlDHTdaTcHSgIZdEzFJfo%3D&timeout=30",
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

public class Test05407 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05407_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05407_s.txt", Encoding.UTF8);

    public Test05407() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerse469b336fd324ec3b666c9ae7029a170",
                        blob: "PageBlob3d1e4fc0f7c5429ca3e695b213ac6d0b",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containerse469b336fd324ec3b666c9ae702" +
    "9a170/PageBlob52855d02f71f4ebeb273d320d534b38e",
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

public class Test03618 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03618_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03618_s.txt", Encoding.UTF8);

    public Test03618() : base(recordedRequest, recordedResponse, "accounts8d439fe9fc7fd75")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9fc7fd75",
                        container: "containerse3aad3351c59439fa4c956ab2efab7a1",
                        blob: "Blobdf13283a50ca4683810e2396f1382f94",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9fc2a645/containersacef9e30146c417f8eefef892923b321/Blob5ea2026dcb14458895edbf306ab8ed3e?se=2017-01-11T10%3A48%3A33.2242962Z&sv=2016-05-31&sr=c&sp=rwd&sig=UDZpZElzt9COxGZHFuPrtSGMqJGbnlPnUY6IFSjxzsM%3D&timeout=30",
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

public class Test05723 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05723_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05723_s.txt", Encoding.UTF8);

    public Test05723() : base(recordedRequest, recordedResponse, "accounts8d439ff20c11b39")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff20c11b39",
                        container: "containers3c03331435ff4876928afbcc85b26234",
                        blob: "Bloba2fc9898f74a4468a1e6ba690d1502b0",
                        copySource: @"http://localhost.fiddler:10000/zrdfepirv28d439ff20c6727/containers1840aa154baf4a8c96e615ea282a414b/Blobb7f9a9cdbbfd43b0aae49b8e9686cbe4?se=2017-01-11T10%3A52%3A09.6692649Z&sv=2016-05-31&sr=c&sp=rwd&sig=Zfrl6KxjGKJ2uMHIuoSVC8%2FZXt0WpnOwe6xe%2ByAQGAk%3D&timeout=30",
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

public class Test03634 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03634_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03634_s.txt", Encoding.UTF8);

    public Test03634() : base(recordedRequest, recordedResponse, "accounts8d439fea00247c0")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fea00247c0",
                        container: "containersaa692250e5f74125aabab91259827d1e",
                        blob: "Blobf24854cf0a7b42ed98e2e40c2f48e80c",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9ffd65b8/containerse9b0a2e819e34ca491ff2110022f2df0/Blobf959d1e8021b412db32f07b63d9e1c68?se=2017-01-11T10%3A48%3A33.5973046Z&sv=2016-05-31&sr=c&sp=rwd&sig=0yv9wqpwmQ1NeimCB1vge1J%2BRDPxGp78XJY1youliHc%3D&timeout=30",
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

public class Test03224 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03224_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03224_s.txt", Encoding.UTF8);

    public Test03224() : base(recordedRequest, recordedResponse, "accounts8d439fe9ae22412")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439fe9ae22412",
                        container: "containers8ab8df46682246b4abf14dfdad3d348c",
                        blob: "Blob9da00e3bb00e4e0e9a3cb4ebf4ac0422",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439fe9ae22412/containers8ab8df46682246b4abf14dfdad3d348c/Blob9da00e3bb00e4e0e9a3cb4ebf4ac0422?se=2017-01-11T10%3A48%3A25.0280648Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2F6d6gmyPZDPGcqEWD%2FF9JxOukKr6ZkDFF2DdUuKzfq4%3D&snapshot=2017-01-11T08%3A48%3A25.0230647Z&timeout=30",
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

public class Test05470 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05470_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05470_s.txt", Encoding.UTF8);

    public Test05470() : base(recordedRequest, recordedResponse, "accounts8d439ff1dee2048")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1dee2048",
                        container: "containers27b4a7e646f7493a92cbd4064ff7c7bf",
                        blob: "Blob4bddb91a963a4ae3bbe80c7104a3a9ed",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1de76920/containers14569844855b42bb9559238e43d433bf/Blob373f09971b8444c99b3adaa591fb4fdd?se=2017-01-11T10%3A52%3A04.8661318Z&sv=2016-05-31&sr=c&sp=rwd&sig=GhxMtpAgefMZsN5Mef6346KsXdwXq8aWvIAcpYHAymU%3D&timeout=30",
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

public class Test05501 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05501_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05501_s.txt", Encoding.UTF8);

    public Test05501() : base(recordedRequest, recordedResponse, "accounts8d439ff1e579110")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1e579110",
                        container: "containers85b9005a924c4d8ea691950c09b874f1",
                        blob: "Blobcc6cca11eac64bac8220f2e0c39b614d",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1e5239b3/containers165d4c5a9ebb485db5bd4a111736f116/Blob82d139a3ae324ce19feba5ee46f66c60?se=2017-01-11T10%3A52%3A05.5721512Z&sv=2016-05-31&sr=c&sp=rwd&sig=SSJ6%2BCsdz6wgDdqH9WM0Wq737oPCmFsKZN4qpbfiI1E%3D&timeout=30",
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

public class Test05517 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05517_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05517_s.txt", Encoding.UTF8);

    public Test05517() : base(recordedRequest, recordedResponse, "accounts8d439ff1e86b791")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1e86b791",
                        container: "containers5c83c0856bfe46e6b89aa4193673bf1f",
                        blob: "Blob486daa543bf64b14abdf3850fcf88689",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1e86b791/containers76d0496ed6d9427c8f06337243e4904b/Blob790c99335e8747fb928e5982866539ec?se=2017-01-11T10%3A52%3A05.8951603Z&sv=2016-05-31&sr=c&sp=rwd&sig=AlBRKy0QFBuXwIrIkGkq%2Fs8bQanqLPl%2BEmalL%2BTqfZQ%3D&timeout=30",
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

public class Test05614 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05614_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05614_s.txt", Encoding.UTF8);

    public Test05614() : base(recordedRequest, recordedResponse, "accounts8d439ff1f96a2df")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1f96a2df",
                        container: "containers65283ea0362641cb8533549145dd8842",
                        blob: "Blobf3c68bb9522044b2a0e698e7cfd8c521",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1f90fd8e/containers93ee973b052f475f9fe2466e75fb2739/Blobed2386a659434de6886d3cdfa7a06d10?se=2017-01-11T10%3A52%3A07.6442088Z&sv=2016-05-31&sr=c&sp=rwd&sig=AIhssSMSyQUr9pHcEYqSkp2E%2BfsKwIjpF1J4z8rl560%3D&timeout=30",
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

public class Test05596 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05596_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05596_s.txt", Encoding.UTF8);

    public Test05596() : base(recordedRequest, recordedResponse, "accounts8d439ff1f63aba2")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1f63aba2",
                        container: "containersffee621dd2f4408890a38c9f8851771e",
                        blob: "Blob89fc4029a5304bceb0b0740cad4ca1fc",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1f67552a/containers0fa978c2a78149d88de04f7a9d702fdb/Blob055fe7aa05ad494caf2d19803b34d80e?se=2017-01-11T10%3A52%3A07.3242011Z&sv=2016-05-31&sr=c&sp=rwd&sig=xwsKvU%2FesDDqAXYQ4Ipfpt1hBueJjR00a6%2FyX%2FnfbHI%3D&timeout=30",
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

public class Test05660 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05660_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05660_s.txt", Encoding.UTF8);

    public Test05660() : base(recordedRequest, recordedResponse, "accounts8d439ff200e44d7")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff200e44d7",
                        container: "containers839690922c6041729d89f423b6addb6e",
                        blob: "Blob05c316e95ec2424e9068e24d89350ce5",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff200e44d7/containers839690922c6041729d89f423b6addb6e/Blob05c316e95ec2424e9068e24d89350ce5?se=2017-01-11T10%3A52%3A08.4322311Z&sv=2016-05-31&sr=c&sp=rwd&sig=kwFM88XooDsaBT5Py4ATs81pZZG0RHGzFJTAY6Z%2FRDg%3D&snapshot=2017-01-11T08%3A52%3A08.4262310Z&timeout=30",
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

public class Test05741 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05741_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05741_s.txt", Encoding.UTF8);

    public Test05741() : base(recordedRequest, recordedResponse, "accounts8d439ff2101f54c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2101f54c",
                        container: "containers0c56758b70b44293a6faa355fe4986d9",
                        blob: "Blob853fbeb870ea4066ae8206ce9df98eeb",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff20fcc511/containers6b5609a507b34d598e48f6e9b37b09bd/PageBlob6f8858b8fd414695b5b6004ef0739cbf?se=2017-01-11T10%3A52%3A10.0122743Z&sv=2016-05-31&sr=c&sp=rwd&sig=rdCjndv5eR30tSBN29fqezyDqmuft7UvLWGXBQjFoac%3D&timeout=30",
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

public class Test05423 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05423_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05423_s.txt", Encoding.UTF8);

    public Test05423() : base(recordedRequest, recordedResponse, "accounts8d439ff1d5d50cb")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1d5d50cb",
                        container: "containers2c7bc2e59bdc4b76907637811aac295b",
                        blob: "Blob1aa921bbd71c424e8a35fd7d9f986fa9",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1d5d50cb/containers6eccaf07d20b43b897d65f48c0e68741/Blob60215c17b0d141c0afac38037d7a467c?se=2017-01-11T10%3A52%3A03.9261058Z&sv=2016-05-31&sr=c&sp=rwd&sig=A0eTMtCACR%2BFGHcF5M136gKUjA6iVt6lG7jgkJacwL0%3D&timeout=30",
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

public class Test05696 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05696_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05696_s.txt", Encoding.UTF8);

    public Test05696() : base(recordedRequest, recordedResponse, "accounts8d439ff207321a5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff207321a5",
                        container: "containers4d35cc46e65d4e1a940e43abc1d0114c",
                        blob: "Blobbcb74f0b5788415fb716271f48492568",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff206df192/containersd1edb5e790eb45f5a6d8ede3eafe7d99/PageBlob4929a0f34af542b68700ace4a7ff4001?se=2017-01-11T10%3A52%3A09.0772497Z&sv=2016-05-31&sr=c&sp=rwd&sig=vD1uPGoxahDS3dj2WCC1bDY2J2UgixFbf95JnYLrnQs%3D&timeout=30",
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

public class Test05963 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05963_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05963_s.txt", Encoding.UTF8);

    public Test05963() : base(recordedRequest, recordedResponse, "accounts8d439ff288b0708")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff288b0708",
                        container: "containersd3b66f9c2c094e41aa1e396ecb03006e",
                        blob: "Blob58c34dcb28aa43e6a16b95fa8c0ea4ad_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff288b0708/containers0df09ccce1884b2593df108e759ee0ec/Blobebd12218045c49deb10b2efbb5d6249e_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=aOhCcu%2BgyQTKEBJuAZdX%2FzAft0qD0ourhP4Qw%2B5RVxg%3D&timeout=30",
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

public class Test05885 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05885_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05885_s.txt", Encoding.UTF8);

    public Test05885() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersef941a0c03c749b1b059ad757cfa31ba",
                        blob: "Blobd6bf7b15f8244cb291f06b972eafdd9d",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersef941a0c03c749b1b059ad757cf" +
    "a31ba/PageBlob9ecf447dbed242728c0cbefddc35fde9",
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

public class Test03855 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03855_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\03855_s.txt", Encoding.UTF8);

    public Test03855() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersfa586120549e4f4aab72497738de442a",
                        blob: "PageBlob46e5514049064c63b1d5e8009a327634",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersfa586120549e4f4aab72497738d" +
    "e442a/PageBlob82e2456c27a741c69245721b8f0bf156",
                        timeout: 30,
                        ifMatches: "invalidETag",
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

public class Test05632 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05632_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05632_s.txt", Encoding.UTF8);

    public Test05632() : base(recordedRequest, recordedResponse, "accounts8d439ff1fc41bd2")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1fc41bd2",
                        container: "containersbb4ec3773d524b7bad0b8de99f7e6408",
                        blob: "Blob899a487a55de46ae886f8f15fffab89d",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1fc41bd2/containers757bb614f75a4b70b2deefc8a4e2bd05/PageBlob282b6fede4b646c78d3c5449d2b9864c?se=2017-01-11T10%3A52%3A07.9372171Z&sv=2016-05-31&sr=c&sp=rwd&sig=oTYL8jjbt8Wmdjm%2FTIBOZ96jCNIdXScji%2BcP6rqWa1k%3D&timeout=30",
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

public class Test05922 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05922_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05922_s.txt", Encoding.UTF8);

    public Test05922() : base(recordedRequest, recordedResponse, "accounts8d439ff28242e2e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff28242e2e",
                        container: "containers7ddd7afd9e864d46b407018e3eea8013",
                        blob: "PageBlobb92b6465462049deadbbda4043b2bed6",
                        copySource: "http://localhost.fiddler:10000/accounts8d439ff28242e2e/containersea1d27939a374fed" +
    "a08cd3c0ef9f62d2/PageBlob82c42dc021cd40e0bfedee701e262a54",
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

public class Test06029 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06029_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06029_s.txt", Encoding.UTF8);

    public Test06029() : base(recordedRequest, recordedResponse, "accounts8d439ff2bd444ac")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2bd444ac",
                        container: "containersdd2cf7c219b94b65a562392915d07d0f",
                        blob: "Blob30ed9be5dfc64620b95bab1394150cda_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff2bd444ac/containers270e9cc9b19546c6a9aa39693c8ac682/Blobe0c1d6ac715342179b24d9cc318a1fac_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=ZlhJCYimFEsUNzhY%2Fe%2Fel8kvW6u0zmv75eJazml6UP0%3D&timeout=30",
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

public class Test05678 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05678_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05678_s.txt", Encoding.UTF8);

    public Test05678() : base(recordedRequest, recordedResponse, "accounts8d439ff203b2186")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff203b2186",
                        container: "containers91bfe0f428504a428be558654cda3d39",
                        blob: "Blobf85277b5179347b19d04d89ebf39b781",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff203b2186/containers91bfe0f428504a428be558654cda3d39/Blobf85277b5179347b19d04d89ebf39b781?se=2017-01-11T10%3A52%3A08.7252398Z&sv=2016-05-31&sr=c&sp=rwd&sig=CvtQBlkWRCMXCepFktNhRWs2%2BdFg4uMB1hAoRwe4dPw%3D&snapshot=2017-01-11T08%3A52%3A08.7202393Z&timeout=30",
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

public class Test05588 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05588_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05588_s.txt", Encoding.UTF8);

    public Test05588() : base(recordedRequest, recordedResponse, "accounts8d439ff1f4cc826")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1f4cc826",
                        container: "containers4730c8c4392c4d2a8dad1e6c2b0acdfb",
                        blob: "Blob92df784537e44722ab46347bd64fbf35",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1f5098cb/containers02702acedffa4e0db77889abc4423f55/Blob0e2760d2c58a45aaa8f895b9e6081f85?se=2017-01-11T10%3A52%3A07.1851962Z&sv=2016-05-31&sr=c&sp=rwd&sig=C%2B0gYNmb6Q3yFQxC%2BqX9kHBFiBun1xgxZWAX5Zu3a9Q%3D&timeout=30",
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

public class Test05535 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05535_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05535_s.txt", Encoding.UTF8);

    public Test05535() : base(recordedRequest, recordedResponse, "accounts8d439ff1eb73dc7")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1eb73dc7",
                        container: "containers6e78eb79790345449b1de0f33bb35e45",
                        blob: "Blobe0a2f4f0d6b849be8ecb2b5b0547fa7b",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1eb73dc7/containers6e78eb79790345449b1de0f33bb35e45/Blobe0a2f4f0d6b849be8ecb2b5b0547fa7b?se=2017-01-11T10%3A52%3A06.2091693Z&sv=2016-05-31&sr=c&sp=rwd&sig=7Ra2atVhP8XzMz%2Fva4nqEfQPwvxN5rk1HTvlIDuu1Us%3D&snapshot=2017-01-11T08%3A52%3A06.1871694Z&timeout=30",
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

public class Test05415 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05415_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05415_s.txt", Encoding.UTF8);

    public Test05415() : base(recordedRequest, recordedResponse, "accounts8d439ff1d45a9d5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1d45a9d5",
                        container: "containers47329c113fea4016bc6171d75266d095",
                        blob: "Blob2e6f95092669487c9591466bf8422739",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1d45a9d5/containersc76fbe74a87b4fd2bc09521a3aa68065/Blob98290e478eaa4d0f9053a19e54386718?se=2017-01-11T10%3A52%3A03.7881023Z&sv=2016-05-31&sr=c&sp=rwd&sig=9udlFgW8AWdIy1cIWiMjXN8Gpl72VqziRDK7uxLh3Rs%3D&timeout=30",
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

public class Test05747 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05747_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05747_s.txt", Encoding.UTF8);

    public Test05747() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb15e137a13604ac992f3594ed826c30a",
                        blob: "Blob1cc2b3a1147149f8837de7b45504acc2",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersb15e137a13604ac992f3594ed82" +
    "6c30a/Blob1cc2b3a1147149f8837de7b45504acc2",
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

public class Test05714 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05714_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05714_s.txt", Encoding.UTF8);

    public Test05714() : base(recordedRequest, recordedResponse, "accounts8d439ff20a66718")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff20a66718",
                        container: "containerse9c89aad88234a67ba73524a5333dafc",
                        blob: "Blobb44b489027fc4a7b95a87a3cf0dd3303",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff20abbe5e/containers4a80e8065cf54490951f2cac1b6847c4/PageBlob38e746797a7848aa905795ce5e0aa87c?se=2017-01-11T10%3A52%3A09.4502590Z&sv=2016-05-31&sr=c&sp=rwd&sig=1BcKddkLFhOLRxj61u1m5ggkAZ0E%2FaZ4u%2FdLcCgUeyc%3D&timeout=30",
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

public class Test06076 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06076_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06076_s.txt", Encoding.UTF8);

    public Test06076() : base(recordedRequest, recordedResponse, "accounts8d439ff2e8c8b93")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2e8c8b93",
                        container: "containers8536d94f0af34a96be843597e60ee4c0",
                        blob: "Blob59b31ff8d4564b6492c4610d18ed97ff_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff2e8c8b93/containers45a4f78f5a0644b793d3dc0d4b68e300/Blob1861a3290c3e498b90edfb66e9ab33cb_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=fIlN2li9dBHGDU9PcSH%2FnztrGU9Z87Aady1Dn4KCKyo%3D&timeout=30",
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

public class Test05455 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05455_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05455_s.txt", Encoding.UTF8);

    public Test05455() : base(recordedRequest, recordedResponse, "accounts8d439ff1db66dc7")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1db66dc7",
                        container: "containers0e774eb827de4d739bc08ee8ad9eec5d",
                        blob: "Blobf20790d80485427b9379c7b2c356992b",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1db66dc7/containers0e774eb827de4d739bc08ee8ad9eec5d/Blobf20790d80485427b9379c7b2c356992b?se=2017-01-11T10%3A52%3A04.5221238Z&sv=2016-05-31&sr=c&sp=rwd&sig=5WpwDA5jX3DSWTxR%2BDFMCJdroXFOjlfFSc8FXY7vNb4%3D&snapshot=2017-01-11T08%3A52%3A04.4901216Z&timeout=30",
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

public class Test05439 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05439_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05439_s.txt", Encoding.UTF8);

    public Test05439() : base(recordedRequest, recordedResponse, "accounts8d439ff1d899158")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1d899158",
                        container: "containers7ddcb99686414ce5987f86ac68ee0ce0",
                        blob: "Blobb781e1ac1a87465da0d20920d3c8798b",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1d899158/containers7ddcb99686414ce5987f86ac68ee0ce0/Blobb781e1ac1a87465da0d20920d3c8798b?se=2017-01-11T10%3A52%3A04.2261142Z&sv=2016-05-31&sr=c&sp=rwd&sig=E0zatak43KcWRvdRpES4YYFurGMr2imYZN7ejYIHlts%3D&snapshot=2017-01-11T08%3A52%3A04.1931137Z&timeout=30",
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

public class Test05571 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05571_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05571_s.txt", Encoding.UTF8);

    public Test05571() : base(recordedRequest, recordedResponse, "accounts8d439ff1f156404")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1f156404",
                        container: "containersd6ce6edc812b49c8b62855c2049597e1",
                        blob: "Blob0cd594c90262443a9bae63c8db70dae4",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1f0fe5bb/containers256545ae773e4b17bdf2a2cada03fe88/Bloba84ad9904b76418a965d5b45d2cb4a34?se=2017-01-11T10%3A52%3A06.8261862Z&sv=2016-05-31&sr=c&sp=rwd&sig=lNer%2FiO%2FdIqPOZeTXvQ5%2Fl6rE6TtPCfEBq6M%2BKSYMdw%3D&timeout=30",
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

public class Test05622 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05622_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05622_s.txt", Encoding.UTF8);

    public Test05622() : base(recordedRequest, recordedResponse, "accounts8d439ff1faf5b2e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1faf5b2e",
                        container: "containersedc298b48a714ae592d57cfceffb4cbc",
                        blob: "Blobcff01a3c84294cf0a9e5ec0bf2b7bd71",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1fa9dcf7/containers63f60b120f494e7ca227d061e7f8d631/Blobf02c8098e9ab4b5da4029ea8de36066b?se=2017-01-11T10%3A52%3A07.8172133Z&sv=2016-05-31&sr=c&sp=rwd&sig=czdEEMtRhvTxcoXvgsgNkEdNyhw00TupOKsoHsQuVjA%3D&timeout=30",
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

public class Test05478 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05478_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05478_s.txt", Encoding.UTF8);

    public Test05478() : base(recordedRequest, recordedResponse, "accounts8d439ff1e01cf2f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1e01cf2f",
                        container: "containerscdc99f1451324218b0eff65d0a9bfcbc",
                        blob: "Blob05fb31fe0cb74149b10cfe64b5a8b70a",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1e072682/containers32894ae92ef84ccca339d8cc140122e4/Blob1d3a586e25a64408b293c2490a1f5dbb?se=2017-01-11T10%3A52%3A05.0431372Z&sv=2016-05-31&sr=c&sp=rwd&sig=nS7SSCHcwuHOPJLdz%2B7%2Bl30kbhWPbdfttrYkYfLasLg%3D&timeout=30",
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

public class Test05733 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05733_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05733_s.txt", Encoding.UTF8);

    public Test05733() : base(recordedRequest, recordedResponse, "accounts8d439ff20e48204")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff20e48204",
                        container: "containers5d49466ba2ff4bf0bc4d3aa4dc576fd4",
                        blob: "Blob74710469dc404f3e9a85afa1f178f7ce",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff20df03bb/containers1e956aa0575f4503a545afc8e0186cae/PageBlobb93ce77bd7f94ca09d7fd0ee021914fa?se=2017-01-11T10%3A52%3A09.8192700Z&sv=2016-05-31&sr=c&sp=rwd&sig=NI2dznu7%2FK%2BtEqMjFcONnavuJrlcANAFGVDKeNGZm4Y%3D&timeout=30",
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

public class Test05651 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05651_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05651_s.txt", Encoding.UTF8);

    public Test05651() : base(recordedRequest, recordedResponse, "accounts8d439ff1ff53e4d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1ff53e4d",
                        container: "containers59c24330bce4469db16358a74b8d3549",
                        blob: "Blob85fd3970e56646b49301650fafb911aa",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1ff53e4d/containers59c24330bce4469db16358a74b8d3549/Blob85fd3970e56646b49301650fafb911aa?se=2017-01-11T10%3A52%3A08.2842274Z&sv=2016-05-31&sr=c&sp=rwd&sig=1xSvwl6ghcQc%2BcrCS8gwjkkWDpm0cKxheJm8buaKesc%3D&snapshot=2017-01-11T08%3A52%3A08.2672267Z&timeout=30",
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

public class Test05553 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05553_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05553_s.txt", Encoding.UTF8);

    public Test05553() : base(recordedRequest, recordedResponse, "accounts8d439ff1ee44197")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1ee44197",
                        container: "containers201a743151a2464e8282965fa8ca8632",
                        blob: "Blob213affa62f03421985f98b0ee3ab18da",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1ee44197/containers201a743151a2464e8282965fa8ca8632/Blob213affa62f03421985f98b0ee3ab18da?se=2017-01-11T10%3A52%3A06.4881778Z&sv=2016-05-31&sr=c&sp=rwd&sig=jjajZI3EtsvxapL6LfVz9JgY3jRBTy7T2gM9NAa0T9s%3D&snapshot=2017-01-11T08%3A52%3A06.4651771Z&timeout=30",
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

public class Test05431 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05431_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05431_s.txt", Encoding.UTF8);

    public Test05431() : base(recordedRequest, recordedResponse, "accounts8d439ff1d7349d0")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1d7349d0",
                        container: "containersf9b72294cc4f496b864305c3f14e29cd",
                        blob: "Blob3f435ddac4b64826aa64108ac508f720",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1d7349d0/containersf9b72294cc4f496b864305c3f14e29cd/Blob3f435ddac4b64826aa64108ac508f720?se=2017-01-11T10%3A52%3A04.0801105Z&sv=2016-05-31&sr=c&sp=rwd&sig=53Gi7tP%2FikbSgfASNCX0l0hpnUDy7Z9CYjTxlaNDGD0%3D&snapshot=2017-01-11T08%3A52%3A04.0481092Z&timeout=30",
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

public class Test05890 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05890_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05890_s.txt", Encoding.UTF8);

    public Test05890() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4223cda142f64ca380810328b7c42f6b",
                        blob: "Blobf41860d1cf0348589727e1bacdd5707e",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers4223cda142f64ca380810328b7c" +
    "42f6b/PageBloba6c7bd614a9041feb4c8c51867cf75aa?se=2017-01-11T09%3A02%3A19.571539" +
    "9Z&sv=2016-05-31&sr=c&sp=rwd&sig=8eyebhkGDaqVhlr%2FJxEYzyI%2FxolMOFexYFS6fvcGs5U" +
    "%3D&timeout=30",
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

public class Test05508 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05508_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05508_s.txt", Encoding.UTF8);

    public Test05508() : base(recordedRequest, recordedResponse, "accounts8d439ff1e72ba4b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1e72ba4b",
                        container: "containers08dddc861bfb4e968ea71294fc25a4a4",
                        blob: "Blobf1b67be580b648178528840be7f921fc",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1e6db121/containersd439f613e3e44cc5ba77817660b89ea9/Bloba44bf41302bc41fbaac21d0551a82819?se=2017-01-11T10%3A52%3A05.7361556Z&sv=2016-05-31&sr=c&sp=rwd&sig=ffQX6QPB6zMNE9ycYDd1jZcnm8%2B%2B1pr8qyOLjk%2B1YLk%3D&timeout=30",
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

public class Test06187 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06187_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06187_s.txt", Encoding.UTF8);

    public Test06187() : base(recordedRequest, recordedResponse, "accounts8d439ff32a8d21a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff32a8d21a",
                        container: "containers687c3d3e4f3c483bae02010694a614f9",
                        blob: "Blob277d472cecbe481b93168f69f7df24b2_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff32a8d21a/containers94f69ac655ab4e95bce81553bc146e08/Blob6ab5542147334ed3a43269d3578b21a1_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=JGfrdGSDYm4uA58f18yz51wA8Fl3%2FrfPtcaPb7%2BpvZE%3D&timeout=30",
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

public class Test05605 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05605_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05605_s.txt", Encoding.UTF8);

    public Test05605() : base(recordedRequest, recordedResponse, "accounts8d439ff1f792f9f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1f792f9f",
                        container: "containersc02ef7e55bc54368b400ec7fa13fd77d",
                        blob: "Blobd9eb6e5895f3425f9a73458506b4eec9",
                        copySource: @"http://localhost.fiddler:10000/ardfepirv28d439ff1f7cd92/containersd3b7267e3458457db2d5e5a6e633ccf1/Blobd46bb570ccc24b5ca1baa8edd889f3a4?se=2017-01-11T10%3A52%3A07.4812040Z&sv=2016-05-31&sr=c&sp=rwd&sig=3QsKHkgk8oPPYcJaVi9kCi0e%2F5osP%2F1V99PJ9MzfFCA%3D&timeout=30",
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

public class Test05526 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05526_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05526_s.txt", Encoding.UTF8);

    public Test05526() : base(recordedRequest, recordedResponse, "accounts8d439ff1e9ed3ad")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1e9ed3ad",
                        container: "containers7ca06708aeed469a9e58cea47a344abd",
                        blob: "Blob0cb80bb824254a34a1315acf4c6d6819",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1e9ed3ad/containersbccae8b69c594b6f9ca7d760fc41c2c4/Blobb49808e8d932419998d5a9cc5f659b2d?se=2017-01-11T10%3A52%3A06.0491650Z&sv=2016-05-31&sr=c&sp=rwd&sig=u4%2Fa7RUf%2BFC5P%2FqJvv6iyZtaj4kB0SvlgPNIhXmPP2g%3D&timeout=30",
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

public class Test05669 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05669_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05669_s.txt", Encoding.UTF8);

    public Test05669() : base(recordedRequest, recordedResponse, "accounts8d439ff20248c0f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff20248c0f",
                        container: "containers5a7c44fc3ba94077be32138f5be02fd9",
                        blob: "Blob4718181065c1411697e2316ed270dd3d",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff20248c0f/containers5a7c44fc3ba94077be32138f5be02fd9/Blob4718181065c1411697e2316ed270dd3d?se=2017-01-11T10%3A52%3A08.5822344Z&sv=2016-05-31&sr=c&sp=rwd&sig=wIO9KCLQU47yaXgttAYqNblJAg37px1%2FdCpSEtLSVa4%3D&snapshot=2017-01-11T08%3A52%3A08.5772374Z&timeout=30",
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

public class Test06267 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06267_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06267_s.txt", Encoding.UTF8);

    public Test06267() : base(recordedRequest, recordedResponse, "accounts8d439ff3a4e1e94")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3a4e1e94",
                        container: "containersee9a5959e41549b6af014d1a7d61c369",
                        blob: "Blobccadabd2fb7f4059bf6e11342b7f8e5c_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff3a4e1e94/containers7345ceaed4b7458c94fa86c87a62a577/Blob647ae4ca6c874a998c31571079dfcfed_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=ND7%2BOgCvAYgWDKDN5Fp9M95GMZ6aDJvbbSS3SLMncG0%3D&timeout=30",
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

public class Test05706 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05706_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05706_s.txt", Encoding.UTF8);

    public Test05706() : base(recordedRequest, recordedResponse, "accounts8d439ff208857b3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff208857b3",
                        container: "containers5a395d05545c421e84d62ae7887750e9",
                        blob: "Bloba6031b48362f4ba2970b98d13bcc1d57",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff208daee7/containersed6f6341bddf44249234672b202f7924/PageBlob9f32beafce7c4205abf47e3538ad165b?se=2017-01-11T10%3A52%3A09.2502550Z&sv=2016-05-31&sr=c&sp=rwd&sig=HW86ZQfjQP896vTt7Evgq4SVnyMD2MuqmnNLZ%2FO7mZc%3D&timeout=30",
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

public class Test06363 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06363_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06363_s.txt", Encoding.UTF8);

    public Test06363() : base(recordedRequest, recordedResponse, "accounts8d439ff3ef1e57e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3ef1e57e",
                        container: "containersa10a7c8c0c2b4111ae398f6b5257abad",
                        blob: "Blobead0a930aa7c4c8a862ec9f33c3738c1_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff3ef1e57e/containerse1bcd890ed6444c7828a9703e11254a5/Blob18f87496108f400b81794ea892de029d_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=VTbmw9ojbfr02TyDgNZwHr2na0WxnNCTJ%2F64uEejCn8%3D&timeout=30",
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

public class Test06316 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06316_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06316_s.txt", Encoding.UTF8);

    public Test06316() : base(recordedRequest, recordedResponse, "accounts8d439ff3d5dd51a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3d5dd51a",
                        container: "containersc7fb4f198b044cd2a60f88747cbb9896",
                        blob: "Blob345172d0ea0e44ebbb174d224f510bcd_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff3d5dd51a/containers4b9db204fee3415d898ffc1049e5ff29/Blobe83dd703598f4cb3827f6e5b87f44372_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=ntSu6LTct4BCDvYSkk52PWE%2BgQ76OshqmDPDDdkkloM%3D&timeout=30",
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

public class Test06412 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06412_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06412_s.txt", Encoding.UTF8);

    public Test06412() : base(recordedRequest, recordedResponse, "accounts8d439ff42ae30e7")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff42ae30e7",
                        container: "containersc80b32189b5644a78f395a3c29cd676e",
                        blob: "Blobe1d9fee647d34d86ad8e8ff5bc8b6c18_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff42a900bf/containers721783d5219b4bd2813fdbba0e66faa5/Blobba2636eb1ea4422796eca29698683de6_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=wqRbD9eI7icKXnSQSFagNJNQ%2F4uMsBMxzCrCje0tORQ%3D&timeout=30",
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

public class Test06348 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06348_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06348_s.txt", Encoding.UTF8);

    public Test06348() : base(recordedRequest, recordedResponse, "accounts8d439ff3ebb1da6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3ebb1da6",
                        container: "containerscd55fce0f8504baa990f5e17dc71f9fc",
                        blob: "Blobc56b89e7e71f4a9d9a43fe8de11adfc7_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff3ebb1da6/containersfd0675af3b5e4436aa88f734c458eb2b/Blobe9c1f4bca5194f3aa97000f48ad1fbca_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=v3EGhDuQxFOQ29a3F3AEMHGiM2FcQnVovZYaMvh4ZFU%3D&timeout=30",
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

public class Test05485 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05485_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05485_s.txt", Encoding.UTF8);

    public Test05485() : base(recordedRequest, recordedResponse, "accounts8d439ff1e1caa84")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1e1caa84",
                        container: "containers203c45b99bea4718a8a91b175d3aea84",
                        blob: "Blob043bd6441b324618b0b57ac22801cdf2",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1e21b382/containers22258612036a440b96db176fb073880f/Blob11648c4cf87c404e8005d7978ea5edb9?se=2017-01-11T10%3A52%3A05.2011411Z&sv=2016-05-31&sr=c&sp=rwd&sig=GnUkE3ENlnM%2B71D1IQ0ybcAyztgP9sa5mE2RlzdZJ8o%3D&timeout=30",
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

public class Test05642 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05642_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05642_s.txt", Encoding.UTF8);

    public Test05642() : base(recordedRequest, recordedResponse, "accounts8d439ff1fdcd42a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1fdcd42a",
                        container: "containersa93bff3132604b5781b48ea15625b0d0",
                        blob: "Blob300507c9595c4ee49196bc2faa08ae1a",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1fdcd42a/containers7e9dfb9c47544f17a9e3748b76f31593/PageBlobd80efe9a7e7b4b5791abab36d3d34583?se=2017-01-11T10%3A52%3A08.0892213Z&sv=2016-05-31&sr=c&sp=rwd&sig=%2BX0D8MvTsqr8n1m%2B19zgNieiq7FyP7ZHj2SK6L3QQzM%3D&timeout=30",
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

public class Test06222 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06222_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06222_s.txt", Encoding.UTF8);

    public Test06222() : base(recordedRequest, recordedResponse, "accounts8d439ff356bc789")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff356bc789",
                        container: "containers910cf000058c40108f861ab5b67ea4e9",
                        blob: "Blobf275a9ea329542c491fc140ea1c2b1d3_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff356bc789/containers174f5ef67a7a40de8ef3487a9dda7d08/Blob48b54b23a6a644018394dd577328654a_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=3FnyBeIlMONaz04JfqhFbxIYzyPUm%2BzhSpVdPXeykyk%3D&timeout=30",
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

public class Test06461 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06461_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06461_s.txt", Encoding.UTF8);

    public Test06461() : base(recordedRequest, recordedResponse, "accounts8d439ff43c17794")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff43c17794",
                        container: "containers84ab84af0f53419d8941cde907e586f9",
                        blob: "Blobc87d066fca2d4d349bcb410753a9fc0d_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff43b84fd0/containersd02b552231714d5bbb853a3463a13fb4/Blobc1c61371ec0e4a509ca55289fd613bc9_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=k0%2BxYy1mp2gf9%2FI3DSwnz%2Fxazj2ogipqvjN%2BiE1cZHo%3D&timeout=30",
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

public class Test06019 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06019_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06019_s.txt", Encoding.UTF8);

    public Test06019() : base(recordedRequest, recordedResponse, "accounts8d439ff2b99fa1e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2b99fa1e",
                        container: "containers024f634e0ea4409aae73e68554d278d9",
                        blob: "Blob7410b1c1a2154edba0db10333a92b7e8_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff2b99fa1e/containers2d1a189075ad40a890a719515f802d68/Blob98dc7df371ea44c4b753471389b2aefe_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=ecQp2GVdl%2FJQshjzUNZdf2TySpJweqvUX1McYjbMMTk%3D&timeout=30",
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

public class Test06304 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06304_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06304_s.txt", Encoding.UTF8);

    public Test06304() : base(recordedRequest, recordedResponse, "accounts8d439ff3aa87443")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3aa87443",
                        container: "containers978ae0adc8094c03b9318ae1f55e43c7",
                        blob: "Blobac4dd9aa81744bd9a83c4c185fee337a_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff3aa87443/containers3b6a710983cd4434aaf841b3a6a85ef9/Blob19626131f076483b9597bb552856013f_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=polKmfJ%2FF977pqKsaCH1tb%2FpsGrYLJ3TxjOppYWGEWM%3D&timeout=30",
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

public class Test05985 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05985_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05985_s.txt", Encoding.UTF8);

    public Test05985() : base(recordedRequest, recordedResponse, "accounts8d439ff291fa6da")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff291fa6da",
                        container: "containers64c54ef7383842ba8601338a741eaeae",
                        blob: "Blob3c2c8838a60b4aaaa9b0d8336bb56beb_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff291fa6da/containerse1c29a4fb98749d680adbf8229b724e8/Blobe5a52e475a3f4ca8bc00794fe6fe31ca_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=oCDzyR482eAtTYzpBCrXbR4WcsppupzesXTacAAP5dc%3D&timeout=30",
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

public class Test05463 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05463_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05463_s.txt", Encoding.UTF8);

    public Test05463() : base(recordedRequest, recordedResponse, "accounts8d439ff1dd28183")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1dd28183",
                        container: "containers02fc50edac994014b708211318c1d71d",
                        blob: "Blob4050357c91d34d89b356a2565b946463",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1dcd7866/containers34d265035a484ddba6defe02a825cb0c/Blobcf02b03bf5dc4c46ba02ce1b70e49bef?se=2017-01-11T10%3A52%3A04.6931274Z&sv=2016-05-31&sr=c&sp=rwd&sig=1z1PIo86CtQolvtYhYsCcMBJWKCsN2Y6%2B2fhNyPVnzA%3D&timeout=30",
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

public class Test05688 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05688_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05688_s.txt", Encoding.UTF8);

    public Test05688() : base(recordedRequest, recordedResponse, "accounts8d439ff205698e1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff205698e1",
                        container: "containers22393f0ffadd4460a7560e07e06cd518",
                        blob: "Blobdb0f6417f87f47ca9c3274a472b33270",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff2051419b/containersaac7bf6ee84549ec95f3ec0ea8a834f3/PageBlobce30f920709d4bc28013057b81d56d60?se=2017-01-11T10%3A52%3A08.8852418Z&sv=2016-05-31&sr=c&sp=rwd&sig=ue4JNWIolfG8J0qfFWpDYU8Jq5PSo4caksOqIg1cfno%3D&timeout=30",
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

public class Test05544 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05544_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05544_s.txt", Encoding.UTF8);

    public Test05544() : base(recordedRequest, recordedResponse, "accounts8d439ff1ece9678")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1ece9678",
                        container: "containers49299d4e27974b83bd55c5585a72db51",
                        blob: "Blobc8ab143283f04d3f957b0628b6c721be",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1ece9678/containers49299d4e27974b83bd55c5585a72db51/Blobc8ab143283f04d3f957b0628b6c721be?se=2017-01-11T10%3A52%3A06.3491769Z&sv=2016-05-31&sr=c&sp=rwd&sig=TTYj56%2BIVzcmf0OPw1DP%2Fuxa%2BKDnhqnUx0uBT88uJyA%3D&snapshot=2017-01-11T08%3A52%3A06.3301735Z&timeout=30",
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

public class Test06160 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06160_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06160_s.txt", Encoding.UTF8);

    public Test06160() : base(recordedRequest, recordedResponse, "accounts8d439ff321f2eb7")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff321f2eb7",
                        container: "containersb352b61820af45cc863634e9fc939d1d",
                        blob: "Blob376923fb8f8a4e73926f6a144abc31e2_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff321f2eb7/containers509c53ebdc354cdbab51d3aac0b65a2b/Blob054b4b864a134a878128f0c67bd86aa9_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=jB9%2F8QMcpjo7BaJNM2we%2FKtew8QfoZvKtS5G0mq38OI%3D&timeout=30",
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

public class Test06653 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06653_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06653_s.txt", Encoding.UTF8);

    public Test06653() : base(recordedRequest, recordedResponse, "accounts8d439ff517a4a4f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff517a4a4f",
                        container: "containers424289cd721e48a6a80a013e899eb1c3",
                        blob: Encoding.UTF8.GetString(new byte[]{66,108,111,98,101,49,55,50,50,48,102,102,51,53,51,102,52,99,101,51,97,51,100,53,57,101,56,56,55,99,97,100,57,54,97,52,95,76,105,110,107,66,108,111,98,207,168}),
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff51742fab/containers1ef31d718684470b8b563f4036594a56/Blob26693c17a6aa448fac663da78785a32f_WriteProtectedBlob%CF%A8?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=AkSF%2FKZrKdpAuPNp57XlBLrZ6FsKeo%2FdXh0PqETTDm8%3D&timeout=30",
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

public class Test06321 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06321_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06321_s.txt", Encoding.UTF8);

    public Test06321() : base(recordedRequest, recordedResponse, "accounts8d439ff3d5dd51a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3d5dd51a",
                        container: "containers93f9974336fc4571a5ec6d6b888b96d6",
                        blob: "Blob0648899e5e004ee69edcda758a5a563f_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff3d5dd51a/containersc7fb4f198b044cd2a60f88747cbb9896/Blob345172d0ea0e44ebbb174d224f510bcd_CoRBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=zOfqvBc6op%2F79yDTXB9OJM1hF5OhlMnc3U1pI%2BIYOPI%3D&timeout=30",
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

public class Test06065 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06065_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06065_s.txt", Encoding.UTF8);

    public Test06065() : base(recordedRequest, recordedResponse, "accounts8d439ff2c9c29c0")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2c9c29c0",
                        container: "containersb0f82e53597740baafcc07a1b0a8a267",
                        blob: "Blob45d20744f7d74fdf9fd481eb8144bbe6_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff2c9c29c0/containersa10cbe24ce2a4dd889b2c0049c672fe7/Blob398fc4318adc43d3b62386c1266b34ab_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=C2Jzx4ttgq%2BngbTX07p%2FzPWPRB%2BL0uTGrS5A0F%2F6Jvw%3D&timeout=30",
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

public class Test05912 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05912_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05912_s.txt", Encoding.UTF8);

    public Test05912() : base(recordedRequest, recordedResponse, "accounts8d439ff2809ef58")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2809ef58",
                        container: "containersf35a09b98dee4eebb3645ab0bb4c0a26",
                        blob: "PageBlobacf20dae283b4de68f59e694ea4ae6ea",
                        copySource: "http://localhost.fiddler:10000/accounts8d439ff2809ef58/containers2ea2bc6c87f645a1" +
    "bd0233fb8581df0d/PageBlob047d62e638874804a058d3c3fd2b94a8",
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

public class Test05973 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05973_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05973_s.txt", Encoding.UTF8);

    public Test05973() : base(recordedRequest, recordedResponse, "accounts8d439ff28c10b8b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff28c10b8b",
                        container: "containers4565a960e3b0472a81117a12f35e234b",
                        blob: "Blob9c0a4e500dcd4728a4aa25b138b2d995_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff28c10b8b/containers3fc54f84d18d474a9202b42365f6ccf8/Blobaef6c05ceaf44b6985daf046521a63b6_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=eyJDTZEPedpyLW8TciJvm7HEkDJ3v11%2BL%2BMcw%2ByT87g%3D&timeout=30",
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

public class Test06368 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06368_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06368_s.txt", Encoding.UTF8);

    public Test06368() : base(recordedRequest, recordedResponse, "accounts8d439ff3ef1e57e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3ef1e57e",
                        container: "containers75e875ee581240348a4679c5addbca0d",
                        blob: "Blob752ec416fe534e26aa3054f523bb1ff2_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff3ef1e57e/containersa10a7c8c0c2b4111ae398f6b5257abad/Blobead0a930aa7c4c8a862ec9f33c3738c1_CoRBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=1o2SDcVwvvH77gAG7c3AnSyn5O8ILMBJjeRE%2FhCwqkE%3D&timeout=30",
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

public class Test06398 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06398_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06398_s.txt", Encoding.UTF8);

    public Test06398() : base(recordedRequest, recordedResponse, "accounts8d439ff3f2c7dd8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3f2c7dd8",
                        container: "containersfa7a9cd9af92498aa9d10d1060106fcd",
                        blob: "Bloba8fb310c6d5a49ed929b8252ed7f5a25_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff3f2c7dd8/containerse6f78054a20b43c8a1738be2db0d27f4/Blob3978513ea3434fa2b42318cef033394b_CoRBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=YtMwjzdomruXaFpQgg6w6qw8vVGBPvQurfY1gF5gzT0%3D&timeout=30",
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

public class Test06278 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06278_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06278_s.txt", Encoding.UTF8);

    public Test06278() : base(recordedRequest, recordedResponse, "accounts8d439ff3a78d86e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3a78d86e",
                        container: "containersf473189346ef44f1b5ea1dd158aecb8a",
                        blob: "Blob02574c310a6448e9953561bd96f42710_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff3a78d86e/containersc78e2a73a01645cda106dfee72bb165a/Blobe245a2b911c04e33bcb58cf1588f9916_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=HrUJyDzYfhiALhst0wNGmPckfx2aTL1nQZArKCnxVLU%3D&timeout=30",
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

public class Test06147 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06147_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06147_s.txt", Encoding.UTF8);

    public Test06147() : base(recordedRequest, recordedResponse, "accounts8d439ff31ca7e73")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff31ca7e73",
                        container: "containers348678b9fe8c410ba0a9a4b44cdab08b",
                        blob: "Blob99483307f1a14632975f58b7a9a0cbc8_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff31ca7e73/containers6e9d5a3138e740bab9d5e251b8415957/Blob479bc64037c54c9e8346bb51dd3586bb_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=dwk7lde3OeG1XYoNmFnhisB9%2BC660piyz7uLqwGJcv0%3D&timeout=30",
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

public class Test06558 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06558_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06558_s.txt", Encoding.UTF8);

    public Test06558() : base(recordedRequest, recordedResponse, "accounts8d439ff4b45a758")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff4b45a758",
                        container: "containerse8bdfe0ed9134d95ad272b602380241a",
                        blob: "Blobcb986a9e795d435492b53cd5e34f75e9_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff4b394b2c/containers7a319c54322747b58e422ab69ed731cb/Blob91786d1eb22a4fce9cec77fa945c1058_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=XJW%2BzCbuOwi6YeZxsOLiWJ3YPZpw7XD4iiki3MxKLbc%3D&timeout=30",
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

public class Test06209 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06209_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06209_s.txt", Encoding.UTF8);

    public Test06209() : base(recordedRequest, recordedResponse, "accounts8d439ff34f3d7c0")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff34f3d7c0",
                        container: "containersf21522f8dbe542079f5101d34231e15c",
                        blob: "Bloba9fe4e4064324fdb8a7ae867d199a78c_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff34f3d7c0/containersf0f9a9fb25d34f9aa957e4ca1d456620/Blob67baf3b3825b432b9eb081a959fa59a2_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=2fU%2BeITAx57eR199qypvrRa0N4yCVfFUUsCg62Wvy94%3D&timeout=30",
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

public class Test05493 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05493_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05493_s.txt", Encoding.UTF8);

    public Test05493() : base(recordedRequest, recordedResponse, "accounts8d439ff1e35148b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1e35148b",
                        container: "containers704b940316164a3abcc73a3bec2c4143",
                        blob: "Blob7fb80b288858440b8e75bc64b7dc5b82",
                        copySource: @"http://localhost.fiddler:10000/rdfepirv28d439ff1e3a92dd/containers1ccbe599e2da4419988eecd25cde095b/Blobf93d0ae2f7f14f7aadc6ed2b29fe2dc4?se=2017-01-11T10%3A52%3A05.3911467Z&sv=2016-05-31&sr=c&sp=rwd&sig=K0b%2BKHYbMDLWYAnJdDwM6DRimzQ5hlNVwSsU0Kj3rnw%3D&timeout=30",
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

public class Test06496 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06496_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06496_s.txt", Encoding.UTF8);

    public Test06496() : base(recordedRequest, recordedResponse, "accounts8d439ff46adee91")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff46adee91",
                        container: "containers46416a78ac03431797b77018a064c848",
                        blob: "Blob97a6485651a14a5a82a1b7fbe6e5f5e4_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff469de8c6/containerse925381ceea24f21a0259e8ef6c7610e/Blob692246941b2a4f59bf238a4f4bce3a4b_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=%2BIIfNgPA3Ck%2F0VWjvPQ4KRugGxAzvx9XyAuzdLSfsjg%3D&timeout=30",
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

public class Test06198 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06198_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06198_s.txt", Encoding.UTF8);

    public Test06198() : base(recordedRequest, recordedResponse, "accounts8d439ff349e8b21")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff349e8b21",
                        container: "containers598df3775d3a4d2095caa3ca17d31e45",
                        blob: "Blob0d2672a3769a4e039060bade6fd87204_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff349e8b21/containerse340b48c5cc844db802b5193c115b0ce/Blob54c0760caabd4d1caafc2096b278a4f8_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=bjZjn8xTNz8OK7IrS6ljt6Iyo2LzqmP%2F1ky07b5Xjk0%3D&timeout=30",
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

public class Test06257 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06257_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06257_s.txt", Encoding.UTF8);

    public Test06257() : base(recordedRequest, recordedResponse, "accounts8d439ff3a30ab59")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3a30ab59",
                        container: "containers2bf925ed4ffd408b8a559b5d74964faf",
                        blob: "Blobd4cf2cfea7894ab594b822ada289a66b_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff3a30ab59/containers54edf8057415456f85048fe27416a48b/Blob77227b525f7542cea9b3534650033814_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=OyE4C6xLXeXqI8BI9Y6iS8ZD%2FJS8XMP5Mrj%2BvI3p6ak%3D&timeout=30",
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

public class Test06041 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06041_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06041_s.txt", Encoding.UTF8);

    public Test06041() : base(recordedRequest, recordedResponse, "accounts8d439ff2c1d8305")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2c1d8305",
                        container: "containersd303df1c1f134722878d0e1989ea0f83",
                        blob: "Bloba0a9f298f50642f196c7be517dad1824_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff2c1d8305/containersa73a9f63182243dca53547d236fce516/Blobb31b6ef287f046b8ba619128954d4c36_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=IqchyDkPfyOaYJI4LdVt%2FX3pGgPts1vm03VQ0l4ioO4%3D&timeout=30",
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

public class Test06353 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06353_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06353_s.txt", Encoding.UTF8);

    public Test06353() : base(recordedRequest, recordedResponse, "accounts8d439ff3ebb1da6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3ebb1da6",
                        container: "containersaa7c17e131db4b9e9a1d86873b7d11c3",
                        blob: "Blob01b5d7e09ba94456812e990acfa9cf4d_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff3ebb1da6/containerscd55fce0f8504baa990f5e17dc71f9fc/Blobc56b89e7e71f4a9d9a43fe8de11adfc7_CoRBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=jj57xJ83pCZl6BV69Edbvu%2BIevSPRs9jOzY%2B1FqtUxI%3D&timeout=30",
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

public class Test06642 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06642_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06642_s.txt", Encoding.UTF8);

    public Test06642() : base(recordedRequest, recordedResponse, "accounts8d439ff512db059")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff512db059",
                        container: "containersbabd163fbeec414581cead0132e67836",
                        blob: Encoding.UTF8.GetString(new byte[]{66,108,111,98,51,49,101,101,49,97,50,48,49,52,98,57,52,52,51,49,97,54,98,99,51,52,57,56,57,52,50,52,56,102,98,102,95,76,105,110,107,66,108,111,98,207,168}),
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff512db059/containers8091abcc57df42b9ba35fe0576f4f403/Blob9be5d79731724a91956de4b0947dbfda_WriteProtectedBlob%CF%A8?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=CNo%2BzrW%2FIE5OZ5kgW%2B6Lf9SB68m%2FGqsSQPThbidGd6c%3D&timeout=30",
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

public class Test05562 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05562_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05562_s.txt", Encoding.UTF8);

    public Test05562() : base(recordedRequest, recordedResponse, "accounts8d439ff1ef95071")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1ef95071",
                        container: "containers55cefde42dae470197d4fd676d62c49e",
                        blob: "Blob4d2cf1e9257648aa87721b4778bc8476",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1ef95071/containers55cefde42dae470197d4fd676d62c49e/Blob4d2cf1e9257648aa87721b4778bc8476?se=2017-01-11T10%3A52%3A06.6331828Z&sv=2016-05-31&sr=c&sp=rwd&sig=tXQXesBgIh9Rqz6s0aPCENR%2BN5a2RO%2F1v4Rst4cn3ok%3D&snapshot=2017-01-11T08%3A52%3A06.6121803Z&timeout=30",
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

public class Test06941 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06941_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06941_s.txt", Encoding.UTF8);

    public Test06941() : base(recordedRequest, recordedResponse, "accounts8d439ff906d3c8f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff906d3c8f",
                        container: "containers35a7d68d513141669c2eedac09d3b13a",
                        blob: "PageBlob428e5c65f0bd4e6e8830af893d942e13",
                        copySource: "http://localhost.fiddler:10000/accounts8d439ff906d3c8f/containers6e269a1813ca4ad1" +
    "955c6927bd0bba01/PageBlob606dee87721f4b569c0949287da19b30",
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

public class Test06100 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06100_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06100_s.txt", Encoding.UTF8);

    public Test06100() : base(recordedRequest, recordedResponse, "accounts8d439ff2f1d8201")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2f1d8201",
                        container: "containers12fc7cc1ec5f4500819a2727c21ca4c6",
                        blob: "Blobbb23ddb05ef54329a44c9609752d3949_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff2f1d8201/containers2c9791cee251415eb7e990660a1391c6/Blobc1b1af2527cf4a05baeb33bdcb2b2395_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=czp136%2BS2gqLt6YN%2FdLPZvIpaJdrQiYOaKJp%2FdtJFSI%3D&timeout=30",
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

public class Test06548 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06548_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06548_s.txt", Encoding.UTF8);

    public Test06548() : base(recordedRequest, recordedResponse, "accounts8d439ff4b0a2490")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff4b0a2490",
                        container: "containers6c6f4838f91e440981bcfaf24601f89a",
                        blob: "Blob2c7f67639c304cf58fb745f5160ba361_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff4afe1680/containerscfe0e8aaadb040908da34360f73b589f/Blob23ab6545c75e4160b57408ba379ec84a_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=uZECe0n406NgJSpXHEu88M4gaTHOFK0Bs5SubXDqBuM%3D&timeout=30",
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

public class Test06737 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06737_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06737_s.txt", Encoding.UTF8);

    public Test06737() : base(recordedRequest, recordedResponse, "accounts8d439ff557091d6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff557091d6",
                        container: "containersa5de5e83368b42dea6e5578584728441",
                        blob: "Blob418ac979251148ada0488f6c13973552_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff557091d6/containersbf61389c742e40e4a0082a1543d73ddb/Blob9ef02d92d72149c58797b934ad4ab1b1_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=sZxAGXlyMw8GEf%2FuRaq3PrH5G4GKFDqepxm9%2BPmKrWc%3D&timeout=30",
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

public class Test06087 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06087_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06087_s.txt", Encoding.UTF8);

    public Test06087() : base(recordedRequest, recordedResponse, "accounts8d439ff2ec80e56")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2ec80e56",
                        container: "containers691b4ef68c164f689a6f01539302c0ea",
                        blob: "Blob3e705b81933c4a79af6777318499f791_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff2ec80e56/containers76949a19489e40e6b2933bdc696d3e5b/Blobe7e5787b87e244feb9fe314dc5fe9e5e_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=YMvvLyouPAfl7ykIN1Re5ssWypZY0DfZm0uaFIckbGE%3D&timeout=30",
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

public class Test06483 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06483_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06483_s.txt", Encoding.UTF8);

    public Test06483() : base(recordedRequest, recordedResponse, "accounts8d439ff463d2a7b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff463d2a7b",
                        container: "containers787ddc77ca484eadb6bc241e9ee54734",
                        blob: "Blob5e6568060f2c4d4e991871545d336a30_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff4637d347/containersa45b111f57e341a2b967e1c4cb16baf6/Blob49715c6cc9f9402db6ed24e95109c089_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=ag17oA97dNCJ9aNrrdl7xUjbJStycej6g75Vux%2Bn9VY%3D&timeout=30",
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

public class Test06689 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06689_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06689_s.txt", Encoding.UTF8);

    public Test06689() : base(recordedRequest, recordedResponse, "accounts8d439ff5236489d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff5236489d",
                        container: "containersa7e2f6299683431cb79f1f93184f868d",
                        blob: "Blob859df5717ccb44e78d71532a60f8687d_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff5236489d/containers959b993c36dc43fea78a08f7f3b93541/Blob8c4cf2674c334940a76d2596be4f2cb1_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=TMBZT8lTgjLAg22lPC%2FZyCQ9Lef4PJ00FLTreU0Coc0%3D&timeout=30",
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

public class Test05447 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05447_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05447_s.txt", Encoding.UTF8);

    public Test05447() : base(recordedRequest, recordedResponse, "accounts8d439ff1da02687")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff1da02687",
                        container: "containersd23336042e464631bdc61816883a8bb0",
                        blob: "Blobc0cfdbadf0b6488987dd24a1f20779b9",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff1da02687/containersd23336042e464631bdc61816883a8bb0/Blobc0cfdbadf0b6488987dd24a1f20779b9?se=2017-01-11T10%3A52%3A04.3681191Z&sv=2016-05-31&sr=c&sp=rwd&sig=5ohnAJfDbD8TSgHMMMoOukLDd0JjTpl1sPK5Gtsfcio%3D&snapshot=2017-01-11T08%3A52%3A04.3381179Z&timeout=30",
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

public class Test05402 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05402_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05402_s.txt", Encoding.UTF8);

    public Test05402() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersaf7cbdac83ec4766ba2459b2343c50e7",
                        blob: "PageBlob8a0dad7990674dd5b1292f00185882ae",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersaf7cbdac83ec4766ba2459b2343" +
    "c50e7/PageBlob8a0dad7990674dd5b1292f00185882ae?snapshot=2017-01-11T08%3A52%3A03." +
    "5390964Z",
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

public class Test06436 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06436_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06436_s.txt", Encoding.UTF8);

    public Test06436() : base(recordedRequest, recordedResponse, "accounts8d439ff43349fd9")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff43349fd9",
                        container: "containers37a0b80fc9c9446db8fc0f9bf2393e54",
                        blob: "Blobb7f49bd80a304262afa31a92b8029936_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff432eac7f/containersf4f2aa33656c47a7a237863cd210f985/Blob29101084fea64487aca8e29a870da11b_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=6S3Kn6rF1xQcBSn5ltzUnhyyrvAJ5eojxgo%2Bf1gYHKs%3D&timeout=30",
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

public class Test06951 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06951_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06951_s.txt", Encoding.UTF8);

    public Test06951() : base(recordedRequest, recordedResponse, "accounts8d439ff9089ec8f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff9089ec8f",
                        container: "containersbcd814b4cf124f6dbd65500622b460f9",
                        blob: "PageBlob9b50d5c607814e4b9392d7e36e65f07e",
                        copySource: "http://localhost.fiddler:10000/accounts8d439ff9089ec8f/containersaf8f7f58ce7b4ffd" +
    "a9571a469ced0818/PageBlobd426679a401848c787d1bce90346436e",
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

public class Test06594 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06594_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06594_s.txt", Encoding.UTF8);

    public Test06594() : base(recordedRequest, recordedResponse, "accounts8d439ff4bd712f7")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff4bd712f7",
                        container: "containers402bb0197544410d907cf62898a0977a",
                        blob: "Blobfd141eb31f594fe68f9904bbdf91f357_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff4bd712f7/containers04e44e6c32fa493aba3f8e8f9f5526b4/Blob496adfe064ac4c4397c46caee701167e_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=YBHWUiyV5t%2FTwQDRoKV%2FOMGg%2FV%2B%2FMyNNqSUjPnult2A%3D&timeout=30",
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

public class Test06742 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06742_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06742_s.txt", Encoding.UTF8);

    public Test06742() : base(recordedRequest, recordedResponse, "accounts8d439ff5575e914")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff5575e914",
                        container: "containersa62ca518070c48d78c2dfe694e7d7aa2",
                        blob: "Blobe529120c9ba24b6d882e63fe663f0c69_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff557091d6/containersa5de5e83368b42dea6e5578584728441/Blob418ac979251148ada0488f6c13973552_CoRBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=ZKvaZFHxsIEwKaDxr6tGTxOl%2Fo3VuQeej3wtwVZ7pgw%3D&timeout=30",
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

public class Test06569 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06569_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06569_s.txt", Encoding.UTF8);

    public Test06569() : base(recordedRequest, recordedResponse, "accounts8d439ff4b952781")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff4b952781",
                        container: "containers2a9aec44e70c41b58f9fae6db255bff6",
                        blob: "Blobf2d8ac149a4d4a4eae779b354778c9d9_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff4b86cf83/containers156b64a757b04bbd97b708b10d38f463/Blob3b01be4df9234bf592ca36428bb6cb80_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=9u%2BjozmyFNwqnmxgIVqLHmzWp3%2BC5AKjqKuKzIL4SsQ%3D&timeout=30",
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

public class Test06664 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06664_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06664_s.txt", Encoding.UTF8);

    public Test06664() : base(recordedRequest, recordedResponse, "accounts8d439ff51b86529")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff51b86529",
                        container: "containers6de0c8d29fa6436eaf038e0fa62a4892",
                        blob: Encoding.UTF8.GetString(new byte[]{66,108,111,98,56,53,48,99,53,53,100,52,57,53,52,54,52,50,102,101,56,53,52,52,54,97,98,52,102,97,51,100,55,48,97,51,95,76,105,110,107,66,108,111,98,207,168}),
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff51b2e6e0/containers77a784f447b34fc8a0d7381123ae6d20/Blobed35542cf4274dcd961cd8967fb59bcf_WriteProtectedBlob%CF%A8?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=cyHmOJ%2FNeWDP82cxTJjEYrZqg3reTKT3YWdN%2Br%2BdqjY%3D&timeout=30",
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

public class Test06631 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06631_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06631_s.txt", Encoding.UTF8);

    public Test06631() : base(recordedRequest, recordedResponse, "accounts8d439ff50f4c59b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff50f4c59b",
                        container: "containers3ebad83234844da9958239e729e94eb4",
                        blob: Encoding.UTF8.GetString(new byte[]{66,108,111,98,97,57,52,56,55,49,51,57,55,53,101,49,52,102,102,55,98,49,56,102,100,99,54,101,51,101,53,102,54,55,57,101,95,76,105,110,107,66,108,111,98,207,168}),
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff50f4c59b/containers06c971b087224b86956d07c5689676f0/Blob0badca917c064b33af7bbfb4d734b86b_WriteProtectedBlob%CF%A8?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=AOaxMbQpkyTBg5LXMY8AoemTtet44bOPHzm2OJKnlmk%3D&timeout=30",
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

public class Test06694 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06694_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06694_s.txt", Encoding.UTF8);

    public Test06694() : base(recordedRequest, recordedResponse, "accounts8d439ff523c1502")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff523c1502",
                        container: "containers250cd533f870499a836e771f14f8b785",
                        blob: "Blob7b46a4bc11824c95be771199b235c3b1_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff5236489d/containersa7e2f6299683431cb79f1f93184f868d/Blob859df5717ccb44e78d71532a60f8687d_CoRBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=FXNhvRfErl4nsIloHPVENhznSBds1Xms2WeU4BsJrQ0%3D&timeout=30",
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

public class Test06423 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06423_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06423_s.txt", Encoding.UTF8);

    public Test06423() : base(recordedRequest, recordedResponse, "accounts8d439ff42e4f8c0")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff42e4f8c0",
                        container: "containers1628e9085c484bbf96e423b34ebb73a9",
                        blob: "Blob5d10b7f8f676466ba4b1fd087e7e7334_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff42dfa18b/containers26d67a1bb44f41ddb2c60f0f808f5dd2/Blob5c8933ed59cc46b59e16db4f65deca9b_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=JATshTsWiXL0cuhjR0jGcMUo94S9sRh79jwSVj83SLM%3D&timeout=30",
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

public class Test06472 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06472_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06472_s.txt", Encoding.UTF8);

    public Test06472() : base(recordedRequest, recordedResponse, "accounts8d439ff45ecbfee")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff45ecbfee",
                        container: "containers17739abe296e45808e1fcc953bc819e9",
                        blob: "Blobd3b6b7dcb4994257baa4cf29725c556d_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff45e2adbc/containers0908ca90fc1c4151a3be9e284129c07b/Blob1fb06af3c8614379b0fd7d23a046f4e4_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=y%2BJesvMFy47J1FarB139kBaEQbQzQ1%2BtIchbTPjx7zY%3D&timeout=30",
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

public class Test06599 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06599_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06599_s.txt", Encoding.UTF8);

    public Test06599() : base(recordedRequest, recordedResponse, "accounts8d439ff4be2d306")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff4be2d306",
                        container: "containers2909fca622a34524aef03de0ea5160ae",
                        blob: "Blob02834e6b6502459e9fe4108c61c3d39d_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff4bd712f7/containers402bb0197544410d907cf62898a0977a/Blobfd141eb31f594fe68f9904bbdf91f357_CoRBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=hE4VS8P6OfYqCZDLzYUKKvebQA6wNyQoNE3DC8hEZB4%3D&timeout=30",
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

public class Test06617 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06617_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06617_s.txt", Encoding.UTF8);

    public Test06617() : base(recordedRequest, recordedResponse, "accounts8d439ff4f47aee2")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff4f47aee2",
                        container: "containersc0fb41a9944249c1aca0ff3dffe28775",
                        blob: "Blob7a76f8248cb94261a396bfbffec11045_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff4f420976/containers696c9ef1e6dc4c058b7f74d867098a3f/Bloba983655df946473eb82707692f33c839_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=2LsIjxwruBa4DcU4B9mRbLouLKJPWglFl28UIb2qUGg%3D&timeout=30",
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

public class Test06247 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06247_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06247_s.txt", Encoding.UTF8);

    public Test06247() : base(recordedRequest, recordedResponse, "accounts8d439ff3656505e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3656505e",
                        container: "containers1c4782cfcc154deba84ea13a24e50642",
                        blob: "Bloba32a3782a94e4aa3a597b9310047c795_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff3656505e/containersab9afe24a9b743f3845bde8fa13183e3/Blobb9fd5be725a64217b7929fad168b58ac_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=FkXacyVjRGjtgxsYMZy0yXtIk2hzAMgbj3b0402hEaM%3D&timeout=30",
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

public class Test06333 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06333_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06333_s.txt", Encoding.UTF8);

    public Test06333() : base(recordedRequest, recordedResponse, "accounts8d439ff3df5824e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3df5824e",
                        container: "containers8dafc86639bc4755bac001f389365685",
                        blob: "Blob5f2ce3c17b3c42f5bc5fe06e977a98cc_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff3df5824e/containers582cd129475d44c4a29fe438b082f922/Blobe85a7fa5259443369c156cec1121f5b2_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=CaEGf9V4Rs1zhqLUbz8EHoipbmIblwbZR0WOKB0QXik%3D&timeout=30",
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

public class Test06125 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06125_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06125_s.txt", Encoding.UTF8);

    public Test06125() : base(recordedRequest, recordedResponse, "accounts8d439ff2fa6b03d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2fa6b03d",
                        container: "containers0d58700c21b84588b7d44794b596017f",
                        blob: "Blob005e48da5b534236bc5051042ba24424_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff2fa6b03d/containersdc113a6b097f4f8db735163e32849c49/Blob8782353f3230447abaca616112d5a373_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=gfCBMZ4Pf1tRGxpW4u5Pwx2LF8zf5ZK6jHew%2FpSLTps%3D&timeout=30",
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

public class Test06393 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06393_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06393_s.txt", Encoding.UTF8);

    public Test06393() : base(recordedRequest, recordedResponse, "accounts8d439ff3f2c7dd8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3f2c7dd8",
                        container: "containerse6f78054a20b43c8a1738be2db0d27f4",
                        blob: "Blob3978513ea3434fa2b42318cef033394b_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff3f2c7dd8/containers5ddb8d6f0ca542f487ea80d299b3e4d2/Blob6c5911d30be444baa6104349e003126b_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=QCKPsj3lBiI1XtjoSfQCAVDgUJ1ZdmxuEZcWdP%2FvO7M%3D&timeout=30",
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

public class Test06674 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06674_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06674_s.txt", Encoding.UTF8);

    public Test06674() : base(recordedRequest, recordedResponse, "accounts8d439ff51f9db6f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff51f9db6f",
                        container: "containersad3bd050b8d44a14897e03f31a00bd23",
                        blob: "Blobe996f2fa940b454a9965ae3df00178c5_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff51f9db6f/containersd63691dc18f14d0e8229a3e13db4f859/Blob285382746e394a0db30a1a29e6b6c993_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=3%2FziWU3spU6rgaYuNWBYDknX67OJMiJJsAdYFNEuckw%3D&timeout=30",
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

public class Test06752 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06752_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06752_s.txt", Encoding.UTF8);

    public Test06752() : base(recordedRequest, recordedResponse, "accounts8d439ff55b9d060")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff55b9d060",
                        container: "containerscace4dca241c42339b235daaecf1cb63",
                        blob: "Blobdcdeeb4227ea4172b81aee5c5bc1ee15_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff55b9d060/containers2f405b9d76594362bb712ea7bf87758d/Blob510e350cfb5c4b86bf1b0b1cc6927bac_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=vO0VIG4FIyBlTAIe8INyDKMCBVGm0ofCt7V3XjSKFs8%3D&timeout=30",
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

public class Test06338 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06338_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06338_s.txt", Encoding.UTF8);

    public Test06338() : base(recordedRequest, recordedResponse, "accounts8d439ff3df5824e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff3df5824e",
                        container: "containersd4c846382b0448669a27c0b1c7c4440d",
                        blob: "Blob243f2fb6377c4f01a44620d18984b61b_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff3df5824e/containers8dafc86639bc4755bac001f389365685/Blob5f2ce3c17b3c42f5bc5fe06e977a98cc_CoRBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=Z%2BWJ0da7Eh3nt3arZsaKdUms6vFJTMT17veCM17Lpno%3D&timeout=30",
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

public class Test06522 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06522_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06522_s.txt", Encoding.UTF8);

    public Test06522() : base(recordedRequest, recordedResponse, "accounts8d439ff4781e1e2")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff4781e1e2",
                        container: "containers997f513525fa4311b34441f08a39696f",
                        blob: "Blob0e98e52d63504365aa4499c37c54dbe4_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff47624b9d/containersdaf8304359414990bae5a6ceb443b409/Blob6218053c7d4e4ab897e2d00a3e40bdd7_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=LYhFLQeMOh1zN3p3OcF0pYfManxn4E3yn6ZB4ixbFGM%3D&timeout=30",
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

public class Test06679 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06679_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06679_s.txt", Encoding.UTF8);

    public Test06679() : base(recordedRequest, recordedResponse, "accounts8d439ff51ff80c0")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff51ff80c0",
                        container: "containers36f17c06683e407f99e1918f1ada7e05",
                        blob: "Blob05d8cf78b9234c70bd43a70dab381bf2_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff51f9db6f/containersad3bd050b8d44a14897e03f31a00bd23/Blobe996f2fa940b454a9965ae3df00178c5_CoRBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=ChI4pPfqyCTjtsLZQPX26h29ch%2FuKG72SqDrBbVGTgU%3D&timeout=30",
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

public class Test06757 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06757_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06757_s.txt", Encoding.UTF8);

    public Test06757() : base(recordedRequest, recordedResponse, "accounts8d439ff55b9d060")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff55b9d060",
                        container: "containersd72919278bfa4917b48fc37304e3213e",
                        blob: "Blob250bbfe19cf3432b9f34958be57fa504_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff55b9d060/containerscace4dca241c42339b235daaecf1cb63/Blobdcdeeb4227ea4172b81aee5c5bc1ee15_CoRBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=JtkSYSCJWHi5UPBAoPJ3rgJYTIlIo63gGmAL5GYgVdo%3D&timeout=30",
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

public class Test06719 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06719_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06719_s.txt", Encoding.UTF8);

    public Test06719() : base(recordedRequest, recordedResponse, "accounts8d439ff527a08e2")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff527a08e2",
                        container: "containers01e7f1e0e0864701be445087238c0153",
                        blob: "Blobfaea7fbc30bb42329e54e5831b2b5d50_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff527a08e2/containers6e5de8d94af8437687fd8f795b1dc162/Blob21a9858154e741a0ad5dffc0ca639472_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=xCF9Mjxtc7K1JRfY%2BcaZqGy3sd67ENt9l5bVxsGUhSg%3D&timeout=30",
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

public class Test06009 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06009_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06009_s.txt", Encoding.UTF8);

    public Test06009() : base(recordedRequest, recordedResponse, "accounts8d439ff2991ca97")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2991ca97",
                        container: "containers7d43a4dbd13945d1bf45281dd2df506f",
                        blob: "Blobfd783915578645c1a5b75e2a7c77503f_CoRBlob",
                        copySource: @"http://localhost.fiddler:10000/accounts8d439ff2991ca97/containers99505c84f1554d8f880264b75b2fca92/Blob4055684429c946988238c8d8fdafe73c_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=YwgIwB6GXlC0eVilzwwdJ%2Fq238nqH5j8SwB2VJSchEY%3D&timeout=30",
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

public class Test06136 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06136_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06136_s.txt", Encoding.UTF8);

    public Test06136() : base(recordedRequest, recordedResponse, "accounts8d439ff31833bbb")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff31833bbb",
                        container: "containers31ce27ca3cb04656b52ed5678c35617f",
                        blob: "Blob6ff568dc508d46699ad1e4ee6c23942b_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff31833bbb/containers841d0bc1cdd345aba583946d22596aa8/Blobb442040ee570410bafdfd5b271df151a_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=0%2Fe5Or0rxREOk2W7ZqFhMUQcGoslUqfL8Foxt1ogREw%3D&timeout=30",
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

public class Test06724 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06724_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06724_s.txt", Encoding.UTF8);

    public Test06724() : base(recordedRequest, recordedResponse, "accounts8d439ff52809897")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff52809897",
                        container: "containers5aaf8d0978e442ce8f73e2c801d7fb33",
                        blob: "Blob0284f94b09e946a3887e35e62c384c36_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff527a08e2/containers01e7f1e0e0864701be445087238c0153/Blobfaea7fbc30bb42329e54e5831b2b5d50_CoRBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=W1XHekaLjjij%2F3AT%2BGc9os5DO%2FZxpbOEAkD6Vh%2BFA%2Fw%3D&timeout=30",
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

public class Test06538 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06538_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06538_s.txt", Encoding.UTF8);

    public Test06538() : base(recordedRequest, recordedResponse, "accounts8d439ff4aa0daac")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d439ff4aa0daac",
                        container: "containers0417c53c3e35489f8a743d1ed1b41d7c",
                        blob: "Blob911ca1d6255543e09a8c33cb1235b106_LinkBlob",
                        copySource: @"http://localhost.fiddler:10005/accounts8d439ff4a8d0465/containersb04a805bee054344bac50afdec8dc861/Blobfe0fbb003425486ca4125e0ade20ad82_WriteProtectedBlob?sk=system-1&se=9999-12-31T23%3A59%3A59.9999999Z&sv=2016-05-31&sr=c&sp=r&sig=f6nR3JfbZ%2FiHEOkzxv7nJ9Jky%2BlUit0Bf5V5UQvpp9E%3D&timeout=30",
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

public class Test17567 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17567_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17567_s.txt", Encoding.UTF8);

    public Test17567() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers35da3d81ddab4b88902f21562cd4b654",
                        blob: "Blobf571fef5fb3b45699098eb1b2c1491a9",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers35da3d81ddab4b88902f21562cd" +
    "4b654/Blobb9aac015b6f74065821c30bd8c889c8f?se=2017-01-11T11%3A12%3A34.6470785Z&s" +
    "v=2016-05-31&sr=c&sp=rwd&sig=%2BazcRHX6KaL7ZGY%2FnvBAXZqh%2BYM5cqImwolD03kWIRA%3" +
    "D&timeout=30",
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

public class Test17918 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17918_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17918_s.txt", Encoding.UTF8);

    public Test17918() : base(recordedRequest, recordedResponse, "accounts8d43a023dff0707")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a023dff0707",
                        container: "containersaf9ebfa24f12467880d1d9e3ccbe247f",
                        blob: "PageBloba412d856ba9e4fc88d070dc34ba91040",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a023dff0707/containers5856abbc964d466d" +
    "8b40d14592f62a95/PageBlob37bb03a3858e482a9f8ec895fb830179",
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

public class Test18464 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18464_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18464_s.txt", Encoding.UTF8);

    public Test18464() : base(recordedRequest, recordedResponse, "accounts8d43a0244e8070f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a0244e8070f",
                        container: "containers004aa2c02ea747e2aa12118e38a7d03d",
                        blob: "PageBlobd348bcbc0a814afbb904a10db21ff9ac",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a0244e8070f/containers430f7d856f7445e8" +
    "8dec81715348dc11/PageBlob689864e1815845b1a399cce9b4c295d1",
                        timeout: 30,
                        leaseId: "7e89fe79-c50c-4a70-b176-39c8db732c9a",
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

public class Test17893 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17893_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17893_s.txt", Encoding.UTF8);

    public Test17893() : base(recordedRequest, recordedResponse, "accounts8d43a023dbb6de0")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a023dbb6de0",
                        container: "containersd0b256ed64144ad28ffeadbdec56bfc1",
                        blob: "PageBlobf76b19168c33458fb154d4f144c06081",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a023dbb6de0/containers6d6de08cce4c4241" +
    "96a2b3de57f38c31/PageBlobac713ba552b24bcba7790fa35d5e1625",
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

public class Test18439 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18439_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18439_s.txt", Encoding.UTF8);

    public Test18439() : base(recordedRequest, recordedResponse, "accounts8d43a0244a41fb5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a0244a41fb5",
                        container: "containers76b878975f714b30ad8d9f81bec7c0f0",
                        blob: "PageBlobfff304d243b345629ed6150481f8e8c1",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a0244a41fb5/containersf6b834c825f947a5" +
    "b1dc86e88748cc3c/PageBlob54d030b7508949649d06e7118e9a1274",
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

public class Test17927 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17927_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17927_s.txt", Encoding.UTF8);

    public Test17927() : base(recordedRequest, recordedResponse, "accounts8d43a023e1638ad")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a023e1638ad",
                        container: "containersa181cd15c787472181009c20d26bc8f1",
                        blob: "BlockBlob7552119a29a042388f68c8f6989dc9d1",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a023e1638ad/containers6f545b2c776e4da3" +
    "b008c7737bcbc861/BlockBlobb7b1a212c25c4798a757957ba9345a3a",
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

public class Test17901 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17901_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17901_s.txt", Encoding.UTF8);

    public Test17901() : base(recordedRequest, recordedResponse, "accounts8d43a023dd27870")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a023dd27870",
                        container: "containers9db2daebaef742eb8b6b8ed18f8294e7",
                        blob: "PageBlob49f307eca8a34880b53a178657b34697",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a023dd27870/containers88e347de98f24de5" +
    "ad7e41d69c361853/PageBlob870640fd4f7040478fe59734b94ecc62",
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

public class Test18448 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18448_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18448_s.txt", Encoding.UTF8);

    public Test18448() : base(recordedRequest, recordedResponse, "accounts8d43a0244bb7885")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a0244bb7885",
                        container: "containers333f5853b32d45dfb44167e5974e8bc0",
                        blob: "PageBlobdf912a5331ef419285f96cc14274fd47",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a0244bb7885/containers0c2c9180683a4234" +
    "bc21fdac9123e9f9/PageBlob7ba17a57d08b42a0a7ec337bf82f31c7",
                        timeout: 30,
                        leaseId: "cac76070-b21f-43b8-9d25-fe86dc6bfe5b",
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

public class Test22491 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22491_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22491_s.txt", Encoding.UTF8);

    public Test22491() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa4ad373df87e4910a98dc337c039ff57",
                        blob: "Blob39c042906b704764a33848135d709fe2",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers377e6b515a9d4f16bd229bb8aa7d5b1e/PageBlobd37efedfe37a44ad90df2cd52504551b?se=2017-01-11T11%3A30%3A56.8315044Z&sv=2016-05-31&sr=c&sp=rwd&sig=NS7SN7ZXjNwUEapcUdnNHVA68%2BwjSRrq8%2BtZ%2FT56dx4%3D&timeout=30",
                        timeout: 30,
                        ifNoneMatch: "\"0x8D43A048BFBC242\"",
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

public class Test22499 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22499_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22499_s.txt", Encoding.UTF8);

    public Test22499() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers19539cbbb439491c8f8eb505aeba9b47",
                        blob: "Blob33f42394f36f48c2b4e5f78d6cbd4ec8",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers41549fec38ed4ced89cf648b897" +
    "d282a/PageBlobcb9899f504304a55b213fc6c8416318b?se=2017-01-11T11%3A30%3A56.961506" +
    "0Z&sv=2016-05-31&sr=c&sp=rwd&sig=9DBWTLXjo02UziGVmh26yb%2BIhNOHaUDju3omkh6Gb6g%3" +
    "D&timeout=30",
                        timeout: 30,
                        ifMatches: "\"0x8D43A048C0F4A7B\"",
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

public class Test18456 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18456_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18456_s.txt", Encoding.UTF8);

    public Test18456() : base(recordedRequest, recordedResponse, "accounts8d43a0244d2aa2b")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a0244d2aa2b",
                        container: "containerseffcb0c2db394f02a919a067dd3caad9",
                        blob: "PageBlobfa8dad5527eb490088f713bcf1feeda0",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a0244d2aa2b/containersaf6e421bdb544c6e" +
    "b2c1a10681e801bc/PageBlob4c2fbd0035294d7eaee09af03840db1f",
                        timeout: 30,
                        leaseId: "71ceab7f-c2ed-4b52-b2be-cce7b02a0d63",
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

public class Test22500 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22500_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22500_s.txt", Encoding.UTF8);

    public Test22500() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers41549fec38ed4ced89cf648b897d282a",
                        blob: "Blob454b284d686743a693248745a128e7ae",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers41549fec38ed4ced89cf648b897" +
    "d282a/PageBlobcb9899f504304a55b213fc6c8416318b?se=2017-01-11T11%3A30%3A56.961506" +
    "0Z&sv=2016-05-31&sr=c&sp=rwd&sig=9DBWTLXjo02UziGVmh26yb%2BIhNOHaUDju3omkh6Gb6g%3" +
    "D&timeout=30",
                        timeout: 30,
                        ifMatches: "*",
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

public class Test17910 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17910_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17910_s.txt", Encoding.UTF8);

    public Test17910() : base(recordedRequest, recordedResponse, "accounts8d43a023de7d566")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a023de7d566",
                        container: "containersd4ab7ff5aabf4523b72cf6e3ae745f67",
                        blob: "PageBlob73aa0d590a1a4a0b97ac91613e77fa08",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a023de7d566/containers764da4c562924406" +
    "8157aeaeb3a39365/PageBlobbec89d45993f46329067f73308be848e",
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

public class Test17560 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17560_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17560_s.txt", Encoding.UTF8);

    public Test17560() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersaf32071c2d2542bf9f41746135d43f1c",
                        blob: "Blob6ffc8eda39bf4d1faf95aa662bebefa6",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersaf32071c2d2542bf9f41746135d" +
    "43f1c/Blobb3f005e1668e432ea2e57a152a5124b2",
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

public class Test22378 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22378_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22378_s.txt", Encoding.UTF8);

    public Test22378() : base(recordedRequest, recordedResponse, "accounts8d43a048a5b2eaf")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a048a5b2eaf",
                        container: "containers30535ea4c6ea4953a6bf2b2aacdbceef",
                        blob: "BlockBlob7f4c0f24f155437e944e7bc33de41503",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a048a5b2eaf/containers9f474fc16bcf409f" +
    "9babd5dd01d7dc50/BlockBlob9417fcc81d33489daab331fa776747ee",
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

public class Test23200 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23200_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23200_s.txt", Encoding.UTF8);

    public Test23200() : base(recordedRequest, recordedResponse, "accounts8d43a0497fafae9")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a0497fafae9",
                        container: "containerscb948fcfb48f4a1eb7159420cdfeb1bc",
                        blob: "AppendBlobdd0da617e8344063a663976232496a13",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersc6b451dad66945d6b9e6892feac" +
    "14204/AppendBlob2294de4aa355428d86cdf5c2b06c78e2",
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

public class Test22252 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22252_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22252_s.txt", Encoding.UTF8);

    public Test22252() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers715db674dc484372b014814b921ad657",
                        blob: "Blob9741e0aeccc14409b75b24b7009752cb",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers715db674dc484372b014814b921ad657/BlockBloba4325cb2cf5a42c8afec908024961195?sv=2014-02-14&sr=c&sp=rwdl&api-version=2016-05-31&se=2017-01-11T10%3A27%3A03.9730756Z&sig=R03r91t%2F%2FTpL%2FnPkHxxnao2hMjZjRv%2Bai4IkZ7fL4hA%3D",
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

public class Test23208 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23208_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23208_s.txt", Encoding.UTF8);

    public Test23208() : base(recordedRequest, recordedResponse, "accounts8d43a049815fd45")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a049815fd45",
                        container: "containersdc69c0cabde54b8198b3f27e7bc31c02",
                        blob: "BlockBlobe155a7be4335410a97ebcf2ed662d9f1",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a049811422e/containers292fd6e6f27f4383" +
    "a175cad80dbe6b7d/BlockBlobd203480e21b74f1485a0ca2224572c35",
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

public class Test22386 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22386_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22386_s.txt", Encoding.UTF8);

    public Test22386() : base(recordedRequest, recordedResponse, "accounts8d43a048aaf90dc")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a048aaf90dc",
                        container: "containers9d550aff0dda41afb20aced022784f7b",
                        blob: "AppendBlobbb25118412e2478fa0b05c74a94eb696",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a048aaf90dc/containerscb0c1056dc5a4a63" +
    "9b21de572e048517/AppendBlob25877792a66140939b0214cf8762d3b8",
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

public class Test23216 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23216_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23216_s.txt", Encoding.UTF8);

    public Test23216() : base(recordedRequest, recordedResponse, "accounts8d43a04982cb9bf")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a04982cb9bf",
                        container: "containersd32b9da182f14c4db2464bf6317447da",
                        blob: "AppendBlob6e86fcbf37f8420aacb9834f0c6b82df",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a049828e939/containers6de743febe9745f9" +
    "ad69dc9217a06628/AppendBlob607b79f0a33644abbf30abf219d1967c",
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

public class Test23223 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23223_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23223_s.txt", Encoding.UTF8);

    public Test23223() : base(recordedRequest, recordedResponse, "accounts8d43a0498454adb")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a0498454adb",
                        container: "containerscb74bfa60fc046d79ab96e6a1c2e17b6",
                        blob: "Blob104a8368903849c8b749a9857588359a",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers788e08823a68413ab286bfb35de" +
    "34d1a/Blob8cf38093d9ed454e943da3d63892a3a2",
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

public class Test22394 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22394_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22394_s.txt", Encoding.UTF8);

    public Test22394() : base(recordedRequest, recordedResponse, "accounts8d43a048ac6e991")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a048ac6e991",
                        container: "containerse44b1da35337446fab72ce38922228d5",
                        blob: "BlockBlobec5c2122533a4be89fc2515e0e83d5a4",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers159e8effbe474580be4e2909217" +
    "23e5a/BlockBlob874ec1d10a8647a68ee46a3c63caea95",
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

public class Test22452 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22452_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22452_s.txt", Encoding.UTF8);

    public Test22452() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers725c951af02a447cb08326276f5c8ece",
                        blob: "Blobb2e2497318a5419fb8c6dd42a064cb0c",
                        copySource: @"http://localhost.fiddler:10000/testaccount1/containers725c951af02a447cb08326276f5c8ece/BlockBlob528658176f694799bd620a8b911c780b?se=2017-01-11T11%3A30%3A56.3404904Z&sv=2016-05-31&sr=c&sp=rwd&sig=d3%2FFrwfVgol0%2Bu4Zh%2B3UUhoodNgCMd1ESskSc3GSg2A%3D&timeout=30",
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

public class Test22402 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22402_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22402_s.txt", Encoding.UTF8);

    public Test22402() : base(recordedRequest, recordedResponse, "accounts8d43a048aece865")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a048aece865",
                        container: "containers45b196da161447aba03d7cdb338abb97",
                        blob: "AppendBlobc79d3e95acb242988bd50c33eef7fd28",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers909599a893504fa0adce7a9bcd3" +
    "46a66/AppendBlob21e51064b4f24fa4b040447502875dd1",
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

public class Test22457 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22457_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22457_s.txt", Encoding.UTF8);

    public Test22457() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersa0964a08d5d644f4a13afc63e7a8a910",
                        blob: "Blobcb1ae8ad35d046f09d3f218c536635f9",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersa0964a08d5d644f4a13afc63e7a" +
    "8a910/PageBlob0f66a0ef69144b5b9d644c2790f7c814?se=2017-01-11T11%3A30%3A56.411492" +
    "2Z&sv=2016-05-31&sr=c&sp=rwd&sig=ThcapPZ%2B7TU8D2UBLgubgY%2FG2oAnin9oFpM3dbdnnPA" +
    "%3D&timeout=30",
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

public class Test22462 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22462_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22462_s.txt", Encoding.UTF8);

    public Test22462() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers5d536c1d21054198b9c12ea5da2e051a",
                        blob: "Blob5c802417ac38478c93e3c4ca49b0de2c",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers5d536c1d21054198b9c12ea5da2" +
    "e051a/PageBlob2a557238f1204e67afdc0a052060f7de?se=2017-01-11T11:30:56.4834949Z&s" +
    "v=2016-05-31&sr=c&sp=d&sig=H3U/Q+q7qpxTszfsoZgGrEWheoHBtQ9gjNKpyCcQvw0=&timeout=" +
    "30",
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

public class Test22410 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22410_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22410_s.txt", Encoding.UTF8);

    public Test22410() : base(recordedRequest, recordedResponse, "accounts8d43a048b0ca5a8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a048b0ca5a8",
                        container: "containers7140dc5312f645708a16d7cd15b323de",
                        blob: "BlockBlobf9fd8c25274145a78ebdc125d5fc6dd1",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a048b0615ea/containers5b56bf0079304855" +
    "a68fdcede385015d/BlockBlob873088f8be7743a38a7bef5e0c13079e",
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

public class Test22467 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22467_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22467_s.txt", Encoding.UTF8);

    public Test22467() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers41080053b37a470abcdce9bb0adf3c5b",
                        blob: "Blobe44ee75119ba415ba81e790b3e345bb9",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers41080053b37a470abcdce9bb0ad" +
    "f3c5b/PageBlob18f27cfd08594602a1f773562d915368?se=2017-01-11T11:30:56.5524932Z&s" +
    "v=2016-05-31&sr=c&sp=d&sig=gbv05KRwsVKuRDJ9mnSJJceeK6yG4wCI1znXcL8FSWw=&timeout=" +
    "30",
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

public class Test22471 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22471_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22471_s.txt", Encoding.UTF8);

    public Test22471() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersab4ba9ac67104128b018a964c18c9bbf",
                        blob: "Blobd67cbfbbc7e9498486426a46190d5275",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersab4ba9ac67104128b018a964c18" +
    "c9bbf/PageBlob15e2021e98104427b47a4b30d9c70f13",
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

public class Test23176 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23176_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23176_s.txt", Encoding.UTF8);

    public Test23176() : base(recordedRequest, recordedResponse, "accounts8d43a0497be8da5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a0497be8da5",
                        container: "containers82afaa839ea146e99e864ce106f888d1",
                        blob: "BlockBlobe899b89f17e64632a701b499a5712eea",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a0497be8da5/containerse4759addaf544c45" +
    "aedf7d624fc75734/BlockBlob2207b5ceb6b44b91a2351179e039a62f",
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

public class Test22418 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22418_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22418_s.txt", Encoding.UTF8);

    public Test22418() : base(recordedRequest, recordedResponse, "accounts8d43a048b2de97f")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a048b2de97f",
                        container: "containers38afd5465b0f499697c0154a05b39e38",
                        blob: "AppendBlob2ed9425f78c045939dee5033a2f7ee11",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a048b238917/containers866165777e594922" +
    "a6e9a2c40f27c19a/AppendBlobc349020ae6c84186b6e0d833bbd93341",
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

public class Test22475 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22475_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22475_s.txt", Encoding.UTF8);

    public Test22475() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers1d77578c0de44ff78ce776d2b344a53a",
                        blob: "Blobc9129c32fb8c4774bd063e654c4d816d",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers1d77578c0de44ff78ce776d2b34" +
    "4a53a/PageBlobdf7188407913444f82743fe8c8d5952c",
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

public class Test22482 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22482_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22482_s.txt", Encoding.UTF8);

    public Test22482() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersd080f5f5cf5147b89a490fd238e14699",
                        blob: "Blob046e0da5a8d34189af547ce16871f12f",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersd080f5f5cf5147b89a490fd238e" +
    "14699/PageBlob9d9e41ade02f47b68e4557ac80e0803b?se=2017-01-11T11%3A30%3A56.741501" +
    "9Z&sv=2016-05-31&sr=c&sp=rwd&sig=Y41y2AbUChTTOg3OTQVDULMifryRhAW9IslQyN0QqEQ%3D&" +
    "timeout=30",
                        timeout: 30,
                        leaseId: "8b031c2c-b0ff-467c-a9b4-506ce850d2a5",
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

public class Test23184 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23184_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23184_s.txt", Encoding.UTF8);

    public Test23184() : base(recordedRequest, recordedResponse, "accounts8d43a0497d0dd66")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a0497d0dd66",
                        container: "containers0e92979693c342b8bd47b4140ac0506e",
                        blob: "AppendBlob366ae721667a42dc9b787e039d887bd8",
                        copySource: "http://localhost.fiddler:10000/accounts8d43a0497d0dd66/containers4989c29175024e89" +
    "801ab988a1804a60/AppendBlobda8701effe994acf88ea9daedb1f2cfd",
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

public class Test22425 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22425_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22425_s.txt", Encoding.UTF8);

    public Test22425() : base(recordedRequest, recordedResponse, "accounts8d43a048b4d318d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a048b4d318d",
                        container: "containerse8169af3f5a04f298cfc9c46c06dee89",
                        blob: "Blobf0d42e80e1434a90ab36aaf27e28a4ae",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containersddcf849477b344d5ad201e8e1e1" +
    "d4918/Blobc6bc4c60e79249f48eb80b0702d68441",
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

public class Test23192 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23192_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23192_s.txt", Encoding.UTF8);

    public Test23192() : base(recordedRequest, recordedResponse, "accounts8d43a0497e41756")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Blobs.CopyWithHttpMessagesAsync(
                        accountName: "accounts8d43a0497e41756",
                        container: "containersef1567cf450a44f28e6e46e06f479743",
                        blob: "BlockBlob8a60ba5fde734f0d8c8b4abb00ee35dc",
                        copySource: "http://localhost.fiddler:10000/testaccount1/containers01eb78dada6b4f67a18f702e4e2" +
    "85613/BlockBlobecd8bfbaa078468bb8680023297418e7",
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
