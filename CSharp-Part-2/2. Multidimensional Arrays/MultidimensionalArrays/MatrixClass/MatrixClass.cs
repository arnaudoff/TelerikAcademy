// Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;

class MatrixClass
{
    static void Main()
    {
        Console.WriteLine("Enter first matrix row count: ");
        int firstRow = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter first matrix column count: ");
        int firstCol = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second matrix row count: ");
        int secondRow = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second matrix column count: ");
        int secondCol = int.Parse(Console.ReadLine());

        Matrix first = new Matrix(firstRow, firstCol);
        Matrix second = new Matrix(secondRow, secondCol);
        first.Fill();
        second.Fill();

        Matrix res = first * second; // also works with a + or a -

        // Print multiplied matrix
        Console.WriteLine("Multiplication result: ");
        for (int row = 0; row < res.Rows; row++)
        {
            for (int col = 0; col < res.Cols; col++)
            {
                Console.Write("{0} ", res[row, col]);
            }
            Console.WriteLine();
        }
        // Print resultant matrix as a string
        Console.WriteLine("As a string: ");
        Console.WriteLine(res.ToString());
    }
}
