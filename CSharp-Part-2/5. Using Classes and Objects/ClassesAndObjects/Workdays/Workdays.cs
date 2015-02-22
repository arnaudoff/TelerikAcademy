/*
 * Write a method that calculates the number of workdays between today and given date, passed as parameter.
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */

using System;
using System.Collections.Generic;

class Workdays
{
    static List<DateTime> holidays;
    static void Main()
    {
        holidays = new List<DateTime>()
        {
            new DateTime(2015, 3, 3),
            new DateTime(2015, 3, 4),
            new DateTime(2015, 3, 5)
        };

        Console.WriteLine("There are {0} working days in the range.", CalculateWorkdays(new DateTime(2015, 2, 21), new DateTime(2015, 3, 5)));
    }


    private static int CalculateWorkdays(DateTime startDate, DateTime endDate)
    {
        int workDays = 0;
        DateTime now = startDate;

        while (now <= endDate)
        {
            if (!holidays.Contains(now) && (int)now.DayOfWeek != 0 && (int)now.DayOfWeek != 6)
            {
                ++workDays;
            }
            now = now.AddDays(1);
        }

        return workDays;
    }
}