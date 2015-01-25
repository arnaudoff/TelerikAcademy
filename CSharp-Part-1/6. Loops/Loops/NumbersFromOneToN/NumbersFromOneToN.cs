// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= inputNumber; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}