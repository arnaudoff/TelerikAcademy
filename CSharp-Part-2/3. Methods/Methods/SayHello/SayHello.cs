/*
 * Write a method that asks the user for his name and prints “Hello, <name>”
 * Write a program to test this method.
 */

using System;

class SayHello
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        PrintHello(Console.ReadLine());
    }
    
    static void PrintHello(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}