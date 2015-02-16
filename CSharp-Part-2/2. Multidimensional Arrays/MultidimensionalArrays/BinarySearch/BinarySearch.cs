// Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter key [k]: ");
        int key = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter array contents: ");
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        /* 
         * LINQ solution:
         * 
         * var result = numbers.Where(t => t <= key).Max();
         * Console.WriteLine(result);
         */

        do 
        {

        } while ();

    }
}