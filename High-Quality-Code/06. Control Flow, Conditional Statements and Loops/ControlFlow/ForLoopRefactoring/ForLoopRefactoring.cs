namespace ForLoopRefactoring
{
    using System;
    using System.Linq;

    public class ForLoopRefactoring
    {
        public static void Main()
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();
            PrintArrayElementsUntilValue(numbers, 11);
        }

        // This doesn't make any sense though.
        public static void PrintArrayElementsUntilValue(int[] numbers, int value)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0 && numbers[i] == value)
                {
                    Console.WriteLine("Value found!");
                    break;
                }

                Console.WriteLine(numbers[i]);
            }
        }
    }
}
