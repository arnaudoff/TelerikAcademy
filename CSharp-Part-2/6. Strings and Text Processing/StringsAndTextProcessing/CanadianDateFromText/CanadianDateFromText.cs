/*
 * Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
 * Display them in the standard date format for Canada.
 */

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class CanadianDateFromText
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        string regex = @"[0-9]{1,2}.[0-9]{1,2}.[0-9]{4}";
        MatchCollection matches = Regex.Matches(text, regex);

        List<DateTime> datesList = new List<DateTime>();
        foreach (var match in matches)
        {
            string[] currentDate = match.ToString().Split('.');
            datesList.Add(new DateTime(int.Parse(currentDate[2]), int.Parse(currentDate[1]), int.Parse(currentDate[0])));
        }

        CultureInfo culture = new CultureInfo("fr-CA");
        foreach (var date in datesList)
        {
            Console.WriteLine(date.ToString("d", culture));
        }
    }
}