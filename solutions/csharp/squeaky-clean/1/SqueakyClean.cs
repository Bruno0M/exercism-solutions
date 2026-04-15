using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();

        for (var i = 0; i <= identifier.Length - 1; i++)
        {
            if (char.IsWhiteSpace(identifier[i]))
            {
                sb.Append('_');
                continue;
            }

            if (char.IsControl(identifier[i]))
            {
                sb.Append("CTRL");
                continue;
            }

            if (identifier[i] == '-')
            {
                int iLength = i + 1;
                if (iLength > identifier.Length - 1 || !char.IsLetter(identifier[iLength])) continue;

                i++;
                sb.Append(char.ToUpper(identifier[i]));
                continue;
            }

            if (!char.IsLetter(identifier[i])) continue;

            if (IsGreekLetter(identifier[i])) continue;

            sb.Append(identifier[i]);
        }
        ;

        identifier = sb.ToString();

        return identifier;
    }

    private static bool IsGreekLetter(char c)
    {
        return (c >= '\u03B1' && c <= '\u03C9');
    }
}
