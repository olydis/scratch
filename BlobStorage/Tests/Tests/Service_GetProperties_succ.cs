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

public class Test000571 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000571_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000571_s.txt", Encoding.UTF8);

    public Test000571() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test000575 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000575_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000575_s.txt", Encoding.UTF8);

    public Test000575() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test000569 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000569_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000569_s.txt", Encoding.UTF8);

    public Test000569() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test000682 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000682_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000682_s.txt", Encoding.UTF8);

    public Test000682() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test000563 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000563_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000563_s.txt", Encoding.UTF8);

    public Test000563() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test000573 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000573_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000573_s.txt", Encoding.UTF8);

    public Test000573() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test000567 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000567_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000567_s.txt", Encoding.UTF8);

    public Test000567() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test000731 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000731_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000731_s.txt", Encoding.UTF8);

    public Test000731() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test00081 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00081_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00081_s.txt", Encoding.UTF8);

    public Test00081() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
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

public class Test00083 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00083_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00083_s.txt", Encoding.UTF8);

    public Test00083() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
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

public class Test000565 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000565_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000565_s.txt", Encoding.UTF8);

    public Test000565() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test000561 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000561_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\000561_s.txt", Encoding.UTF8);

    public Test000561() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test00082 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00082_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00082_s.txt", Encoding.UTF8);

    public Test00082() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "testaccount1",
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

public class Test001489 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001489_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001489_s.txt", Encoding.UTF8);

    public Test001489() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test001487 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001487_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\001487_s.txt", Encoding.UTF8);

    public Test001487() : base(recordedRequest, recordedResponse, "xclientdev3")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "xclientdev3",
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

public class Test23126 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23126_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23126_s.txt", Encoding.UTF8);

    public Test23126() : base(recordedRequest, recordedResponse, "accounts8d43a0496e14b85-secondary")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetPropertiesWithHttpMessagesAsync(
                        accountName: "accounts8d43a0496e14b85-secondary",
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
