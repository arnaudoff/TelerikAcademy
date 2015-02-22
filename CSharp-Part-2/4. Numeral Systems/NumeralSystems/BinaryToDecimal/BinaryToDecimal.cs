// Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a number (base 2): ");
        string inputStr = Console.ReadLine();

        long result = 0L;
        for (int i = 0; i < inputStr.Length; i++)
        {
            if (inputStr[i] == '1')
            {
                result += (long)Math.Pow(2, inputStr.Length - i - 1);
            }
        }
        Console.WriteLine(result);
    }
}
