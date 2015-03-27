/*
 * Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
 * Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
 * Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
 * Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.
 */

namespace Shapes
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Shape[] shapes = new Shape[]{
                new Circle(5),
                new Triangle(5, 10),
                new Rectangle(5, 10),
                new Square(7)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0} Surface: {1}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
