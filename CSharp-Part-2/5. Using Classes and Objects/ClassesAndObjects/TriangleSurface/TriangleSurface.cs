/*
 * Write methods that calculate the surface of a triangle by given:
 *      Side and an altitude to it;
 *      Three sides;
 *      Two sides and an angle between them;
 * Use System.Math.
 */

using System;

class TriangleSurface
{
    static void Main()
    {
        double A = 3.0;
        double hA = 1.5;
        double B = 4.0;
        double C = 5.0;
        double angle = 30.0;

        Console.WriteLine("Surface by side and height: ");
        Console.WriteLine(CalcSurface(A, hA));
        Console.WriteLine("Surface by three sides: ");
        Console.WriteLine(CalcSurfaceBySides(A, B, C));
        Console.WriteLine("Surface by two sides and an angle: ");
        Console.WriteLine(CalcSurface(A, B, angle));
    }

    static double CalcSurface(double side, double altitude)
    {
        return (side * altitude) / 2;
    }

    static double CalcSurface(double firstSide, double secondSide, double angle)
    {
        angle = angle * Math.PI / 180.0;
        return (Math.Sin(angle) * firstSide * secondSide) / 2.0;
    }

    static double CalcSurfaceBySides(double firstSide, double secondSide, double thirdSide)
    {
        double p = (firstSide + secondSide + thirdSide) / 2;
        return Math.Sqrt((p * (p - firstSide) * (p - secondSide) * (p - thirdSide)));
    }
}
