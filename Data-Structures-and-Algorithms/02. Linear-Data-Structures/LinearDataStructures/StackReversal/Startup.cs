namespace StackReversal
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Stack<int> numbers = new Stack<int>();

            string inputLine = Console.ReadLine();
            while (inputLine != string.Empty)
            {
                numbers.Push(int.Parse(inputLine));
                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Reversing..");

            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
