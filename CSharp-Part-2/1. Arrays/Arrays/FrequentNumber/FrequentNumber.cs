// Write a program that finds the most frequent number in an array.

using System;
using System.Collections.Generic;
using System.Linq;

class FrequentNumber
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter array contents: ");
        int[] inputArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }


        int[] uniqueArray = inputArray.Distinct().ToArray();
        Dictionary<int, int> elementsCount = new Dictionary<int, int>();
        for (int i = 0; i < uniqueArray.Length; i++)
        {
            elementsCount.Add(uniqueArray[i], 0);
        }
        for (int i = 0; i < inputArray.Length; i++)
        {
            int currentCount = 0;
            elementsCount.TryGetValue(inputArray[i], out currentCount);
            elementsCount[inputArray[i]] = currentCount + 1;
        }

        int maxOccurences = 0;
        int number = 0;
        foreach (KeyValuePair<int, int> pair in elementsCount)
        {
            if (pair.Value > maxOccurences)
            {
                maxOccurences = pair.Value;
                number = pair.Key;
            }
        }

        Console.WriteLine("{0} ({1} times)", number, maxOccurences);
    }
}