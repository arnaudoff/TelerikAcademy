/*
 * Write a program that converts a string to a sequence of C# Unicode character literals.
 * Use format strings.
 */

using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputStr = Console.ReadLine();
        foreach (char token in inputStr)
        {
            Console.Write(String.Format("\\u{0:X4}", (int)token));
        }
        Console.WriteLine();
    }
}