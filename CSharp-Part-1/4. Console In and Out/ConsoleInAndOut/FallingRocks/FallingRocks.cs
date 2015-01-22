/*
 * Implement the "Falling Rocks" game in the text console.
 * A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
 * A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
 * Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
 * Ensure a constant game speed by Thread.Sleep(150).
 * Implement collision detection and scoring system.
 */

using System;
using System.Threading;

class Program
{
    static char [,] gameMatrix;
    static int currentDwarfPos;
    static bool dwarfIsAlive = true;
    // Initialize a random seed
    static Random randomGenerator = new Random();
    static char[] rocksCharacters = {'^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-'};
    static int maxWindowHeight;
    static int maxWindowWidth;
    static int currentScore;

    static void GameFieldInit(int maxWindowHeight, int maxWindowWidth)
    {
        gameMatrix = new char[maxWindowHeight, maxWindowWidth];

        Console.BufferWidth = Console.WindowWidth;
        Console.BufferHeight = Console.WindowHeight;
        // Fill the whole matrix without the last row
        for (int row = 0; row < maxWindowHeight - 1; row++)
        {
            for (int col = 0; col < maxWindowWidth; col++)
            {
                gameMatrix[row, col] = ' ';
            }
        }

        // Fill out the dwarf
        currentDwarfPos = (maxWindowWidth / 2) - 1;
        gameMatrix[maxWindowHeight - 1, currentDwarfPos - 1] = '(';
        gameMatrix[maxWindowHeight - 1, currentDwarfPos] = 'O';
        gameMatrix[maxWindowHeight - 1, currentDwarfPos + 1] = ')';
    }
    static void DrawField()
    {
        Console.Clear();
        for (int i = 0; i < maxWindowHeight; i++)
        {
            for (int j = 0; j < maxWindowWidth - 1; j++)
            {
                /* This is for the colours, by default commented out because it slows down the matrix updating. 
                 * An idea on how to improve this would be appreciated.
                 * 
                switch (gameMatrix[i, j])
                {
                    case '^':
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case '@':
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case '*':
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case '&':
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case '+':
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break; 
                    case '%':
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case '$':
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case '#':
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case '!':
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case '.':
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    case ';':
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                 */
                Console.Write(gameMatrix[i, j]);
            }
            // This fixes the index exception
            if (i == maxWindowHeight - 1)
            {
                continue;
            }
            Console.WriteLine();
        }
    }
    static void MoveDwarfLeft()
    {
        if (currentDwarfPos > 1)
        {
            currentDwarfPos--;
            gameMatrix[maxWindowHeight - 1, currentDwarfPos - 1] = '(';
            gameMatrix[maxWindowHeight - 1, currentDwarfPos] = 'O';
            gameMatrix[maxWindowHeight - 1, currentDwarfPos + 1] = ')';
            gameMatrix[maxWindowHeight - 1, currentDwarfPos + 2] = ' ';
        }
    }
    static void MoveDwarfRight()
    {
        if (currentDwarfPos < maxWindowWidth - 3)
        {
            currentDwarfPos++;
            gameMatrix[maxWindowHeight - 1, currentDwarfPos - 1] = '(';
            gameMatrix[maxWindowHeight - 1, currentDwarfPos] = 'O';
            gameMatrix[maxWindowHeight - 1, currentDwarfPos + 1] = ')';
            gameMatrix[maxWindowHeight - 1, currentDwarfPos - 2] = ' ';
        }
    }
    static char[] GenerateRandomRocks()
    {
        // This is used to generate random characters in the interval one to four (as in the example picture)
        int amountOfRocksPerLine = randomGenerator.Next(1, 4);
        char[] rocksArr = new char[maxWindowWidth - 1];
        // Fill the rocks array with spaces
        for (int i = 0; i < maxWindowWidth - 1; i++)
        {
            rocksArr[i] = ' ';
        }
        // Fill it with some random chars
        for (int i = 0; i < amountOfRocksPerLine; i++)
        {
            int rocksIndex = randomGenerator.Next(0, 11); // random index from the rocks array
            int matrixIndex = randomGenerator.Next(0, maxWindowWidth - 1); // random index from the game matrix
            rocksArr[matrixIndex] = rocksCharacters[rocksIndex]; // merge the result
        }
        return rocksArr;
    }
 
    static void MoveDwarf()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            if (keyPressed.Key == ConsoleKey.LeftArrow)
            {
                MoveDwarfLeft();
            }
            if (keyPressed.Key == ConsoleKey.RightArrow)
            {
                MoveDwarfRight();
            }
            if (keyPressed.Key == ConsoleKey.Escape)
            {
                Console.WriteLine();
                Environment.Exit(0);
            }
        }
    }
    static void Main()
    {
        maxWindowHeight = Console.WindowHeight;
        maxWindowWidth = Console.WindowWidth;
        GameFieldInit(maxWindowHeight, maxWindowWidth);

        int currentLine = 0;
        // Main game loop
        while (dwarfIsAlive)
        {
            // Collision detection 
            if ((gameMatrix[maxWindowHeight - 2, currentDwarfPos] != ' ') || (gameMatrix[maxWindowHeight - 2, currentDwarfPos - 1] != ' ') || (gameMatrix[maxWindowHeight - 2, currentDwarfPos + 1] != ' '))
            {
                dwarfIsAlive = false;
            }
            else
            {
                // Only if the dwarf has reached the rocks part
                if (currentLine > maxWindowHeight - 2)
                {
                    currentScore++;
                }
            }
            // Replace the current row with the previous
            for (int i = maxWindowHeight - 2; i > 0; i--)
            {
                for (int j = 0; j < maxWindowWidth - 1; j++)
                {
                    gameMatrix[i, j] = gameMatrix[i - 1, j];
                }
            }
            char[] rocks = GenerateRandomRocks();
            // Fill the row with the randomly generated rocks
            for (int i = 0; i < maxWindowWidth - 1; i++)
            {
                gameMatrix[0, i] = rocks[i];
            }
            DrawField();
            MoveDwarf();
            currentLine++;
            Thread.Sleep(50);
        }
        Console.WriteLine();
        Console.WriteLine("You've died. Score: {0}", currentScore);
    }
}
