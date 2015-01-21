// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number sequence: ");
        string[] inputString = Console.ReadLine().Split(' ');

        double finalSum = 0;
        for (int i = 0; i < 5; i++)
        {
            finalSum += double.Parse(inputString[i]);
        }
        Console.WriteLine(finalSum);
    }
}
