using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int width = N * 2 + 1;
        int height = 6 + ((N - 3) / 2) * 3;

        Console.Write(new string('.', N));
        Console.Write('*');
        Console.Write(new string('.', N));
        Console.WriteLine();
        int i;
        for (i = 1; i < N; i++)
        {
            Console.Write(new string('.', N-i));
            Console.Write("*");
            Console.Write(new string('.', i-1));
            Console.Write("*");
            Console.Write(new string('.', i-1));
            Console.Write("*");
            Console.Write(new string('.', N-i));
            Console.WriteLine();
        }
        Console.WriteLine(new string('*', width));

        for (i = 1; i < height - N - 1; i++)
        {
            Console.Write(new string('.', i));
            Console.Write('*');
            Console.Write(new string('.', N-i-1));
            Console.Write('*');
            Console.Write(new string('.', N-i-1));
            Console.Write('*');
            Console.Write(new string('.', i));
            Console.WriteLine();
        }
        Console.Write(new string('.', i));
        Console.Write(new string('*', N));
        Console.Write(new string('.', i));
        Console.WriteLine();
    }
}