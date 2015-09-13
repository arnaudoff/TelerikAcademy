using System;
namespace RotatingWalkInMatrix
{
    public class RotatingWalkInMatrix
    {
        public static void Main(string[] args)
        {
            SquareMatrix matrix = new SquareMatrix(5);
            matrix.RotatingWalk();
            Console.WriteLine(matrix.ToString());
        }
    }
}

