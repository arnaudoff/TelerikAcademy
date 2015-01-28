// Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;

class SpiralMatrix
{
    static void Main()
    {
        /* 
         * Disclaimer: if you've *also* struggled to do this task, I recommend you check out this article - http://dobromirivanov.net/c-csharp-spiral-matrix/. 
         * My code uses his idea of filling the matrix, which is probably not the best solution, but is easily understandable. In short, you keep counting till you reach 
         * the end of the matrix or a number that isn't 0 (already filled) and you change direction.
         */
        Console.WriteLine("Enter matrix size [n]: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n]; // Since we haven't studied arrays yet, this is a 2D array or a "matrix". Look it up for a better explanation :)
        int row = 0;
        int col = 0;
        string direction = "right";
 
        int maxIterations = n * n; // We store n^2 here because using it as a condition in the for loop would calculate it every iteration

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
                Console.Write("{0,2} ", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }
}