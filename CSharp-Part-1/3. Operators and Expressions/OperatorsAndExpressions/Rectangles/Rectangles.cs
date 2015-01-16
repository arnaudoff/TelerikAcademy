// Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter width: ");
        int inputWidth = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        int inputHeight = int.Parse(Console.ReadLine());

        int perimeter = 2 * (inputHeight + inputWidth);
        Console.WriteLine("Perimeter: {0}", perimeter);
        int area = inputHeight * inputWidth;
        Console.WriteLine("Area: {0}", area);
    }
}
