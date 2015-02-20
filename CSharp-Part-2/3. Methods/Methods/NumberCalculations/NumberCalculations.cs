/*
 * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
 * Use a generic method (read about generic methods in C#).
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
        Console.WriteLine("Average: {0}", CalculateAverage(1, 2, 3, 4, 5));
        Console.WriteLine("Sum: {0}", CalculateSum(1, 2, 3, 4, 5));
        Console.WriteLine("Product: {0}", CalculateProduct(1, 2, 3, 4, 5));
    }

    static T CalculateMinimum<T>(params T[] array)
    {
        return array.Min();
    }

    static T CalculateMaximum<T>(params T[] array)
    {
        return array.Max();
    }

    static double CalculateAverage<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }

        return sum / (double)array.Length;
    }

    static T CalculateSum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
        return sum;
    }

    static T CalculateProduct<T>(params T[] array)
    {
        dynamic product = 1;
        foreach (var number in array)
        {
            product *= number;
        }
        return product;
    }
}
