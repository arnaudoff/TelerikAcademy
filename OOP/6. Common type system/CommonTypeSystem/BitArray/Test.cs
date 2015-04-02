/*
 * Define a class BitArray64 to hold 64 bit values inside an ulong value.
 * Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
 */

namespace BitArray
{
    using System;

    public class Test
    {
        public static void Main()
        {
            const ulong number = 8;
            BitArray64 firstArray = new BitArray64(number);
            BitArray64 secondArray = new BitArray64(number / 2);

            Console.WriteLine(firstArray.ToString());
            Console.WriteLine(secondArray.ToString());
            Console.WriteLine(firstArray == secondArray);
            firstArray[0] = 1;
            firstArray[1] = 1;
            Console.WriteLine(firstArray.ToString());

            // Enumerator test
            foreach (var bit in firstArray)
            {
                Console.Write(bit);
            }
        }
    }
}
