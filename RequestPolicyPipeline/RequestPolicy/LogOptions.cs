using System;

namespace Microsoft.Rest.RequestPolicy
{
    // LogOptions configures the pipeline's logging mechanism & severity filtering.
    public class LogOptions
    {
        private Action<LogSeverity, string> log; 

        public LogOptions(
            Action<LogSeverity, string> log,
            LogSeverity maxSeverity
        )
        {
            this.log = log;
            this.MaxSeverity = maxSeverity;
        }

        public void Log(LogSeverity level, string message) => log(level, message);
        public LogSeverity MaxSeverity { get; private set; }
    }
}