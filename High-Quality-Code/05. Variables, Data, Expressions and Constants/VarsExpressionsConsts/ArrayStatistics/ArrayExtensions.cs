namespace ArrayStatistics
{
    using System;
    using System.Linq;

    public static class ArrayExtensions
    {
        public static T GetMin<T>(this T[] items) where T : IComparable
        {
            return items.Min();
        }

        public static T GetMax<T>(this T[] items) where T : IComparable
        {
            return items.Max();
        }

        public static T GetAverage<T>(this T[] items) where T : IComparable
        {
            dynamic sum = 0;

            for (int i = 0; i < items.Length; i++)
            {
                sum += items[i];
            }

            return (T)(sum / items.Length);
        }
    }
}
