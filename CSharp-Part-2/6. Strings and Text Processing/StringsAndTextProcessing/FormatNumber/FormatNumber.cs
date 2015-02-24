/*
 * Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
 * Format the output aligned right in 15 symbols.
 */

using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        // Print as decimal
        Console.WriteLine("{0,15}", number.ToString("d"));
        // Print as hexadecimal
        Console.WriteLine("{0,15}", number.ToString("x"));
        // Print as percentage
        Console.WriteLine("{0,15}", number.ToString("P"));
        // Print with its scientific notation
        Console.WriteLine("{0,15}", number.ToString("e"));
    }
}
