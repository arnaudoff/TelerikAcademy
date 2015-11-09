namespace HeapPriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class MinHeap<T> where T : IComparable<T>
    {
        private List<T> data;

        public MinHeap()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
            RecursiveSwapUp(this.data.Count - 1);
        }

        public T RemoveMin()
        {
            if (this.Count < 0)
            {
                throw new InvalidOperationException("Heap is empty!");
            }

            T ret = this.data[0];
            this.data[0] = this.data[this.data.Count - 1];
            this.data.RemoveAt(this.data.Count - 1);
            if (this.data.Count > 0)
            {
                // Balance the heap after swap
                RecursiveSwapDown(0);
            }
            return ret;
        }

        // Since it's a min heap, we have to maintain its order.
        private void RecursiveSwapUp(int index)
        {
            if (this.data[index].CompareTo(this.data[index / 2]) == -1)
            {
                T tmp = this.data[index];
                this.data[index] = this.data[index / 2];
                this.data[index / 2] = tmp;

                // This recursively goes up the heap and swaps the parent node with the child
                RecursiveSwapUp(index / 2);
            }
        }

        private void RecursiveSwapDown(int index)
        {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;
            int minIndex;
            T tmp;

            // Edge cases
            if (rightChildIndex >= this.data.Count)
            {
                if (leftChildIndex >= this.data.Count)
                {
                    return;
                }
                else // Catches the case when there is only one children
                {
                    minIndex = leftChildIndex;
                }
            }
            else
            {
                // Compare two children and get the one with min priority
                if (data[leftChildIndex].CompareTo(data[rightChildIndex]) < 0
                    || data[leftChildIndex].CompareTo(data[rightChildIndex]) == 0)
                {
                    minIndex = leftChildIndex;
                }
                else
                {
                    minIndex = rightChildIndex;
                }
            }

            // Compare the one with less priority with root
            if (data[minIndex].CompareTo(data[index]) < 0)
            {
                tmp = data[minIndex];
                data[minIndex] = data[index];
                data[index] = tmp;
                RecursiveSwapDown(minIndex);
            }
        }

        public T Peek()
        {
            return this.data[0];
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }
    }
}
