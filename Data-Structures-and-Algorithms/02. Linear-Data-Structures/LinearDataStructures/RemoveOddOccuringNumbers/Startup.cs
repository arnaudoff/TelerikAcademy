namespace RemoveOddOccuringNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> sampleNumbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var result = RemoveOddOccuringNumbers(sampleNumbers);

            foreach (var number in result)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }

        public static IEnumerable<int> RemoveOddOccuringNumbers(IEnumerable<int> numbers)
        {
            var oddOccuringNumbers = numbers
                .GroupBy(x => x)
                .Where(x => x.Count() % 2 != 0)
                .Select(x => x.Key);

            return numbers.Where(x => !oddOccuringNumbers.Contains(x));
        }
    }
}
