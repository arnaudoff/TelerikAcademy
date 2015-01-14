/*
 * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
 *  Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
 *  Prints on the console the number in reversed order: dcba (in our example 1102).
 *  Puts the last digit in the first position: dabc (in our example 1201).
 *  Exchanges the second and the third digits: acbd (in our example 2101).
 * The number has always exactly 4 digits and cannot start with 0.
 */

using System;

class FourDigitNumber
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum: {0}\nReversed: {1}\nLast digit first: {2}\nSecond and third exchanged: {3}\n", 
            calculateSum(inputNumber), reverseNumber(inputNumber), lastDigitFirst(inputNumber), exchangeSecondAndThirdDigits(inputNumber));

    }

    private static int calculateSum(int inputNumber)
    {
        int totalSum = 0;
        do
        {
            int digit = inputNumber % 10;
            totalSum += digit;
            inputNumber /= 10;
        } while (inputNumber > 0);

        return totalSum;
    }

    private static int reverseNumber(int inputNumber)
    {
        int result = 0;
        while (inputNumber > 0)
        {
            result = result * 10 + inputNumber % 10;
            inputNumber /= 10;
        }
        return result;
    }

    private static int lastDigitFirst(int inputNumber)
    {
        int lastDigit = inputNumber % 10;
        int rightPart = inputNumber / 10;

        int result = lastDigit * 1000 + rightPart;

        return result;
    }

    private static int exchangeSecondAndThirdDigits(int inputNumber)
    {
        int secondDigit = (inputNumber / 100) % 10;
        int thirdDigit = (inputNumber / 10) % 10;
        int result = (inputNumber / 1000) * 1000 + thirdDigit * 100 + secondDigit * 10 + inputNumber % 10;
        return result;
    }
}
