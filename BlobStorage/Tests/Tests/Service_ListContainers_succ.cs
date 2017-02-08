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

public class Test000042 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000042_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000042_s.txt", Encoding.UTF8);

    public Test000042() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test000043 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000043_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000043_s.txt", Encoding.UTF8);

    public Test000043() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test000047 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000047_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000047_s.txt", Encoding.UTF8);

    public Test000047() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test000048 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000048_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000048_s.txt", Encoding.UTF8);

    public Test000048() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test000052 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000052_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000052_s.txt", Encoding.UTF8);

    public Test000052() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test000053 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000053_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000053_s.txt", Encoding.UTF8);

    public Test000053() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "testca8a0bcae1bb540f4b21c69fc28a75f79",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test000125 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000125_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000125_s.txt", Encoding.UTF8);

    public Test000125() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "c93c691e44c3467a91fc53c39c6de643",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test000210 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000210_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000210_s.txt", Encoding.UTF8);

    public Test000210() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "f5c9fc9d0efd4e0aa9cb6bc9fe3332b4",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test000499 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000499_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000499_s.txt", Encoding.UTF8);

    public Test000499() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "aba69e68335d4b92be74e78a868bbf76",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test000301 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000301_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000301_s.txt", Encoding.UTF8);

    public Test000301() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "6cda9e166fc244c1a7489c5703b39b9b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test00060 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00060_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00060_s.txt", Encoding.UTF8);

    public Test00060() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        include: "metadata",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test00058 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00058_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00058_s.txt", Encoding.UTF8);

    public Test00058() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        include: "metadata",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test00059 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00059_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00059_s.txt", Encoding.UTF8);

    public Test00059() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        include: "metadata",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test000667 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000667_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000667_s.txt", Encoding.UTF8);

    public Test000667() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "b94b53950bd1424286b9b0d9b95cfe70",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test000818 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000818_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000818_s.txt", Encoding.UTF8);

    public Test000818() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "xclientdev3",
                        prefix: "224d402e649e4f859da9dda7ba35ba2b",
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test04307 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04307_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04307_s.txt", Encoding.UTF8);

    public Test04307() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        prefix: "containers94b785c60842411c88f14c5b8f52175a",
                        include: "metadata",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test04314 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04314_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04314_s.txt", Encoding.UTF8);

    public Test04314() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        prefix: "containerse395d85621764902813537af8934b9a5",
                        include: "metadata",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test04299 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04299_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04299_s.txt", Encoding.UTF8);

    public Test04299() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        prefix: "containers94b785c60842411c88f14c5b8f52175a",
                        include: "metadata",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test05775 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05775_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05775_s.txt", Encoding.UTF8);

    public Test05775() : base(recordedRequest, recordedResponse, "accounts8d439ff2165249e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d439ff2165249e",
                        prefix: "containers3022d866d3f04b6d852e8b5e70ea8607",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test04303 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04303_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\04303_s.txt", Encoding.UTF8);

    public Test04303() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        prefix: "containers94b785c60842411c88f14c5b8f52175a",
                        include: "metadata",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test18051 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18051_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18051_s.txt", Encoding.UTF8);

    public Test18051() : base(recordedRequest, recordedResponse, "accounts8d43a023f4b5f7a")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d43a023f4b5f7a",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test19715 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19715_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19715_s.txt", Encoding.UTF8);

    public Test19715() : base(recordedRequest, recordedResponse, "accounts8d43a024c06bd90")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d43a024c06bd90",
                        maxresults: 2147483647,
                        include: "metadata",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test18066 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18066_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18066_s.txt", Encoding.UTF8);

    public Test18066() : base(recordedRequest, recordedResponse, "accounts8d43a023f6c7c4e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d43a023f6c7c4e",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test18001 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18001_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18001_s.txt", Encoding.UTF8);

    public Test18001() : base(recordedRequest, recordedResponse, "accounts8d43a023f00e87c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d43a023f00e87c",
                        maxresults: 5001,
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test19722 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19722_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19722_s.txt", Encoding.UTF8);

    public Test19722() : base(recordedRequest, recordedResponse, "accounts8d43a024c14c75c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d43a024c14c75c",
                        prefix: "containersabb55f67727e4a55ae05c279fc44c6b7",
                        include: "metadata",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test18016 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18016_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18016_s.txt", Encoding.UTF8);

    public Test18016() : base(recordedRequest, recordedResponse, "accounts8d43a023f1e34b8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d43a023f1e34b8",
                        prefix: Encoding.UTF8.GetString(new byte[]{97,230,188,162,229,173,151,230,177,137,229,173,151,233,184,161}),
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test18018 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18018_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18018_s.txt", Encoding.UTF8);

    public Test18018() : base(recordedRequest, recordedResponse, "accounts8d43a023f1e34b8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d43a023f1e34b8",
                        prefix: Encoding.UTF8.GetString(new byte[]{97,98,99,239,191,189,195,156,86,48,52}),
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test18019 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18019_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18019_s.txt", Encoding.UTF8);

    public Test18019() : base(recordedRequest, recordedResponse, "accounts8d43a023f1e34b8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d43a023f1e34b8",
                        prefix: Encoding.UTF8.GetString(new byte[]{239,191,189,195,156,86,48,52}),
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test18020 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18020_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18020_s.txt", Encoding.UTF8);

    public Test18020() : base(recordedRequest, recordedResponse, "accounts8d43a023f1e34b8")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d43a023f1e34b8",
                        prefix: Encoding.UTF8.GetString(new byte[]{9,10,13,32,237,159,191,238,128,128,239,191,189}),
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test18036 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18036_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\18036_s.txt", Encoding.UTF8);

    public Test18036() : base(recordedRequest, recordedResponse, "accounts8d43a023f2adf0e")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d43a023f2adf0e",
                        include: "metadata",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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

public class Test19598 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19598_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\19598_s.txt", Encoding.UTF8);

    public Test19598() : base(recordedRequest, recordedResponse, "accounts8d43a024b9a186c")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.ListContainersWithHttpMessagesAsync(
                        accountName: "accounts8d43a024b9a186c",
                        maxresults: 2147483647,
                        include: "metadata",
                        timeout: 30,
                        cancellationToken: cancellationToken).GetAwaiter().GetResult();
                
                                // body validation
                var xmlBodyExpected = XElement.Parse(RawResponseBody);
                var xmlBodyActual = new XElement(xmlBodyExpected.Name);
                result.Body.XmlSerialize(xmlBodyActual);
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
