// Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;

class DecimalToHex
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