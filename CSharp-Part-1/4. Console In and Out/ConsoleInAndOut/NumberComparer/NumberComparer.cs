/* 
 * Write a program that gets two numbers from the console and prints the greater of them.
 * Try to implement this without if statements.
 */

using System;

class NumberComparer
{
    static void Main()
    {  
        Console.WriteLine("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        /* 
            * We can easily figure out that if we have three integers: a, b and c and the result of a - b is stored in c, then:
            * Case 1: if a > b => c > 0
            * Case 2: if a < b => c < 0
            * Case 3: if a == b => c = 0
            * Since we can't use if statements, the only left option is to use bit manipulation. Since our computers use "two's-complement"
            * to determine if an integer is negative or not (the most significant bit is 1 if negative, 0 if positiove), we can use that to determine the sign of c.
            * 
            * Disclaimer: I'm not using an if for comparison, but to determine the types!
        */
        if (firstNumber % 1 == 0 && secondNumber % 1 == 0) // if the numbers are integers
        {
            int absoluteValue = (int)firstNumber - (int)secondNumber;
            int bitDeterminator = (absoluteValue >> 31) & 1; // 1 if negative, 0 if positive
            int maxNumber = (int)firstNumber - (bitDeterminator * absoluteValue);
            Console.WriteLine("Greater: {0}", maxNumber);
        }
        else
        {
            /* 
                * Using the first method with real numbers won't work firstly because bitwise operations can not be applied to floating-point numbers and secondly, 
                * because the way they are represented in binary is complicated.
            */
            Console.WriteLine("Greater: {0}", Math.Max(firstNumber, secondNumber));
        }
    }
}
