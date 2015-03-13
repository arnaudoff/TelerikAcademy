namespace GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
	    private const int INITIAL_SIZE = 8;
        private T[] values;

        public GenericList(int size = INITIAL_SIZE)
        {
            this.values = new T[size];
            this.Capacity = size;
            this.Count = 0;
        }

        public int Count {get; private set; }

        public int Capacity {get; set; }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Count)
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
                if (index >= 0 && index < this.Count)
                {
                    this.values[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index was outside the bounds of the list.");
                }
            }
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

        // Returns -1 if the element is not present in the array.
        public int IndexOf(T element)
        {
            int index = -1;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.values[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
        public void InsertAt(int index, T element)
        {
            if (index >= 0 && index < this.Count)
            {
                if (index + 1 == this.values.Length)
                {
                    Resize();
                }

                for (int i = this.Count; i > index; i--)
                {
                    this.values[i] = this.values[i - 1];
                }

                this.values[index] = element;
                this.Count++;
            }
            else
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the list.");
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                for (int i = index + 1; i < this.Count; i++)
                {
                    this.values[i - 1] = this.values[i];
                }

                this.values[this.Count--] = default(T);
            }
            else
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the list.");
            }
        }

        // Generic type comparison workaround: http://stackoverflow.com/questions/6480577/c-sharp-generics-how-to-compare-values-of-generic-types
        public T Max()
        {

            if (this.Count <= 0)
            {
                throw new InvalidOperationException("The maximum of an empty list cannot be determined.");
            }
            else
            {
                T max = this.values[0];
                for (int i = 1; i < this.Count; i++)
                {
                    if (max.CompareTo(this.values[i]) < 0)
                    {
                        max = this.values[i];
                    }
                }

                return max;
            }
        }

        public T Min()
        {

            if (this.Count <= 0)
            {
                throw new InvalidOperationException("The minimum of an empty list cannot be determined.");
            }
            else
            {
                T min = this.values[0];
                for (int i = 1; i < this.Count; i++)
                {
                    if (min.CompareTo(this.values[i]) > 0)
                    {
                        min = this.values[i];
                    }
                }

                return min;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                sb.Append(string.Format("{0} ", this.values[i]));
            }

            return sb.ToString();
        }

        public void Clear()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.values[i] = default(T);
            }

            this.Count = 0;
        }

        private void Resize()
        {
            int newSize = this.values.Length * 2;
            T[] resizedValues = new T[newSize];

            // Array.Copy would also work fine here
            for (int i = 0; i < this.Count; i++)
            {
                resizedValues[i] = this.values[i];
            }

            this.values = resizedValues;
            this.Capacity *= 2;
        }

    }
}
