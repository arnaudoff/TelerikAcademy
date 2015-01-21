/*
 * Write a program that reads a number n and prints on the console the first n members
 * of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
 */

using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter amount of Fibonacci numbers to be printed: ");
        int n = int.Parse(Console.ReadLine());

        int firstMember = 0;
        int secondMember = 1;
        if (n <= 3)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine(firstMember);
                    break;
                case 2:
                    Console.WriteLine("{0} {1}", firstMember, secondMember);
                    break;
                case 3:
                    Console.WriteLine("{0} {1} {2}", firstMember, secondMember, firstMember + secondMember);
                    break;
            }
        }
        else
        {
            Console.Write("0 1 1 ");
            int tempMember;
            for (int i = 3; i < n; i++)
            {
                tempMember = firstMember;
                firstMember = secondMember;
                secondMember = tempMember + secondMember;
                Console.Write("{0} ", firstMember + secondMember);
            }
        }
    }
}
