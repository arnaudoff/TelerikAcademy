namespace Stack
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Stack<int> sampleStack = new Stack<int>();

            for (int i = 1; i <= 10; i++)
            {
                sampleStack.Push(i); // Auto-resizes on 8 to 16 (like List<T>)
            }

            Console.WriteLine("Size: {0}", sampleStack.Size);

            while (!sampleStack.IsEmpty())
            {
                Console.WriteLine(sampleStack.Pop());
            }
        }
    }
}
