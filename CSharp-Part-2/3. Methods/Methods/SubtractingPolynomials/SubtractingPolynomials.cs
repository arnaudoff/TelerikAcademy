// Extend the previous program to support also subtraction and multiplication of polynomials.

using System;

class SubtractingPolynomials
{
    static void Main()
    {
        Console.WriteLine("Enter your first polynomial degree: ");
        int firstMaxDegree = int.Parse(Console.ReadLine());
        int[] firstPolynomial = new int[firstMaxDegree + 1];
        for (int i = firstMaxDegree; i >= 0; i--)
        {
            Console.Write("x^{0}: ", i);
            firstPolynomial[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Normal form: ");
        PrintPolynomial(firstMaxDegree, firstPolynomial);
        Console.WriteLine("Enter your second polynomial degree: ");
        int secondMaxDegree = int.Parse(Console.ReadLine());
        int[] secondPolynomial = new int[secondMaxDegree + 1];
        for (int i = secondMaxDegree; i >= 0; i--)
        {
            Console.Write("x^{0}: ", i);
            secondPolynomial[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Normal form: ");
        PrintPolynomial(secondMaxDegree, secondPolynomial);
        Console.WriteLine();
        int maxDegree = Math.Max(firstMaxDegree, secondMaxDegree);
        int[] res;
        if (firstPolynomial.Length < secondPolynomial.Length)
        {
            res = CalcSubstraction(secondPolynomial, firstPolynomial, maxDegree);
        }
        else
        {
            res = CalcSubstraction(firstPolynomial, secondPolynomial, maxDegree);
        }
        Array.Reverse(res);
        Console.WriteLine("Result: ");
        PrintPolynomial(maxDegree, res);
    }

    static void PrintPolynomial(int maxDegree, int[] polynomial)
    {
        for (int i = maxDegree; i >= 0; i--)
        {
            if (i != 0)
            {
                Console.Write("{0}x^{1}", polynomial[i], i);
            }
            else
            {
                Console.Write(polynomial[i]);
            }
            if (i > 0)
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine();
    }

    static int[] CalcSubstraction(int[] firstPolynomial, int[] secondPolynomial, int maxDegree)
    {
        int[] tempArray = new int[firstPolynomial.Length];
        secondPolynomial.CopyTo(tempArray, firstPolynomial.Length - secondPolynomial.Length);
        int[] finalResult = new int[firstPolynomial.Length];
        for (int i = maxDegree; i >= 0; i--)
        {
            finalResult[i] = firstPolynomial[i] - tempArray[i];
        }
        return finalResult;
    }

    // TODO: Implement multiplication
}