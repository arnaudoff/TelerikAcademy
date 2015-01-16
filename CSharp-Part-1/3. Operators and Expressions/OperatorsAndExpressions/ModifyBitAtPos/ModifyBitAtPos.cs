/*
 * We are given an integer number n, a bit value v (v=0 or 1) and a position p.
 * Write a sequence of operators (a few lines of C# code) that modifies 
 * n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
 */

using System;

class ModifyBitAtPos
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int inputPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit (0 / 1): ");
        int inputBit = int.Parse(Console.ReadLine());
        int mask = 1 << inputPosition;

        switch(inputBit)
        {
            case 0:
                inputNumber &= ~mask;
                break;
            case 1:
                inputNumber |= mask;
                break;
        }
        Console.WriteLine(inputNumber);
    }
}
