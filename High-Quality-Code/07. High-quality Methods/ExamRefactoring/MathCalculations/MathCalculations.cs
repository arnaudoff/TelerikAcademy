namespace MathCalculations
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public static class MathCalculations
    {
        public static void Main()
        {
            // Read input
            string inputStr = Console.ReadLine();

            string[] initialInputSequence = inputStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] convertedInputSequence = new long[initialInputSequence.Length];
            for (long i = 0; i < initialInputSequence.Length; i++)
            {
                convertedInputSequence[i] = long.Parse(initialInputSequence[i]);
            }

            // Calculations
            long sequenceIndex = 1;

            List<long> oddNumbers = new List<long>();

            while (sequenceIndex < convertedInputSequence.Length)
            {
                long absoluteDifference = CalculateAbsoluteDifference(convertedInputSequence[sequenceIndex], convertedInputSequence[sequenceIndex - 1]);
                if (absoluteDifference % 2 != 0)
                {
                    oddNumbers.Add(absoluteDifference);
                    ++sequenceIndex;
                }
                else
                {
                    sequenceIndex += 2;
                    if (sequenceIndex > convertedInputSequence.Length)
                    {
                        break;
                    }
                }
            }

            BigInteger sum = 0;
            foreach (long num in oddNumbers)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }

        public static long CalculateAbsoluteDifference(long a, long b)
        {
            return Math.Max(a, b) - Math.Min(a, b);
        }
    }
}