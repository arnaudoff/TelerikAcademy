namespace JediMeditation
{
    using System;
    using System.Collections.Generic;

    public static class QueueSolution
    {
        // Old solution, kept for reference only - 68 points with time limit hit.
        public static void Solve()
        {
            int N = int.Parse(Console.ReadLine());
            string[] currentJedisOrder = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Queue<string> newJedisOrder = new Queue<string>();

            EnqueueJediType(newJedisOrder, currentJedisOrder, 'm');
            EnqueueJediType(newJedisOrder, currentJedisOrder, 'k');
            EnqueueJediType(newJedisOrder, currentJedisOrder, 'p');

            while (newJedisOrder.Count > 0)
            {
                Console.Write(newJedisOrder.Dequeue());

                if (newJedisOrder.Count == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }

        public static void EnqueueJediType(Queue<string> newJedisOrder, string[] currentJedisOrder, char jediTypePrefix)
        {
            foreach (var jedi in currentJedisOrder)
            {
                if (jedi[0] == jediTypePrefix)
                {
                    newJedisOrder.Enqueue(jedi);
                }
            }
        }
    }
}