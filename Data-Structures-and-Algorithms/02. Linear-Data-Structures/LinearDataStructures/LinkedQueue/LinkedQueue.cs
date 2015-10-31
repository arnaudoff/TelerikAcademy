namespace LinkedQueue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedQueue<T> : IEnumerable<T>
    {
        private readonly LinkedList<T> data;

        public LinkedQueue()
        {
            this.data = new LinkedList<T>();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public T Peek()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("Cannot peek from an empty queue!");
            }

            return this.data.First.Value;
        }

        public void Enqueue(T item)
        {
            this.data.AddLast(item);
        }

        public T Dequeue()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("Cannot dequeue from an empty queue!");
            }

            var head = this.data.First;
            this.data.RemoveFirst();
            return head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
