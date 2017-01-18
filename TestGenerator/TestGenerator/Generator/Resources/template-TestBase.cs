using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
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
                    listener.BeginAcceptTcpClient(iar => Serve(listener.EndAcceptTcpClient(iar)), null);
                    break;
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"Server ({this.GetType().Name}): Port {Port} was in use. ({e.Message})");
                }
            }
            Debug.WriteLine($"Server ({this.GetType().Name}): Listening at {listener.LocalEndpoint}.");
        }

        private void Serve(TcpClient server)
        {
            Debug.WriteLine($"Server ({this.GetType().Name}): Incoming request.");
            var networkStream = server.GetStream();

            // read request
            var requestBuffer = new char[1 << 16];
            var reader = new StreamReader(networkStream, Encoding.UTF8);
            var read = reader.Read(requestBuffer, 0, requestBuffer.Length);
            var request = new string(requestBuffer, 0, read);

            // TODO: VALIDATION

            // write response
            var writer = new StreamWriter(networkStream, Encoding.UTF8);
            writer.Write(RawResponse);
            writer.Close();
        }
    }
}
