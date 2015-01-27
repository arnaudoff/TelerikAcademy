// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersInRange
{
    static void Main()
    {
        Console.WriteLine("Enter amount of random numbers [n]: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter min number [min]:");
        int minNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter max number [max]:");
        int maxNumber = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            int randomNumber = rnd.Next(minNumber, maxNumber + 1);
            Console.Write("{0} ", randomNumber);
        }
        Console.WriteLine();
    }
}
