// Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        Console.WriteLine(Reverse(inputStr));
    }

    static string Reverse(string str)
    {
        StringBuilder finalStr = new StringBuilder();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            finalStr.Append(str[i]);
        }
        return finalStr.ToString();
    }
}