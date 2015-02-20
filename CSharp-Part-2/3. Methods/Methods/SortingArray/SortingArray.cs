/*
 * Write a method that return the maximal element in a portion of array of integers starting at given index.
 * Using it write another method that sorts an array in ascending / descending order.
 */

using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        Console.WriteLine("Enter array contents [{0}]: ", arraySize);
        string[] inputArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Enter array index to start from: ");
        int pos = int.Parse(Console.ReadLine());

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(inputArray[i]);
        }

        Console.WriteLine("Biggest element in the subarray: {0}", FindMaxInSubArray(array, pos));
        Console.WriteLine("Sorted in ascending order: ");
        Sort(array, 0);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);            
        }
        Console.WriteLine();
        Console.WriteLine("Sorted in descending order: ");
        Sort(array, 1);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    static int FindMaxInSubArray(int[] array, int startingIndex)
    {
        var subArray = array.Skip(startingIndex).Take(array.Length - startingIndex);
        return subArray.Max();
    }

    static void Sort(int[] array, byte order)
    {
        switch (order)
        {
            case 0:
                Array.Sort(array);
                break;
            case 1:
                Array.Sort<int>(array,
                                new Comparison<int>(
                                        (i1, i2) => i2.CompareTo(i1)
                                ));
                break;
        }
    }
}
