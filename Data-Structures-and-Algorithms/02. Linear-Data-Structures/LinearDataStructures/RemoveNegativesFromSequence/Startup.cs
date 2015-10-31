namespace RemoveNegativesFromSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> sampleNumbers = new List<int>() { 1, -3, -4, -5, 3, 3, -2, 7 };

            var result = RemoveNegativesFromSequence(sampleNumbers);

            foreach (var number in result)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }

        public static IEnumerable<int> RemoveNegativesFromSequence(IEnumerable<int> numbers)
        {
            return numbers.Where(x => x >= 0);
        }
    }
}
