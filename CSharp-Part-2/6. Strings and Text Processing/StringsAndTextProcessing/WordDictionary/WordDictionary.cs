/*
 * A dictionary is stored as a sequence of text lines containing words and their explanations.
 * Write a program that enters a word and translates it by using the dictionary.
 */

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        var dict = new Dictionary<string, string>()
        {
            {".NET", "platform for applications from Microsoft"},
            {"CLR", "managed execution environment for .NET"},
            {"namespace", "hierarchical organization of classes"}
        };

        Console.Write("Enter a word to be translated: ");
        string inputWord = Console.ReadLine();
        Console.WriteLine(dict[inputWord]);
    }
}