/*
 * Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array
 */

using System;

class LettersIndices
{
    static void Main()
    {
        Console.WriteLine("Enter a word: ");
        string inputString = Console.ReadLine();

        char[] alphabetArray = new char[52];
        for (int i = 65; i <= 90; i++)
        {
            alphabetArray[i - 65] = (char)i;
        }
        for (int i = 97, j = 26; i <= 122; i++, j++)
        {
            alphabetArray[j] = (char)i;
        }

        foreach (char token in inputString)
        {
            Console.WriteLine("{0} at index {1}.", token, Array.IndexOf(alphabetArray, token));
        }
    }
}