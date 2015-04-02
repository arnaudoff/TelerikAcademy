namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BitArray64 : IEnumerable
    {
        private ulong value;

        public BitArray64(ulong value)
        {
            this.value = value;
        }

        public ulong this[int index]
        {
            get
            {
                return (this.value >> index) & 1;
            }
            set
            {
                if (index < 0 || index >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }

                if (((this.value >> index) & 1) != value)
                {
                    this.value ^= (1u << index);
                }
            }
        }

        public override bool Equals(object obj)
        {
            for (int i = 0; i < 64; i++)
            {
                if (((this.value >> i) & 1) != ((((obj as BitArray64).value >> i)) & 1))
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 63; i >= 0; i--)
            {
                result.Append((value >> i) & 1);
            }

            return result.ToString();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return (int)this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
