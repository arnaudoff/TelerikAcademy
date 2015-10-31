namespace ReadSequenceIntoListAndSort
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

            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.Write("{0} ", number);
            }
        }
    }
}
