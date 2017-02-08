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

public class Test00380 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00380_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00380_s.txt", Encoding.UTF8);

    public Test00380() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers37afee7d4d91492090561cc9aca17d2e",
                        blob: "Blob2639ea91ab244be1a7aec80cfc3451be",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test00381 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00381_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00381_s.txt", Encoding.UTF8);

    public Test00381() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers37afee7d4d91492090561cc9aca17d2e",
                        blob: "Blob2639ea91ab244be1a7aec80cfc3451be",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test00379 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00379_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\00379_s.txt", Encoding.UTF8);

    public Test00379() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers37afee7d4d91492090561cc9aca17d2e",
                        blob: "Blob2639ea91ab244be1a7aec80cfc3451be",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test05746 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05746_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\05746_s.txt", Encoding.UTF8);

    public Test05746() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containersb15e137a13604ac992f3594ed826c30a",
                        blob: "Blob1cc2b3a1147149f8837de7b45504acc2",
                        listType: "Uncommitted".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "Uncommitted"),
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

public class Test21734 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21734_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21734_s.txt", Encoding.UTF8);

    public Test21734() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerseea03b67738a44d3bbc03a76323186dd",
                        blob: "Blob1150f68c5a20468b84bd0678de7a7cc4",
                        listType: "Uncommitted".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "Uncommitted"),
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

public class Test21735 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21735_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21735_s.txt", Encoding.UTF8);

    public Test21735() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerseea03b67738a44d3bbc03a76323186dd",
                        blob: "Blob1150f68c5a20468b84bd0678de7a7cc4",
                        listType: "Committed".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "Committed"),
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

public class Test21736 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21736_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21736_s.txt", Encoding.UTF8);

    public Test21736() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerseea03b67738a44d3bbc03a76323186dd",
                        blob: "Blob1150f68c5a20468b84bd0678de7a7cc4",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test23124 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23124_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\23124_s.txt", Encoding.UTF8);

    public Test23124() : base(recordedRequest, recordedResponse, "accounts8d43a0496e14b85")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "accounts8d43a0496e14b85",
                        container: "containers25a10669d74c46e38015fff918143069",
                        blob: "BlockBlob5f53c01987cb4c7e8a789524de1cf94f",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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

public class Test21738 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21738_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21738_s.txt", Encoding.UTF8);

    public Test21738() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containerseea03b67738a44d3bbc03a76323186dd",
                        blob: "Blob1150f68c5a20468b84bd0678de7a7cc4",
                        listType: "Committed".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "Committed"),
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

public class Test21746 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21746_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21746_s.txt", Encoding.UTF8);

    public Test21746() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers1e74122d684744bfa48a6f0080a32bb0",
                        blob: "Blob5e2000c39a8a465e86ff5a7378cfc267",
                        listType: "Uncommitted".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "Uncommitted"),
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

public class Test21747 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21747_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21747_s.txt", Encoding.UTF8);

    public Test21747() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers1e74122d684744bfa48a6f0080a32bb0",
                        blob: "Blob5e2000c39a8a465e86ff5a7378cfc267",
                        listType: "Committed".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "Committed"),
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

public class Test21748 : TestBase
{
    private static readonly string recordedRequest = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21748_c.txt", Encoding.UTF8);
    private static readonly string recordedResponse = File.ReadAllText("E:\\BlobStorageTests\\ALL\\21748_s.txt", Encoding.UTF8);

    public Test21748() : base(recordedRequest, recordedResponse, "testaccount1")
    { }

    [Fact]
    public void Execute()
    {
        // start server
        StartServer();

        try
        {
            // create and use client
            var serviceClient = new AzureStorageClient(this.Credentials);
            serviceClient.BaseUri = new UriBuilder("http", "localhost", Port).Uri.ToString();
            //<bodyParamInit/>
            try
            {
                serviceClient.HttpClient.DefaultRequestHeaders.ExpectContinue = false;
                var cancellationToken = Debugger.IsAttached
                    ? new CancellationToken()
                    : new CancellationTokenSource(3000).Token;
                var result = serviceClient.BlockBlobs.GetBlockListWithHttpMessagesAsync(
                        accountName: "testaccount1",
                        container: "containers1e74122d684744bfa48a6f0080a32bb0",
                        blob: "Blob5e2000c39a8a465e86ff5a7378cfc267",
                        listType: "All".ParseBlockListType() ?? (BlockListType)Enum.Parse(typeof(BlockListType), "All"),
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
