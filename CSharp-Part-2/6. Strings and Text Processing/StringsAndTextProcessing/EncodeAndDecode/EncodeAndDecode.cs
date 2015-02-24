/*
 * Write a program that encodes and decodes a string using given encryption key (cipher).
 * The key consists of a sequence of characters.
 * The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. 
 * When the last key character is reached, the next is the first.
 */

using System;
using System.Linq;
using System.Text;

class EncodeAndDecode
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string inputText = Console.ReadLine();

        Console.Write("Enter key (cipher): ");
        string inputKey = Console.ReadLine();

        string encodedStr = Encode_Decode(inputText, inputKey);
        Console.WriteLine("Encoded string: ");
        Console.WriteLine(encodedStr);

        string decodedStr = Encode_Decode(encodedStr, inputKey);
        Console.WriteLine("Decoded string: ");
        Console.WriteLine(decodedStr);
    }

    // This method takes advantage of the "XOR cipher" so it can encode as well as decode a given string.
    static string Encode_Decode(string text, string key)
    {
        // Fixes the key length
        StringBuilder fixedKey = new StringBuilder();
        fixedKey.Append(key);
        if (key.Length < text.Length)
        {
            fixedKey.Append(String.Concat(Enumerable.Repeat(key, (text.Length / key.Length) - 1)));
            for (int i = 0; i < text.Length % key.Length; i++)
            {
                fixedKey.Append(key[i]);
            }
        }
        StringBuilder resultantStr = new StringBuilder();
        int inputLetter;
        int keyLetter;
        for (int i = 0; i < text.Length; i++ )
        {
            inputLetter = (int)text[i];
            keyLetter = (int)fixedKey[i];
            resultantStr.Append((char)(fixedKey[i] ^ text[i]));
        }
        return resultantStr.ToString();
    }
}