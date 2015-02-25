// Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

using System;
using System.Linq;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();
        Dictionary<char, int> uniqueChars = inputString.Distinct().ToDictionary(d => d, d => 0);
        foreach (char ch in inputString)
        {
            uniqueChars[ch] = ++uniqueChars[ch];
        }
        foreach (var ch in uniqueChars)
        {
            Console.WriteLine("{0} -> {1} occurence{2}", ch.Key, ch.Value, ch.Value == 1 ? '\0' : 's');
        }
    }
}
