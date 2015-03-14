namespace Matrices
{
    using System;

    class Test
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

            Matrix<int> first = new Matrix<int>(firstRow, firstCol);
            Matrix<int> second = new Matrix<int>(secondRow, secondCol);

            first.Fill();
            second.Fill();
            Matrix<int> res = first * second;

            Console.WriteLine("Multiplication result: ");
            for (int row = 0; row < res.Rows; row++)
            {
                for (int col = 0; col < res.Cols; col++)
                {
                    Console.Write("{0} ", res[row, col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("As a string: ");
            Console.WriteLine(res.ToString());
        }
    }
}
