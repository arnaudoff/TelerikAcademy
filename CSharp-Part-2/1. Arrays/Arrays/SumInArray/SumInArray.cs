// Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class SumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter sum: ");
        int inputSum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array contents: ");
        int[] inputArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        int[] resultSeq = GetSequence(inputArray, inputSum);
        if (resultSeq[0] == -1 && resultSeq[1] == -1)
        {
            Console.WriteLine("No sequence found.");
        }
        else
        {
            for (int i = resultSeq[0]; i < resultSeq[1]; i++)
            {
                Console.Write("{0} ", inputArray[i]);
            }
        }


    }

    static int[] GetSequence(int[] inputArray, int inputSum)
    {
        // This is an O(n^2) solution. There could be a better one. 

        int length = inputArray.Length;
        int[] result = { -1, -1 };
        for (int i = 0; i < length; i++)
        {
            int currentSum = inputArray[i];
            for (int j = i + 1; j <= length; j++)
            {
                if (currentSum == inputSum)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
                if (currentSum > inputSum || j == length)
                {
                    break;
                }
                currentSum += inputArray[j];
            }
        }
        return result;
    }
}