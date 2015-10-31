namespace LinkedList
{
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedList()
        {
        }

        public ListItem<T> FirstElement { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            var currentElement = this.FirstElement;

            while (currentElement != null)
            {
                yield return currentElement.Value;

                currentElement = currentElement.NextItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
