static class LogLine
{
    public static string Message(string logLine)
    {
        var logLevelStart = logLine.IndexOf(' ') + 1;

        return logLine
            .Substring(logLevelStart)
            .Replace("\t", "")
            .Replace("\r", "")
            .Replace("\n", "")
            .Trim();
    }

    public static string LogLevel(string logLine)
    {
        var logLevelStart = logLine.IndexOf('[') + 1;
        var logLevelEnd = logLine.IndexOf(']');

        return logLine.Substring(logLevelStart, logLevelEnd - logLevelStart).ToLower();
    }

    public static string Reformat(string logLine)
    {
        string logLevel = LogLevel(logLine);
        string message = Message(logLine);
        string newMessage = $"{message} ({logLevel})";

        return newMessage;
    }
}
