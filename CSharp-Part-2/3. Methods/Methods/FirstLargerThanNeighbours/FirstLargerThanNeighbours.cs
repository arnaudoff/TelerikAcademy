// Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        Console.WriteLine("Enter array contents [{0}]: ", arraySize);
        string[] inputArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(inputArray[i]);
        }

        Console.WriteLine(IsLargerThanNeighbours(array));
    }

    static int IsLargerThanNeighbours(int[] array)
    {
        bool isLarger = false;
        int i;
        for (i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                isLarger = true;
                break;
            }
        }
        if (isLarger)
        {
            return i;
        }
        else
        {
            return -1;
        }
    }
}