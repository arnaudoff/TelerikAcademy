/*
 * We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
 * Write a program that finds the longest sequence of equal strings in the matrix.
 */

using System;

class SequenceInMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter width: ");
        int cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        int rows = int.Parse(Console.ReadLine());

        string[,] numbersMatrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < cols; col++)
            {
                numbersMatrix[row, col] = currentRow[col];
            }
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0} ", numbersMatrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}