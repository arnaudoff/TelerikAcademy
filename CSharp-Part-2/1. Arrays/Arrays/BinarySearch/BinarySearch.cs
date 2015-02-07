// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number to search for: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array contents: ");
        int[] inputArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(inputArray);
        int index = binarySearch(inputArray, inputNumber, 0, n - 1);
        if (index != -1)
        {
            Console.WriteLine("The number {0} was found at index {1}.", inputNumber, index);
        }
        else
        {
            Console.WriteLine("The number {0} is not present in the array.", inputNumber);
        }
    }
    static int binarySearch(int[] inputArray, int inputNumber, int iMin, int iMax)
    {
        while (iMax >= iMin)
        {
            int midPoint = (iMin + iMax) / 2;
            if (inputArray[midPoint] == inputNumber)
            {
                return midPoint;
            }
            else if (inputArray[midPoint] < inputNumber)
            {
                iMin = midPoint + 1;
            }
            else
            {
                iMax = midPoint - 1;
            }
        }
        return -1;
    }
}