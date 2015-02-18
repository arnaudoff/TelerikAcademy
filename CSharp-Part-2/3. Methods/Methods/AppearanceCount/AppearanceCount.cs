/*
 * Write a method that counts how many times given number appears in given array.
 * Write a test program to check if the method is working correctly.
 */

using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        Console.WriteLine("Enter array contents [{0}]: ", arraySize);
        string[] inputArray = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Enter key to search for: ");
        int key = int.Parse(Console.ReadLine());

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(inputArray[i]);
        }

        Console.WriteLine("The number {0} is present in the array {1} times. ", key, CountOccurences(array, key));
    }

    static int CountOccurences(int[] array, int key)
    {
        return array.Where(x => x == key).Count();
    }
}