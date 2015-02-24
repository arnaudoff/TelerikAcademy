/*
 * Write a program that encodes and decodes a string using given encryption key (cipher).
 * The key consists of a sequence of characters.
 * The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. 
 * When the last key character is reached, the next is the first.
 */

using System;
using System.Text;

class EncodeAndDecode
{
    static void Main()
    {
        string res = Encode("test", "gosho");
        Console.WriteLine(res);
        Console.WriteLine(Decode(res, "gosho"));
    }

    static string Encode(string text, string key)
    {
        StringBuilder outputStr = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            outputStr.Append(text[i] ^ key[i]);
        }
        return outputStr.ToString();
    }

    static string Decode(string text, string key)
    {
        StringBuilder outputStr = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            outputStr.Append(text[i] ^ key[i]);
        }
        return outputStr.ToString();
    }
}