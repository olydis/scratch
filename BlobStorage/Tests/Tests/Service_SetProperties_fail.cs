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

public class Test00074 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00074_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00074_s.txt", Encoding.UTF8);

    public Test00074() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>7</Days></RetentionPolicy></Logging><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00072 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00072_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00072_s.txt", Encoding.UTF8);

    public Test00072() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>7</Days></RetentionPolicy></Logging><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00078 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00078_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00078_s.txt", Encoding.UTF8);

    public Test00078() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>7</Days></RetentionPolicy></Logging><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00079 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00079_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00079_s.txt", Encoding.UTF8);

    public Test00079() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>7</Days></RetentionPolicy></Logging><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00076 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00076_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00076_s.txt", Encoding.UTF8);

    public Test00076() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>7</Days></RetentionPolicy></Logging><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00075 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00075_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00075_s.txt", Encoding.UTF8);

    public Test00075() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>7</Days></RetentionPolicy></Logging><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00077 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00077_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00077_s.txt", Encoding.UTF8);

    public Test00077() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>7</Days></RetentionPolicy></Logging><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00073 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00073_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00073_s.txt", Encoding.UTF8);

    public Test00073() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>7</Days></RetentionPolicy></Logging><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23164 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23164_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23164_s.txt", Encoding.UTF8);

    public Test23164() : base(recordedRequest, recordedResponse, "accounts8d43a04979affe5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><HourMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>7</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></HourMetrics><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a04979affe5",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23165 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23165_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23165_s.txt", Encoding.UTF8);

    public Test23165() : base(recordedRequest, recordedResponse, "accounts8d43a0497a38b7a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><MinuteMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>7</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></MinuteMetrics><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0497a38b7a",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23166 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23166_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23166_s.txt", Encoding.UTF8);

    public Test23166() : base(recordedRequest, recordedResponse, "accounts8d43a0497acb346")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>7</Days></RetentionPolicy></Logging><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0497acb346",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}
