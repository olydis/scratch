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

namespace /*<*/Dummy/*></clientNamespace>*/.Tests
{
    public class TestBase
    {
        static int nextPort = 8000;

        public TestBase(string rawRequest, string rawResponse)
        {
            this.RawRequest = rawRequest;
            this.RawResponse = rawResponse;
        }

        protected string RawRequest { get; }
        protected string RawResponse { get; }

        protected int Port { get; private set; }
                
        private TcpListener listener;

        protected void StopServer()
        {
            listener.Stop();
        }

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
                        Serve(listener.EndAcceptTcpClient(iar));
                        // shut off retries
                        listener.BeginAcceptTcpClient(iar2 =>
                        {
                            var server = listener.EndAcceptTcpClient(iar2);
                            var networkStream = server.GetStream();
                            ReadHttpRequest(networkStream);
                            var writer = new StreamWriter(networkStream, new UTF8Encoding(false));
                            writer.WriteLine("HTTP/1.1 400 Mute");
                            writer.WriteLine("Connection: close");
                            writer.WriteLine();
                            writer.Close();
                        }, null);
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

            // TODO: VALIDATION

            // write response
            var writer = new StreamWriter(networkStream, new UTF8Encoding(false));
            writer.Write(Regex.Replace(RawResponse, "Content-Length: .*?\r\n", ""));
            writer.Close();
        }
    }
}
