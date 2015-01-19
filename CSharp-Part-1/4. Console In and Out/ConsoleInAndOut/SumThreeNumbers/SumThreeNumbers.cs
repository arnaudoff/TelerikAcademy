// Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        double result = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine(result);
    }
}
