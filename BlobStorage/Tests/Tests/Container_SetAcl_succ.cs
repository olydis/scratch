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

public class Test000044 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000044_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000044_s.txt", Encoding.UTF8);

    public Test000044() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers />"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        containerAcl: body,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000039 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000039_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000039_s.txt", Encoding.UTF8);

    public Test000039() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers />"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        containerAcl: body,
                        access: "container",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test000049 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000049_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000049_s.txt", Encoding.UTF8);

    public Test000049() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers />"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        containerAcl: body,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test001459 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001459_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001459_s.txt", Encoding.UTF8);

    public Test001459() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers />"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcf5dee7c19bf94da5a9609c7bcbe0aa5b",
                        containerAcl: body,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test001214 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001214_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001214_s.txt", Encoding.UTF8);

    public Test001214() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>key1</Id><AccessPolicy><Start>2017-01-11T21:14:50Z</Start><Expiry>2017-01-11T21:44:50Z</Expiry><Permission>l</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>key2</Id><AccessPolicy><Start>2017-01-11T21:14:50Z</Start><Expiry>2017-01-11T21:44:50Z</Expiry><Permission>l</Permission></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcca1a42d2bc5f495a80ad0e6921a2e9eb",
                        containerAcl: body,
                        access: "container",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test00965 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00965_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00965_s.txt", Encoding.UTF8);

    public Test00965() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers00632d8b71ae405d9cadf15dec9c2499",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test01068 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01068_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01068_s.txt", Encoding.UTF8);

    public Test01068() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers><SignedIdentifier><Id>do" +
    "ubleExpiry</Id><AccessPolicy><Start /><Expiry>2017-01-11T10:43:59.5577396Z</Expi" +
    "ry><Permission>w</Permission></AccessPolicy></SignedIdentifier></SignedIdentifie" +
    "rs>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers749ce3e28b6141408991f4844f13dc3e",
                        containerAcl: body,
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

public class Test01078 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01078_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01078_s.txt", Encoding.UTF8);

    public Test01078() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers><SignedIdentifier><Id>Si" +
    "AuthTest</Id><AccessPolicy><Start /><Expiry /><Permission /></AccessPolicy></Sig" +
    "nedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersab5a522b5b7f4faf90e902fd89462935",
                        containerAcl: body,
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

public class Test01064 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01064_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01064_s.txt", Encoding.UTF8);

    public Test01064() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers><SignedIdentifier><Id>sa" +
    "sWithExpiredPolicy</Id><AccessPolicy><Start /><Expiry>2017-01-11T06:43:59.511734" +
    "6Z</Expiry><Permission>w</Permission></AccessPolicy></SignedIdentifier></SignedI" +
    "dentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersf210f21cf28941e8b9b579ecedbc3d62",
                        containerAcl: body,
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

public class Test00433 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00433_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00433_s.txt", Encoding.UTF8);

    public Test00433() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers><SignedIdentifier><Id>sa" +
    "sWithExpiredPolicy</Id><AccessPolicy><Start /><Expiry>2017-01-11T06:43:34.615045" +
    "6Z</Expiry><Permission>w</Permission></AccessPolicy></SignedIdentifier></SignedI" +
    "dentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers24af2d06e4f34b998c13d75f653e379c",
                        containerAcl: body,
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

public class Test01073 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01073_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01073_s.txt", Encoding.UTF8);

    public Test01073() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers><SignedIdentifier><Id>Si" +
    "AuthTest</Id><AccessPolicy><Start /><Expiry>2017-01-13T08:43:59.6197378Z</Expiry" +
    "><Permission>r</Permission></AccessPolicy></SignedIdentifier></SignedIdentifiers" +
    ">"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers4cce2968159e4b4b913d57ff2453ef43",
                        containerAcl: body,
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

public class Test01080 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01080_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\01080_s.txt", Encoding.UTF8);

    public Test01080() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers />"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersab5a522b5b7f4faf90e902fd89462935",
                        containerAcl: body,
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

