// Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter matrix size [n]: ");
        byte inputNumber = byte.Parse(Console.ReadLine());

        for (byte i = 0; i < inputNumber; i++)
        {
            for (byte j = 1; j <= inputNumber; j++)
            {
                Console.Write("{0} ", j + i);
            }
            Console.WriteLine();
        }
    }
}