/*
 * Write a program that reads two integer numbers N and K and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum. 
 */

using System;

class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter amount of elements (K): ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter array contents: ");
        int[] inputArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(inputArray);
        int sum = 0;
        for (int i = n - k; i < n; i++)
        {
            sum += inputArray[i];
        }

        Console.WriteLine("The maximum sum of {0} elements is {1}. ", k, sum);
    }
}