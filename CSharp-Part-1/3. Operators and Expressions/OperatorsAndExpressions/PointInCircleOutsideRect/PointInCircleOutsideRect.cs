// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInCircleOutsideRect
{
    static void Main()
    {
        Console.WriteLine("Enter x-axis coordinate: ");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter y-axis coordinate: ");
        float y = float.Parse(Console.ReadLine());

        bool isInCircle = false;

        if (Math.Pow((1 - x), 2) + Math.Pow((1 - y), 2) <= 2.25)
        {
            isInCircle = true;
        }

        bool isOutsideRect = false;

        if (y > 1 && x >= -0.5 && x <= 2.5)
        {
            isOutsideRect = true;
        }

        if (isInCircle && isOutsideRect)
        {
            Console.WriteLine("Yes.");
        }
        else
        {
            Console.WriteLine("No.");
        }
    }
}