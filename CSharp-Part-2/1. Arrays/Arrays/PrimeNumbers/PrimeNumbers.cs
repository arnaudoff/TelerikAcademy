// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main()
    {
        // If you're a real man you will run this without changing n.
        int n = 10000000;
        List<int> primes = GetPrimes(n);

        foreach (int prime in primes)
        {
            Console.Write("{0} ", prime);
        }
        Console.WriteLine();
    }

    private static List<int> GetPrimes(int n)
    {
        List<int> currentPrimes = new List<int>() { 2 };
        int maxSquareRoot = (int)Math.Sqrt(n);
        BitArray eliminated = new BitArray(n + 1);

        for (int i = 3; i <= n; i += 2)
        {
            if (!eliminated[i])
            {
                currentPrimes.Add(i);
                if (i < maxSquareRoot)
                {
                    for (int j = i * i; j <= n; j += 2 * i)
                    {
                        eliminated[j] = true;
                    }
                }
            }
        }
        return currentPrimes;
    }
}
