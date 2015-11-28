namespace Portals
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

    public class Cell
    {
        public Cell(int row, int col, int power)
        {
            this.Row = row;
            this.Col = col;
            this.Power = power;
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public long Power { get; set; }

        public bool IsVisited { get; set; }
    }

    public class Startup
    {
        static Cell[,] matrix;
        static long result = 0;

        static void Main(string[] args)
        {
            int[] xy = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int startX = xy[0];
            int startY = xy[1];

            int[] rc = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int r = rc[0];
            int c = rc[1];

            matrix = new Cell[r, c];

            for (int i = 0; i < r; i++)
            {
                string[] row = Console.ReadLine().Split(' ').ToArray();

                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = new Cell(i, j, 0);

                    if (row[j] == "#") 
                    {
                        matrix[i, j].Power = -1;
                    }
                    else
                    {
                        matrix[i, j].Power = long.Parse(row[j]);
                    }
                }
            }

            Bfs(matrix[startX, startY]);
            result += matrix[startX, startY].Power;

            Console.WriteLine(result);
        }

        public static void Bfs(Cell start)
        {
            Queue<Cell> queue = new Queue<Cell>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                Cell cell = queue.Dequeue();

                Cell nextCell = new Cell(-1337, -1337, -1337);
                
                // up
                if (cell.Row - cell.Power >= 0 && matrix[cell.Row - cell.Power, cell.Col].IsVisited == false)
                {
                    nextCell = matrix[cell.Row - cell.Power, cell.Col];
                }

                // right

                if (cell.Col + cell.Power < matrix.GetLength(1) && matrix[cell.Row, cell.Col + cell.Power].IsVisited == false)
                {
                    if (matrix[cell.Row, cell.Col + cell.Power].Power > nextCell.Power)
                    {
                        nextCell = matrix[cell.Row, cell.Col + cell.Power];
                    }
                }

                // down 

                if (cell.Row + cell.Power < matrix.GetLength(0) && matrix[cell.Row + cell.Power, cell.Col].IsVisited == false)
                {
                    if (matrix[cell.Row + cell.Power, cell.Col].Power > nextCell.Power)
                    {
                        nextCell = matrix[cell.Row + cell.Power, cell.Col];
                    }
                }

                // left 

                if (cell.Col - cell.Power >= 0 && matrix[cell.Row, cell.Col - cell.Power].IsVisited == false)
                {
                    if (matrix[cell.Row, cell.Col - cell.Power].Power > nextCell.Power)
                    {
                        nextCell = matrix[cell.Row, cell.Col - cell.Power];
                    }
                }

                if (nextCell.Row == -1337 && nextCell.Col == -1337 && nextCell.Power == -1337)
                {
                    break;
                }
                else
                {
                    matrix[nextCell.Row, nextCell.Col].IsVisited = true;
                    queue.Enqueue(nextCell);
                    result += nextCell.Power;
                }
            }
        }
    }
}
