// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {

        Console.Write("Enter a string: ");
        string inputStr = Console.ReadLine();
        StringBuilder outputStr = new StringBuilder();
        char lastChar = '\0';

        foreach (var currentChr in inputStr)
        {
            if (currentChr != lastChar)
            {
                outputStr.Append(currentChr);
            }

            lastChar = currentChr;
        }

        Console.WriteLine(outputStr);
    }
}