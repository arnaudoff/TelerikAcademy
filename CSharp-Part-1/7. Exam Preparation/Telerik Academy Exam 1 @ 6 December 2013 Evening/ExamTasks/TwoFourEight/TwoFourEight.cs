using System;

class TwoFourEight
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        ulong result = 0;

        switch(secondNumber) 
        {
            case 2:
                result = (ulong)firstNumber % (ulong)thirdNumber;
                break;
            case 4:
                result = (ulong)firstNumber + (ulong)thirdNumber;
                break;
            case 8:
                result = (ulong)firstNumber * (ulong)thirdNumber;
                break;
        }

        if (result % 4 == 0)
        {
            ulong nonReminderResult = result / 4;
            Console.WriteLine(nonReminderResult);
        }
        else
        {
            ulong remainerResult = result % 4;
            Console.WriteLine(remainerResult);
        }

        Console.WriteLine(result);
    }
}
