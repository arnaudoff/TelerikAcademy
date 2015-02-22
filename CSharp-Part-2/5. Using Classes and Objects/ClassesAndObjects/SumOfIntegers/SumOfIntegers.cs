/*
 * You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum.
 */

using System;
using System.Linq;

class SumOfIntegers
{
    static void Main()
    {
        Console.Write("Enter a sequence of numbers (use space as a delimiter): ");
        Console.WriteLine(CalculateSum(Console.ReadLine()));
    }

    static int CalculateSum(string numbersSequence)
    {
        string[] strNumbersArray = numbersSequence.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] numbersArray = new int[strNumbersArray.Length];
        for (int i = 0; i < numbersArray.Length; i++)
        {
            numbersArray[i] = int.Parse(strNumbersArray[i]);
        }
        return numbersArray.Sum();
    }
}
