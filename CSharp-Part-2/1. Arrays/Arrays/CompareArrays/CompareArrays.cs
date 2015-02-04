// Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        /*
         * This assumes the size of the arrays is explicitly stated and that it is equal for both of the arrays. 
         * For a non-static size, this could be done using a dynamic List<int>.
         */

        Console.WriteLine("Enter array size: ");
        int arrSize = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} elements for the first array: ", arrSize);
        int[] firstArray = new int[arrSize];

        for (int i = 0; i < arrSize; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter {0} elements for the second array: ", arrSize);
        int[] secondArray = new int[arrSize];

        for (int i = 0; i < arrSize; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;
        for (int i = 0; i < arrSize; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                areEqual = false;
            }
        }

        Console.WriteLine(areEqual);
    }
}
