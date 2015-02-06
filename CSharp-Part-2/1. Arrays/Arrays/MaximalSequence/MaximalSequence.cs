// Write a program that finds the maximal sequence of equal elements in an array.

using System;

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
            int tempMember = 0;
            int tempCount = 0;
            int highestCount = 0;
            int arrIndex = 1;
            while (arrIndex < arrSize)
            {
                if (inputArray[arrIndex] == inputArray[arrIndex - 1])
                {
                    tempMember = inputArray[arrIndex];
                    if (tempCount > 0)
                    {
                        tempCount++;
                    }
                    else
                    {
                        tempCount += 2;
                    }
                }
                else
                {
                    tempCount = 0;
                }
                if (tempCount > highestCount)
                {
                    highestCount = tempCount;
                }
                arrIndex++;
            }
            for (int i = 0; i < highestCount; i++)
            {
                Console.Write("{0} ", tempMember);
            }
            Console.WriteLine();
        }
    }
}