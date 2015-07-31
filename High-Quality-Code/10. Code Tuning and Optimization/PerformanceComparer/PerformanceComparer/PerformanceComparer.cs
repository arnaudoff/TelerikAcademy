namespace PerformanceComparer
{
    using System;

    public class PerformanceComparer
    {
        private const int FirstInteger = 2147480;
        private const int SecondInteger = 10;

        private const long FirstLong = 9223372036854775800L;
        private const long SecondLong = 4294967296L;

        private const float FirstFloat = 20.23232F;
        private const float SecondFloat = 10.23232F;

        private const double FirstDouble = 203.3232321214124D;
        private const double SecondDouble = 64.313123111D;

        private const decimal FirstDecimal = 305.434234234241242352643M;
        private const decimal SecondDecimal = 5.324923942342384234M;

        public static void Main(string[] args)
        {
            Console.WriteLine("-- Simple math --");

            PrintSimpleMathForType(
                "Integer", 
                SimpleMath.Add(FirstInteger, SecondInteger), 
                SimpleMath.Substract(FirstInteger, SecondInteger),
                SimpleMath.Multiply(FirstInteger, SecondInteger),
                SimpleMath.Divide(FirstInteger, SecondInteger),
                SimpleMath.Increment(FirstInteger));

            PrintSimpleMathForType(
                "Long",
                SimpleMath.Add(FirstLong, SecondLong),
                SimpleMath.Substract(FirstLong, SecondLong),
                SimpleMath.Multiply(FirstLong, SecondLong),
                SimpleMath.Divide(FirstLong, SecondLong),
                SimpleMath.Increment(FirstLong));

            PrintSimpleMathForType(
                "Float",
                SimpleMath.Add(FirstFloat, SecondFloat),
                SimpleMath.Substract(FirstFloat, SecondFloat),
                SimpleMath.Multiply(FirstFloat, SecondFloat),
                SimpleMath.Divide(FirstFloat, SecondFloat),
                SimpleMath.Increment(FirstFloat));

            PrintSimpleMathForType(
                "Double",
                SimpleMath.Add(FirstDouble, SecondDouble),
                SimpleMath.Substract(FirstDouble, SecondDouble),
                SimpleMath.Multiply(FirstDouble, SecondDouble),
                SimpleMath.Divide(FirstDouble, SecondDouble),
                SimpleMath.Increment(FirstDouble));

            PrintSimpleMathForType(
                "Decimal",
                SimpleMath.Add(FirstDecimal, SecondDecimal),
                SimpleMath.Substract(FirstDecimal, SecondDecimal),
                SimpleMath.Multiply(FirstDecimal, SecondDecimal),
                SimpleMath.Divide(FirstDecimal, SecondDecimal),
                SimpleMath.Increment(FirstDecimal));

            Console.WriteLine("-- Advanced math --");

            PrintAdvancedMathForType(
                "Float",
                AdvancedMath.Sqrt(FirstFloat),
                AdvancedMath.Log(FirstFloat),
                AdvancedMath.Sin(FirstFloat));

            PrintAdvancedMathForType(
                "Double",
                AdvancedMath.Sqrt(FirstDouble),
                AdvancedMath.Log(FirstDouble),
                AdvancedMath.Sin(FirstDouble));

            PrintAdvancedMathForType(
                "Decimal",
                AdvancedMath.Sqrt(FirstDecimal),
                AdvancedMath.Log(FirstDecimal),
                AdvancedMath.Sin(FirstDecimal));

            // Comparing different sorting algorithms that way is very wrong, their complexity varies for different cases
            Console.WriteLine("-- Sorting algorithms -- ");
            
            int[] integerArray = new int[5] { 7, 8, 3, 4, 1 };
            double[] doubleArray = new double[5] { FirstDouble, SecondDouble, 13.23432532D, 1352.232131241D, 424654721.321432D };
            string[] stringArray = new string[5] { "hello", "friend", "how", "are", "you" };

            PrintSortingForType(
                "Integer",
                Sorting.Insertion(integerArray),
                Sorting.Selection(integerArray),
                Sorting.Quick(integerArray));

            PrintSortingForType(
                "Double",
                Sorting.Insertion(doubleArray),
                Sorting.Selection(doubleArray),
                Sorting.Quick(doubleArray));

            PrintSortingForType(
                "String",
                Sorting.Insertion(stringArray),
                Sorting.Selection(stringArray),
                Sorting.Quick(stringArray));
        }

        private static void PrintSimpleMathForType(string type, TimeSpan add, TimeSpan substract, TimeSpan multiply, TimeSpan divide, TimeSpan increment)
        {
            Console.WriteLine("[{0}]", type);

            Console.WriteLine("Add: " + add);
            Console.WriteLine("Substract: " + substract);
            Console.WriteLine("Multiply: " + multiply);
            Console.WriteLine("Divide: " + divide);
            Console.WriteLine("Increment: " + increment);
            Console.WriteLine();
        }

        private static void PrintAdvancedMathForType(string type, TimeSpan sqrt, TimeSpan log, TimeSpan sin)
        {
            Console.WriteLine("[{0}]", type);

            Console.WriteLine("Sqrt: " + sqrt);
            Console.WriteLine("Log: " + log);
            Console.WriteLine("Sin: " + sin);
            Console.WriteLine();
        }

        private static void PrintSortingForType(string type, TimeSpan insertion, TimeSpan selection, TimeSpan quick)
        {
            Console.WriteLine("[{0}]", type);

            Console.WriteLine("Insertion: " + insertion);
            Console.WriteLine("Selection: " + selection);
            Console.WriteLine("Quick: " + quick);
            Console.WriteLine();
        }
    }
}
