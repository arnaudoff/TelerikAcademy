namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(6);
            Console.WriteLine("Max: {0}", numbers.Max());
            Console.WriteLine("Min: {0}", numbers.Min());
            Console.WriteLine("Average: {0}", numbers.Average());
            Console.WriteLine("Sum: {0}", numbers.Sum());
            Console.WriteLine("Product: {0}", numbers.Product());
        }
    }
}
