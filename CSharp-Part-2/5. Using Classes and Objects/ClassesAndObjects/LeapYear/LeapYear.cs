/*
 * Write a program that reads a year from the console and checks whether it is a leap one.
 * Use System.DateTime.
 */

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        DateTime input = new DateTime(int.Parse(Console.ReadLine()), 1, 1);
        if (DateTime.IsLeapYear(input.Year))
        {
            Console.WriteLine("The year {0} is leap!", input.Year);
        }
        else
        {
            Console.WriteLine("The year {0} is not leap!", input.Year);
        }
    }
}
