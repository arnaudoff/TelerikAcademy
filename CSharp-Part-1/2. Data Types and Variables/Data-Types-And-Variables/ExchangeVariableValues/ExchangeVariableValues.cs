// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;
        Console.WriteLine("Before exchanging values: a = {0}; b = {1}", a, b);
        byte tempVar = a;
        a = b;
        b = tempVar;
        Console.WriteLine("After exchanging values: a = {0}; b = {1}", a, b);
    }
}
