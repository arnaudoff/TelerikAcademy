// Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

using System;

class Permutations
{
    static int[] currentResult;
    static int[] usedElements;
    static void Main()
    {
        Console.WriteLine("Enter number of elements to permute: ");
        int n = int.Parse(Console.ReadLine());
        currentResult = new int[n];
        usedElements = new int[n];
        for (int i = 0; i < n; i++)
        {
            usedElements[i] = 0;
        }
        Permute(0, n);
    }

    private static void PrintPermutation(int n)
    {
        Console.Write("{");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}", currentResult[i] + 1);
            if (i < n - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write("}");
        Console.WriteLine();
    }
    private static void Permute(int pos, int n)
    {
        if (pos >= n)
        {
            PrintPermutation(n);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                if (usedElements[i] == 0)
                {
                    usedElements[i] = 1;
                    currentResult[pos] = i;
                    Permute(pos + 1, n);
                    usedElements[i] = 0;
                }
            }
        }
    }

}