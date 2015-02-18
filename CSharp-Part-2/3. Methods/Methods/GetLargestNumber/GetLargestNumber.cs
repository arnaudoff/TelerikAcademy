/*
 * Write a method GetMax() with two parameters that returns the larger of two integers.
 * Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int firstResult = GetMax(firstNumber, secondNumber);
        int finalResult = GetMax(firstResult, thirdNumber);
        Console.WriteLine(finalResult);
    }
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else if (firstNumber < secondNumber)
        {
            return secondNumber;
        }
        return -1;
    }
}
