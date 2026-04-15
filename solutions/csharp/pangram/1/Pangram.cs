public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var alphabet = Enumerable.Range('a', 26).Select(c => (char)c).ToArray();

        input = input.ToLower();

        foreach (var a in alphabet)
        {
            bool pangram = input.Contains(a);
            if (!pangram)
            {
                return false;
            }
        }
        
        return true;
    }
}
