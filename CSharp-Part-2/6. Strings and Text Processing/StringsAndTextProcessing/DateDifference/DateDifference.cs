// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;

class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter starting date: ");
        string inputStr = Console.ReadLine();
        string[] splitInput = inputStr.Split('.');
        DateTime firstDate = new DateTime(int.Parse(splitInput[2]), int.Parse(splitInput[1]), int.Parse(splitInput[0]));
        Console.WriteLine("Enter ending date: ");
        inputStr = Console.ReadLine();
        splitInput = inputStr.Split('.');
        DateTime secondDate = new DateTime(int.Parse(splitInput[2]), int.Parse(splitInput[1]), int.Parse(splitInput[0]));

        double difference = (secondDate - firstDate).TotalDays;
        Console.WriteLine("{0} days", difference);
    }
}
