using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var cipher = new StringBuilder();
        const int codePointUpper = 64;
        const int codePointLower = 96;
        
        foreach (var letter in text)
        {
            var letterPosition = char.IsUpper(letter) ? (letter - codePointUpper) : (letter - codePointLower);

            if (letterPosition > 26 || letterPosition < 0)
            {
                cipher.Append(letter);
                continue;
            }
            
            var rotKey = letterPosition + shiftKey;
            var newPosition = rotKey > 26 ? rotKey % 26 : rotKey;
            var newChar = char.IsUpper(letter) ? (char)(newPosition + codePointUpper) : (char)(newPosition + codePointLower);

            cipher.Append(newChar);
        }

        return cipher.ToString();
    }
}

