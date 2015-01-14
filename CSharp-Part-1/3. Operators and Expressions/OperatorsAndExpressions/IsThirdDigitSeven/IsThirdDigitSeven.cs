// Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        int i = 0;
        bool isSeven = false;
        do {
           int digit = inputNumber % 10;
           if (i == 2 && digit == 7)
           {
               isSeven = true;
           }
           inputNumber = inputNumber / 10;
           i++;
        } while (inputNumber > 0);
        Console.WriteLine(isSeven);
    }
}
