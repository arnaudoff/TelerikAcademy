// Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class NumbersInIntervalDividableByFive
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        int dividableCount = 0;
        // In case the start number is bigger, we will swap them - the result will be the same.
        int tmp;
        if (startNumber > endNumber)
        {
            tmp = startNumber;
            startNumber = endNumber;
            endNumber = tmp;
        }
        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 5 == 0)
            {
                dividableCount++;
            }
        }
        Console.WriteLine(dividableCount);
    }
}
