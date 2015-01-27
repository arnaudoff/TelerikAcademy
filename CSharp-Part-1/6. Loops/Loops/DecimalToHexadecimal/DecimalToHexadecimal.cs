/*
 * Using loops write a program that converts an integer number to its hexadecimal representation.
 * The input is entered as long. The output should be a variable of type string.
 * Do not use the built-in .NET functionality
 */

using System;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a number (base 10): ");
        long inputNumber = long.Parse(Console.ReadLine());

        Dictionary<long, char> hexAlpha = new Dictionary<long, char>();
        hexAlpha.Add(10, 'A');
        hexAlpha.Add(11, 'B');
        hexAlpha.Add(12, 'C');
        hexAlpha.Add(13, 'D');
        hexAlpha.Add(14, 'E');
        hexAlpha.Add(15, 'F');

        string result = "";

        long remainder;
        while (inputNumber > 0)
        {
            remainder = inputNumber % 16;
            if (remainder > 9)
            {
                result = hexAlpha[remainder] + result;
            }
            else
            {
                result = remainder.ToString() + result;
            }
            inputNumber /= 16;
        }

        Console.WriteLine(result);
    }
}