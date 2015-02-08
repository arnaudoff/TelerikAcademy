// Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

class MergeSort
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

        Console.WriteLine("Before Merge sort: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", inputArray[i]);
        }

        Sort(inputArray, n);

        Console.WriteLine();
        Console.WriteLine("After Merge sort: ");
        for (int  i = 0;  i < n;  i++)
        {
            Console.Write("{0} ", inputArray[i]);
        }
        Console.WriteLine();
    }

    static void Sort(int[] A, int length)
    {
        if (length < 2)
        {
            return;
        }
        int midPoint = length / 2; 
        int[] left = new int[midPoint];
        int[] right = new int[length - midPoint];

        for (int i = 0; i < midPoint; i++)
        {
            left[i] = A[i];
        }

        for (int i = midPoint; i < length; i++)
        {
            right[i - midPoint] = A[i];
        }

        Sort(left, midPoint);
        Sort(right, length - midPoint);
        Merge(A, left, midPoint, right, length - midPoint);
    }

    static void Merge(int[] A, int[] L, int leftLength, int[] R, int rightLength)
    {
        int i = 0;
        int j = 0;
        int k = 0;

        // Fill in the resultant array
        while (i < leftLength && j < rightLength)
        {
            if (L[i] < R[j])
            {
                A[k++] = L[i++];
            }
            else
            {
                A[k++] = R[j++];
            }
        }
        // To fill the leftovers in both arrays.
        while (i < leftLength)
        {
            A[k++] = L[i++];
        }
        while (j < rightLength)
        {
            A[k++] = R[j++];
        }
    }
}