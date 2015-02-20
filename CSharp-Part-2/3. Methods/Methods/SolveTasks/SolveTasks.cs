using System;
using System.Linq;
using System.Threading;

class SolveTasks
{
    static int currentSelection = 0;
    private static string[] mainMenu = { "Reverse a number", "Calculate average", "Solve linear equation"};
    static string selector = "> ";
    static void Main()
    {
        while (true)
        {
            PrintMenu(mainMenu);
            HandleInput();
            Thread.Sleep(200);
            Console.Clear();
        }
    }

    static double Reverse(double number)
    {
        string reversedStr = new string(number.ToString().Reverse().ToArray());
        double reversedDouble;
        if (double.TryParse(reversedStr, out reversedDouble))
        {
            return reversedDouble;
        }
        else
        {
            return -1;
        }
    }

    static double CalculateAverage(int[] array)
    {
        return array.Average();
    }

    static int SolveLinearEquation(int a, int b)
    {
        return -b / a;
    }

    static void HandleInput()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.UpArrow)
            {
                currentSelection--;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                currentSelection++;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                CheckUserChoice();
            }

            if (currentSelection < 0)
            {
                currentSelection = mainMenu.GetLength(0) - 1;
            }
            else if (currentSelection > mainMenu.GetLength(0) - 1)
            {
                currentSelection = 0;
            }
        }
    }

    static void CheckUserChoice()
    {
        Console.Clear();
        switch (currentSelection)
        {
            case 0:
                Console.WriteLine("Enter a number: ");
                Console.WriteLine(Reverse(double.Parse(Console.ReadLine())));
                Environment.Exit(0);                
                break;
            case 1:
                Console.WriteLine("Enter array size: ");
                int arraySize = int.Parse(Console.ReadLine());
                int[] array = new int[arraySize];
                Console.WriteLine("Enter array contents [{0}]: ", arraySize);
                string[] inputArray = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < arraySize; i++)
                {
                    array[i] = int.Parse(inputArray[i]);
                }
                Console.WriteLine(CalculateAverage(array));
                Environment.Exit(0);    
                break;
            case 2:
                Console.WriteLine("Enter first coefficient: ");
                int firstCoefficient = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second coefficient: ");
                int secondCoefficient = int.Parse(Console.ReadLine());
                Console.WriteLine(SolveLinearEquation(firstCoefficient, secondCoefficient));
                Environment.Exit(0);
                break;
            case 3:
                Environment.Exit(0);
                break;
        }
    }

    private static void PrintMenu(string[] menu)
    {
           
        for (int i = 0; i < menu.GetLength(0); i++)
        {
            if (currentSelection == i)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - menu[i].Length / 2 - selector.Length, Console.WindowHeight / 2 + 2 * i);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(selector + menu[i]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(Console.WindowWidth / 2 - menu[i].Length / 2, Console.WindowHeight / 2 + 2 * i);
                Console.Write(menu[i]);
            }
        }
    }
}