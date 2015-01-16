// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int inputPosition = int.Parse(Console.ReadLine());
        int mask = 1 << inputPosition;
        int res = (inputNumber & mask) >> inputPosition;
        Console.WriteLine(res);
    }
}
