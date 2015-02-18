using System;
using System.Text;

public class Matrix
{
    int rows;
    int cols;
    int[,] matrix;
    const string delimiter = " "; // Matrix elements separator. Could be an escape sequence.

    // Constructor
    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        this.matrix = new int[rows, cols];
    }

    // A setter and a getter for the rows and cols to simply modify/extract values.
    public int Rows
    {
        get
        {
            return this.rows;
        }
        set
        {
            this.rows = value;
        }
    }

    public int Cols
    {
        get
        {
            return this.cols;
        }
        set
        {
            this.cols = value;
        }
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

    // Override the ToString() method
    public override string ToString()
    {
        StringBuilder res = new StringBuilder();

        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Cols; col++)
            {
                res.Append(this.matrix[row, col] + delimiter);
            }
            res.AppendLine();
        }

        return res.ToString();
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

    // Overload the addition operator
    public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
    {
        if (firstMatrix.Cols != secondMatrix.Cols || firstMatrix.Rows != secondMatrix.Rows)
        {
            throw new Exception("Matrices are with different dimensions.");
        }

        Matrix res = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                res[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
            }
        }

        return res;
    }

    // Overload the substraction operator
    public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
    {
        if (firstMatrix.Cols != secondMatrix.Cols || firstMatrix.Rows != secondMatrix.Rows)
        {
            throw new Exception("Matrices are with different dimensions.");
        }

        Matrix res = new Matrix(firstMatrix.Rows, firstMatrix.Cols);

        for (int row = 0; row < firstMatrix.Rows; row++)
        {
            for (int col = 0; col < firstMatrix.Cols; col++)
            {
                res[row, col] = firstMatrix[row, col] - secondMatrix[row, col];
            }
        }

        return res;
    }

    // Overload the multiply operator
    public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
    {
        if (firstMatrix.Cols != secondMatrix.Rows)
        {
            throw new Exception("Matrices are with different dimensions.");
        }

        Matrix res = new Matrix(firstMatrix.Rows, secondMatrix.Cols);
        int tmp;

        for (int matrixRow = 0; matrixRow < res.Rows; matrixRow++)
        {
            for (int matrixCol = 0; matrixCol < res.Cols; matrixCol++)
            {
                tmp = 0;
                for (int index = 0; index < res.Cols; index++)
                {
                    tmp += firstMatrix[matrixRow, index] * secondMatrix[index, matrixCol];
                }
                res[matrixRow, matrixCol] = tmp;
            }
        }

        return res;
    }
}