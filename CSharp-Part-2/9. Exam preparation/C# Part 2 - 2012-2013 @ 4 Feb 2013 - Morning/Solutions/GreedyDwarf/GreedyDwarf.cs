using System;
using System.Linq;

class GreedyDwarf
{
    static void Main()
    {
        int[] valley = ReadArray(Console.ReadLine());
        int patternCount = int.Parse(Console.ReadLine());
        int maxCoinsCollected = int.MinValue;

        for (int i = 0; i < patternCount; i++)
        {
            int[] pattern = ReadArray(Console.ReadLine());
            bool[] isVisited = new bool[valley.Length];

            int currentIndex = 0;
            int currentCoinsCollected = valley[currentIndex];
            isVisited[currentIndex] = true;

            for (int j = 0;; j++)
            {
                if (j > pattern.Length - 1)
                {
                    j -= pattern.Length;
                }

                currentIndex += pattern[j];
                if (currentIndex < 0 || currentIndex > valley.Length - 1 || isVisited[currentIndex])
                {
                    break;
                }

                currentCoinsCollected += valley[currentIndex];
                isVisited[currentIndex] = true;
            }

            if (currentCoinsCollected > maxCoinsCollected)
            {
                maxCoinsCollected = currentCoinsCollected;
            }
        }
        Console.WriteLine(maxCoinsCollected);
    }

    private static int[] ReadArray(string strArray)
    {
        int[] arr = strArray.Split(new char[]{ ',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToArray();
        return arr;
    }
}