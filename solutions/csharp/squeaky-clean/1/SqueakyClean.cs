public static class Identifier
{
    public static string Clean(string identifier)
    {
        string cleaned = "";
        bool cap = false;

        foreach (char c in identifier)
        {
            if (c == '-')
            {
                cap = true;
                continue; // on ignore le tiret, on ne l'ajoute pas à cleaned
            }

            char current = c;

            if (cap)
            {
                current = char.ToUpper(current);
                cap = false;
            }

            if (current == ' ')
            {
                cleaned += '_';
            }
            else if (char.IsControl(current))
            {
                cleaned += "CTRL";
            }
            else if (current >= 'α' && current <= 'ω')
            {
                continue;
            }
            else if (char.IsLetter(current))
            {
                cleaned += current;
            }
        }

        return cleaned;
    }
}