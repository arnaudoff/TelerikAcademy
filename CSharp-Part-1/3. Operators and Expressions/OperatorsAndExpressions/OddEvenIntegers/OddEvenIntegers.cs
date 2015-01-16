// Write an expression that checks if given integer is odd or even.

using System;

class OddEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        bool isOdd = false;
        if (inputNumber % 2 != 0)
        {
            isOdd = true;
        }
        Console.WriteLine(isOdd);
    }
}
