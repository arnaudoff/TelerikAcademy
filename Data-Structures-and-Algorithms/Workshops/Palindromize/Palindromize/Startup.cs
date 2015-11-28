namespace Palindromize
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();

            StringBuilder res = new StringBuilder(s);

            int currentTakeCount = 0;

            while (!IsPalindrome(res))
            {
                // Take new part
                string part = s.Substring(0, currentTakeCount + 1);

                // Remove old part
                res.Remove(res.Length - currentTakeCount, currentTakeCount);

                // Reverse append the new part
                for (int i = currentTakeCount; i >= 0; i--)
                {
                    res.Append(part[i]);
                }

                currentTakeCount++;
            }

            Console.WriteLine(res.ToString());
        }

        public static bool IsPalindrome(StringBuilder s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
