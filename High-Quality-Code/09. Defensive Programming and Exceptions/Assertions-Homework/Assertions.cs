namespace AssertionsHomework
{
    using System;
    using System.Diagnostics;

    public class AssertionsHomework
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("Array contents: [{0}]", string.Join(", ", arr));

            arr.SelectionSort();
            Console.WriteLine("Sorted: [{0}]", string.Join(", ", arr));

            // new int[0].SelectionSort();
            new int[1].SelectionSort();

            Console.WriteLine(arr.BinarySearch(-1000));
            Console.WriteLine(arr.BinarySearch(0));
            Console.WriteLine(arr.BinarySearch(17));
            Console.WriteLine(arr.BinarySearch(10));
            Console.WriteLine(arr.BinarySearch(1000));
        }
    }
}