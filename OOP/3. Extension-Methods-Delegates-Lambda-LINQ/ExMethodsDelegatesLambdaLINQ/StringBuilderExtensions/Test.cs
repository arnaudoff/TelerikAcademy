namespace StringBuilderExtensions
{
    using System;
    using System.Text;

    public class Test
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Hello world!");
            sb = sb.Substring(0, 5);
            Console.WriteLine(sb);
        }
    }
}
