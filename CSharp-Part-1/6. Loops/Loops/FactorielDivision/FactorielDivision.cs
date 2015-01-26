/*
 * Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
 * Use only one loop. 
 */

using System;
using System.Numerics;

class FactorielDivision
{
    static void Main()
    {
        Console.WriteLine("Enter number [n]: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number [k]: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger result = 1;
        for (int i = k + 1; i <= n; i++)
        {
            result = result * i;
        }
        Console.WriteLine(result);
    }
}
