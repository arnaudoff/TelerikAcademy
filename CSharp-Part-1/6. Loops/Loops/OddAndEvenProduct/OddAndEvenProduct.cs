/*
 * You are given n integers (given in a single line, separated by a space).
 * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter sequence: ");
        string[] tokens = Console.ReadLine().Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < tokens.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= int.Parse(tokens[i]);
            }
            else
            {
                oddProduct *= int.Parse(tokens[i]);
            }
        }
        Console.WriteLine("{0}", (evenProduct == oddProduct) ? "Yes." : "No.");
    }
}