public class Test04259 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04259_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04259_s.txt", Encoding.UTF8);

    public Test04259() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>cuNFWhscMZHdzkhwbfUTEIVYoGizudykwSmGqKnlAnxOazihebitVPzUZoQPzshi</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.4075458Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>bGQsjSRKGypYBVTuFPgTSgBuXmHFOoCSCjCVSBlwiJTqbryXNoVIzMfuEWUxKLvR</Id><AccessPolicy><Start>2017-01-12T08:48:42.4075458Z</Start><Expiry /><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>ycDdklINLTgnkraTuSpDIQvgnlWNBuEVgFPLRePbXgsDoJaTVyAEfNJhhXpyOuLR</Id><AccessPolicy><Start /><Expiry /><Permission>r</Permission></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers2a77c4a1c1bc4c048d19a5e77dd8ecfe",
                        containerAcl: body,
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

public class Test04291 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04291_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04291_s.txt", Encoding.UTF8);

    public Test04291() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers><SignedIdentifier><Id>si" +
    "gnedidentifier4</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.6535526Z<" +
    "/Expiry><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        containerAcl: body,
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

public class Test04310 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04310_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04310_s.txt", Encoding.UTF8);

    public Test04310() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerse395d85621764902813537af8934b9a5",
                        containerAcl: body,
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

public class Test04246 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04246_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04246_s.txt", Encoding.UTF8);

    public Test04246() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>zYjCYPTyuYMzDNJSkagwCdYIoHcaqqDOcQBgQkPLrXBcjtVyRRRmdEfVzaORmtHD</Id><AccessPolicy><Start /><Expiry /><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>dBAKVEebwZuleIZZRlXlfgqVyYyQxHlWimoPQbHAAtDBUgIkieDMzBgwLfLwGOep</Id><AccessPolicy><Start /><Expiry /><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>JIpdXkmdoBSQNhTDZWhFsElQKtmPOOwdQQZWOicRuSWdsgshKlOBVmbEWZSdyWPa</Id><AccessPolicy><Start /><Expiry /><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>xpqtPLZhIXeBFEczuIdpUzpPzTXDvYDgwZNwYHFaBXOBocsRmaKhWHnxAauwoVlj</Id><AccessPolicy><Start /><Expiry /><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>gbnCDoxknbWaFRVNWJplPvxMJlflehqXMaFzXeSSqMMyXViEQWxoPubkdasRIMGF</Id><AccessPolicy><Start /><Expiry /><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers901744097bb448a9a8a1ee977f858d0c",
                        containerAcl: body,
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

public class Test04262 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04262_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04262_s.txt", Encoding.UTF8);

    public Test04262() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version='1.0' encoding='utf-8'?>
<SignedIdentifiers>
    <SignedIdentifier>
        <Id>policy1</Id>
        <AccessPolicy>
            <Start>2017-01-10T08:48:42.4495486Z</Start>
            <Expiry>2017-01-12T08:48:42.4505464Z</Expiry>
            <Permission>c</Permission>
        </AccessPolicy>
    </SignedIdentifier>
</SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbd7c80eb7bcf4c59b4db4d6f065d70df",
                        containerAcl: body,
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

public class Test04277 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04277_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04277_s.txt", Encoding.UTF8);

    public Test04277() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version='1.0' encoding='utf-8'?>
                <SignedIdentifiers>
                    <SignedIdentifier>
                        <Id>id</Id>

                        <AccessPolicy>
                            
                            
                            <Permission>rwd</Permission>

                        </AccessPolicy>
                    </SignedIdentifier>
                </SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers82a2590f4e644c6e8f288b99a5bcc197",
                        containerAcl: body,
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

public class Test04293 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04293_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04293_s.txt", Encoding.UTF8);

    public Test04293() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>signedidentifier0</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier1</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier2</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier3</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier4</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        containerAcl: body,
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

