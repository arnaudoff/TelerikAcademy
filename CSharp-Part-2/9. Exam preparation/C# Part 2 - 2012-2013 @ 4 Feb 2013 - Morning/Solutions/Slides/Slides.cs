using System;
using System.Linq;

class Slides
{
    static void Main()
    {
        // Read cube dimensions
        string[] line = Console.ReadLine().Split(' ');
        int cuboidWidth = int.Parse(line[0]);
        int cuboidHeigth = int.Parse(line[1]);
        int cuboidDepth = int.Parse(line[2]);

        // Read cube contents
        string[, ,] cuboid = new string[cuboidWidth, cuboidHeigth, cuboidDepth];
        for (int h = 0; h < cuboidHeigth; h++)
        {
            string[] row = Console.ReadLine().Split('|');
            for (int d = 0; d < cuboidDepth; d++)
            {
                string[] cubes = row[d].Trim().Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < cuboidWidth; w++)
                {
                    cuboid[w, h, d] = cubes[w];
                }
            }
        }

        // Read ball's starting coords
        line = Console.ReadLine().Split(' ');
        int ballWidth = 0;
        int ballHeight = 0;
        int ballDepth = 0;

        // Falling logic
        int nextWidth = int.Parse(line[0]);
        int nextHeight = 0;
        int nextDepth = int.Parse(line[1]);
        bool canFall = true;
        string currentCube = "";
        while (canFall)
        {
            if (nextHeight == cuboidHeigth)
            {
                break;
            }

            if (0 > nextWidth || nextWidth > cuboidWidth - 1 || 0 > nextDepth || nextDepth > cuboidDepth - 1)
            {
                canFall = false;
                break;
            }

            ballWidth = nextWidth;
            ballHeight = nextHeight;
            ballDepth = nextDepth;

            // Read the cube inside the cuboid
            currentCube = cuboid[nextWidth, nextHeight, nextDepth];
            
            // Ball command logic
            char command = currentCube[0];
            switch (command)
            {
                // Basket
                case 'B': 
                    canFall = false; 
                    break;
                // Empty
                case 'E': 
                    nextHeight++;
                    break;
                // Teleport
                case 'T':
                    int[] coord = currentCube.Substring(2).Split(' ')
                        .Select(x => int.Parse(x)).ToArray();
                    nextWidth = coord[0];
                    nextDepth = coord[1];
                    break;
                // Slide
                case 'S':
                    nextHeight++;
                    string direction = currentCube.Substring(2);
                    switch (direction)
                    {
                        case "L": 
                            nextWidth--; 
                            break;
                        case "R": 
                            nextWidth++; 
                            break;
                        case "F":
                            nextDepth--;
                            break;
                        case "B":
                            nextDepth++;
                            break;
                        case "FL": 
                            nextWidth--;
                            nextDepth--; 
                            break;
                        case "FR":
                            nextWidth++;
                            nextDepth--;
                            break;
                        case "BL":
                            nextWidth--;
                            nextDepth++;
                            break;
                        case "BR":
                            nextWidth++;
                            nextDepth++;
                            break;
                    }
                    break;
            }

        }

        // Final result
        Console.WriteLine(canFall ? "Yes" : "No");
        Console.WriteLine("{0} {1} {2}", ballWidth, ballHeight, ballDepth);
    }
}