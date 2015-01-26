/*
 * In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
 * Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
 */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number [n]: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger firstFactoriel = 1;
        int i;
        for (i = 1; i <= 2 * n; i++)
        {
            firstFactoriel = firstFactoriel * i;
        }

        BigInteger secondFactoriel = 1;
        for (i = 1; i <= n + 1; i++)
        {
            secondFactoriel = secondFactoriel * i;
        }

        BigInteger thirdFactoriel = 1;
        for (i = 1; i <= n; i++)
        {
            thirdFactoriel = thirdFactoriel * i;
        }

        Console.WriteLine(firstFactoriel / (secondFactoriel * thirdFactoriel));

    }
}