using System;
using System.Text;

class KaspichanNumbers
{
    static void Main(string[] args)
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string[] digitsDict = new string[256];
        int index = 0;
        for (char j = 'A'; j <= 'Z'; j++)
        {
            index = j - 'A';
            digitsDict[index] = j.ToString();
        }
        for (char i = 'a'; i <= 'i'; i++)
        {
            for (char j = 'A'; j <= 'Z'; j++)
            {
                digitsDict[++index] = string.Concat(i, j);
                if (i == 'i' && j == 'V')
                {
                    break;
                }
            }
        }

        string result = string.Empty;
        // Silly but eh.
        if (number == 0)
        {
            Console.WriteLine("A");
        }
        else
        {
            while (number > 0)
            {
                ulong digit = number % 256;
                result = digitsDict[digit] + result;
                number /= 256;
            }
            Console.WriteLine(result);
        }
    }
}