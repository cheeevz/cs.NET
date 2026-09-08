static class LogLine
{
    public static string Message(string logLine) => logLine.Split(": ", 2)[1].Trim();

    public static string LogLevel(string logLine) => logLine.Split(": ", 2)[0].Trim(new Char[] { ' ', '[', ']' }).ToLower();

    public static string Reformat(string logLine)
    {
        string premierePartie = Message(logLine);
        string deuxiemePartie = LogLevel(logLine);

        return premierePartie + " (" + deuxiemePartie + ")";
    }
}
