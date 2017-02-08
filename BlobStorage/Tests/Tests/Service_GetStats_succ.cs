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

public class Test00030 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00030_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00030_s.txt", Encoding.UTF8);

    public Test00030() : base(recordedRequest, recordedResponse, "accounts8d439fde9e0d905-secondary")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetStatsWithHttpMessagesAsync(
                        accountName: "accounts8d439fde9e0d905-secondary",
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

public class Test00092 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00092_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00092_s.txt", Encoding.UTF8);

    public Test00092() : base(recordedRequest, recordedResponse, "accounts8d439fdebd866da-secondary")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetStatsWithHttpMessagesAsync(
                        accountName: "accounts8d439fdebd866da-secondary",
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

public class Test00093 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00093_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00093_s.txt", Encoding.UTF8);

    public Test00093() : base(recordedRequest, recordedResponse, "accounts8d439fdebd866da-secondary")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetStatsWithHttpMessagesAsync(
                        accountName: "accounts8d439fdebd866da-secondary",
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

public class Test00094 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00094_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00094_s.txt", Encoding.UTF8);

    public Test00094() : base(recordedRequest, recordedResponse, "accounts8d439fdebd866da-secondary")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetStatsWithHttpMessagesAsync(
                        accountName: "accounts8d439fdebd866da-secondary",
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

public class Test06763 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06763_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06763_s.txt", Encoding.UTF8);

    public Test06763() : base(recordedRequest, recordedResponse, "accounts8d439ff560c84db-secondary")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetStatsWithHttpMessagesAsync(
                        accountName: "accounts8d439ff560c84db-secondary",
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

public class Test06764 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06764_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06764_s.txt", Encoding.UTF8);

    public Test06764() : base(recordedRequest, recordedResponse, "accounts8d439ff67f9b9ef-secondary")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetStatsWithHttpMessagesAsync(
                        accountName: "accounts8d439ff67f9b9ef-secondary",
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

public class Test06760 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06760_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\06760_s.txt", Encoding.UTF8);

    public Test06760() : base(recordedRequest, recordedResponse, "accounts8d439ff55f8d5a0-secondary")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetStatsWithHttpMessagesAsync(
                        accountName: "accounts8d439ff55f8d5a0-secondary",
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

public class Test23125 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23125_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23125_s.txt", Encoding.UTF8);

    public Test23125() : base(recordedRequest, recordedResponse, "accounts8d43a0496e14b85-secondary")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.Service.GetStatsWithHttpMessagesAsync(
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
