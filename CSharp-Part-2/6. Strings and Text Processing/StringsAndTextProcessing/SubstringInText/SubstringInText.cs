// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;
using System.Text.RegularExpressions;

class SubstringInText
{
    static void Main()
    {
        Console.WriteLine("Enter input text: ");
        string inputText = Console.ReadLine();
        Console.WriteLine("Enter target sub-string: ");
        string targetString = Console.ReadLine(); 
        MatchCollection matches = Regex.Matches(inputText, targetString, RegexOptions.IgnoreCase);
        Console.WriteLine(matches.Count);
    }
}