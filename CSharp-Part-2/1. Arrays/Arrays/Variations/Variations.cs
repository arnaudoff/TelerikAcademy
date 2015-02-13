// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

using System;

class Variations
{
    static int[] currentResult;
    static void Main()
    {
        Console.WriteLine("Enter size of the set: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        currentResult = new int[k];
        Variate(0, n, k);
    }

    private static void PrintVariation(int i)
    {
        Console.Write("{");
        for (int j = 0; j < i; j++)
        {
            Console.Write("{0}", currentResult[j] + 1);
            if (j < i - 1)
            {
                Console.Write(", ");      
            }
        }
        Console.Write("}");
        Console.WriteLine();
    }

    private static void Variate(int i, int n, int k)
    {
        if (i >= k)
        {
            PrintVariation(i);
            return;
        }
        else
        {
            for (int j = 0; j < n; j++)
            {
                currentResult[i] = j;
                Variate(i + 1, n, k);
            }
        }
    }
 
}