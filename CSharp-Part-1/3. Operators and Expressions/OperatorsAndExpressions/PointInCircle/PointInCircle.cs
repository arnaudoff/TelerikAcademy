﻿// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter x-axis coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y-axis coordinate: ");
        double y = double.Parse(Console.ReadLine());
        bool isInside = false;
        if (Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2) <=  4)
        {
            isInside = true;
        }
        Console.WriteLine(isInside);

    }
}