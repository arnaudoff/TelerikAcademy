/*
 * Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
 * Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */

using System;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter array contents: ");
        int[] inputArray = new int[n];
        int i;
        for (i = 0; i < n; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        int current, walker, smallest, temp;

        for (current = 0; current < n;  current++)
        {
            smallest = current;
            for (walker = current + 1; walker < n; walker++)
            {
                if (inputArray[walker] < inputArray[smallest])
                {
                    smallest = walker;
                }
            }
            temp = inputArray[current];
            inputArray[current] = inputArray[smallest];
            inputArray[smallest] = temp;
        }

        for (i = 0; i < n; i++)
        {
            Console.Write("{0} ", inputArray[i]);
        }
        Console.WriteLine();
    }
}