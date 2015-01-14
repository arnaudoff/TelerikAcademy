// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        int inputWidth = int.Parse(Console.ReadLine());
        int inputHeight = int.Parse(Console.ReadLine());

        int perimeter = 2 * (inputHeight + inputWidth);
        Console.WriteLine("Perimeter: {0}", perimeter);
        int area = inputHeight * inputWidth;
        Console.WriteLine("Area: {0}", area);
    }
}
