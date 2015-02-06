// Write a program that finds the maximal increasing sequence in an array.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the contents of the array [1, 2, 3]: ");
        string inputString = Console.ReadLine();
        string[] sInputArray = inputString.Split(new string[] { ", " }, StringSplitOptions.None);
        int arrSize = sInputArray.Length;
        int[] inputArray = new int[arrSize];
        for (int i = 0; i < arrSize; i++)
        {
            inputArray[i] = Int32.Parse(sInputArray[i]);
        }

        int tempCount = 0;
        int arrIndex = 0;
        int highestCount = 0;
        int firstMember = 0;
        while (arrIndex < arrSize - 1)
        {
            if (inputArray[arrIndex] == inputArray[arrIndex + 1] - 1)
            {
                if (tempCount == 0)
                {
                    firstMember = inputArray[arrIndex];
                    tempCount += 2;
                }
                else
                {
                    tempCount++;
                }
                if (tempCount > highestCount)
                {
                    highestCount = tempCount;
                }
            }
            else
            {
                tempCount = 0;
            }
            arrIndex++;
        }

        for (int i = 0; i < highestCount; i++)
        {
            Console.Write("{0} ", firstMember);
            firstMember++;
        }
        Console.WriteLine();
    }
}