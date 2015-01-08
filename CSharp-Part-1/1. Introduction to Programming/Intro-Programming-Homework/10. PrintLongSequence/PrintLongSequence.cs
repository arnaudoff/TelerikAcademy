// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

using System;

class PrintLongSequence
{
    static void Main()
    {

        Console.Write(2);
        for (int i = 3; i < 1002; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(", " + i);
            }
            else
            {
                Console.Write(", " + -i);
            }
        }

        Console.WriteLine();
    }
}
