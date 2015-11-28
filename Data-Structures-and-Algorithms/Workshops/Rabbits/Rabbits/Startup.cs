namespace Rabbits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] answers = Console.ReadLine()
                .Split(' ')
                .ToArray()
                .Select(int.Parse)
                .Where(x => x != -1)
                .ToArray();

            var rabbitGroups = new Dictionary<int, int>();

            for (int i = 0; i < answers.Length; i++)
            {
                // If the rabbit answers k rabbits, the same color group is k + 1 so it includes the one asked
                if (!rabbitGroups.ContainsKey(answers[i] + 1))
                {
                    rabbitGroups[answers[i] + 1] = 0;
                }

                rabbitGroups[answers[i] + 1]++;
            }

            int result = 0;

            foreach (var group in rabbitGroups)
            {
                int groupsCount = (int)Math.Ceiling(group.Value / (decimal)group.Key);

                result += groupsCount * group.Key;
            }

            Console.WriteLine(result);
        }
    }
}
