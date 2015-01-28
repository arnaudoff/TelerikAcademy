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
        int inputNumber = int.Parse(Console.ReadLine());

        BigInteger result = countTrailingZeroes(inputNumber);
        Console.WriteLine(result);

    }

    static BigInteger countTrailingZeroes(int n)
    {
        // Since a trailing zero means n * 10 and 10 is 5 x 2, we're going to divide by each power of two (until n / i > 0)
        int count = 0;
        for (int i = 5; n / i > 0; i = i * 5)
        {
            count += n / i;
        }
        return count;
    }
}