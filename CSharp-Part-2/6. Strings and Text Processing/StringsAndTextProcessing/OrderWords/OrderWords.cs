// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter a list of words: ");
        string inputStr = Console.ReadLine();
        string[] wordArr = inputStr.Split(' ');
        Array.Sort(wordArr);
        foreach (string item in wordArr)
        {
            Console.WriteLine(item);
        }
    }
}