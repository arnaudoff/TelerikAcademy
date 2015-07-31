namespace PerformanceComparer.SortingAlgorithms
{
    using System;

    public static class SelectionSort<T> where T : IComparable
    {
        public static void Sort(T[] list)
        {
            int k;
            T temp;

            for (int i = 0; i < list.Length; i++)
            {
                k = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j].CompareTo(list[k]) < 0)
                    {
                        k = j;
                    }
                }

                temp = list[i];
                list[i] = list[k];
                list[k] = temp;
            }
        }
    }
}
