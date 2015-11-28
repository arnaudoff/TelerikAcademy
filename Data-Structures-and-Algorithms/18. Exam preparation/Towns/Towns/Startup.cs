namespace Towns
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] longestIncreasingPath = new int[3, n];
            for (int i = 0; i < n; i++)
            {
                longestIncreasingPath[0, i] = int.Parse(Console.ReadLine().Split(new[] { ' ' }).ToArray()[0]);
                longestIncreasingPath[1, i] = 1;
                longestIncreasingPath[2, i] = 1;
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if ((longestIncreasingPath[0, j] < longestIncreasingPath[0, i]) && (longestIncreasingPath[1, j] + 1 > longestIncreasingPath[1, i]))
                    {
                        longestIncreasingPath[1, i] = longestIncreasingPath[1, j] + 1;
                    }
                }
            }

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = i; j < n; j++)
                {
                    if ((longestIncreasingPath[0, j] < longestIncreasingPath[0, i]) && (longestIncreasingPath[2, j] + 1 > longestIncreasingPath[2, i]))
                    {
                        longestIncreasingPath[2, i] = longestIncreasingPath[2, j] + 1;
                    }
                }
            }

            int max = longestIncreasingPath[1, 0] + longestIncreasingPath[2, 0] - 1;

            for (int i = 0; i < n; i++)
            {
                int newDistance = longestIncreasingPath[1, i] + longestIncreasingPath[2, i] - 1;
                if (newDistance > max)
                {
                    max = newDistance;
                }
            }

            Console.WriteLine(max);
        }
    }
}