public class Test04248 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04248_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04248_s.txt", Encoding.UTF8);

    public Test04248() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>zYjCYPTyuYMzDNJSkagwCdYIoHcaqqDOcQBgQkPLrXBcjtVyRRRmdEfVzaORmtHD</Id><AccessPolicy><Start /><Expiry /><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>dBAKVEebwZuleIZZRlXlfgqVyYyQxHlWimoPQbHAAtDBUgIkieDMzBgwLfLwGOep</Id><AccessPolicy><Start /><Expiry /><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>JIpdXkmdoBSQNhTDZWhFsElQKtmPOOwdQQZWOicRuSWdsgshKlOBVmbEWZSdyWPa</Id><AccessPolicy><Start /><Expiry /><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>xpqtPLZhIXeBFEczuIdpUzpPzTXDvYDgwZNwYHFaBXOBocsRmaKhWHnxAauwoVlj</Id><AccessPolicy><Start /><Expiry /><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>gbnCDoxknbWaFRVNWJplPvxMJlflehqXMaFzXeSSqMMyXViEQWxoPubkdasRIMGF</Id><AccessPolicy><Start /><Expiry /><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers901744097bb448a9a8a1ee977f858d0c",
                        containerAcl: body,
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

public class Test04294 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04294_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04294_s.txt", Encoding.UTF8);

    public Test04294() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers />"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        containerAcl: body,
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

public class Test04280 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04280_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04280_s.txt", Encoding.UTF8);

    public Test04280() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>signedidentifier0</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier1</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier2</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier3</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier4</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        containerAcl: body,
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

public class Test04281 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04281_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04281_s.txt", Encoding.UTF8);

    public Test04281() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>signedidentifier1</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier2</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier3</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier4</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        containerAcl: body,
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

public class Test04297 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04297_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04297_s.txt", Encoding.UTF8);

    public Test04297() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers94b785c60842411c88f14c5b8f52175a",
                        containerAcl: body,
                        timeout: 30,
                        access: "container",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04251 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04251_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04251_s.txt", Encoding.UTF8);

    public Test04251() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>VqrqWvCjypnDaUIkBHSzVVwlBJeGHNYIDtufFxtyYBflFOirxVjrvfqAtFpMRwbl</Id><AccessPolicy /></SignedIdentifier><SignedIdentifier><Id>dfEOTaTqLgmbmJmegMYDulzHhhcZtTaPARUpfdcEWKiZDkfmpGlSbdfrgwgmytwr</Id><AccessPolicy /></SignedIdentifier><SignedIdentifier><Id>wzCkTgjDZEwBpjniHnXmdIiwpGcOqTfJKxtHjiIwvoGrkkIJIJyjDhLnQFuMDVMF</Id><AccessPolicy /></SignedIdentifier><SignedIdentifier><Id>fzYfaroCrMExTFhUvFdlFrdnvsZbBSxtQTdKaEdqXlYsqOkQflcgNGkoVlkhSNBY</Id><AccessPolicy /></SignedIdentifier><SignedIdentifier><Id>WurcmOUSlxgHIvPqQfKioopTwYJkAdfhloIqkEbrQVknDZJSlizfWRniFYgOFjRI</Id><AccessPolicy /></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9a0ae8e575f1446a9822db71e4673982",
                        containerAcl: body,
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

public class Test04283 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04283_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04283_s.txt", Encoding.UTF8);

    public Test04283() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>signedidentifier0</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier1</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier2</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier3</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier4</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        containerAcl: body,
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

public class Test04235 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04235_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04235_s.txt", Encoding.UTF8);

    public Test04235() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>wael</Id><AccessPolicy><Start>2017-01-10T08:48:42.0765353Z</Start><Expiry>2017-01-12T08:48:42.0765353Z</Expiry><Permission>r</Permission></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers7825f8d4373340ff913d38c69b27855f",
                        containerAcl: body,
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

public class Test04284 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04284_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04284_s.txt", Encoding.UTF8);

    public Test04284() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>signedidentifier2</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier3</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier4</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        containerAcl: body,
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

