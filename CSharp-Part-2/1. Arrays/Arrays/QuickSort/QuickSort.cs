// Write a program that sorts an array of strings using the Quick sort algorithm.

using System;

class QuickSort
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

        Console.WriteLine("Before Quick sort: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", inputArray[i]);
        }

        Sort(inputArray, 0, inputArray.Length - 1);

        Console.WriteLine();
        Console.WriteLine("After Quick sort: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", inputArray[i]);
        }
        Console.WriteLine();        
    }

    static void Sort(int[] A, int startIndex, int endIndex)
    {
        if (startIndex < endIndex)
        {
            int pIndex = Partition(A, startIndex, endIndex);
            // Sort left segment
            Sort(A, startIndex, pIndex - 1);
            // Sort right segment
            Sort(A, pIndex + 1, endIndex);
        }
    }

    static int Partition(int[] A, int startIndex, int endIndex)
    {
        int pivot = A[endIndex];
        int pIndex = startIndex;
        int tmp;
        for (int i = startIndex; i < endIndex; i++)
        {
            if (A[i] <= pivot)
            {
                tmp = A[i];
                A[i] = A[pIndex];
                A[pIndex] = tmp;
                pIndex++;
            }
        }
        tmp = A[pIndex];
        A[pIndex] = A[endIndex];
        A[endIndex] = tmp;
        return pIndex;
    }
}