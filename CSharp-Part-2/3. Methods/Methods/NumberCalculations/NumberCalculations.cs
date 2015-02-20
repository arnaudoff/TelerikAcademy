/*
 * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
 * Use generic method (read in Internet about generic methods in C#).
 */

using System;
using System.Linq;

class NumberCalculations
{

    static void Main()
    {
        Console.WriteLine("Set of numbers: {1, 2, 3, 4, 5}");
        Console.WriteLine("Minimum: {0}", CalculateMinimum(1, 2, 3, 4, 5));
        Console.WriteLine("Maximum: {0}", CalculateMaximum(1, 2, 3, 4, 5));
        //Console.WriteLine("Average: {0}", CalculateAverage(1, 2, 3, 4, 5));
        Console.WriteLine("Sum: {0}", CalculateSum(1, 2, 3, 4, 5));
        //Console.WriteLine("Product: {0}", CalculateProduct(1, 2, 3, 4, 5));
    }

    // These functions can be implemented with a for loop.
    static T CalculateMinimum<T>(params T[] array)
    {
        return array.Min();
    }

    static T CalculateMaximum<T>(params T[] array)
    {
        return array.Max();
    }

    // todo..

    static double CalculateSum(params double[] array)
    {
        return array.Sum();
    }
 
    // TODO: Calculate product
}
