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

public class Test000041 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000041_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000041_s.txt", Encoding.UTF8);

    public Test000041() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test000046 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000046_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000046_s.txt", Encoding.UTF8);

    public Test000046() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test000051 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000051_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000051_s.txt", Encoding.UTF8);

    public Test000051() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test001215 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001215_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001215_s.txt", Encoding.UTF8);

    public Test001215() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcca1a42d2bc5f495a80ad0e6921a2e9eb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test001213 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001213_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001213_s.txt", Encoding.UTF8);

    public Test001213() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        container: "testcca1a42d2bc5f495a80ad0e6921a2e9eb",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04260 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04260_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04260_s.txt", Encoding.UTF8);

    public Test04260() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers2a77c4a1c1bc4c048d19a5e77dd8ecfe",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04247 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04247_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04247_s.txt", Encoding.UTF8);

    public Test04247() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers901744097bb448a9a8a1ee977f858d0c",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04311 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04311_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04311_s.txt", Encoding.UTF8);

    public Test04311() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerse395d85621764902813537af8934b9a5",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04292 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04292_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04292_s.txt", Encoding.UTF8);

    public Test04292() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04263 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04263_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04263_s.txt", Encoding.UTF8);

    public Test04263() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersbd7c80eb7bcf4c59b4db4d6f065d70df",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04312 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04312_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04312_s.txt", Encoding.UTF8);

    public Test04312() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerse395d85621764902813537af8934b9a5",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04249 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04249_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04249_s.txt", Encoding.UTF8);

    public Test04249() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers901744097bb448a9a8a1ee977f858d0c",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04295 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04295_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04295_s.txt", Encoding.UTF8);

    public Test04295() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04282 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04282_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04282_s.txt", Encoding.UTF8);

    public Test04282() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04298 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04298_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04298_s.txt", Encoding.UTF8);

    public Test04298() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers94b785c60842411c88f14c5b8f52175a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04236 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04236_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04236_s.txt", Encoding.UTF8);

    public Test04236() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers7825f8d4373340ff913d38c69b27855f",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04252 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04252_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04252_s.txt", Encoding.UTF8);

    public Test04252() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9a0ae8e575f1446a9822db71e4673982",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04285 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04285_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04285_s.txt", Encoding.UTF8);

    public Test04285() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04255 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04255_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04255_s.txt", Encoding.UTF8);

    public Test04255() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers086c269886414ad19687e514ed6e1fd6",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04302 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04302_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04302_s.txt", Encoding.UTF8);

    public Test04302() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers94b785c60842411c88f14c5b8f52175a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04239 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04239_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04239_s.txt", Encoding.UTF8);

    public Test04239() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers11e78f8136af42e3946316ceaaf80353",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04257 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04257_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04257_s.txt", Encoding.UTF8);

    public Test04257() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers086c269886414ad19687e514ed6e1fd6",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04306 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04306_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04306_s.txt", Encoding.UTF8);

    public Test04306() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers94b785c60842411c88f14c5b8f52175a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04289 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04289_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04289_s.txt", Encoding.UTF8);

    public Test04289() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers6f58b97c5b9a48c5af221608ff54ab20",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test04242 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04242_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04242_s.txt", Encoding.UTF8);

    public Test04242() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers9ce1d2ccc6a3486aa88b6107c8b6f1a4",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test17765 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17765_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17765_s.txt", Encoding.UTF8);

    public Test17765() : base(recordedRequest, recordedResponse, "accounts8d43a0239360495")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a0239360495",
                        container: "containers53cc09707a3c4988bc049522b7310679",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test23132 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23132_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23132_s.txt", Encoding.UTF8);

    public Test23132() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersc11941826276434facd809ee7e04fce8",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test17773 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17773_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\17773_s.txt", Encoding.UTF8);

    public Test17773() : base(recordedRequest, recordedResponse, "accounts8d43a0239360495")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "accounts8d43a0239360495",
                        container: "containers53cc09707a3c4988bc049522b7310679",
                        timeout: 30,
                        leaseId: "83c00cac-555e-4ce2-94b6-9cf43c42fecc",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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

public class Test23117 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23117_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23117_s.txt", Encoding.UTF8);

    public Test23117() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Container.GetAclWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers28ab964f2ab04d08994828b9dbb10750",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name, result.Body.Select(x => x.XmlSerialize(new XElement("SignedIdentifier"))));
                // Assert.Equal(xmlBodyExpected, xmlBodyActual);

                if (Debugger.IsAttached)
                {
                    var fileA = Path.GetTempFileName();
                    var fileB = Path.GetTempFileName();
                    File.WriteAllText(fileA, xmlBodyExpected.ToString());
                    File.WriteAllText(fileB, xmlBodyActual.ToString());
                    var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                    p.WaitForExit();
                    try
                    {
                        File.Delete(fileA);
                        File.Delete(fileB);
                    }
                    catch { }
                }

                FuzzyMatch(xmlBodyExpected, xmlBodyActual);

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
