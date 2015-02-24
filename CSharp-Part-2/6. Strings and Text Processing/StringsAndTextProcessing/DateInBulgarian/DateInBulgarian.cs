/*
 * Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints
 * the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */

using System;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Enter a date: ");
        string inputStr = Console.ReadLine();
        DateTime date = DateTime.ParseExact(inputStr, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        DateTime newDate = date.AddHours(6).AddMinutes(30);
        Console.WriteLine("Date {0}", newDate.ToString("dd.MM.yyyy HH:mm:ss"));
        Console.WriteLine("Day of the week: {0}", newDate.DayOfWeek);

    }
}