// Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class NumbersFrom1toN
{
    static void Main()
    {
        Console.WriteLine("Enter number (n): ");
        int inputNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i <= inputNumber; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}
