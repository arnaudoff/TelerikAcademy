namespace PerformanceComparer
{
    using System;

    public static class InsertionSort<T> where T : IComparable
    {
        public static void Sort(T[] entries)
        {
            Sort(entries, 0, entries.Length - 1);
        }

        public static void Sort(T[] entries, int first, int last)
        {
            for (var i = first + 1; i <= last; i++)
            {
                var entry = entries[i];
                var j = i;

                while (j > first && entries[j - 1].CompareTo(entry) > 0)
                {
                    entries[j] = entries[--j];
                }

                entries[j] = entry;
            }
        }
    }
}
