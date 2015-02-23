/*
 * We are given a string containing a list of forbidden words and a text containing some of these words.
 * Write a program that replaces the forbidden words with asterisks.
 */

using System;
using System.Text;
using System.Linq;

class ForbiddenWords
{
    static void Main()
    {
        string forbiddenWords = "PHP, CLR, Microsoft";
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string[] forbiddenWordsList = forbiddenWords.Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in forbiddenWordsList)
        {
            text = text.Replace(word, new string('*', word.Length));
        }
        Console.WriteLine(text);
    }
}