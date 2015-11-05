namespace TreeOperations
{
    using System;
    using System.Collections.Generic;

    public class Node<T>
    {
        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public bool HasParent { get; set; }

        public int NumberOfChildren
        {
            get
            {
                return this.Children.Count;
            }
        }

        public Node()
        {
            this.Children = new List<Node<T>>();
        }

        public Node(T value)
            : this()
        {
            this.Value = value;
        }

        public void AddChild(Node<T> child)
        {
            child.HasParent = true;
            this.Children.Add(child);
        }
    }
}
