/*
 * Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
 * Print the result string into the console.
 */

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string inputStr = Console.ReadLine();
        
        while (inputStr.Length > 20)
        {
            Console.Write("Wrong amount of characters entered. Enter a new string: ");
            inputStr = Console.ReadLine();
        }

        if (inputStr.Length < 20)
        {
            StringBuilder fixedOutput = new StringBuilder();
            fixedOutput.Append(inputStr);
            for (int i = inputStr.Length; i < 20; i++)
            {
                fixedOutput.Append('*');
            }
            Console.WriteLine(fixedOutput);
        }
        else
        {
            Console.WriteLine("No changes to the original string \"{0}\" were made.", inputStr);
        }
    }
}