using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Node
    {
        public object Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public Node() {}
        public Node(object value)
        {
            Value = value;
        }
    }
}
