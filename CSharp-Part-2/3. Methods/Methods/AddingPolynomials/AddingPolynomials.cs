/*
 * Write a method that adds two polynomials.
 * Represent them as arrays of their coefficients.
 */

using System;

class AddingPolynomials
{
    static void Main()
    {
        Console.WriteLine("Enter your first polynomial degree: ");
        int maxDegree = int.Parse(Console.ReadLine());
        int[] firstPolynomial = new int[maxDegree + 1];
        for (int i = maxDegree; i >= 0; i--)
        {
            Console.Write("x^{0}: ", i);
            firstPolynomial[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Normal form: ");
        for (int i = maxDegree; i >= 0; i-- )
        {
            if (i != 0)
            {
                Console.Write("{0}x^{1}", firstPolynomial[i], i);
            }
            else
            {
                Console.Write(firstPolynomial[i]);
            }
            if (i > 0)
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Enter your second polynomial degree: ");
        maxDegree = int.Parse(Console.ReadLine());
        int[] secondPolynomial = new int[maxDegree + 1];
        for (int i = maxDegree; i >= 0; i--)
        {
            Console.Write("x^{0}: ", i);
            secondPolynomial[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Normal form: ");
        for (int i = maxDegree; i >= 0; i--)
        {
            if (i != 0)
            {
                Console.Write("{0}x^{1}", secondPolynomial[i], i);
            }
            else
            {
                Console.Write(secondPolynomial[i]);
            }
            if (i > 0)
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine();
    }

    static int[] CalcAddition(int[] firstPolynomial, int[] secondPolynomial)
    {
        // TODO: Implement.
    }
}