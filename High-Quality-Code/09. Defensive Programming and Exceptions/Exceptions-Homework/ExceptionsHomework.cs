namespace ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExceptionsHomework
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("array", "Array cannot be null.");
            }

            if (startIndex < 0 || startIndex >= arr.Length)
            {
                throw new IndexOutOfRangeException("Start index must be in the range [0; arr.Length).");
            }

            if (count < 0)
            {
                throw new ArgumentException("Length of subsequence cannot be negative.");
            }

            if (startIndex + count > arr.Length)
            {
                throw new ArgumentOutOfRangeException("count", "The specified startIndex and count exceed the boundaries of the array.");
            }

            List<T> result = new List<T>();

            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("str", "Cannot extract ending from an empty or null string.");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException("count", "Count cannot be bigger than the string length itself.");
            }

            StringBuilder result = new StringBuilder();

            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main()
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("beer", 4));

            try
            {
                Console.WriteLine(ExtractEnding("Pesho", 100));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // https://social.msdn.microsoft.com/Forums/vstudio/en-US/3e8be3a7-70cd-4f14-812e-b7800c4a2394/how-to-implement-stderr-in-c-console-application
                Console.Error.WriteLine(ex.Message);
            }

            int somePrime = 13;
            Console.WriteLine("{0} is prime: {1}", somePrime, CheckPrime(somePrime));

            int someNonPrime = 25;
            Console.WriteLine("{0} is prime: {1}", someNonPrime, CheckPrime(someNonPrime));

            List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}