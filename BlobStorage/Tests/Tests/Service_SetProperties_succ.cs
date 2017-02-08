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

public class Test000568 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000568_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000568_s.txt", Encoding.UTF8);

    public Test000568() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>false</Delete><Read>false</Read><Write>false</Write><RetentionPolicy><Enabled>false</Enabled></RetentionPolicy></Logging><HourMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>2</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>2</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></MinuteMetrics><Cors /><DefaultServiceVersion>2013-08-15</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000566 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000566_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000566_s.txt", Encoding.UTF8);

    public Test000566() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>false</Delete><Read>false</Read><Write>false</Write><RetentionPolicy><Enabled>false</Enabled></RetentionPolicy></Logging><HourMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>2</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>2</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></MinuteMetrics><Cors /><DefaultServiceVersion>2013-08-15</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000564 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000564_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000564_s.txt", Encoding.UTF8);

    public Test000564() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>false</Delete><Read>false</Read><Write>false</Write><RetentionPolicy><Enabled>false</Enabled></RetentionPolicy></Logging><HourMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>1</Days></RetentionPolicy><IncludeAPIs>false</IncludeAPIs></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>1</Days></RetentionPolicy><IncludeAPIs>false</IncludeAPIs></MinuteMetrics><Cors /><DefaultServiceVersion>2013-08-15</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000572 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000572_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000572_s.txt", Encoding.UTF8);

    public Test000572() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>false</Enabled></RetentionPolicy></Logging><HourMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>2</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>2</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></MinuteMetrics><Cors /><DefaultServiceVersion>2013-08-15</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000730 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000730_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000730_s.txt", Encoding.UTF8);

    public Test000730() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>false</Delete><Read>false</Read><Write>false</Write><RetentionPolicy><Enabled>false</Enabled></RetentionPolicy></Logging><HourMetrics><Version>1.0</Version><Enabled>false</Enabled><RetentionPolicy><Enabled>false</Enabled></RetentionPolicy></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>false</Enabled><RetentionPolicy><Enabled>false</Enabled></RetentionPolicy></MinuteMetrics><Cors /><DefaultServiceVersion>2013-08-15</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000681 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000681_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000681_s.txt", Encoding.UTF8);

    public Test000681() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>11</Days></RetentionPolicy></Logging><HourMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>11</Days></RetentionPolicy><IncludeAPIs>false</IncludeAPIs></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>false</Enabled><RetentionPolicy><Enabled>false</Enabled></RetentionPolicy></MinuteMetrics><Cors /><DefaultServiceVersion>2013-08-15</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000570 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000570_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000570_s.txt", Encoding.UTF8);

    public Test000570() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>false</Delete><Read>false</Read><Write>false</Write><RetentionPolicy><Enabled>true</Enabled><Days>3</Days></RetentionPolicy></Logging><HourMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>2</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>2</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></MinuteMetrics><Cors /><DefaultServiceVersion>2013-08-15</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00070 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00070_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00070_s.txt", Encoding.UTF8);

    public Test00070() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000574 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000574_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000574_s.txt", Encoding.UTF8);

    public Test000574() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>4</Days></RetentionPolicy></Logging><HourMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>2</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>2</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></MinuteMetrics><Cors /><DefaultServiceVersion>2013-08-15</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000562 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000562_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000562_s.txt", Encoding.UTF8);

    public Test000562() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>false</Delete><Read>false</Read><Write>false</Write><RetentionPolicy><Enabled>false</Enabled></RetentionPolicy></Logging><HourMetrics><Version>1.0</Version><Enabled>false</Enabled><RetentionPolicy><Enabled>false</Enabled></RetentionPolicy></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>false</Enabled><RetentionPolicy><Enabled>false</Enabled></RetentionPolicy></MinuteMetrics><Cors /><DefaultServiceVersion>2013-08-15</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00071 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00071_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00071_s.txt", Encoding.UTF8);

    public Test00071() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00080 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00080_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00080_s.txt", Encoding.UTF8);

    public Test00080() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00069 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00069_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00069_s.txt", Encoding.UTF8);

    public Test00069() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test001488 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001488_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001488_s.txt", Encoding.UTF8);

    public Test001488() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>false</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>5</Days></RetentionPolicy></Logging><HourMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>6</Days></RetentionPolicy><IncludeAPIs>false</IncludeAPIs></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>6</Days></RetentionPolicy><IncludeAPIs>false</IncludeAPIs></MinuteMetrics></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test001485 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001485_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001485_s.txt", Encoding.UTF8);

    public Test001485() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>false</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>5</Days></RetentionPolicy></Logging><HourMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>6</Days></RetentionPolicy><IncludeAPIs>false</IncludeAPIs></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>6</Days></RetentionPolicy><IncludeAPIs>false</IncludeAPIs></MinuteMetrics><Cors /><DefaultServiceVersion>2013-08-15</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test001486 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001486_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001486_s.txt", Encoding.UTF8);

    public Test001486() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Cors><CorsRule><AllowedOrigins>www.ab.com,www.bc.com</AllowedOrigins><AllowedMethods>GET,PUT</AllowedMethods><ExposedHeaders>x-ms-meta-data*,x-ms-meta-source*,x-ms-meta-abc,x-ms-meta-bcd</ExposedHeaders><AllowedHeaders>x-ms-meta-data*,x-ms-meta-target*,x-ms-meta-xyz,x-ms-meta-foo</AllowedHeaders><MaxAgeInSeconds>500</MaxAgeInSeconds></CorsRule></Cors></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        storageServiceProperties: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22363 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22363_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22363_s.txt", Encoding.UTF8);

    public Test22363() : base(recordedRequest, recordedResponse, "accounts8d43a048a037129")
    { }

    [Fact]
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
                        accountName: "accounts8d43a048a037129",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22364 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22364_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22364_s.txt", Encoding.UTF8);

    public Test22364() : base(recordedRequest, recordedResponse, "accounts8d43a048a139ded")
    { }

    [Fact]
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
                        accountName: "accounts8d43a048a139ded",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22365 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22365_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22365_s.txt", Encoding.UTF8);

    public Test22365() : base(recordedRequest, recordedResponse, "accounts8d43a048a252a2c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><StorageServiceProperties><Cors /><DefaultS" +
    "erviceVersion>2016-05-31</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a048a252a2c",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22367 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22367_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22367_s.txt", Encoding.UTF8);

    public Test22367() : base(recordedRequest, recordedResponse, "accounts8d43a048a372bba")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><StorageServiceProperties><Cors /><DefaultS" +
    "erviceVersion>2016-05-31</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a048a372bba",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22369 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22369_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22369_s.txt", Encoding.UTF8);

    public Test22369() : base(recordedRequest, recordedResponse, "accounts8d43a048a48b81d")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><StorageServiceProperties><Cors /><DefaultS" +
    "erviceVersion>2016-05-31</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a048a48b81d",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23019 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23019_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23019_s.txt", Encoding.UTF8);

    public Test23019() : base(recordedRequest, recordedResponse, "accounts8d43a0494d01b0c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Logging><Version>1.0</Version><Delete>true</Delete><Read>true</Read><Write>true</Write><RetentionPolicy><Enabled>true</Enabled><Days>10</Days></RetentionPolicy></Logging><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0494d01b0c",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23026 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23026_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23026_s.txt", Encoding.UTF8);

    public Test23026() : base(recordedRequest, recordedResponse, "accounts8d43a0494f556c1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><HourMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>10</Days></RetentionPolicy><IncludeAPIs>true</IncludeAPIs></HourMetrics><MinuteMetrics><Version>1.0</Version><Enabled>true</Enabled><RetentionPolicy><Enabled>true</Enabled><Days>10</Days></RetentionPolicy><IncludeAPIs>false</IncludeAPIs></MinuteMetrics><Cors /></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0494f556c1",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23029 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23029_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23029_s.txt", Encoding.UTF8);

    public Test23029() : base(recordedRequest, recordedResponse, "accounts8d43a0495a1c462")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><StorageServiceProperties><Cors><CorsRule><AllowedOrigins>www.ab.com</AllowedOrigins><AllowedMethods>PUT</AllowedMethods><ExposedHeaders>x-ms-meta-data*,x-ms-meta-bcd</ExposedHeaders><AllowedHeaders>x-ms-meta-target*,x-ms-meta-foo</AllowedHeaders><MaxAgeInSeconds>500</MaxAgeInSeconds></CorsRule></Cors></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0495a1c462",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23167 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23167_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23167_s.txt", Encoding.UTF8);

    public Test23167() : base(recordedRequest, recordedResponse, "accounts8d43a0497b3b835")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            StorageServiceProperties body; Assert.True(XmlSerialization.Root(XmlSerialization.ToDeserializer(e => StorageServiceProperties.XmlDeserialize(e)))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><StorageServiceProperties><Cors /><DefaultS" +
    "erviceVersion>2016-05-31</DefaultServiceVersion></StorageServiceProperties>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.SetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0497b3b835",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22356 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22356_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22356_s.txt", Encoding.UTF8);

    public Test22356() : base(recordedRequest, recordedResponse, "accounts8d43a04898c4477")
    { }

    [Fact]
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
                        accountName: "accounts8d43a04898c4477",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22357 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22357_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22357_s.txt", Encoding.UTF8);

    public Test22357() : base(recordedRequest, recordedResponse, "accounts8d43a04899da9c1")
    { }

    [Fact]
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
                        accountName: "accounts8d43a04899da9c1",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22358 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22358_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22358_s.txt", Encoding.UTF8);

    public Test22358() : base(recordedRequest, recordedResponse, "accounts8d43a0489adaf63")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0489adaf63",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22359 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22359_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22359_s.txt", Encoding.UTF8);

    public Test22359() : base(recordedRequest, recordedResponse, "accounts8d43a0489bf62e7")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0489bf62e7",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22360 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22360_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22360_s.txt", Encoding.UTF8);

    public Test22360() : base(recordedRequest, recordedResponse, "accounts8d43a0489cf4167")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0489cf4167",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22361 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22361_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22361_s.txt", Encoding.UTF8);

    public Test22361() : base(recordedRequest, recordedResponse, "accounts8d43a0489e05895")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0489e05895",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22362 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22362_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22362_s.txt", Encoding.UTF8);

    public Test22362() : base(recordedRequest, recordedResponse, "accounts8d43a0489f25a00")
    { }

    [Fact]
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
                        accountName: "accounts8d43a0489f25a00",
                        storageServiceProperties: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}