public class Test04301 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04301_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04301_s.txt", Encoding.UTF8);

    public Test04301() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers94b785c60842411c88f14c5b8f52175a",
                        containerAcl: body,
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

public class Test04238 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04238_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04238_s.txt", Encoding.UTF8);

    public Test04238() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>wael</Id><AccessPolicy><Start>2017-01-10T08:48:42.1295355Z</Start><Expiry>2017-01-12T08:48:42.1295355Z</Expiry><Permission>r</Permission></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers11e78f8136af42e3946316ceaaf80353",
                        containerAcl: body,
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

public class Test04254 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04254_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04254_s.txt", Encoding.UTF8);

    public Test04254() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>ZFLESRSEBPWOrzSeAKTBakMXMmhEcVECpfLcnaDAUeEIJzOkyeSnDSMososgkOcg</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.3485441Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>pqZHThwgDOMXwFxDRzWTXjyiWQFBXxpZDxJnsgkkPHpZfJnJedtVDrPFsrkCbuJF</Id><AccessPolicy><Start>2017-01-12T08:48:42.3485441Z</Start><Expiry /><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>KKkOlDPuZDNdwXuEUWLhDvAwhJVyjBsonMTSJGRozKSoXZfWOBEQJStPKohchRLX</Id><AccessPolicy><Start /><Expiry /><Permission>r</Permission></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers086c269886414ad19687e514ed6e1fd6",
                        containerAcl: body,
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

public class Test04286 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04286_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04286_s.txt", Encoding.UTF8);

    public Test04286() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>signedidentifier0</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier1</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier2</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier3</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier4</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        containerAcl: body,
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

public class Test04256 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04256_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04256_s.txt", Encoding.UTF8);

    public Test04256() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>ZFLESRSEBPWOrzSeAKTBakMXMmhEcVECpfLcnaDAUeEIJzOkyeSnDSMososgkOcg</Id><AccessPolicy><Expiry>2017-01-12T08:48:42.3485441Z</Expiry></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>pqZHThwgDOMXwFxDRzWTXjyiWQFBXxpZDxJnsgkkPHpZfJnJedtVDrPFsrkCbuJF</Id><AccessPolicy><Start>2017-01-12T08:48:42.3485441Z</Start></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>KKkOlDPuZDNdwXuEUWLhDvAwhJVyjBsonMTSJGRozKSoXZfWOBEQJStPKohchRLX</Id><AccessPolicy><Permission>r</Permission></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers086c269886414ad19687e514ed6e1fd6",
                        containerAcl: body,
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

public class Test04288 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04288_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04288_s.txt", Encoding.UTF8);

    public Test04288() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>signedidentifier3</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier4</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        containerAcl: body,
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

public class Test04305 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04305_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04305_s.txt", Encoding.UTF8);

    public Test04305() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers94b785c60842411c88f14c5b8f52175a",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04241 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04241_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04241_s.txt", Encoding.UTF8);

    public Test04241() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>zlkJDUHyXweDkuqhYBWAzZBYJlITxVFKvoSdCbWWNAbxpTYPPaslUXuZjMASMnAC</Id><AccessPolicy><Start>2017-01-10T08:48:42.1715356Z</Start><Expiry>2017-01-12T08:48:42.1715356Z</Expiry><Permission>r</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>MfxezmzxEipMsEXcUqXutupaEJazZHVLdnCuvHUkubfeLFUidZVdkBiSpXZqMAYx</Id><AccessPolicy><Start>2017-01-10T08:48:42.1715356Z</Start><Expiry>2017-01-12T08:48:42.1715356Z</Expiry><Permission>r</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>chNWmzRPLPyprWAlsabFkFYheYuDiShWPgArIHxCRDeHaBUeYLUDHzSXJgsOEOgs</Id><AccessPolicy><Start>2017-01-10T08:48:42.1715356Z</Start><Expiry>2017-01-12T08:48:42.1715356Z</Expiry><Permission>r</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>IckdZngaQGdEQeWyeOPNcicPjxCWlZybIIPjjZiLlwtZOJojKuEOJxtaAVtblKpq</Id><AccessPolicy><Start>2017-01-10T08:48:42.1715356Z</Start><Expiry>2017-01-12T08:48:42.1715356Z</Expiry><Permission>r</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>nPEfEcfoCAaJTLrVkRKOpiNfHabHCSNNgUXfziFVNlxVTSRyxVXkltZEBYXdBYmk</Id><AccessPolicy><Start>2017-01-10T08:48:42.1715356Z</Start><Expiry>2017-01-12T08:48:42.1715356Z</Expiry><Permission>r</Permission></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9ce1d2ccc6a3486aa88b6107c8b6f1a4",
                        containerAcl: body,
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

