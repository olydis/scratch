using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Microsoft.Rest.ClientRuntime.RequestPolicy
{
    // A PolicyNode represents a node in a linked-list of Policy objects. A PolicyNode is passed
    // to the Factory's New method which passes to the Policy object it creates. The Policy object
    // uses the PolicyNode to forward the Context and HTTP request to the next Policy object in the pipeline.
    public class PolicyNode
    {
        public Pipeline Pipeline { get; private set; }
        public IPolicy Next { get; set; }
   
        public PolicyNode(Pipeline pipeline, IPolicy next)
        {
            this.Pipeline = pipeline;
            this.Next = next;
        }

        // SendAsync forwards the Context and HTTP request to the next Policy object in the pipeline. The last Policy object
        // sends the request over the network via HTTPSender's SendAsync method. The response and error are returned
        // back up the pipeline through the Policy objects.
        public Task<HttpResponseMessage> SendAsync(Context ctx, HttpRequestMessage request)
        {
            return this.Next.SendAsync(ctx, request);
        }

        // Log logs a string to the Pipeline's Logger.
        public void Log(LogSeverity severity, string format, params object[] v)
        {
            if (severity > Pipeline.Options.Log.MaxSeverity) {
                return; // Short circuit message formatting if we're not logging it
            }
            string msg = string.Format(format, v);
            if (!msg.EndsWith("\n"))
            {
                msg += "\n";
            }
            // defaultLog(severity, msg) // TODO: WAT?
            Pipeline.Options.Log.Log(severity, msg);
            // If logger doesn't handle fatal/panic, we'll do it here.
            if (severity == LogSeverity.Fatal)
            {
                Environment.Exit(1); // TODO: really?
            } 
            else if (severity == LogSeverity.Panic)
            {
                // panic(msg); // WAT
            }
        }
    }
}
