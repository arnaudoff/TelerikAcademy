// Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Linq;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();
        string[] splitResult = inputString.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> uniqueStrings = splitResult.Distinct().ToDictionary(d => d, d => 0);
        foreach (string str in splitResult)
        {
            uniqueStrings[str] = ++uniqueStrings[str];
        }
        foreach (var str in uniqueStrings)
        {
            Console.WriteLine("{0} -> {1} occurence{2}", str.Key, str.Value, str.Value == 1 ? '\0' : 's');
        }
    }
}