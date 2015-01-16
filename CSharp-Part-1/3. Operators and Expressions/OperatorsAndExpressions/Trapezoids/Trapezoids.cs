// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter big base: ");
        float bigBase = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter small base: ");
        float smallBase = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        float height = float.Parse(Console.ReadLine());
        double area = ((bigBase + smallBase) / 2) * height;
        Console.WriteLine(area);
    }
}
