// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> items) where T : IComparable
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException("Sum of elements of an empty collection cannot be calculated");
            }

            dynamic sum = default(T);
            foreach (var item in items)
            {
                sum += item;
            }

            return sum;
        }

        public static double Average<T>(this IEnumerable<T> items) where T : IComparable
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException("Average of elements of an empty collection cannot be calculated");
            }

            dynamic sum = default(T);
            foreach (var item in items)
            {
                sum += item;
            }

            return (double)sum / (double)items.Count();
        }

        public static T Product<T>(this IEnumerable<T> items) where T : IComparable
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException("Product of elements of an empty collection cannot be calculated");
            }

            dynamic product = 1;
            foreach (var item in items)
            {
                product *= item;
            }

            return product;
        }

        public static T Max<T>(this IEnumerable<T> items) where T : IComparable
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException("The maximum element of an empty collection cannot be calculated");
            }

            dynamic maxValue = default(T);
            foreach (var item in items)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                }
            }

            return maxValue;
        }

        public static T Min<T>(this IEnumerable<T> items) where T : IComparable
        {
            if (items.Count() == 0)
            {
                throw new ArgumentException("The minimum element of an empty collection cannot be calculated");
            }

            dynamic minValue = items.First();
            foreach (var item in items)
            {
                if (item < minValue)
                {
                    minValue = item;
                }
            }

            return minValue;
        }

    }
}
