// Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;

class HexToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a number (base 16): ");
        string inputHex = Console.ReadLine();

        Dictionary<char, int> hexAlpha = new Dictionary<char, int>();
        hexAlpha.Add('A', 10);
        hexAlpha.Add('B', 11);
        hexAlpha.Add('C', 12);
        hexAlpha.Add('D', 13);
        hexAlpha.Add('E', 14);
        hexAlpha.Add('F', 15);

        long result = 0L;
        for (int i = 0; i < inputHex.Length; i++)
        {
            if (Char.IsDigit(inputHex[i]))
            {
                result += (inputHex[i] - '0') * (long)Math.Pow(16, inputHex.Length - i - 1);
            }
            else
            {
                result += hexAlpha[inputHex[i]] * (long)Math.Pow(16, inputHex.Length - i - 1);
            }
        }
        Console.WriteLine(result);
    }
}