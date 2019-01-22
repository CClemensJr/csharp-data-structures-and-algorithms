using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// This constructor allows Node objects with no properties defined to be instantiated.
        /// </summary>
        public Node() { }

        /// <summary>
        /// This custom constructor allows a Node object to be created with a set Value property
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
