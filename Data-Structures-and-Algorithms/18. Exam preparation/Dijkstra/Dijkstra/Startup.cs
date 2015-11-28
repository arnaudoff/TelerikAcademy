namespace Dijkstra
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Startup
    {
        private static int n = 6;
        private static int m = 10;

        public static void Main(string[] args)
        {
            string inputGraph = @"
0 3 7
0 4 3
0 5 5
5 4 3
5 2 17
2 4 100
2 1 10
4 3 1
4 1 1
1 3 2";
            List<Node>[] vertices = new List<Node>[n];

            string[] edges = inputGraph.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var edgeAsString in edges)
            {
                int[] edgeInfo = edgeAsString.Split(' ').Select(int.Parse).ToArray();
                int v1 = edgeInfo[0];
                int v2 = edgeInfo[1];
                int w = edgeInfo[2];

                if (vertices[v1] == null)
                {
                    vertices[v1] = new List<Node>();
                }

                if (vertices[v2] == null)
                {
                    vertices[v2] = new List<Node>();
                }

                var firstNode = new Node(v1, w);
                var secondNode = new Node(v2, w);

                vertices[v1].Add(secondNode);
                vertices[v2].Add(firstNode);
            }

            Dijkstra(vertices, 0);
        }

        private static void Dijkstra(List<Node>[] vertices, int startNode)
        {
            int[] dist = new int[n];
            for (int i = 0; i < vertices.Length; i++)
            {
                dist[i] = int.MaxValue;
            }

            dist[startNode] = 0;

            var queue = new PriorityQueue<Node>();
            queue.Enqueue(new Node(startNode, 0));

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                foreach (var neighbour in vertices[current.Vertex])
                {
                    var currentDistance = dist[neighbour.Vertex];
                    var newDistance = dist[current.Vertex] + neighbour.Weight;

                    if (newDistance < currentDistance)
                    {
                        dist[neighbour.Vertex] = newDistance;
                        queue.Enqueue(new Node(neighbour.Vertex, newDistance));
                    }
                }
            }

            for (int i = 0; i < dist.Length; i++)
            {
                Console.WriteLine("{0} -> {1} = {2}", startNode, i, dist[i]);
            }
        }
    }
}
