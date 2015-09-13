namespace RotatingWalkInMatrix
{
    using System;

    public class Position
    {
        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public static Position operator +(Position first, Position second)
        {
            if (first == null)
            {
                throw new ArgumentNullException("First position cannot be null.");
            }

            if (second == null)
            {
                throw new ArgumentNullException("Second position cannot be null.");
            }

            return new Position(first.Row + second.Row, first.Col + second.Col);
        }

        public int Row { get; set; }

        public int Col { get; set; }
    }
}
