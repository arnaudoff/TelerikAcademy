// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string inputStr = "aaaaabbbbbcdddeeeedssaa";

        // TODO: fix this
        StringBuilder outputStr = new StringBuilder();
        int currentPos = 1;
        int currentChar = inputStr[0];
        int currentCharCount = 1;
        bool isSeries = false;
        while (currentPos < inputStr.Length)
        {
            if (inputStr[currentPos] == currentChar)
            {
                isSeries = true;
                currentCharCount++;
            }
            else
            {
                if (isSeries)
                {
                    isSeries = false;
                    outputStr.Append(inputStr[currentPos - 1]);
                    currentChar = inputStr[currentPos];
                    // Append if single
                    if (inputStr[currentPos] != currentChar)
                    {
                        outputStr.Append(currentChar);
                        currentChar = inputStr[currentPos + 1];
                    }
                    currentCharCount = 1;
                }
                else
                {
                    outputStr.Append(inputStr[currentPos]);
                }
            }
            currentPos++;
        }
        Console.WriteLine(outputStr.ToString());
    }
}