/*
 * Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
 * Find in the array a subset of K elements that have sum S or indicate about its absence. 
 */

using System;

class SumAsSubsetK
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

        Console.WriteLine("Enter amount of elements: ");
        int k = int.Parse(Console.ReadLine());

        int result = GetSum(inputArray, n, sum, k);
        if (result == 1)
        {
            Console.WriteLine("The sum {0} was found in a subset in the given range k (k = {1}).", sum, k);
        }
        else
        {
            Console.WriteLine("The sum {0} was not found or was not present in the given range k (k = {1}).", sum, k);
        }

    }

    static int GetSum(int[] inputArray, int n, int sum, int k)
    {
        int currentSum = inputArray[0];
        int start = 0;

        for (int i = 1; i < n; i++)
        {
            while (currentSum > sum && start < i - 1)
            {
                currentSum = currentSum - inputArray[start];
                start++;
            }

            if (currentSum == sum)
            {
                if (i - start == k)
                {
                    return 1;
                }
            }

            if (i < n)
            {
                currentSum += inputArray[i];
            }
        }
        return -1;
    }
}