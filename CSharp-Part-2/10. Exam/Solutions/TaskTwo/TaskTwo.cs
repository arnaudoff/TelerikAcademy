using System;
using System.Collections.Generic;
using System.Numerics;

class Second
{
    static void Main()
    {
        // Read input
        string inputStr = Console.ReadLine();

        string[] strInputSequence = inputStr.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        long[] inputSequence = new long[strInputSequence.Length];
        for (long i = 0; i < strInputSequence.Length; i++)
        {
            inputSequence[i] = long.Parse(strInputSequence[i]);
        }

        // Calculations

        long seqIndex = 1;
        List<long> oddNumbers = new List<long>();
        while (seqIndex < inputSequence.Length)
        {
            long absDifference = CalculateAbsoluteDifference(inputSequence[seqIndex], inputSequence[seqIndex - 1]);
            if (absDifference % 2 != 0)
            {
                oddNumbers.Add(absDifference);
                ++seqIndex;
            }
            else
            {
                seqIndex += 2;
                if (seqIndex > inputSequence.Length)
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

    static long CalculateAbsoluteDifference(long a, long b)
    {
        return Math.Max(a, b) - Math.Min(a, b);
    }

}