namespace HeapPriorityQueue
{
    using System;

    public class PriorityQueue<T>
    {
        internal class Node : IComparable<Node>
        {
            public int Priority { get; set; }

            public T Value { get; set; }

            public int CompareTo(Node other)
            {
                return Priority.CompareTo(other.Priority);
            }
        }

        private MinHeap<Node> minHeap = new MinHeap<Node>();

        public void Enqueue(T element, int priority)
        {
            minHeap.Add(new Node() { Value = element, Priority = priority });
        }

        public T Dequeue()
        {
            return minHeap.RemoveMin().Value;
        }

        public T Peek()
        {
            return minHeap.Peek().Value;
        }

        public int Count
        {
            get
            {
                return minHeap.Count;
            }
        }
    }
}
