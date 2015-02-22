// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHex
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string inputStr = Console.ReadLine();

        // This fixes the input if the number isn't entirely dividable by 4 by padding with leading zeros.
        int remaindingBits = inputStr.Length % 4;
        inputStr = inputStr.PadLeft(remaindingBits, '0');

        StringBuilder result = new StringBuilder();
        for (int i = 0; i <= inputStr.Length - 4; i += 4)
        {
            result.Append(string.Format("{0:X}", Convert.ToByte(inputStr.Substring(i, 4), 2)));
        }
        Console.WriteLine(result);
    }
}
