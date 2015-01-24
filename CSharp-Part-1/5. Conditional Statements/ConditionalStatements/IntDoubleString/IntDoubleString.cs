/*
 * Write a program that, depending on the user’s choice, inputs an int, double or string variable.
 * If the variable is int or double, the program increases it by one.
 * If the variable is a string, the program appends * at the end.
 * Print the result at the console. Use switch statement. 
 */

using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 -> int \n2 -> double\n3 -> string");

        int inputType = int.Parse(Console.ReadLine());

        switch (inputType)
        {
            case 1:
                Console.WriteLine("Please enter an int: ");
                int inputNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(inputNumber + 1);
                break;
            case 2:
                Console.WriteLine("Please enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(inputDouble + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string: ");
                string inputStr = Console.ReadLine();
                Console.WriteLine("{0}*", inputStr);
                break;
        }
    }
}