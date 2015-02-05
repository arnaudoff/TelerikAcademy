// Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the contents of the array [1, 2, 3]: ");
        string inputString = Console.ReadLine();
        string[] sInputArray = inputString.Split(new string[] {", "}, StringSplitOptions.None);

        int arrSize = sInputArray.Length;
        int[] inputArray = new int[arrSize];

        bool isSequencePresent = false;
        for (int i = 0; i < arrSize; i++)
        {
            inputArray[i] = Int32.Parse(sInputArray[i]);
            if (i != 0 && inputArray[i] == inputArray[i - 1])
            {
                isSequencePresent = true;
            }
        }

        if (!isSequencePresent)
        {
            Console.WriteLine("No sequence is present in the given array.");
        }
        else 
        {
            List<int> currentSequence = new List<int>();

            // TODO: Fix this
            int i = 0;
            while (i < arrSize)
            {
                if (inputArray[i] == inputArray[i + 1] && i < arrSize - 1)
                {
                    currentSequence.Add(inputArray[i]);
                    currentSequence.Add(inputArray[i]);
                    i += 2;
                }
                else if (inputArray[i] == currentSequence[i - 1])
                {
                    currentSequence.Add(inputArray[i]);
                }
            }
            foreach (int sequenceMember in currentSequence)
            {
                Console.Write("{0} ", sequenceMember);
            }
        }
    }
}