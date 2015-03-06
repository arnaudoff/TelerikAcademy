using System;
using System.Collections.Generic;

class Third
{
    static void Main()
    {

        string[] strMatrixDimensions = Console.ReadLine().Split(' ');
        int matrixHeight = int.Parse(strMatrixDimensions[0]);
        int matrixWidth = int.Parse(strMatrixDimensions[1]);

        int numberOfMoves = int.Parse(Console.ReadLine());
        string[] directions = new string[numberOfMoves];
        int[] moves = new int[numberOfMoves];
        for (int i = 0; i < numberOfMoves; i++)
        {
            string[] directionAndMove = Console.ReadLine().Split(' ');
            directions[i] = directionAndMove[0];
            moves[i] = int.Parse(directionAndMove[1]);
        }

        int[,] field = new int[matrixHeight, matrixWidth];
        bool[,] passedField = new bool[matrixHeight, matrixWidth];

        FillMatrix(field);

        string currentDirection;
        int currentMoveCount = 0;
        int[] currentBishopPosition = {matrixHeight - 1, 0};
        passedField[currentBishopPosition[0], currentBishopPosition[1]] = true;
        int moveIndex = 0;
        int sum = 0;
        while (moveIndex < numberOfMoves)
        {
            currentDirection = directions[moveIndex];
            currentMoveCount = moves[moveIndex] - 1;
            bool moveHasEnded = false;
            for (int i = 0; i < currentMoveCount && moveHasEnded == false; i++)
            {
                switch (currentDirection)
                {
                    case "UR":
                    case "RU":
                        if (currentBishopPosition[0] - 1 < 0 || currentBishopPosition[1] + 1 > field.GetLength(1) - 1)
                        {
                            moveHasEnded = true;
                        }
                        else
                        {
                            currentBishopPosition[0] = currentBishopPosition[0] - 1; // height
                            currentBishopPosition[1] = currentBishopPosition[1] + 1; // width
                        }
                        break;
                    case "UL":
                    case "LU":
                        if (currentBishopPosition[0] - 1 < 0 || currentBishopPosition[1] - 1 < 0)
                        {
                            moveHasEnded = true;
                        }
                        else
                        {
                            currentBishopPosition[0] = currentBishopPosition[0] - 1; // height
                            currentBishopPosition[1] = currentBishopPosition[1] - 1; // width
                        }
                        break;
                    case "DL":
                    case "LD":
                        if (currentBishopPosition[0] + 1 > field.GetLength(0) - 1 || currentBishopPosition[1] - 1 < 0)
                        {
                            moveHasEnded = true;
                        }
                        else
                        {
                            currentBishopPosition[0] = currentBishopPosition[0] + 1; // height
                            currentBishopPosition[1] = currentBishopPosition[1] - 1; // width
                        }
                        break;
                    case "DR":
                    case "RD":
                        if (currentBishopPosition[0] + 1 > field.GetLength(0) - 1 || currentBishopPosition[1] + 1 > field.GetLength(1) - 1)
                        {
                            moveHasEnded = true;
                        }
                        else
                        {
                            currentBishopPosition[0] = currentBishopPosition[0] + 1; // height
                            currentBishopPosition[1] = currentBishopPosition[1] + 1; // width
                        }
                        break;
                }
                if (!passedField[currentBishopPosition[0], currentBishopPosition[1]])
                {
                    sum += field[currentBishopPosition[0], currentBishopPosition[1]];
                    passedField[currentBishopPosition[0], currentBishopPosition[1]] = true;
                }
            }
            moveIndex++;
        }
        Console.WriteLine(sum);
    }

    static void FillMatrix(int[,] field)
    {
        int currentX = 0;
        for (int col = 0; col < field.GetLength(1); col++)
        {
            int currentY = currentX;
            if (col == 0)
            {
                currentY = 0;
            }
            for (int row = field.GetLength(0) - 1; row >= 0; row--)
            {
                field[row, col] = currentY;
                currentY += 3;
            }
            currentX += 3;
        }
    }
}