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
        Console.WriteLine("Enter array index to check: ");
        int pos = int.Parse(Console.ReadLine());

        for (int i = 0; i < arraySize; i++)
        {
            array[i] = int.Parse(inputArray[i]);
        }

        Console.WriteLine(IsLargerThanNeighbours(array, pos));
    }

    static int IsLargerThanNeighbours(int[] array, int pos)
    {
        
    }
}