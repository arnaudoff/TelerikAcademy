/*
 * Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
 * Each of the numbers that will be added could have up to 10 000 digits.
 */

﻿using System;

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        string input = Console.ReadLine();
        int[] firstNumber = new int[input.Length];

        for (int i = 0; i < firstNumber.Length; i++)
        {
            firstNumber[i] = int.Parse(input[input.Length - 1 - i].ToString());
        }

        Console.Write("Enter second integer: ");
        input = Console.ReadLine();
        int[] secondNumber = new int[input.Length];

        for (int i = 0; i < secondNumber.Length; i++)
        {
            secondNumber[i] = int.Parse(input[input.Length - 1 - i].ToString());
        }

        PrintResult(CalculateSum(firstNumber, secondNumber));
    }

    static int[] CalculateSum(int[] first, int[] second)
    {
        if (first.Length > second.Length)
        {
            return CalculateSum(second, first);
        }

        int[] result = new int[second.Length + 1];
        int i = 0;
        int remainder = 0;

        for (; i < first.Length; i++)
        {
            result[i] = (byte)(first[i] + second[i] + remainder);
            remainder = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < second.Length && remainder != 0; i++)
        {
            result[i] += (byte)(second[i] + remainder);
            remainder = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < second.Length; i++)
        {
            result[i] = second[i];
        }

        if (remainder != 0)
        {
            result[i] = 1;
        }
        else
        {
            Array.Resize(ref result, result.Length - 1);
        }
        return result;
    }

    static void PrintResult(int[] finalArray)
    {
        for (int i = finalArray.Length - 1; i >= 0; i--)
        {
            if (finalArray[i] == 0 && i == finalArray.Length - 1)
            {
                continue;
            }
            Console.Write(finalArray[i]);
        }
        Console.WriteLine();
    }
}