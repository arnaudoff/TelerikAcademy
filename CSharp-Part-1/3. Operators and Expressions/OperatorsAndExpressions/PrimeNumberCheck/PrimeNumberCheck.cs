// Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int inputNumber = int.Parse(Console.ReadLine());

        bool isPrime = true;
        if (inputNumber <= 1)
        {
            isPrime = false;
        }
        for (int i = 2; i <= Math.Sqrt(inputNumber); i++)
        {
            if (inputNumber % i == 0)
            {
                isPrime = false;
            }
        }
        Console.WriteLine(isPrime);
    }
}
