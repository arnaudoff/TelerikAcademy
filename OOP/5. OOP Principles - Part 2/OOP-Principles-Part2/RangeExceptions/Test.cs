/*
 * Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
 * It should hold error message and a range definition [start … end]. Write a sample application that demonstrates 
 * the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
 */

namespace RangeExceptions
{
    using System;

    public class Test
    {
        public static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>("Invalid range specified.", 1, 100);
            }
            catch (InvalidRangeException<int> exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                throw new InvalidRangeException<DateTime>("Invalid date given.", new DateTime(1980, 1, 1), DateTime.Now);
            }
            catch (InvalidRangeException<DateTime> exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
