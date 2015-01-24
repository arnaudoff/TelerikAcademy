// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            double tempValue = firstNumber;
            firstNumber = secondNumber;
            secondNumber = tempValue;
        }
        Console.WriteLine("{0} {1}", firstNumber, secondNumber);
    }
}