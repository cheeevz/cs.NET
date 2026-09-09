enum LogLevel 
        {
            Trace,
            Debug,
            Info,
            Warning,
            Error,
            Fatal,
            Unknown
        }

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        int start = logLine.IndexOf('[')+1;
        int end = logLine.IndexOf(']');
        string levelCode = logLine.Substring(start,end-start);

        switch (levelCode)
        {
            case "TRC" : 
                return LogLevel.Trace;
            case "DBG" : 
                return LogLevel.Debug;
            case "INF" : 
                return LogLevel.Info;
            case "WRN" : 
                return LogLevel.Warning;
            case "ERR" : 
                return LogLevel.Error;
            case "FTL" : 
                return LogLevel.Fatal;
            default :
                return LogLevel.Unknown;
        }
        
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        switch (logLevel)
        {
            case LogLevel.Trace : 
                return $"1:{message}";
            case LogLevel.Debug : 
                return $"2:{message}";
            case LogLevel.Info : 
                return $"4:{message}";
            case LogLevel.Warning : 
                return $"5:{message}";
            case LogLevel.Error : 
                return $"6:{message}";
            case LogLevel.Fatal : 
                return $"42:{message}";
            default :
                return $"0:{message}";
        }
    }
}
