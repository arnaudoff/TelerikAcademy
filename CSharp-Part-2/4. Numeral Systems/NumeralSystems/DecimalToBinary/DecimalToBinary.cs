// Write a program to convert decimal numbers to their binary representation.

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
