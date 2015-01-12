using System;

class CodeStreetNightmare
{
    static void Main()
    {
        string inputStr = Console.ReadLine();

        int oddSum = 0;
        int count = 0;
        for (int i = 0; i < inputStr.Length; i++)
        {
            if (i % 2 != 0 && Char.IsNumber(inputStr[i]))
            {
                count++;
                oddSum = oddSum + (inputStr[i] - '0');
            }
        }
        Console.WriteLine(count + " " + oddSum);
    }
}
