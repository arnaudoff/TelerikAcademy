/*
 * Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
 * Use variable number of arguments.
 */

using System;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        Console.WriteLine("Set of numbers: {1, 2, 3, 4, 5}");
        Console.WriteLine("Minimum: {0}", CalculateMinimum(1, 2, 3, 4, 5));
        Console.WriteLine("Maximum: {0}", CalculateMaximum(1, 2, 3, 4, 5));
        Console.WriteLine("Average: {0}", CalculateAverage(1, 2, 3, 4, 5));
        Console.WriteLine("Sum: {0}", CalculateSum(1, 2, 3, 4, 5));
        Console.WriteLine("Product: {0}", CalculateProduct(1, 2, 3, 4, 5));
    }

    // These functions can be implemented with a for loop.
    static int CalculateMinimum(params int[] array)
    {
        return array.Min();
    }

    static int CalculateMaximum(params int[] array)
    {
        return array.Max();
    }

    static double CalculateAverage(params int[] array)
    {
        return array.Average();
    }

    static int CalculateSum(params int[] array)
    {
        return array.Sum();
    }

    static int CalculateProduct(params int[] array)
    {
        int res = 1;
        for (int i = 0; i < array.Length; i++)
        {
            res *= array[i];
        }
        return res;
    }
}