using System;

class TaskFour
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int width = 2 * n + 1;
        int height = 2 * n + 1;

        int startingDistance = width - 2;
        for (int rows = 0; rows < height / 2; rows++)
        {
            Console.Write(new string('#', rows));
            Console.Write('\\');
            Console.Write(new string(' ', startingDistance));
            Console.Write('/');
            Console.Write(new string('#', rows));
            Console.WriteLine();
            startingDistance -= 2;
        }
        Console.Write(new string('#', width / 2));
        Console.Write("X");
        Console.Write(new string('#', width / 2));
        Console.WriteLine();
        startingDistance = 1;
        for (int rows = height / 2 - 1; rows >= 0; rows--)
        {
            Console.Write(new string('#', rows));
            Console.Write('/');
            Console.Write(new string(' ', startingDistance));
            Console.Write('\\');
            Console.Write(new string('#', rows));
            Console.WriteLine();
            startingDistance += 2;
        }
    }
}