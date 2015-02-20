// Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        for (int i = 1; i < 100; i++)
        {
            Console.WriteLine(Factorial(i));
        }
    }

    static BigInteger Factorial(int number)
    {
        BigInteger accumulator = 1;
        for (int factor = 1; factor <= number; factor++)
        {
            accumulator *= factor;
        }
        return accumulator;
    }
 
}