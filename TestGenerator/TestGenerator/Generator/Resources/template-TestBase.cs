using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Rest;
using Xunit;

namespace /*<*/Dummy/*></clientNamespace>*/.Tests
{
    public class TestBase
    {
        static int nextPort = 8000;

        private static string GetHttpBody(string message)
        {
            var httpNewLine = "\r\n";
            var divideIndex = new string(message.Select(c => (char)(c % 256)).ToArray()).IndexOf(httpNewLine + httpNewLine, StringComparison.Ordinal);
            var body = message.Substring(divideIndex + 4).Trim('\x00EF', '\x00BB', '\x00BF', '\uFEFF', '\u200B');

            // parse chunked body
            if (message.Contains("Transfer-Encoding: chunked"))
            {
                var enc = Encoding.GetEncoding(1252);
                Func<string, string> toByteStr = str => enc.GetString(Encoding.UTF8.GetBytes(str));
                Func<string, string> fromByteStr = str => Encoding.UTF8.GetString(enc.GetBytes(str));

                var bodyReader = new StringReader(toByteStr(body));
                body = "";
                int len;
                while ((len = Convert.ToInt32(bodyReader.ReadLine(), 16)) > 0)
                {
                    var buffer = new char[len];
                    if (bodyReader.ReadBlock(buffer, 0, len) != len)
                        throw new InvalidDataException();
                    body += fromByteStr(new string(buffer));

                    if (body != body.Trim('\x00EF', '\x00BB', '\x00BF', '\uFEFF', '\u200B'))
                    {
                        body = body.Trim('\x00EF', '\x00BB', '\x00BF', '\uFEFF', '\u200B');
                        bodyReader.Read();
                        bodyReader.Read();// apparently not accounted for in chunk length...
                    }
                }
            }

            return body;
        }

        public TestBase(string rawRequest, string rawResponse, string accountName)
        {
            this.RawRequest = rawRequest;
            this.RawResponse = rawResponse;
            this.AccountName = accountName;
        }

        public ServiceClientCredentials Credentials => new TokenCredentials("TOKEN", Guid.NewGuid().ToString());

        protected string RawRequest { get; }
        protected string RawResponse { get; }
        protected string AccountName { get; }

        protected string RawRequestBody => GetHttpBody(RawRequest);

        protected string RawResponseBody => GetHttpBody(RawResponse);

        protected int Port { get; private set; }
                
        private TcpListener listener;

        protected void StopServer()
        {
            listener.Stop();
        }

        protected Exception ServerException { get; private set; } = null;

        protected void StartServer()
        {
            IPAddress ipAddress = Dns.GetHostAddresses("localhost")[0];
            while (true)
            {
                try
                {
                    Port = Interlocked.Increment(ref nextPort);
                    listener = new TcpListener(ipAddress, Port);
                    listener.Start();
                    listener.BeginAcceptTcpClient(iar =>
                    {
                        try
                        {
                            Serve(listener.EndAcceptTcpClient(iar));
                            // shut off retries
                            listener.BeginAcceptTcpClient(iar2 =>
                            {
                                try
                                {
                                    var server = listener.EndAcceptTcpClient(iar2);
                                    var networkStream = server.GetStream();
                                    ReadHttpRequest(networkStream);
                                    var writer = new StreamWriter(networkStream, new UTF8Encoding(false));
                                    writer.WriteLine("HTTP/1.1 400 Mute");
                                    writer.WriteLine("Connection: close");
                                    writer.WriteLine();
                                    writer.Close();
                                }
                                catch (ObjectDisposedException) { /* might have been disposed */ }
                            }, null);
                        }
                        catch (ObjectDisposedException) { /* might have been disposed */ }
                        catch (Exception e) { ServerException = e; }
                    }, null);
                    break;
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Server ({this.GetType().Name}): Port {Port} was in use. ({e.Message})");
                }
            }
            Debug.WriteLine($"Server ({this.GetType().Name}): Listening at {listener.LocalEndpoint}.");
        }

        private string ReadHttpRequest(NetworkStream stream)
        {
            Thread.Sleep(800); // laziness
            var requestBuffer = new char[1 << 16];
            var reader = new StreamReader(stream, Encoding.UTF8);
            var read = reader.Read(requestBuffer, 0, requestBuffer.Length);
            return new string(requestBuffer, 0, read);
        }

        private void Serve(TcpClient server)
        {
            Debug.WriteLine($"Server ({this.GetType().Name}): Incoming request.");
            var networkStream = server.GetStream();

            // read request
            var request = ReadHttpRequest(networkStream);
            var requestReader = new StringReader(request);
            while (requestReader.ReadLine() != "") ;
            var actualRequestBody = requestReader.ReadToEnd().Trim('\x00EF', '\x00BB', '\x00BF', '\uFEFF', '\u200B');

            // compare
            if (Debugger.IsAttached)
            {
                var fileA = Path.GetTempFileName();
                var fileB = Path.GetTempFileName();
                File.WriteAllText(fileA, RawRequest);
                File.WriteAllText(fileB, request);
                var p = Process.Start("code", $"-w -d \"{fileA}\" \"{fileB}\"");
                p.WaitForExit();
                try
                {
                    File.Delete(fileA);
                    File.Delete(fileB);
                }
                catch { }
            }
            XElement xml1 = null, xml2 = null;
            try { xml1 = XElement.Parse(RawRequestBody); } catch { }
            try { xml2 = XElement.Parse(actualRequestBody); } catch { }
            FuzzyMatch(xml1, xml2);

            // write response
            var writer = new StreamWriter(networkStream, new UTF8Encoding(false));
            writer.Write(Regex.Replace(RawResponse, "Content-Length: .*?\r\n", ""));
            writer.Close();
        }

        protected void FuzzyMatch(XElement xml1, XElement xml2)
        {
            // SPECIAL DOOHICKEY
            Func<XElement, bool> doohickeyFilter = e =>
                (xml1.Name.LocalName != "BlockList" || e.Name.LocalName == "Latest") && // `BlockList` only supported with `Latest` stuff
                (xml1.Name.LocalName != "Blobs" || e.Name.LocalName != "BlobPrefix"); // `BlobPrefix` not supported in `BlobEnumerationResults`

            Assert.Equal(xml1 == null, xml2 == null);
            if (xml1 == null)
                return;

            Assert.Equal(xml1.Name.LocalName, xml2.Name.LocalName);

            if (!xml1.HasElements && !xml2.HasElements)
                Assert.Equal(xml1.Value, xml2.Value);

            var attr1 = xml1.Attributes().Select(a => $"{a.Name}: {a.Value}").OrderBy(x => x);
            var attr2 = xml2.Attributes().Select(a => $"{a.Name}: {a.Value}").OrderBy(x => x);
            Assert.Equal(attr1, attr2);

            var children1 = xml1.Elements().Where(doohickeyFilter).OrderBy(x => x.Name.LocalName).Where(x => x.HasAttributes || x.HasElements || !string.IsNullOrEmpty(x.Value) || xml2.Element(x.Name) != null).ToArray();
            var children2 = xml2.Elements().Where(doohickeyFilter).OrderBy(x => x.Name.LocalName).Where(x => x.HasAttributes || x.HasElements || !string.IsNullOrEmpty(x.Value) || xml1.Element(x.Name) != null).ToArray();
            Assert.Equal(children1.Length, children2.Length);
            for (int i = 0; i < children1.Length; ++i)
                FuzzyMatch(children1[i], children2[i]);
        }
    }
}
