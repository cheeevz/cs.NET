public static class LogAnalysis
{
    // 1. Extraire après un délimiteur
    public static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter);
        return str.Substring(index + delimiter.Length);
    }

    // 2. Extraire entre deux délimiteurs
    public static string SubstringBetween(this string str, string start, string end)
    {
        int indexStart = str.IndexOf(start);
        int indexEnd = str.IndexOf(end, indexStart + start.Length);
        return str.Substring(indexStart + start.Length, indexEnd - indexStart - start.Length);
    }

    // 3. Message — utilise SubstringAfter
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    // 4. LogLevel — utilise SubstringBetween
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}