/*
 * Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
 * Use the Euclidean algorithm (find it in Internet).
 */

using System;
using System.Collections.Generic;

class CalculateGCD
{
    static void Main()
    {
        Console.WriteLine("Enter first number [a]: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number [b]: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int remainder = 1;
        while (remainder > 0)
        {
            remainder = firstNumber % secondNumber;
            firstNumber = secondNumber;
            secondNumber = remainder;
        }
        Console.WriteLine(firstNumber);
    }
}