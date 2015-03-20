/*
 * Implement an extension method Substring(int index, int length) for the class StringBuilder
 * that returns new StringBuilder and has the same functionality as Substring in the class String.
 */

namespace StringBuilderExtensions
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            if (length < 0)
            {
                throw new ArgumentException("Length must be greater than zero.");
            }

            if (index < 0 || index >= str.Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (index + length >= str.Length)
            {
                throw new ArgumentException("The length of the desired substring is out of the boundaries of the string.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                result.Append(str[i]);
            }

            return result;
        }

    }
}
