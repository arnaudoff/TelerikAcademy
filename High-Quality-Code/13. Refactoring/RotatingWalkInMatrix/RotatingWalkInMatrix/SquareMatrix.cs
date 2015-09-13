namespace RotatingWalkInMatrix
{
    using System;
    using System.Text;

    public class SquareMatrix
    {
        private const int MaxSize = 100;
        private const int StartingNumber = 1;
        private const int DirectionsCount = 8;

        private int size;
        private int[,] matrix;

        public SquareMatrix(int size)
        {
            this.Size = size;
            this.matrix = new int[this.Size, this.Size];
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value < 0 || value > SquareMatrix.MaxSize)
                {
                    throw new ArgumentOutOfRangeException("Size", string.Format("Matrix size cannot be a negative number and shouldn't be more than {0}.", SquareMatrix.MaxSize));
                }

                this.size = value;
            }
        }

        public int[,] Matrix
        {
            get
            {
                return this.matrix;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Size; i++)
            {
                StringBuilder rowResult = new StringBuilder();

                for (int j = 0; j < this.Size; j++)
                {
                    rowResult.Append(this.matrix[i, j]);
                }

                result.Append(rowResult);
                result.AppendLine();
            }

            return result.ToString();
        }

        private void PrintMatrix()
        {
            Console.WriteLine(new string('-', 50));
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    Console.Write("{0,3}", this.matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        public void RotatingWalk()
        {
            int startingNumber = SquareMatrix.StartingNumber;
            Direction currentDirection = Direction.DownRight;
            Position currentPosition = new Position(0, 0);
            this.matrix[currentPosition.Row, currentPosition.Col] = startingNumber;
            
            while (startingNumber <= this.Size * this.Size)
            {
                Position nextPosition = currentPosition + GetPositionChangeByDirection(currentDirection);

                if (HasEmptyNeighbour(nextPosition))
                {
                    if (!IsPositionValid(nextPosition))
                    {
                        currentDirection = GetNextPossibleDirection(currentDirection, currentPosition);
                        nextPosition = currentPosition + GetPositionChangeByDirection(currentDirection);
                    }
                }
                else
                {
                    nextPosition = FindFirstEmptyCell();
                    currentDirection = GetNextPossibleDirection(currentDirection, nextPosition);
                    if (nextPosition == null)
                    {
                        break;
                    }
                }

                currentPosition = nextPosition;
                this.matrix[currentPosition.Row, currentPosition.Col] = ++startingNumber;
                PrintMatrix();
            }

        }

        // TODO: Extract all of these in RotationWalkUtils.cs or something
        private bool HasEmptyNeighbour(Position position)
        {
            int topRow = position.Row < 0 ? position.Row + 1: position.Row;
            int bottomRow = position.Row > this.Size - 1 ? position.Row - 1 : position.Row;
            int leftCol = position.Col < 0 ? position.Col + 1 : position.Col;
            int rightCol = position.Col > this.Size - 1 ? position.Col - 1 : position.Col;

            for (int row = topRow; row <= bottomRow; row++)
            {
                for (int col = leftCol; col <= rightCol; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private Direction GetNextPossibleDirection(Direction currentDirection, Position currentPosition)
        {
            int currentDirectionNumber = 0;
            Direction direction = currentDirection;
            Position nextPosition = currentPosition + GetPositionChangeByDirection(currentDirection);

            while (!IsPositionValid(nextPosition))
            {
                direction = (Direction)(((int)currentDirection + currentDirectionNumber) % DirectionsCount);
                nextPosition = currentPosition + GetPositionChangeByDirection(direction);
                currentDirectionNumber++;
            }

            return direction;
        }

        private bool IsPositionValid(Position position) 
        {
            return (position.Row >= 0 && position.Row < this.Size) && (position.Col >= 0 && position.Col < this.Size);
        }

        private Position FindFirstEmptyCell()
        {
            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    if (this.matrix[i, j] == 0)
                    {
                        return new Position(i, j);
                    }
                }
            }

            return null;
        }

        private Position GetPositionChangeByDirection(Direction direction)
        {
            switch (direction)
            {
                case Direction.DownRight:
                    return new Position(1, 1);
                case Direction.Down:
                    return new Position(1, 0);
                case Direction.DownLeft:
                    return new Position(1, -1);
                case Direction.Left:
                    return new Position(0, -1);
                case Direction.UpLeft:
                    return new Position(-1, -1);
                case Direction.Up:
                    return new Position(-1, 0);
                case Direction.UpRight:
                    return new Position(-1, 1);
                case Direction.Right:
                    return new Position(0, 1);
                default:
                    throw new ArgumentException("Invalid direction specified.");
            }
        }
    }
}
