// Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber 
            && firstNumber >= fourthNumber && firstNumber >= fifthNumber)
        {
            Console.WriteLine(firstNumber);
        }

        if (secondNumber >= firstNumber && secondNumber >= thirdNumber
            && secondNumber >= fourthNumber && secondNumber >= fifthNumber)
        {
            Console.WriteLine(secondNumber);
        }

        if (thirdNumber >= firstNumber && thirdNumber >= secondNumber
            && thirdNumber >= fourthNumber && thirdNumber >= fifthNumber)
        {
            Console.WriteLine(thirdNumber);
        }

        if (fourthNumber >= firstNumber && fourthNumber >= secondNumber
            && fourthNumber >= thirdNumber && fourthNumber >= fifthNumber)
        {
            Console.WriteLine(fourthNumber);
        }

        if (fifthNumber >= firstNumber && fifthNumber >= secondNumber
            && fifthNumber >= thirdNumber && fifthNumber >= fourthNumber)
        {
            Console.WriteLine(fifthNumber);
        }

    }
}