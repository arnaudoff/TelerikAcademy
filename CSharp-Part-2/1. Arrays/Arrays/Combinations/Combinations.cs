// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].

using System;

class Combinations
{
    static int[] currentResult;
    static void Main()
    {
        Console.WriteLine("Enter size of the set: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        currentResult = new int[k];
        Combine(1, 0, n, k);
    }

    private static void PrintCombination(int len)
    {
        Console.Write("{");
        for (int i = 0; i < len; i++)
        {
            Console.Write("{0}", currentResult[i]);
            if (i < len - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("}");
    }

    private static void Combine(int len, int after, int n, int k)
    {
        if (len > k)
        {
            return;
        }
        for (int j = after + 1; j <= n; j++)
        {
            currentResult[len - 1] = j;
            if (len == k)
            {
                PrintCombination(len);
            }
            Combine(len + 1, j, n, k);
        }
    }
}