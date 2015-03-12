namespace GenericList
{
    using System;

    public class GenericList<T>
    {
	    private const int INITIAL_SIZE = 8;
        private T[] values;

        public GenericList(int size = INITIAL_SIZE)
        {
            this.values = new T[size];
            this.Capacity = size;
            this.Count = 0;
        }

        public int Count {get; set; }

        public int Capacity {get; set; }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.values.Length)
                {
                    return this.values[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index was outside the bounds of the list.");
                }

            }
            set
            {
                if (index >= 0 && index < this.values.Length)
                {
                    this.values[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index was outside the bounds of the list");
                }
            }
        }

        private void Resize()
        {
            int newSize = this.values.Length * 2;
            T[] resizedValues = new T[newSize];

            // Array.Copy would also do..
            for (int i = 0; i < this.Count; i++)
            {
                resizedValues[i] = this.values[i];
            }

            this.values = resizedValues;
            this.Capacity *= 2;
        }

        public void Add(T element)
        {
            if (this.Count >= values.Length)
            {
                this.Resize();
            }
            this.values[this.Count] = element;
            this.Count++;
        }

        
    }
}
