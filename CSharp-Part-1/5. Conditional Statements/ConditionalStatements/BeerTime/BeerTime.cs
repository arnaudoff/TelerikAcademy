/*
 * A beer time is after 1:00 PM and before 3:00 AM.
 * Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and 
 * prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 
 * Note: You may need to learn how to parse dates and times. 
 */

using System;

class BeerTime
{
    static void Main()
    {
        // Note that you should enter the time with leading zeros, i.e 1:00 PM should be 01:00 PM!

        Console.WriteLine("Enter time [hh:mm tt]: ");
        string inputStr = Console.ReadLine();
        DateTime inputHour = new DateTime();
        inputHour = DateTime.ParseExact(inputStr, "hh:mm tt", null);

        if (inputHour.Hour >= 13 || inputHour.Hour < 3)
        {
            Console.WriteLine("Beer time!");
        }
        else
        {
            Console.WriteLine("Non-beer time!");
        }


    }
}