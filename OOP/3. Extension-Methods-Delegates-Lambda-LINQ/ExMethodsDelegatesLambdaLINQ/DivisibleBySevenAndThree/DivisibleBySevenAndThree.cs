// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace DivisibleBySevenAndThree
{
    using System;
    using System.Linq;

    class DivisibleBySevenAndThree
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 14, 15, 21, 441};

            var result = numbers.Where(x => x % 7 == 0 && x % 3 == 0);
            Console.WriteLine("LINQ Extension methods: \n");
            foreach (var number in result)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
            var secondResult = from number in numbers
                               where number % 7 == 0 && number % 3 == 0
                               select number;
            Console.WriteLine("\nLINQ: \n");
            foreach (var number in secondResult)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
