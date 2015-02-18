// Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        Console.WriteLine("Enter array contents [{0}]: ", arraySize);
        string[] inputArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Enter array index to check: ");
        int pos = int.Parse(Console.ReadLine());

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(inputArray[i]);
        }

        Console.WriteLine(IsLargerThanNeighbours(array, pos));
    }

    static bool IsLargerThanNeighbours(int[] array, int pos)
    {
        if (pos > 0 && pos < array.Length - 1 && array[pos] > array[pos - 1] && array[pos] > array[pos + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
