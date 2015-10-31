namespace LongestSubseqOfEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> sampleNumbers = new List<int>() { 2, 5, 5, 2, 2, 2, 3, 3, 4, 4, 4, 4, 6, 6, 6, 6, 6, 6 };

            var result = FindLongestSubsequenceOfEqualNumbers(sampleNumbers);

            foreach (var number in result)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }

        public static List<int> FindLongestSubsequenceOfEqualNumbers(IList<int> numbers)
        {
            int maxSequenceCount = 0;
            int maxSequenceNumber = 0;

            int currentSequenceCount = 1;
            int currentSequenceNumber = numbers[0];

            bool inSequence = false;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    if (currentSequenceNumber != numbers[i])
                    {
                        currentSequenceNumber = numbers[i];
                        inSequence = true;
                    }

                    currentSequenceCount++;
                }
                else if (inSequence)
                {
                    if (currentSequenceCount > maxSequenceCount)
                    {
                        maxSequenceCount = currentSequenceCount;
                        maxSequenceNumber = currentSequenceNumber;
                    }

                    inSequence = false;
                    currentSequenceCount = 1;
                }
            }

            // Checking is also done here so the last element is also counted if the last sequence is the longest. It's better than doing it every iteration.
            if (currentSequenceCount > maxSequenceCount)
            {
                maxSequenceCount = currentSequenceCount;
                maxSequenceNumber = currentSequenceNumber;
            }

            return Enumerable.Repeat(maxSequenceNumber, maxSequenceCount).ToList();
        }
    }
}
