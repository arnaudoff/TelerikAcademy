// Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;

class MatrixClass
{
    static void Main()
    {
        Matrix first = new Matrix(3, 3);
        first.Fill();

        // Print first one
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write("{0} ", first[row, col]);
            }
            Console.WriteLine();
        }

        Matrix second = new Matrix(3, 5);
        second.Fill();

        // Print first one
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                Console.Write("{0} ", second[row, col]);
            }
            Console.WriteLine();
        }


    }
}
