/*
 * Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
 * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
 */

using System;

class MinMaxSumAndAverage
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        
        int[] numbers = new int[inputNumber];

        for (int i = 0; i < inputNumber; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxNumber = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }

        int minNumber = maxNumber;
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
            sum += numbers[i];
        }

        float average = (float)sum / (float)inputNumber;
        Console.WriteLine("Min: {0}", minNumber);
        Console.WriteLine("Max: {0}", maxNumber);
        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Average: {0:F2}", average);
    }
}