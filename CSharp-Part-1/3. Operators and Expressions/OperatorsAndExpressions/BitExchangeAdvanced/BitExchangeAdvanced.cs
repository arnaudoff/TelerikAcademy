/*
 * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
 * The first and the second sequence of bits may not overlap.
 */

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        long inputNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter first position (p): ");
        int firstSequencePosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second position (q): ");
        int secondSequencePosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter sequence length (k): ");
        int sequenceLength = int.Parse(Console.ReadLine());

        if (firstSequencePosition + sequenceLength - 1 > 31 || secondSequencePosition + sequenceLength - 1 > 31)
        {
            Console.WriteLine("The resultant sequence can not exceed a 32-bit unsigned integer");
        }
        else if (secondSequencePosition < firstSequencePosition + sequenceLength - 1 && firstSequencePosition < secondSequencePosition + 1)
        {
            Console.WriteLine("The sequences can not overlap.");
        }
        else
        {
            long firstSequence = (inputNumber >> firstSequencePosition) & ((1L << sequenceLength) - 1);
            long secondSequence =  (inputNumber >> secondSequencePosition) & ((1L << sequenceLength) - 1);
            long xoredSequences = (firstSequence ^ secondSequence);
            xoredSequences = (xoredSequences << firstSequencePosition) | (xoredSequences << secondSequencePosition);
            long result = inputNumber ^ xoredSequences;
            Console.WriteLine(result);
        }
    }
}
