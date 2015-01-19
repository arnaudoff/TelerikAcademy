// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CircleParameterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter radius (r): ");
        int radius = int.Parse(Console.ReadLine());

        double circlePerimeter = 2 * Math.PI * radius;
        double circleArea = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("Perimeter: {0:0.00}\nArea: {1:0.00}", circlePerimeter, circleArea);
    }
}