public class Test04290 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04290_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04290_s.txt", Encoding.UTF8);

    public Test04290() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>signedidentifier0</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier1</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier2</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry /><Permission>d</Permission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier3</Id><AccessPolicy><Start>2017-01-10T08:48:42.6535526Z</Start><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>signedidentifier4</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.6535526Z</Expiry><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        containerAcl: body,
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

public class Test17767 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17767_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17767_s.txt", Encoding.UTF8);

    public Test17767() : base(recordedRequest, recordedResponse, "accounts8d43a0239360495")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a0239360495",
                        container: "containers53cc09707a3c4988bc049522b7310679",
                        containerAcl: body,
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

public class Test22429 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22429_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22429_s.txt", Encoding.UTF8);

    public Test22429() : base(recordedRequest, recordedResponse, "accounts8d43a048b593f8c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a048b593f8c",
                        container: "containers041dc84c107348beb1286da53b067ee3",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22434 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22434_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22434_s.txt", Encoding.UTF8);

    public Test22434() : base(recordedRequest, recordedResponse, "accounts8d43a048b674985")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a048b674985",
                        container: "containers1b6d82dad2714a5baf86d9131e6970dd",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23199 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23199_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23199_s.txt", Encoding.UTF8);

    public Test23199() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersc6b451dad66945d6b9e6892feac14204",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22377 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22377_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22377_s.txt", Encoding.UTF8);

    public Test22377() : base(recordedRequest, recordedResponse, "accounts8d43a048a5b2eaf")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a048a5b2eaf",
                        container: "containers9f474fc16bcf409f9babd5dd01d7dc50",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22439 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22439_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22439_s.txt", Encoding.UTF8);

    public Test22439() : base(recordedRequest, recordedResponse, "accounts8d43a048b7664b9")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a048b7664b9",
                        container: "containersbd7b03ed65a649e8a5e31808b7bc6f84",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23207 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23207_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23207_s.txt", Encoding.UTF8);

    public Test23207() : base(recordedRequest, recordedResponse, "accounts8d43a049811422e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a049811422e",
                        container: "containers292fd6e6f27f4383a175cad80dbe6b7d",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22385 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22385_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22385_s.txt", Encoding.UTF8);

    public Test22385() : base(recordedRequest, recordedResponse, "accounts8d43a048aaf90dc")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a048aaf90dc",
                        container: "containerscb0c1056dc5a4a639b21de572e048517",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23141 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23141_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23141_s.txt", Encoding.UTF8);

    public Test23141() : base(recordedRequest, recordedResponse, "accounts8d43a0497244890")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a0497244890",
                        container: "containers9457ac81d697469e9699c8b1514e36c1",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test17775 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17775_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17775_s.txt", Encoding.UTF8);

    public Test17775() : base(recordedRequest, recordedResponse, "accounts8d43a0239360495")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a0239360495",
                        container: "containers53cc09707a3c4988bc049522b7310679",
                        containerAcl: body,
                        timeout: 30,
                        leaseId: "83c00cac-555e-4ce2-94b6-9cf43c42fecc",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23215 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23215_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23215_s.txt", Encoding.UTF8);

    public Test23215() : base(recordedRequest, recordedResponse, "accounts8d43a049828e939")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a049828e939",
                        container: "containers6de743febe9745f9ad69dc9217a06628",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22444 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22444_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22444_s.txt", Encoding.UTF8);

    public Test22444() : base(recordedRequest, recordedResponse, "accounts8d43a048b895092")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a048b895092",
                        container: "containers825f8168984a468ab075273dfe683f22",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23220 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23220_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23220_s.txt", Encoding.UTF8);

    public Test23220() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers788e08823a68413ab286bfb35de34d1a",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22393 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22393_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22393_s.txt", Encoding.UTF8);

    public Test22393() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers159e8effbe474580be4e290921723e5a",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23227 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23227_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23227_s.txt", Encoding.UTF8);

    public Test23227() : base(recordedRequest, recordedResponse, "accounts8d43a04984ff951")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a04984ff951",
                        container: "containers4f58be861ac44cac886385605ca5f9b9",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22401 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22401_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22401_s.txt", Encoding.UTF8);

    public Test22401() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers909599a893504fa0adce7a9bcd346a66",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22281 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22281_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22281_s.txt", Encoding.UTF8);

    public Test22281() : base(recordedRequest, recordedResponse, "accounts8d43a0488576bc6")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a0488576bc6",
                        container: "containerse5e2817592d348bc8b3f3784fe3ba7d7",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22409 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22409_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22409_s.txt", Encoding.UTF8);

    public Test22409() : base(recordedRequest, recordedResponse, "accounts8d43a048b0615ea")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a048b0615ea",
                        container: "containers5b56bf0079304855a68fdcede385015d",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23175 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23175_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23175_s.txt", Encoding.UTF8);

    public Test23175() : base(recordedRequest, recordedResponse, "accounts8d43a0497be8da5")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a0497be8da5",
                        container: "containerse4759addaf544c45aedf7d624fc75734",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22286 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22286_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22286_s.txt", Encoding.UTF8);

    public Test22286() : base(recordedRequest, recordedResponse, "accounts8d43a04886f12a0")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a04886f12a0",
                        container: "containers90b58ac437844432bc7a1a0b107fe707",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22417 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22417_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22417_s.txt", Encoding.UTF8);

    public Test22417() : base(recordedRequest, recordedResponse, "accounts8d43a048b238917")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a048b238917",
                        container: "containers866165777e594922a6e9a2c40f27c19a",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test21466 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21466_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21466_s.txt", Encoding.UTF8);

    public Test21466() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers><SignedIdentifier><Id>sa" +
    "sWithSiPolicy</Id><AccessPolicy><Start>2017-01-10T09:26:26.0550285Z</Start><Expi" +
    "ry /><Permission>w</Permission></AccessPolicy></SignedIdentifier></SignedIdentif" +
    "iers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers85ce408de64b47da805a9c21e4a5be04",
                        containerAcl: body,
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

public class Test22291 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22291_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22291_s.txt", Encoding.UTF8);

    public Test22291() : base(recordedRequest, recordedResponse, "accounts8d43a04887e7c14")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a04887e7c14",
                        container: "containerseff577f3dacd4ff08b441ea98b5576c4",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test22422 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22422_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\22422_s.txt", Encoding.UTF8);

    public Test22422() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersddcf849477b344d5ad201e8e1e1d4918",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23183 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23183_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23183_s.txt", Encoding.UTF8);

    public Test23183() : base(recordedRequest, recordedResponse, "accounts8d43a0497d0dd66")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a0497d0dd66",
                        container: "containers4989c29175024e89801ab988a1804a60",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test23191 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23191_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23191_s.txt", Encoding.UTF8);

    public Test23191() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; body = null;
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers01eb78dada6b4f67a18f702e4e285613",
                        containerAcl: body,
                        timeout: 30,
                        access: "blob",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                
            }
            catch (CloudException)
            {
                throw; // expected success

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                throw; // expected success
            }
            catch (ArgumentException)
            {
                throw; // expected success
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*<*/throw ServerException/*></assertServerFail>*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}
