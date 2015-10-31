namespace ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = 5;
            int m = 16;

            var shortestSequence = GetShortestSequence(n, m);
            Console.WriteLine(string.Join(" -> ", shortestSequence));
        }

        public static List<int> GetShortestSequence(int start, int end)
        {
            // The hint is to use a queue, but we clearly need a LIFO data structure (i.e 5 is added last, but is first displayed)
            Stack<int> sequence = new Stack<int>();

            int currentNumber = end;
            while (start <= currentNumber)
            {
                sequence.Push(currentNumber);

                if (currentNumber / 2 >= start)
                {
                    if (currentNumber % 2 == 0)
                    {
                        currentNumber /= 2;
                    }
                    else
                    {
                        currentNumber--;
                    }
                }
                else
                {
                    if (currentNumber - 2 >= start)
                    {
                        currentNumber -= 2;
                    }
                    else
                    {
                        currentNumber--;
                    }
                }
            }

            // Conversion is done with the default enumerator (the current value popped is added to the list respectively)
            return sequence.ToList();
        }
    }
}
