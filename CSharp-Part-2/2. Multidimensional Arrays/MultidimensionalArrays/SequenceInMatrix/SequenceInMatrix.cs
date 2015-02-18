/*
 * We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
 * Write a program that finds the longest sequence of equal strings in the matrix.
 */

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter row count: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter col count: ");
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }

        string bestHorizontalSeq = "";
        int bestCount = 0;
        int currentCount = 1;
        var bestDictionaryValues = new Dictionary<string, int>();

        for (int row = 0; row < rows; row++)
        {
            currentCount = 1;
            for (int col = 0; col < cols - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentCount++;
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestHorizontalSeq = matrix[row, col];
                    }
                }
            }
        }

        bestDictionaryValues.Add(bestHorizontalSeq, bestCount);

        bestCount = 0;
        string bestVerticalSeq = "";
        for (int col = 0; col < cols; col++)
        {
            currentCount = 1;
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentCount++;
                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestVerticalSeq = matrix[row, col];
                    }
                }
            }
        }

        bestDictionaryValues.Add(bestVerticalSeq, bestCount);

        string bestDiagonalSeq = "";
        bestCount = 0;
        currentCount = 1;
        for (int row = 0, col = 0; row < rows - 1 && col < cols - 1; row++, col++)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                currentCount++;
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestDiagonalSeq = matrix[row, col];
                }
            }
        }

        if (!bestDictionaryValues.ContainsKey(bestDiagonalSeq))
        {
            bestDictionaryValues.Add(bestDiagonalSeq, bestCount);
        }
        else
        {
            if (bestDictionaryValues[bestDiagonalSeq] < bestCount)
            {
                bestDictionaryValues[bestDiagonalSeq] = bestCount;
            }
        }

        int bestValue = bestDictionaryValues.Values.Max();
        string bestKey = "";
        foreach (KeyValuePair<string, int> pair in bestDictionaryValues)
        {
            if (bestValue.Equals(pair.Value))
            {
                bestKey = pair.Key;
            }
        }

        Console.WriteLine(string.Join(", ", Enumerable.Repeat(bestKey, bestValue)));
    }
}