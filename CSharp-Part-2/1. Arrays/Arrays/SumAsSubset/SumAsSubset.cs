/*
 * We are given an array of integers and a number S.
 * Write a program to find if there exists a subset of the elements of the array that has a sum S.
 */

using System;

class SumAsSubset
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter array contents: ");
        int[] inputArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter sum to search for: ");
        int sum = int.Parse(Console.ReadLine());

        bool res = isSubsetSum(inputArray, n, sum);
        Console.WriteLine(res);
    }

    static bool isSubsetSum(int[] set, int n, int sum)
    {
        // The value of subset[i][j] will be true if there is a subset of set[0..j-1]
        //  with sum equal to i
        bool[,] subset = new bool[sum + 1, n + 1];
 
        // If sum is 0, then answer is true
        for (int i = 0; i <= n; i++)
          subset[0, i] = true;
 
        // If sum is not 0 and set is empty, then answer is false
        for (int i = 1; i <= sum; i++)
          subset[i, 0] = false;
 
         // Fill the subset table in botton up manner
         for (int i = 1; i <= sum; i++)
         {
           for (int j = 1; j <= n; j++)
           {
             subset[i, j] = subset[i, j-1];
             if (i >= set[j-1])
               subset[i, j] = subset[i, j] || subset[i - set[j-1], j-1];
           }
         }

         for (int i = 0; i <= sum; i++)
         {
           for (int j = 0; j <= n; j++)
              Console.Write("{0,4}", subset[i, j]);
           Console.WriteLine();
         }
 
         return subset[sum, n];
    }
}