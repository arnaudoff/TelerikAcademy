/*
 * Using loops write a program that converts a binary integer number to its decimal form.
 * The input is entered as string. The output should be a variable of type long.
 * Do not use the built-in .NET functionality. 
 */

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