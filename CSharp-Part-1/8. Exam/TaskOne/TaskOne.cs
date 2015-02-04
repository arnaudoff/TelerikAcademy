using System;
using System.Linq;

class TaskOne
{
    static void Main()
    {
        long[] numbers = new long[3];
        for (int i = 0; i < 3; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        long maxNumber = numbers.Max();
        long minNumber = numbers.Min();

        double totalSum = 0;
        for (int i = 0; i < 3; i++)
        {
            totalSum += numbers[i];
        }
        double arithmeticMean = totalSum / 3.00;
        Console.WriteLine(maxNumber);
        Console.WriteLine(minNumber);
        Console.WriteLine("{0:F2}", arithmeticMean);
    }
}