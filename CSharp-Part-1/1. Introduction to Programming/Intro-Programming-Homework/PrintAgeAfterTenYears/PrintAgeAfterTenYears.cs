// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class PrintAgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter birthday (DD/MM/YYYY): ");
        string[] inputStr = Console.ReadLine().Split('/');

        int inputYear = int.Parse(inputStr[2]);
        DateTime today = DateTime.Today;
        int currentAge = today.Year - inputYear;
        int newAge = currentAge + 10;
        Console.WriteLine("I am now {0} years old and I will be {1} years old in 10 years. ", currentAge, newAge);
    }
}
