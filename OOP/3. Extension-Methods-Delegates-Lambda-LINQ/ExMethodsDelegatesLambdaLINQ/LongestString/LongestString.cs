// Write a program to return the string with maximum length from an array of strings. Use LINQ.

namespace LongestString
{
    using System;
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            var names = new[]
                            {
                                "Goshkata", 
                                "Pesho",
                                "Vasil",
                                "Hristofor"
                            };

            string longestStr = names.OrderByDescending(name => name.Length).First();
            Console.WriteLine("Longest string: {0}", longestStr);
        }
    }
}
