/*
 * In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula.
 * For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
 * Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
 */

using System;
using System.Numerics;

class CombinatoricsFactoriel
{
    static void Main()
    {
        Console.WriteLine("Enter number [n]: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number [k]: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger firstResult = 1;
        for (int i = k + 1; i <= n; i++)
        {
            firstResult = firstResult * i;
        }
        BigInteger secondResult = 1;
        for (int i = 1; i <= n - k; i++)
        {
            secondResult = secondResult * i;
        }

        Console.WriteLine(firstResult / secondResult);      
    }
}