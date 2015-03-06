using System;
using System.Text;

class First
{
    static void Main()
    {
        // Populate dictionary with the digits
        char[] digitsDict = new char[19];
        for (char i = 'a'; i <= 's'; i++)
        {
            digitsDict[i - 97] = i;
        }

        // Read input
        string inputStr = Console.ReadLine();
        int sum = 0;
        foreach (string num in inputStr.Split(' '))
        {
            sum += stringToDecimal(num, digitsDict);
        }
        Console.WriteLine("{0} = {1}", convertToBase19(sum, digitsDict), sum);
    }

    static string convertToBase19(int number, char[] digits)
    {
        string result = string.Empty;
        while (number > 0)
        {
            int digit = number % 19;
            result = digits[digit] + result;
            number /= 19;
        }
        return result;
    }

    static int stringToDecimal(string inputStr, char[] digits)
    {
        int res = 0;
        int power = 0;
        for (int i = inputStr.Length - 1; i >= 0; i--)
        {
            int digitInNineteenBase = Array.IndexOf(digits, inputStr[i]);
            res += digitInNineteenBase * CalculatePower(19, power);
            power++;
        }
        return res;
    }
    static int CalculatePower(int number, int power)
    {
        int result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
}