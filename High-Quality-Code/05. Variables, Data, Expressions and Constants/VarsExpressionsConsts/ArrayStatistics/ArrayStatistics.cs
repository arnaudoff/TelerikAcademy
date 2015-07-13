namespace ArrayStatistics
{
    using System;
    using System.Text;

    public class ArrayStatistics
    {
        public static void Main(string[] args)
        {
            double[] numbers = new double[] { 10, 20, 30, 40, 50 };

            PrintArrayStatistics(numbers);
        }

        public static void PrintArrayStatistics<T>(T[] numbers) where T : IComparable
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Max: {0}", numbers.GetMax()));
            result.AppendLine(string.Format("Min: {0}", numbers.GetMin()));
            result.AppendLine(string.Format("Average: {0}", numbers.GetAverage()));

            Console.Write(result.ToString());
        }
    }
}
