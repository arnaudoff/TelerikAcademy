namespace JediMeditation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using JediMeditation.PriorityQueue;

    public class PriorityQueueSolution
    {
        public static void Main()
        {
            Console.ReadLine();
            List<JediRank> currentJedisOrder = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => new JediRank { RankName = x })
                .ToList();

            HeapPriorityQueue<JediRank> priorityQueue = new HeapPriorityQueue<JediRank>(100000);

            foreach (var jedi in currentJedisOrder)
            {
                if (jedi.RankName[0] == 'm')
                {
                    priorityQueue.Enqueue(jedi, 1);
                }
            }

            foreach (var jedi in currentJedisOrder)
            {
                if (jedi.RankName[0] == 'k')
                {
                    priorityQueue.Enqueue(jedi, 2);
                }
            }

            foreach (var jedi in currentJedisOrder)
            {
                if (jedi.RankName[0] == 'p')
                {
                    priorityQueue.Enqueue(jedi, 3);
                }
            }

            StringBuilder result = new StringBuilder();
            while (priorityQueue.Count != 0)
            {
                result.Append(priorityQueue.Dequeue().RankName);

                if (priorityQueue.Count >= 1)
                {
                    result.Append(" ");
                }
            }

            Console.WriteLine(result);
        }
    }
}