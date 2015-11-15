namespace BinaryTrees
{
    using System;
    using System.Numerics;

    public class Startup
    {
        private static BigInteger[] memo;

        private static BigInteger CountTrees(int numkeys)
        {
            if (memo[numkeys] > 0)
            {
                return memo[numkeys];
            }

            if (numkeys > 1)
            {
                int i = 1;
                BigInteger sum = 0;

                for (i = 1; i <= numkeys; i++)
                {

                    BigInteger lcount = CountTrees(i - 1);
                    BigInteger rcount = CountTrees(numkeys - i);
                    sum += lcount * rcount;
                }

                memo[numkeys] = sum;
                return (sum);
            }
            else
            {
                return 1;
            }
        }

        public static void Main()
        {
            var input = Console.ReadLine();
            int n = input.Length;

            int[] groups = new int[26];

            for (int i = 0; i < n; i++)
            {
                groups[input[i] - 'A']++;
            }

            long[] factorials = new long[n + 1];
            factorials[0] = 1;

            for (int i = 0; i < n; i++)
            {
                factorials[i + 1] = factorials[i] * (i + 1);
            }

            BigInteger result = factorials[n];

            for (int i = 0; i < groups.Length; i++)
            {
                result = result / factorials[groups[i]];
            }

            memo = new BigInteger[n + 1];
            Console.WriteLine(result * CountTrees(n));
        }
    }
}
