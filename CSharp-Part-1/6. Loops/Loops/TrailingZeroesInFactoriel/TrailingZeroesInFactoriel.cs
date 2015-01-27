/*
 * Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
 * Your program should work well for very big numbers, e.g. n=100000. 
 */

using System;
using System.Numerics;

class TrailingZeroesInFactoriel
{
    static void Main()
    {
        Console.WriteLine("Enter a number [n]: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(calculateFactoriel(n));
    }

    static BigInteger calculateFactoriel(int inputNumber)
    {
        BigInteger result = 1;
        for (int i = 1; i <= inputNumber; i++)
        {
            result = result * i;
        }
        return result;
    }
}