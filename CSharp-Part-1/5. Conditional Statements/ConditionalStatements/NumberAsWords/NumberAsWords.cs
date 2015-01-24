// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;
using System.Collections.Generic;

class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        Dictionary<int, string> digitsDict = new Dictionary<int, string>
        {
            {0, "Zero"},
            {1, "One"},
            {2, "Two"},
            {3, "Three"},
            {4, "Four"},
            {5, "Five"},
            {6, "Six"},
            {7, "Seven"},
            {8, "Eight"},
            {9, "Nine"},
        };

        Dictionary<int, string> teenDict = new Dictionary<int, string>
        {
            {10, "Ten"},
            {11, "Eleven"},
            {12, "Twelve"},
            {13, "Thirteen"},
            {14, "Fourteen"},
            {15, "Fifteen"},
            {16, "Sixteen"},
            {17, "Seventeen"},
            {18, "Eighteen"},
            {19, "Nineteen"}
        };

        Dictionary<int, string> tensDict = new Dictionary<int, string>
        {
            {20, "Twenty"},
            {30, "Thirty"},
            {40, "Fourty"},
            {50, "Fifty"},
            {60, "Sixty"},
            {70, "Seventy"},
            {80, "Eighty"},
            {90, "Ninety"},
        };

        if (inputNumber >= 0 && inputNumber <= 9)
        {
            Console.WriteLine(digitsDict[inputNumber]);
        } 
        else if (inputNumber >= 10 && inputNumber < 20)
        {
            Console.WriteLine(teenDict[inputNumber]);
        }
        else if (inputNumber % 10 == 0)
        {
            Console.WriteLine(tensDict[inputNumber]);
        }
        // TODO: modulus for up to 1000
    }
}