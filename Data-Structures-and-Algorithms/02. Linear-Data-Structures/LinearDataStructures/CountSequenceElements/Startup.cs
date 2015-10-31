namespace CountSequenceElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> sampleNumbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            var result = CountSequenceElements(sampleNumbers);

            foreach (var kvp in result)
            {
                Console.WriteLine("{0} -> {1} times", kvp.Key, kvp.Value);
            }

            Console.WriteLine();
        }

        public static IDictionary<int, int> CountSequenceElements(IEnumerable<int> numbers)
        {
            return numbers
                .GroupBy(x => x)
                .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
