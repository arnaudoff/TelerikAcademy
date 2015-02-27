/*
 * Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
 *      If an invalid number or non-number text is entered, the method should throw an exception.
 * Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;

class EnterNumbers
{
    static void Main()
    {
        try
        {
            int num;
            for (int i = 0; i < 10; i++)
            {
                num = ReadNumber(1, 100);
            }
        }
        catch (FormatException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }

    private static int ReadNumber(int start, int end)
    {
        Console.Write("Enter a number in the range [{0}...{1}]: ", start + 1, end - 1);
        int number = int.Parse(Console.ReadLine());

        if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException();
        }

        return number;
    }
}