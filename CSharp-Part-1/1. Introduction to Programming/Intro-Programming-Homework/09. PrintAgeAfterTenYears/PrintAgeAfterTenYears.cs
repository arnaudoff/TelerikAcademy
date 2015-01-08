// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class PrintAgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter birthday (DD/MM/YYYY): ");
        string[] inputStr = Console.ReadLine().Split('/');

        int inputYear = int.Parse(inputStr[2]);
        int afterYear = inputYear + 10;
        Console.WriteLine(afterYear);
    }
}
