namespace LinkedQueue
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var linkedQueue = new LinkedQueue<int>();
            linkedQueue.Enqueue(42);
            linkedQueue.Enqueue(666);
            linkedQueue.Enqueue(1337);

            while (linkedQueue.Count > 0)
            {
                Console.WriteLine(linkedQueue.Dequeue());
            }
        }
    }
}
