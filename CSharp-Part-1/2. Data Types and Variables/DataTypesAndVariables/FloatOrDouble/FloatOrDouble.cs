﻿// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class FloatOrDouble
{
    static void Main()
    {
        double firstNumber = 34.567839023D;
        float secondNumber = 12.345f;
        double thirdNumber = 8923.1234857D;
        float fourthNumber = 3456.091f;

        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        Console.WriteLine(thirdNumber);
        Console.WriteLine(fourthNumber);
    }
}