/*
 * Implement the "Falling Rocks" game in the text console.
 * A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
 * A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
 * Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
 * Ensure a constant game speed by Thread.Sleep(150).
 * Implement collision detection and scoring system.
 */

using System;
using System.Linq;
using System.Threading;

class Program
{
    private static Random random = new Random();
    public static string GetRandomAlphaNumeric(int len)
    {
        var chars = "^     @       *      &      +      %       $       #      !      .     ;     -";
        var result = new string(
            Enumerable.Repeat(chars, len)
                      .Select(s => s[random.Next(s.Length)])
                      .ToArray());
        return result.ToString();
    }
    static void Main()
    {
        int maxWindowWidth = Console.WindowWidth;
        int maxWindowHeight = Console.WindowHeight;
        char[,] gameMatrix = new char[maxWindowHeight-1, maxWindowWidth];
        int currentDwarfPos = (maxWindowWidth / 2) - 1;
        Console.CursorVisible = false;
        Console.SetCursorPosition(0, maxWindowHeight-1);

        Console.Write(new string(' ', currentDwarfPos - 1));
        Console.Write("(O)");
        while (true)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < maxWindowHeight - 1; i++)
            {
                string randomStr = GetRandomAlphaNumeric(maxWindowWidth);
                for (int j = 0; j < maxWindowWidth; j++)
                {
                    gameMatrix[i, j] = randomStr[j];
                    Console.Write("{0}", gameMatrix[i, j]);
                }
            }
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                while (Console.KeyAvailable) { Console.ReadKey(true); }
                if (keyPressed.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    currentDwarfPos -= 1;
                    if (currentDwarfPos < 1)
                    {
                        currentDwarfPos = 0;
                    }
                }
                if (keyPressed.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    currentDwarfPos += 1;
                    if (currentDwarfPos > maxWindowWidth - 4)
                    {
                        currentDwarfPos = maxWindowWidth - 4;
                    }
                }
                if (keyPressed.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine();
                    Environment.Exit(0);
                }
            }
            Console.SetCursorPosition(0, maxWindowHeight - 1);
            Console.Write(new string(' ', currentDwarfPos));
            Console.Write("(O)");
        }
    }
}
