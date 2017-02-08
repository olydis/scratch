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

public class Test04275 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04275_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04275_s.txt", Encoding.UTF8);

    public Test04275() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                            
                            <Expiry>Invalid DateTime</Expiry>

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
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04244 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04244_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04244_s.txt", Encoding.UTF8);

    public Test04244() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?><SignedIdentifiers><SignedIdentifier><Id>MV" +
    "BLoBDlsMpJcKgucbnuTdaKcUpzMiGpSKlzVYwsWTJMiUYOFqKlpFVjvqjULEYJ</Id><AccessPolicy" +
    "><Start>2017-01-10T08:48:42.2135393Z</Start><Expiry>2017-01-12T08:48:42.2135393Z" +
    "</Expiry><Permission>r</Permission></AccessPolicy></SignedIdentifier><SignedIden" +
    "tifier><Id>hYEeuYATOcHwbtWXUzMoBEfocgRuzGidGpYRGHugVQgOcXkLBmlAedXctPBOGFTH</Id>" +
    "<AccessPolicy><Start>2017-01-10T08:48:42.2135393Z</Start><Expiry>2017-01-12T08:4" +
    "8:42.2135393Z</Expiry><Permission>r</Permission></AccessPolicy></SignedIdentifie" +
    "r><SignedIdentifier><Id>FRNEfTlXQMFvGtNVizcSvXrFfaPwZUxhyqwUXvyJlFcCwTAMFmLfNTYh" +
    "aHYFEoyv</Id><AccessPolicy><Start>2017-01-10T08:48:42.2135393Z</Start><Expiry>20" +
    "17-01-12T08:48:42.2135393Z</Expiry><Permission>r</Permission></AccessPolicy></Si" +
    "gnedIdentifier><SignedIdentifier><Id>sxmBSgqvoJMaDrmJSTfROuPWsFwGhnYXkPMoYevnhml" +
    "yMfAxLmwDRyiyiQIMkkNB</Id><AccessPolicy><Start>2017-01-10T08:48:42.2135393Z</Sta" +
    "rt><Expiry>2017-01-12T08:48:42.2135393Z</Expiry><Permission>r</Permission></Acce" +
    "ssPolicy></SignedIdentifier><SignedIdentifier><Id>yloYrjcJRKNFyvvrUFlgOGIViCxYjO" +
    "WpMTNAHfZOFoRFvHlpSKPjEHPrcTqplEaC</Id><AccessPolicy><Start>2017-01-10T08:48:42." +
    "2135393Z</Start><Expiry>2017-01-12T08:48:42.2135393Z</Expiry><Permission>r</Perm" +
    "ission></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>ukpfWbapCaaQIFZyn" +
    "kEEWYnokcBOOSXOHHYaZDhgoCatPYdyAEAmoaLVwBvtZMbj</Id><AccessPolicy><Start>2017-01" +
    "-10T08:48:42.2135393Z</Start><Expiry>2017-01-12T08:48:42.2135393Z</Expiry><Permi" +
    "ssion>r</Permission></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.SetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersf23ae9993d40429bb5ded73edf9e01d9",
                        containerAcl: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04276 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04276_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04276_s.txt", Encoding.UTF8);

    public Test04276() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                            
                            
                            <Permission>Invalid Permission</Permission>

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
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04266 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04266_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04266_s.txt", Encoding.UTF8);

    public Test04266() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        <Id>Single Id</Id>
                        <AccessPolicy>
                            <Permission>rwd</Permission>
                            <Permission>d</Permission>
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
                        container: "containers06385f89093f4b55bfd4e337e3338a61",
                        containerAcl: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04267 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04267_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04267_s.txt", Encoding.UTF8);

    public Test04267() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        <Id>Single Id</Id>
                        <AccessPolicy>
                            <Start>1/11/2017 8:48:42 AM</Start>
                            <Start>1/11/2017 8:48:42 AM</Start>
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
                        container: "containers06385f89093f4b55bfd4e337e3338a61",
                        containerAcl: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04268 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04268_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04268_s.txt", Encoding.UTF8);

    public Test04268() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        <Id>Single Id</Id>
                        <AccessPolicy>
                            <Expiry>1/11/2017 8:58:42 AM</Expiry>
                            <Expiry>1/11/2017 8:58:42 AM</Expiry>
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
                        container: "containers06385f89093f4b55bfd4e337e3338a61",
                        containerAcl: body,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04270 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04270_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04270_s.txt", Encoding.UTF8);

    public Test04270() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            System.Collections.Generic.IList<SignedIdentifier> body; Assert.True(XmlSerialization.Root(XmlSerialization.CreateListXmlDeserializer(XmlSerialization.ToDeserializer(e => SignedIdentifier.XmlDeserialize(e)), "SignedIdentifier"))(XElement.Parse(@"<?xml version=""1.0"" encoding=""utf-8""?><SignedIdentifiers><SignedIdentifier><Id>OBQCNgbXrseKDsCtzpSwieuoQNcUbodCwrGxkBShhJpfLnLCJXOUoiukHbmAEGwD</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.5625491Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>FJyXlOYpOdcCZLEZJNNxWpIPRdaNlRjZzRDOQxDTVvsyJyevrdEPAOPPAiGHnLDx</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.5625491Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>qIMJubawKGTyfVIMTYkBnNiqvfKrvDFvWmBUsFGmoTpcmJIpulafSHUcaVNORiBG</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.5625491Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>nTORyMUXFEmXUwKdZdPSYtXssUFSjbOhPVHRMOTuAEURaqxlrdbuMavtvVZdGCoe</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.5625491Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>sRLJURTZGRBXUaFzTUoZNVqpqnyQqbVjywyMQlsIbUpEXFmbjfWlSZbWaWSgTDif</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.5625491Z</Expiry><Permission /></AccessPolicy></SignedIdentifier><SignedIdentifier><Id>sjhbgxtglRkBWhKFjQYUcltSLpYlKHFgOzqvoJmciqpFhfwWYZMCBDzHpPQqZHVd</Id><AccessPolicy><Start /><Expiry>2017-01-12T08:48:42.5625491Z</Expiry><Permission /></AccessPolicy></SignedIdentifier></SignedIdentifiers>"), out body));
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
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04271 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04271_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04271_s.txt", Encoding.UTF8);

    public Test04271() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        <Id>Duplicate Id</Id>
                        <AccessPolicy>
                            <Permission>rwd</Permission>
                        </AccessPolicy>
                    </SignedIdentifier>
                    <SignedIdentifier>
                        <Id>Duplicate Id</Id>
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
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04272 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04272_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04272_s.txt", Encoding.UTF8);

    public Test04272() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04273 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04273_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04273_s.txt", Encoding.UTF8);

    public Test04273() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                        <Id>abcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabcabc</Id>

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
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test04274 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04274_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04274_s.txt", Encoding.UTF8);

    public Test04274() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
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
                            <Start>Invalid DateTime</Start>

                            
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
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test17762 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17762_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17762_s.txt", Encoding.UTF8);

    public Test17762() : base(recordedRequest, recordedResponse, "accounts8d43a0239360495")
    { }

    [Fact]
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
                        leaseId: "ec7e57ea-0c76-4c25-8e86-a40cb31ce970",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}

//<dump disabled/>

public class Test17771 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17771_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17771_s.txt", Encoding.UTF8);

    public Test17771() : base(recordedRequest, recordedResponse, "accounts8d43a0239360495")
    { }

    [Fact]
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
                        leaseId: "ec7e57ea-0c76-4c25-8e86-a40cb31ce970",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                Assert.True(false); // expected exception
                
            }
            catch (CloudException)
            {
                

                // validate e.Body or similar?
            }
            catch (ValidationException)
            {
                
            }
            catch (ArgumentException)
            {
                
            }
        }
        catch
        {
            // prioritize! The server exception might have caused the exception on this thread (but get's swallowed by VS and such)
            if (ServerException != null)
                /*expecting failure*/;
            else
                throw;
        }
        finally
        {
            // stop server
            StopServer();
        }
    }
}
