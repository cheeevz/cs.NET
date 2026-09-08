public static class Languages
{
    public static List<string> NewList()
    {
        List<string> listOfString = new List<String>();
        return listOfString;
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> listOfString = NewList();
        listOfString.Add("C#");
        listOfString.Add("Clojure");
        listOfString.Add("Elm");
        return listOfString;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        int length = 0;
        foreach (string language in languages) {
            length++;
        }
        return length;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        foreach (string languageCurrent in languages) {
            if (languageCurrent == language){
                return true;
            }
        }
        return false;
    }

    public static List<string> ReverseList(List<string> languages)
    {   
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (CountLanguages(languages) == 0){
            return false;
        }
        else if (languages[0] == "C#"){
            return true;
        }
        else if (languages[1] == "C#" && CountLanguages(languages) == 2 ||CountLanguages(languages) == 3){
            return true;
        }
        else {
            return false;
        }
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        languages.Sort();
        for (int i= 0; i < CountLanguages(languages)-1; i++){
            int j = i++;
            if (languages[i] == languages[j]){
                return false;
            }
        }
        return true;
    }
}
