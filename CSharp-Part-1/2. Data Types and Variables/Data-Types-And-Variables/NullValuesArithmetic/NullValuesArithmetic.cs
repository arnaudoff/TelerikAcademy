/* 
 * Create a program that assigns null values to an integer and to a double variable.
 * Try to print these variables at the console.
 * Try to add some number or the null literal to these variables and print the result.
 */

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? firstNullableVar = null;
        double? secondNullableVar = null;

        Console.WriteLine(firstNullableVar);
        Console.WriteLine(secondNullableVar);

        firstNullableVar = 1337;
        secondNullableVar = 323.392321D;
        Console.WriteLine(firstNullableVar);
        Console.WriteLine(secondNullableVar);
    }
}
