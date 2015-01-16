﻿/*
 * Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
 * The bits are counted from right to left, starting from bit #0.
 * The result of the expression should be either 1 or 0.
 */

using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int inputNumer = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int res = (inputNumer & mask) >> 3;
        Console.WriteLine(res);
    }
}
