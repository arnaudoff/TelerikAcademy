namespace FindMajorant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            List<int> sampleNumbers = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            int? majorant = FindMajorant(sampleNumbers);

            if (majorant != null)
            {
                Console.WriteLine("Majorant: {0}", majorant);
            }
            else
            {
                Console.WriteLine("No majorant found for the given sequence.");
            }
        }

        public static int? FindMajorant(IList<int> numbers)
        {
            int minimumOccurencesRequired = (numbers.Count / 2) + 1;

            return numbers
                .GroupBy(x => x)
                .Where(g => g.Count() >= minimumOccurencesRequired)
                .Select(g => (int?)g.Key)
                .SingleOrDefault();
        }
    }
}
