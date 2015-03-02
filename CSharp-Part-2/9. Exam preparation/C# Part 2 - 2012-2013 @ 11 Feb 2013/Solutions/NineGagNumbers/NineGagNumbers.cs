using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class NineGagNumbers
{
    static BigInteger CalculatePower(int number, int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
    static void Main()
    {
        string nineGagNumber = Console.ReadLine();
        Dictionary<string, string> digitsDict = new Dictionary<string, string>
        {
            {"-!", "0"},
            {"**", "1"},
            {"!!!", "2"},
            {"&&", "3"},
            {"&-", "4"},
            {"!-", "5"},
            {"*!!!", "6"},
            {"&*!", "7"},
            {"!!**!-", "8"}
        };

        StringBuilder currentResult = new StringBuilder();
        StringBuilder finalResult = new StringBuilder();
        currentResult.Append(nineGagNumber[0]);
        for (int i = 1; i < nineGagNumber.Length; i++)
        {
            currentResult.Append(nineGagNumber[i]);
            if (digitsDict.ContainsKey(currentResult.ToString()))
            {
                finalResult.Append(digitsDict[currentResult.ToString()]);
                currentResult.Clear();
            }
            else
            {
                continue;
            }
        }

        Console.WriteLine(NtoDecimal(BigInteger.Parse(finalResult.ToString()), 9));
    }

    static BigInteger NtoDecimal(BigInteger number, int numBase)
    {
        BigInteger res = 0;
        BigInteger digit = 0;
        int power = 0;
        while (number > 0)
        {
            digit = number % 10;
            res += digit * CalculatePower(numBase, power);
            power++;
            number /= 10;
        }
        return res;
    }
}
