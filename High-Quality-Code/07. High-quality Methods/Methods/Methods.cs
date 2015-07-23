namespace Methods
{
    using System;

    public class Methods
    {
        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("There should be at least one argument.");
            }

            int maxElement = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                maxElement = Math.Max(maxElement, elements[i]);
            }

            return maxElement;
        }

        public static void Main()
        {
            Console.WriteLine(MathUtils.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(NumberUtils.NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            NumberUtils.PrintAsNumber(1.3, FormatSpecifier.Precision);
            NumberUtils.PrintAsNumber(0.75, FormatSpecifier.Percent);
            NumberUtils.PrintAsNumber(2.30, FormatSpecifier.RightAlignment);

            double firstPointX = 3.0;
            double firstPointY = -1.0;
            double secondPointX = 3.0;
            double secondPointY = 2.5;

            double lineLength = MathUtils.CalculateDistanceBetweenTwoPoints(firstPointX, firstPointY, secondPointX, secondPointY);
            Console.WriteLine(lineLength);

            LineType lineType = MathUtils.GetLineType(firstPointX, firstPointY, secondPointX, secondPointY);
            Console.WriteLine("Line type: " + lineType);

            Student peter = new Student("Peter", "Ivanov", "Sofia", new DateTime(1992, 3, 17));
            Student stela = new Student("Stela", "Markova", "Vidin", new DateTime(1993, 11, 3), new string[] { "Gamer", "High results" });

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stela.FirstName, peter.IsOlderThan(stela));
        }
    }
}
