namespace HeapPriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            PriorityQueue<char> pq = new PriorityQueue<char>();
            pq.Enqueue('a', 2);
            pq.Enqueue('b', 1);
            pq.Enqueue('c', 0);
            pq.Enqueue('d', 133);

            while (pq.Count > 0)
            {
                Console.WriteLine(pq.Dequeue());
            }
        }
    }
}
