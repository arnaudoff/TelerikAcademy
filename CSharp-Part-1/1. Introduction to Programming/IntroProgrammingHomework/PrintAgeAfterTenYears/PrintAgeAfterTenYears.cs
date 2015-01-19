// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class PrintAgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter birthday (DD/MM/YYYY): ");
        string[] inputStr = Console.ReadLine().Split('/');

        // It's a good idea to catch exceptions thrown from Split here in case of wrong format, but since we haven't talked about exceptions yet it's better to keep it as simple as possible.

        int inputDay = int.Parse(inputStr[0]);
        int inputMonth = int.Parse(inputStr[1]);
        int inputYear = int.Parse(inputStr[2]);
        DateTime today = DateTime.Today;

        if (inputYear > today.Year)
        {
            Console.WriteLine("Invalid birthday date.");
        }
        else
        {
            int currentAge = today.Year - inputYear;
            if (inputMonth > today.Month)
            {
                currentAge--;
            }
            else
            {
                if (inputDay > today.Day)
                {
                    currentAge--;
                }
            }
            Console.WriteLine("I am currently {0} years old and I will be {1} years old at this date after 10 years.", currentAge, currentAge + 10);
        }
    }
}
