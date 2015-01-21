// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                // The equation is linear
                Console.WriteLine("x1 = x2 = {0}", c/b);
            }
            else
            {
                // The equation is indeed quadratic
                double discriminant = Math.Pow(b, 2) - 4*a*c;
                if (discriminant < 0)
                {
                    Console.WriteLine("No real roots.");
                }
                else if (discriminant == 0)
                {
                    Console.WriteLine("x1 = x2 = {0}", -b/2*a);
                } else {
                    Console.WriteLine("x1 = {0}", (-b + Math.Sqrt(Math.Pow(b, 2) - 4*a*c)) / 2*a);
                    Console.WriteLine("x2 = {0}", (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a);
                }
            }
        }
    }