/*
 * Write a program that reads an integer number and calculates and prints its square root.
 *      If the number is invalid or negative, print Invalid number.
 *      In all cases finally print Good bye.
 * Use try-catch-finally block.
 */

using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a positive number: ");
            double number = double.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Console.WriteLine(Math.Sqrt(number));
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Good bye.");
        }
    }
}
