/*
 * Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
 * Use only one loop. Print the result with 5 digits after the decimal point. 
 */

using System;

class FactorielSum
{
    static void Main()
    {
        Console.WriteLine("Enter number [n]: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number [x]: ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum += calculateFactoriel(i) / (double)Math.Pow(x, i);
        }
        Console.WriteLine("{0:F5}", sum);
    }
    static double calculateFactoriel(int inputNumber)
    {
        int result = 1;
        for (int i = 1; i <= inputNumber; i++)
        {
            result = result * i;
        }
        return result;
    }
}