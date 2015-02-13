/*
 * We are given an array of integers and a number S.
 * Write a program to find if there exists a subset of the elements of the array that has a sum S.
 */

using System;
using System.Collections.Generic;

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

        int result = GetSum(inputArray, n, sum);
        if (result == 1)
        {
            Console.WriteLine("The sum was found in a subset.");
        }
        else
        {
            Console.WriteLine("The sum was not found in any subset.");
        }

    }

    // A naive solution for this would be O(n^2). The complexity of this algorithm, however, is O(n).

    static int GetSum(int[] inputArray, int n, int sum)
    {
        int currentSum = inputArray[0];
        int start = 0;

        for (int i = 1; i < n; i++)
        {
            // Remove the first element if we've exceeded the sum. It improves the time complexity to linear.
            while (currentSum > sum && start < i - 1)
            {
                currentSum = currentSum - inputArray[start];
                start++;
            }

            if (currentSum == sum)
            {
                return 1;
            }

            if (i < n)
            {
                currentSum += inputArray[i];
            }
        }
        return -1;
    }
}