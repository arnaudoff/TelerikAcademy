// Write a method that reverses the digits of given decimal number.

using System;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        double inputNumber = double.Parse(Console.ReadLine());
        Console.WriteLine(Reverse(inputNumber));
    }
    static double Reverse(double number)
    {
        string reversedStr = new string(number.ToString().Reverse().ToArray());
        double reversedDouble;
        if (double.TryParse(reversedStr, out reversedDouble))
        {
            return reversedDouble;
        }
        else
        {
            return -1;
        }
    }
}
