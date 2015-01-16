// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        bool canBeDivided = false;
        if (inputNumber % 7 == 0 && inputNumber % 5 == 0)
        {
            canBeDivided = true;
        }
        else 
        {
            canBeDivided = false;
        }
        Console.WriteLine(canBeDivided);
    }
}
