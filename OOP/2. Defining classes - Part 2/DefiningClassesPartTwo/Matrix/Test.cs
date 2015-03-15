namespace Matrices
{
    using System;

    public class Test
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

            Matrix<double> firstMatrix = new Matrix<double>(firstRow, firstCol);
            Matrix<double> secondMatrix = new Matrix<double>(secondRow, secondCol);

            Fill(firstMatrix);
            Fill(secondMatrix);
            Matrix<double> res = firstMatrix * secondMatrix; // Also works with addition and substraction

            Console.WriteLine("Multiplication result: ");
            // Use this to check the result: http://www.wolframalpha.com/input/?i=matrix+multiplication+calculator
            Console.WriteLine(res.ToString());
        }

        private static void Fill<T>(Matrix<T> matrix) where T : IComparable<T>
        {
            Console.WriteLine("Please enter a matrix: ");
            for (int row = 0; row < matrix.Rows; row++)
            {
                string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.Cols; col++)
                {
                    matrix[row, col] = (T)Convert.ChangeType(currentRow[col], typeof(T));
                }
            }
        }
    }
}
