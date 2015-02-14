// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter width: ");
        int cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        int rows = int.Parse(Console.ReadLine());

        int[,] numbersMatrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < cols; col++)
            {
                numbersMatrix[row, col] = int.Parse(currentRow[col]);
            }
        }

        int bestSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;
        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                // Another nested loop here would be an overkill, so sum the inside matrix manually.
                int currentSum = numbersMatrix[row, col] + numbersMatrix[row, col + 1] + numbersMatrix[row, col + 2]
                                 + numbersMatrix[row + 1, col] + numbersMatrix[row + 1, col + 1] + numbersMatrix[row + 1, col + 2]
                                 + numbersMatrix[row + 2, col] + numbersMatrix[row + 2, col + 2] + numbersMatrix[row + 2, col + 2];
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    maxRow = row;
                    maxCol = col;
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Max platform: ");
        Console.WriteLine("{0} {1} {2}", numbersMatrix[maxRow, maxCol], numbersMatrix[maxRow, maxCol + 1], numbersMatrix[maxRow, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", numbersMatrix[maxRow + 1, maxCol], numbersMatrix[maxRow + 1, maxCol + 1], numbersMatrix[maxRow + 1, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", numbersMatrix[maxRow + 2, maxCol], numbersMatrix[maxRow + 2, maxCol + 1], numbersMatrix[maxRow + 2, maxCol + 2]);
    }
}
