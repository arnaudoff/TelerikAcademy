namespace AssertionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    public static class ArrayExtensions
    {
        public static void SelectionSort<T>(this T[] arr) where T : IComparable<T>
        {
            CheckArrayValidity(arr);

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            Debug.Assert(CollectionUtils.IsSorted(arr), "Collection is still not sorted.");
        }

        public static int BinarySearch<T>(this T[] arr, T value) where T : IComparable<T>
        {
            CheckArrayValidity(arr);
            Debug.Assert(value != null, "Value cannot be null.");
            Debug.Assert(CollectionUtils.IsSorted(arr), "Collection should be sorted in order to perform a binary search.");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            CheckIndexValidity(arr, startIndex, endIndex);

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            Debug.Assert(!CollectionUtils.HasValue(arr, value), "The collection has the value, but returns otherwise.");
            return -1;
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            CheckIndexValidity(arr, startIndex, endIndex);

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(CollectionUtils.HasValue(arr, arr[minElementIndex]), "Element with the found index does not exist in the collection.");
            Debug.Assert(
                CollectionUtils.IsMinValue(arr, arr[minElementIndex], startIndex, endIndex), 
                "Element with the found index does not have the smallest value in the collection.");

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            Debug.Assert(x != null && y != null, "Cannot perform swap on a null variable.");

            T oldX = x;
            x = y;
            y = oldX;
        }

        private static void CheckArrayValidity<T>(T[] arr)
        {
            Debug.Assert(arr != null, "Array cannot be null.");
            Debug.Assert(arr.Length != 0, "Array cannot be of zero length.");
        }

        private static void CheckIndexValidity<T>(T[] arr, int startIndex, int endIndex)
        {
            Debug.Assert(startIndex <= endIndex, "Start index cannot be bigger than end index");
            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Start index is out of range.");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "End index is out of range.");
        }
    }
}
