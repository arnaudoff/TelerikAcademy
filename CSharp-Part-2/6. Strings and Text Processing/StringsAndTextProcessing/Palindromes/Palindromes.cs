// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

class Palindromes
{
    static void Main()
    {
        string text = "Hello. This is an example that contains palindromes.exe and I like listening to ABBA, but have no idea what lamal is.";

        StringBuilder outputStr = new StringBuilder();
        foreach (var match in Regex.Matches(text, @"\w+"))
        {
            string word = match.ToString(); 
            if (word.SequenceEqual(word.Reverse())) // && word.Length > 1 in the condition if one-letter words are not considered palindromes.
            {
                outputStr.AppendLine(match.ToString());
            }
        }
        Console.WriteLine("List of palindromes: ");
        Console.Write(outputStr);
    }
}
