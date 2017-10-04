namespace Microsoft.Rest.RequestPolicy
{
    // Options configures a Pipeline's behavior.
    public class PipelineOptions
    {
        public PipelineOptions(
            IFactory httpSender,
            LogOptions log
        )
        {
            this.HttpSender = httpSender;
            this.Log = log;
        }

        public IFactory HttpSender { get; private set; }
        public LogOptions Log { get; private set; }
    }
}