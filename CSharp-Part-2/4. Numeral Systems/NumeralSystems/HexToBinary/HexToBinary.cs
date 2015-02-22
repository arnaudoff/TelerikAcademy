// Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Text;

class HexToBinary
{
    static void Main()
    {
        // Note that this preserves leading zeros
        Dictionary<char, string> hexAlpha = new Dictionary<char, string>();
        hexAlpha.Add('1', "0001");
        hexAlpha.Add('2', "0010");
        hexAlpha.Add('3', "0011");
        hexAlpha.Add('4', "0100");
        hexAlpha.Add('5', "0101");
        hexAlpha.Add('6', "0110");
        hexAlpha.Add('7', "0111");
        hexAlpha.Add('8', "1000");
        hexAlpha.Add('9', "1001");
        hexAlpha.Add('A', "1010");
        hexAlpha.Add('a', "1010");
        hexAlpha.Add('B', "1011");
        hexAlpha.Add('b', "1011");
        hexAlpha.Add('C', "1100");
        hexAlpha.Add('c', "1100");
        hexAlpha.Add('D', "1101");
        hexAlpha.Add('d', "1101");
        hexAlpha.Add('E', "1110");
        hexAlpha.Add('e', "1110");
        hexAlpha.Add('F', "1111");
        hexAlpha.Add('f', "1111");

        Console.Write("Enter a hexadecimal number: ");
        string inputStr = Console.ReadLine();      
        StringBuilder result = new StringBuilder();
        foreach (char token in inputStr)
        {
            result.Append(hexAlpha[token]);
        }

        Console.WriteLine("Result: {0}", result);
    }
}