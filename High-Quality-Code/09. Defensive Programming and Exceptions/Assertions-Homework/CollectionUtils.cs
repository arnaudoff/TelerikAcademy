namespace AssertionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CollectionUtils
    {
        public static bool IsSorted<T>(IEnumerable<T> list) where T : IComparable<T>
        {
            if (list.Count() > 0)
            {
                var firstElement = list.First();
                return list.Skip(1).All(x =>
                {
                    bool result = firstElement.CompareTo(x) < 0;
                    firstElement = x;
                    return result;
                });
            }
            else
            {
                return true;
            }
        }

        public static bool HasValue<T>(IEnumerable<T> list, T value) where T : IComparable<T>
        {
            return list.Any(x => x.Equals(value));
        }

        public static bool IsMinValue<T>(IEnumerable<T> list, T value, int startIndex, int endIndex) where T : IComparable<T>
        {
            return list.Skip(startIndex)
                .Take(endIndex - startIndex)
                .Min()
                .CompareTo(value) > -1;
        }
    }
}
