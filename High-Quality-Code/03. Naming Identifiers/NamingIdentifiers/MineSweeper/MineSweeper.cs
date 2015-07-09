namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Minesweeper
    {
        private const int MAX_SCORE = 35;
        private const int MAX_FIELD_ROWS = 5;
        private const int MAX_FIELD_COLS = 10;

        public static void Main(string[] аргументи)
        {
            char[,] gameField = GenerateGameField();
            char[,] bombs = PlaceMines();
            List<Score> scoreBoard = new List<Score>(6);

            int row = 0;
            int col = 0;
            int currentScore = 0;

            bool isPlayerAtGameStart = true;
            bool hitMine = false;
            bool hasPlayerWon = false;

            string command = string.Empty;

            do
            {
                if (isPlayerAtGameStart)
                {
                    Console.WriteLine("Let's play “Minesweeper”. Try your luck finding out the fields without mines." +
                    " The command 'top' shows the scoreboard, 'restart' starts a new game and 'exit' quits the game.");
                    PrintField(gameField);

                    isPlayerAtGameStart = false;
                }

                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintScoreBoard(scoreBoard);
                        break;
                    case "restart":
                        gameField = GenerateGameField();
                        bombs = PlaceMines();

                        PrintField(gameField);

                        hitMine = false;
                        isPlayerAtGameStart = false;
                        break;
                    case "exit":
                        Console.WriteLine("Exiting..");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                PlayerTurn(gameField, bombs, row, col);
                                currentScore++;
                            }

                            if (MAX_SCORE == currentScore)
                            {
                                hasPlayerWon = true;
                            }
                            else
                            {
                                PrintField(gameField);
                            }
                        }
                        else
                        {
                            hitMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError: invalid command given.\n");
                        break;
                }

                if (hitMine)
                {
                    PrintField(bombs);
                    Console.Write("\nYou died. Score: {0}. Please enter your nickname: ", currentScore);
                    string playerNickname = Console.ReadLine();

                    Score currentPlayerScore = new Score(playerNickname, currentScore);
                    if (scoreBoard.Count < 5)
                    {
                        scoreBoard.Add(currentPlayerScore);
                    }
                    else
                    {
                        for (int i = 0; i < scoreBoard.Count; i++)
                        {
                            if (scoreBoard[i].Points < currentPlayerScore.Points)
                            {
                                scoreBoard.Insert(i, currentPlayerScore);
                                scoreBoard.RemoveAt(scoreBoard.Count - 1);
                                break;
                            }
                        }
                    }

                    scoreBoard.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    scoreBoard.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    PrintScoreBoard(scoreBoard);

                    gameField = GenerateGameField();
                    bombs = PlaceMines();
                    currentScore = 0;
                    hitMine = false;
                    isPlayerAtGameStart = true;
                }

                if (hasPlayerWon)
                {
                    Console.WriteLine("\nCongratulation. You have won the game!.");
                    PrintField(bombs);
                    Console.WriteLine("Insert your nickname: ");
                    string playerNickname = Console.ReadLine();

                    Score currentPlayerScore = new Score(playerNickname, currentScore);
                    scoreBoard.Add(currentPlayerScore);

                    PrintScoreBoard(scoreBoard);

                    gameField = GenerateGameField();
                    bombs = PlaceMines();
                    currentScore = 0;
                    hasPlayerWon = false;
                    isPlayerAtGameStart = true;
                }
            }
            while (command != "exit");

            Console.Read();
        }

        private static void PrintScoreBoard(List<Score> points)
        {
            Console.WriteLine("\nScoreboard:");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} => {2} points", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty scoreboard!\n");
            }
        }

        private static void PlayerTurn(char[,] gameField, char[,] bombs, int row, int col)
        {
            char minesCount = CountMines(bombs, row, col);
            bombs[row, col] = minesCount;
            gameField[row, col] = minesCount;
        }

        private static void PrintField(char[,] gameField)
        {
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0} ", gameField[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] GenerateGameField()
        {
            char[,] gameField = new char[MAX_FIELD_ROWS, MAX_FIELD_COLS];

            for (int row = 0; row < MAX_FIELD_ROWS; row++)
            {
                for (int col = 0; col < MAX_FIELD_COLS; col++)
                {
                    gameField[row, col] = '?';
                }
            }

            return gameField;
        }

        private static char[,] PlaceMines()
        {
            char[,] gameField = new char[MAX_FIELD_ROWS, MAX_FIELD_COLS];

            for (int row = 0; row < MAX_FIELD_ROWS; row++)
            {
                for (int col = 0; col < MAX_FIELD_COLS; col++)
                {
                    gameField[row, col] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();

            while (randomNumbers.Count < 15)
            {
                Random random = new Random();
                int newRandom = random.Next(50);
                if (!randomNumbers.Contains(newRandom))
                {
                    randomNumbers.Add(newRandom);
                }
            }

            foreach (int randomNumber in randomNumbers)
            {
                int col = randomNumber / MAX_FIELD_COLS;
                int row = randomNumber % MAX_FIELD_COLS;

                if (row == 0 && randomNumber != 0)
                {
                    col--;
                    row = MAX_FIELD_COLS;
                }
                else
                {
                    row++;
                }

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void CalculateFieldValues(char[,] gameField)
        {
            for (int row = 0; row < MAX_FIELD_ROWS; row++)
            {
                for (int col = 0; col < MAX_FIELD_COLS; col++)
                {
                    if (gameField[row, col] != '*')
                    {
                        char minesCount = CountMines(gameField, row, col);
                        gameField[row, col] = minesCount;
                    }
                }
            }
        }

        private static char CountMines(char[,] gameField, int row, int col)
        {
            int mineCount = 0;

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, col] == '*')
                {
                    mineCount++;
                }
            }

            if (row + 1 < MAX_FIELD_ROWS)
            {
                if (gameField[row + 1, col] == '*')
                {
                    mineCount++;
                }
            }

            if (col - 1 >= 0)
            {
                if (gameField[row, col - 1] == '*')
                {
                    mineCount++;
                }
            }

            if (col + 1 < MAX_FIELD_COLS)
            {
                if (gameField[row, col + 1] == '*')
                {
                    mineCount++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameField[row - 1, col - 1] == '*')
                {
                    mineCount++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < MAX_FIELD_COLS))
            {
                if (gameField[row - 1, col + 1] == '*')
                {
                    mineCount++;
                }
            }

            if ((row + 1 < MAX_FIELD_ROWS) && (col - 1 >= 0))
            {
                if (gameField[row + 1, col - 1] == '*')
                {
                    mineCount++;
                }
            }

            if ((row + 1 < MAX_FIELD_ROWS) && (col + 1 < MAX_FIELD_COLS))
            {
                if (gameField[row + 1, col + 1] == '*')
                {
                    mineCount++;
                }
            }

            return char.Parse(mineCount.ToString());
        }
    }
}
