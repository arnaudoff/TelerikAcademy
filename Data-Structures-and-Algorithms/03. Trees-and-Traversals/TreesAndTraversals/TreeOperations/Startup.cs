namespace TreeOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var nodes = new Dictionary<int, Node<int>>();

            for (var i = 0; i < N - 1; i++)
            {
                int[] nodePair = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                int parent = nodePair[0];
                int child = nodePair[1];

                Node<int> parentNode;
                Node<int> childNode;

                if (nodes.ContainsKey(parent))
                {
                    parentNode = nodes[parent];
                }
                else
                {
                    parentNode = new Node<int>(parent);
                    nodes.Add(parent, parentNode);
                }

                if (nodes.ContainsKey(child))
                {
                    childNode = nodes[child];
                }
                else
                {
                    childNode = new Node<int>(child);
                    nodes.Add(child, childNode);
                }

                parentNode.AddChild(childNode);
            }

            var root = GetRootNode(nodes.Values);
            Console.WriteLine("Root: {0}", root.Value);
            Console.WriteLine("Leaves: {0}", string.Join(" ", GetLeaves(nodes.Values).Select(n => n.Value)));
            Console.WriteLine("Middle nodes: {0}", string.Join(" ", GetMiddleNodes(nodes.Values).Select(n => n.Value)));
            Console.WriteLine("Longest path: {0}", FindLongestPath(root) + 1 ); // + 1 for the root
        }

        /*
         * It's hard to understand why these work. The conception is a bit weird, but apparently EVERY node
         * is stored as a dictionary value. This is why these simple queries actually work - imagine the iterative traversing as recursive!
         * This is where I cried the most.
         */
       
        private static Node<int> GetRootNode(ICollection<Node<int>> nodes)
        {
            Node<int> root = nodes
                .Where(n => !n.HasParent)
                .FirstOrDefault();

            if (root == null)
            {
                throw new InvalidOperationException("Invalid tree.");
            }

            return root;
        }

        private static IEnumerable<Node<int>> GetLeaves(ICollection<Node<int>> nodes)
        {
            return nodes
                .Where(n => n.NumberOfChildren == 0)
                .ToList();
        }

        private static IEnumerable<Node<int>> GetMiddleNodes(ICollection<Node<int>> nodes)
        {
            return nodes.Where(n => n.NumberOfChildren > 0 && n.HasParent);
        }

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            return maxPath + 1;
        }
    } 
}
