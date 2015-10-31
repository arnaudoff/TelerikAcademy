namespace CalculateSequenceWithQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var result = CalculateSequence(2, 50);

            foreach (var number in result)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }

        public static IEnumerable<int> CalculateSequence(int startingNumber, int sequenceLength)
        {
            var result = new List<int>();
            var sequence = new Queue<int>();

            // S1 = N;
            sequence.Enqueue(startingNumber);

            // Load up the queue with elements and add some to the resulting sequence
            int currentSequenceLength = 0;
            while (currentSequenceLength < sequenceLength)
            {
                var element = sequence.Dequeue();

                result.Add(element);

                sequence.Enqueue(element + 1);
                sequence.Enqueue((2 * element) + 1);
                sequence.Enqueue(element + 2);

                currentSequenceLength += 3;
            }

            // Empty the rest of the queue into the result
            while (sequence.Count > 0)
            {
                result.Add(sequence.Dequeue());
            }

            return result;
        }
    }
}
