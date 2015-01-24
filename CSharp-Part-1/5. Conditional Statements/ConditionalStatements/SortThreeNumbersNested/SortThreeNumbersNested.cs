/*
 * Write a program that enters 3 real numbers and prints them sorted in descending order.
 * Use nested if statements.
 * Note: Don’t use arrays and the built-in sorting functionality.
 */

using System;

class SortThreeNumbersNested
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                if (secondNumber >= thirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
        else if (secondNumber >= firstNumber)
        {
           if (secondNumber >= thirdNumber)
           {
               if (firstNumber >= thirdNumber)
               {
                   Console.WriteLine("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
               }
               else
               {
                   Console.WriteLine("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
               }
           }
           else
           {
               Console.WriteLine("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
           }
        }
    }
}