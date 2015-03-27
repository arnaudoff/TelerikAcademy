namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException where T : IComparable<T>
    {
        public InvalidRangeException(string message, T start, T end, Exception e) 
                : base(String.Format("{0} (argument should be in the range {1} - {2})", message, start, end), e)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end) : this(message, start, end, null) { }

        public InvalidRangeException(T start, T end) : this(null, start, end, null) { }

        public T Start { get; set; }

        public T End { get; set; }
    }
}
