/*
 * Write a program that can solve these tasks:
 *    Reverses the digits of a number
 *    Calculates the average of a sequence of integers
 *    Solves a linear equation a * x + b = 0
 * Create appropriate methods.
 * Provide a simple text-based menu for the user to choose which task to solve.
 * Validate the input data:
 *    The decimal number should be non-negative
 *    The sequence should not be empty
 *    a should not be equal to 0
 */

using System;
using System.Linq;
using System.Threading;

class SolveTasks
{
    static int currentSelection = 0;
    private static string[] mainMenu = { "Reverse a number", "Calculate average", "Solve linear equation", "Exit"};
    static string selector = "> ";
    static void Main()
    {
        while (true)
        {
            PrintMenu(mainMenu);
            HandleInput();
            Thread.Sleep(150);
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

    static double SolveLinearEquation(double a, double b)
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
        switch (currentSelection)
        {
            case 0:
                Console.Clear();
                Console.Write("Enter a number: ");
                double number = double.Parse(Console.ReadLine());
                while (number < 0)
                {
                    Console.Write("Invalid decimal number (should be non-negative). Enter a new one: ");
                    number = double.Parse(Console.ReadLine());
                }
                Console.WriteLine(Reverse(number));
                Environment.Exit(0);                
                break;
            case 1:
                Console.Clear();
                Console.Write("Enter array size: ");
                int arraySize = int.Parse(Console.ReadLine());
                int[] array = new int[arraySize];
                Console.Write("Enter array contents [{0}]: ", arraySize);
                string[] inputArray = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                while (inputArray.Length == 0)
                {
                    Console.Write("Invalid sequence. Please enter a non-empty sequence: ");
                    inputArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                }
                for (int i = 0; i < arraySize; i++)
                {
                    array[i] = int.Parse(inputArray[i]);
                }
                Console.WriteLine(CalculateAverage(array));
                Environment.Exit(0);    
                break;
            case 2:
                Console.Clear();
                Console.Write("Enter first coefficient: ");
                double firstCoefficient = double.Parse(Console.ReadLine());
                while (firstCoefficient == 0)
                {
                    Console.Write("Invalid input (a should be a non-zero value). Enter a new coefficient: ");
                    firstCoefficient = double.Parse(Console.ReadLine());
                }
                Console.Write("Enter second coefficient: ");
                double secondCoefficient = double.Parse(Console.ReadLine());
                Console.WriteLine("x = {0}", SolveLinearEquation(firstCoefficient, secondCoefficient));
                Environment.Exit(0);
                break;
            case 3:
                Console.Clear();
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
                Console.Write(selector + menu[i]);
            }
            else
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - menu[i].Length / 2, Console.WindowHeight / 2 + 2 * i);
                Console.Write(menu[i]);
            }
        }
    }
}