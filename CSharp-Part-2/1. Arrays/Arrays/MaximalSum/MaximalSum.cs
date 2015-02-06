// Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
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

        int arrLength = inputArray.Length;
        int maxSum = 0;
        int beginMax = 0; 
        int endMax = -1;
        int sum = 0;

        for (int i = 0; i < arrLength; i++)
        {
            sum = 0;
            for (int k = i; k < arrLength; k++)
            {
                sum += inputArray[k];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    beginMax = i;
                    endMax = k;
                }
            }
        }

        for (int i = beginMax; i <= endMax; i++)
        {
            Console.Write("{0} ", inputArray[i]);
        }
        Console.WriteLine();
    }
}