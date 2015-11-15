namespace Precision
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int maxDenominator = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();

            int bestNominator = 0;
            int bestDenominator = 1;
            int bestPrecision = 0;

            for (int denominator = 1; denominator <= maxDenominator; denominator++)
            {
                int left = 0;
                int right = denominator;

                while (left < right)
                {
                    int middle = (left + right) / 2;
                    if (Compare(middle, denominator, number))
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                int currentPrecision = GetPrecision(left, denominator, number);
                if (currentPrecision > bestPrecision)
                {
                    bestDenominator = denominator;
                    bestNominator = left;
                    bestPrecision = currentPrecision;
                }

                currentPrecision = GetPrecision(left - 1, denominator, number);
                if (currentPrecision > bestPrecision)
                {
                    bestDenominator = denominator;
                    bestNominator = left - 1;
                    bestPrecision = currentPrecision;
                }
            }

            Console.WriteLine("{0}/{1}", bestNominator, bestDenominator);
            Console.WriteLine(bestPrecision);
        }

        private static bool Compare(int a, int b, string number)
        {
            int i = 0;
            while (i < number.Length)
            {
                if (number[i] == '.')
                {
                    i++;
                    continue;
                }

                int currentDigit = a / b;
                if (currentDigit < number[i] - '0')
                {
                    return false;
                }
                else if (currentDigit > number[i] - '0') 
                {
                    return true;
                }

                a = a % b * 10;
                i++;
            }

            return true;
        }

        private static int GetPrecision(int a, int b, string number)
        {
            int i = 0;
            while (i < number.Length)
            {
                if (number[i] == '.')
                {
                    i++;
                    continue;
                }

                int currentDigit = a / b;
                if (currentDigit != number[i] - '0')
                {
                    break;
                }

                a = a % b * 10;
                i++;
            }

            return i - 1;
        }
    }
}
