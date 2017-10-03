using System;

namespace Microsoft.Rest.ClientRuntime.RequestPolicy
{
    // LogSeverity tells a logger the minimum severity to log. When code reports a log entry,
    // the LogSeverity indicates the severity of the log entry. The logger only records entries
    // whose severity is at as as severe as what it was told to log. See the Log* constants.
    // For example, if a logger is configured with LogError severity, then LogError, LogPanic,
    // and Fatal entries will be logged; less severe entries will be ignored.
    public enum LogSeverity
    { 
        // tells a logger not to log any entries passed to it.
        None,

        // tells a logger to log all Fatal entries passed to it.
        Fatal,

        // tells a logger to log all Panic and Fatal entries passed to it.
        Panic,

        // tells a logger to log all Error, Panic and Fatal entries passed to it.
        Error,

        // tells a logger to log all Warning, Error, Panic and Fatal entries passed to it.
        Warning,

        // tells a logger to log all Info, Warning, Error, Panic and Fatal entries passed to it.
        Info
    }
}