// Write a boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckBitAtPos
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int inputPosition = int.Parse(Console.ReadLine());

        int mask = 1 << inputPosition;
        int result = (inputNumber & mask) >> inputPosition;
        Console.WriteLine(Convert.ToBoolean(result));
    }
}
