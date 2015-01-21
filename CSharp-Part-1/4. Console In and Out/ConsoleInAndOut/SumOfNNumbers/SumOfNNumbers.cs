// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter amount of numbers to be read: ");
        int inputNumber = int.Parse(Console.ReadLine());
        double sum = 0D;
        for (int i = 0; i < inputNumber; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum: {0}", sum);
    }
}
