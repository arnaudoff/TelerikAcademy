// Write a program that finds the biggest of three numbers.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine(firstNumber);
        }
        if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine(secondNumber);
        }
        if (thirdNumber > secondNumber && thirdNumber > firstNumber)
        {
            Console.WriteLine(thirdNumber);
        }

    }
}
