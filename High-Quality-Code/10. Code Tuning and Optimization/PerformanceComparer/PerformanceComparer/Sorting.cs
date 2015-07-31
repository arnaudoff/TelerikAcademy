namespace PerformanceComparer
{
    using System;
    using SortingAlgorithms;

    public static class Sorting
    {
        public static TimeSpan Insertion(int[] arr)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                InsertionSort<int>.Sort(arr);
            });
        }

        public static TimeSpan Insertion(double[] arr)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                InsertionSort<double>.Sort(arr);
            });
        }

        public static TimeSpan Insertion(string[] arr)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                InsertionSort<string>.Sort(arr);
            });
        }

        public static TimeSpan Selection(int[] arr)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                SelectionSort<int>.Sort(arr);
            });
        }

        public static TimeSpan Selection(double[] arr)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                SelectionSort<double>.Sort(arr);
            });
        }

        public static TimeSpan Selection(string[] arr)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                SelectionSort<string>.Sort(arr);
            });
        }

        public static TimeSpan Quick(int[] arr)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                QuickSort<int>.Sort(arr, 0, arr.Length - 1);
            });
        }

        public static TimeSpan Quick(double[] arr)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                QuickSort<double>.Sort(arr, 0, arr.Length - 1);
            });
        }

        public static TimeSpan Quick(string[] arr)
        {
            return ExecutionUtils.CalculateTime(() =>
            {
                QuickSort<string>.Sort(arr, 0, arr.Length - 1);
            });
        }
    }
}
