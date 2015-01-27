/*
 * Using loops write a program that converts an integer number to its binary representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality.
 */

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter a number (base 10): ");
        long inputNumber = long.Parse(Console.ReadLine());

        string result = "";

        long remainder;
        while (inputNumber > 0)
        {
            remainder = inputNumber % 2;
            result = remainder.ToString() + result;
            inputNumber /= 2;
        }

        Console.WriteLine(result);
    }
}