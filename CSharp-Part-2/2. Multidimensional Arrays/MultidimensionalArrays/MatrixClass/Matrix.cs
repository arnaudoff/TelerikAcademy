using System;

public class Matrix
{
    int rows;
    int cols;
    int[,] matrix;

    // Constructor
    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        this.matrix = new int[rows, cols];
    }

    // Overload the indexer
    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    // Fill the matrix
    public void Fill()
    {
        Console.WriteLine("Please enter a matrix: ");
        for (int row = 0; row < this.rows; row++)
        {
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < this.cols; col++)
            {
                this.matrix[row, col] = int.Parse(currentRow[col]);
            }
        }
    }
}