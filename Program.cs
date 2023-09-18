using System;

class VigenereCipherByKornelyukVadym
{
    static string Encrypt(string text, string key)
    {
        int n = text.Length;
        string result = "";

        for (int i = 0; i < n; i++)
        {
            // 'A' in ASCII is 65, so we subtract to make 'A' as 0
            char encryptedChar = (char)(((text[i] + key[i % key.Length] - 2 * 'A') % 26) + 'A');
            result += encryptedChar;
        }

        return result;
    }

    static void Main()
    {
        string plaintext = "HELLO";
        string key = "KEY";

        string encryptedText = Encrypt(plaintext, key);
        Console.WriteLine("Plaintext: " + plaintext);
        Console.WriteLine("Key: " + key);
        Console.WriteLine("Encrypted text: " + encryptedText);
    }
}
