/*
 * We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
 * Assume that repeating the same subset several times is not a problem.
 * Hint: you may check for zero each of the 32 subsets with 32 if statements.
 */

using System;
using System.Collections.Generic;

class ZeroSubset
{
    static void Main()
    {
        int[] inputNumbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter number {0}: ", i + 1);
            inputNumbers[i] = int.Parse(Console.ReadLine());
        }

        int count = 0;
        List<List<int>> finalOut = new List<List<int>>();

        /*
         * Since we have 5 integers, we will create something similar to a bit mask (but for an entire number, not a bit) to match each of the numbers. 
         * That way we iterate through all of the possible combinations with ease. If the bit is 1, we add up to the sum and then check whether the sum equals 0.
         */

        for (int i = 1; i <= 31; i++)
        {
            List<int> outNumbers = new List<int>();
            int currentSum = 0;
            for (int j = 0; j < 5; j++)
            {
                int mask = 1 << j;        
                int nAndMask = i & mask;  
                int bit = nAndMask >> j;  
                if (bit == 1)
                {
                    currentSum += inputNumbers[j];
                    outNumbers.Add(inputNumbers[j]);
                }
            }
            if (currentSum == 0)
            {
                count++;
                // TODO: Compare the contents of the parent list members with the current instance of outNumbers to avoid duplicates in the result.
                finalOut.Add(outNumbers);
            }
        }
        if (count > 0)
        {
            foreach (var sublist in finalOut)
            {
                int itCount = 0;
                foreach (var value in sublist)
                {
                    Console.Write(value);
                    if (itCount != sublist.Count - 1)
                    {
                        Console.Write('+');
                    }
                    itCount++;
                }
                Console.Write(" = 0");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No zero subset.");
        }
    }
}