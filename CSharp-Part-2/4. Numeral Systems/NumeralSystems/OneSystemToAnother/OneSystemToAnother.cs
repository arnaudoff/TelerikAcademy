// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;

class OneSystemToAnother
{
    static void Main()
    {
        Console.WriteLine(NToMBase(103, 3, 4));
    }

    static double NToMBase(int number, int firstBase, int secondBase)
    {
        int decResult = NtoDecimal(number, firstBase);
        return DecimalToN(decResult, secondBase);
    }
    static int NtoDecimal(int number, int numBase)
    {
        int res = 0;
        int digit = 0;
        int power = 0;
        while (number > 0)
        {
            digit = number % 10;
            res += digit * (int)Math.Pow(numBase, power);
            power++;
            number /= 10;
        }
        return res;
    }

    static double DecimalToN(int number, int numBase)
    {
        int digit = 0;
        double result = 0;
        int power = 0;
        while (number > 0)
        {
            digit = number % numBase;
            result += digit* (int)Math.Pow(10, power); ;
            number /= numBase;
            power++;
        }
        return result;
    }
}
