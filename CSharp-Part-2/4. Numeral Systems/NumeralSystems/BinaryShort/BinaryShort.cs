// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main()
    {
        short firstNumber = 4;
        Console.WriteLine(GetBinaryRepresentation(firstNumber));
        short secondNumber = 5;
        Console.WriteLine(GetBinaryRepresentation(secondNumber));
    }

    static string GetBinaryRepresentation(short n)
    {
        char[] b = new char[16];
        int pos = 15;
        int i = 0;

        while (i < 16)
        {
            if ((n & (1 << i)) != 0)
            {
                b[pos] = '1';
            }
            else
            {
                b[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(b);
    }
}