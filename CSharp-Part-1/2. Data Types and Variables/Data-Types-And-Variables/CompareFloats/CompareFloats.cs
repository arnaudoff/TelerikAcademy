// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

class CompareFloats
{
    static void Main()
    {
        const float eps = 0.000001f;

        Console.Write("Enter first float: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter second float: ");
        double secondNum = double.Parse(Console.ReadLine());
        bool areEqual = Math.Abs(firstNum - secondNum) < eps;

        if (areEqual)
        {
            Console.WriteLine("The floats are equal (eps = {0}).", eps);
        }
        else
        {
            Console.WriteLine("The floats are NOT equal (eps = {0}).", eps);
        }
    }
}
