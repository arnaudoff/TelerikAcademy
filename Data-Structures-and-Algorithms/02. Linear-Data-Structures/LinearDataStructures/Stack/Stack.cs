namespace Stack
{
    using System;

    public class Stack<T>
    {
        private const int DefaultSize = 8;

        private T[] data;
        private int capacity;
        private int top;

        public Stack()
            : this(DefaultSize)
        {
        }

        public Stack(int size)
        {
            this.data = new T[size];
            this.capacity = size;
            this.top = 0;
        }

        public int Size
        {
            get
            {
                return this.top;
            }
        }

        public bool IsFull()
        {
            return this.top == this.capacity;
        }

        public bool IsEmpty()
        {
            return this.top == 0;
        }

        public void Push(T element)
        {
            if (this.top == this.capacity)
            {
                this.Resize();
            }

            this.data[this.top++] = element;
        }

        public T Pop()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException("Cannot pop from an empty stack!");
            }
            
            return this.data[--this.top];
        }

        private void Resize()
        {
            var newData = new T[this.capacity * 2];

            Array.Copy(this.data, newData, this.data.Length);

            this.data = newData;
            this.capacity *= 2;
        }
    }
}
