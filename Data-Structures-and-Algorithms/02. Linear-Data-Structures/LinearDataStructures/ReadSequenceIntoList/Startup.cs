namespace ReadSequenceIntoList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();

            string inputLine = Console.ReadLine();
            while (inputLine != string.Empty)
            {
                numbers.Add(int.Parse(inputLine));
                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Sum: {0}", numbers.Sum());
            Console.WriteLine("Average: {0}", numbers.Average());
        }
    }
}
