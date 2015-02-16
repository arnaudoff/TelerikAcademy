// Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;

class FillMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter matrix size: ");
        int matrixSize = int.Parse(Console.ReadLine());

        int[,] matrix = new int[matrixSize, matrixSize];
        int start = 1;
        for (int cols = 0; cols < matrixSize; cols++)
        {
            for (int rows = 0; rows < matrixSize; rows++)
            {
                matrix[rows, cols] = start++;
            }
        }

        Console.WriteLine("A) ");
        for (int rows = 0; rows < matrixSize; rows++)
        {
            for (int cols = 0; cols < matrixSize; cols++)
            {
                Console.Write("{0,3}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }

        start = 1;
        for (int cols = 0; cols < matrixSize; cols++)
        {
            if (cols % 2 == 0)
            {
                if (cols != 0)
                {
                    start = start + matrixSize;
                }
                for (int rows = 0; rows < matrixSize; rows++)
                {
                    matrix[rows, cols] = start++;
                }
            }
            else
            {
                start = start + matrixSize;
                for (int rows = 0; rows < matrixSize; rows++)
                {
                    matrix[rows, cols] = --start;
                }
            }
        }

        Console.WriteLine("B) ");
   
        for (int rows = 0; rows < matrixSize; rows++)
        {
            for (int cols = 0; cols < matrixSize; cols++)
            {
                Console.Write("{0,3}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }

        for (int rows = 0; rows < matrixSize; rows++)
        {
            for (int cols = 0; cols < matrixSize; cols++)
            {
                matrix[rows, cols] = 0;
            }
        }

        int number = 1;
        int currentRow;

        for (int row = matrixSize - 1; row >= 0; row--)
        {
            currentRow = row;
            for (int col = 0; col < matrixSize - row; col++)
            {
                matrix[currentRow++, col] = number++;
            }
        }

        number = matrixSize * matrixSize;

        for (int row = 0; row < matrixSize - 1; row++)
        {
            currentRow = row;
            for (int col = matrixSize - 1; currentRow >= 0; col--)
            {
                matrix[currentRow--, col] = number--;
            }
        }
        Console.WriteLine("C) ");
        for (int rows = 0; rows < matrixSize; rows++)
        {
            for (int cols = 0; cols < matrixSize; cols++)
            {
                Console.Write("{0,3}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("D) ");
        PrintSpiralMatrix(matrixSize);
    }

    static void PrintSpiralMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        string direction = "right";

        int maxIterations = n * n;

        for (int i = 1; i <= maxIterations; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }

            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }

            matrix[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                Console.Write("{0,3} ", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }
}