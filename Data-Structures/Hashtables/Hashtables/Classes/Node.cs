using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Node
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public Node Next { get; set; }

        public Node() { }

        /// <summary>
        /// This custome constructor allows key and value to be set upon instantiation
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Node(string key, object value)
        {
            Key = key;
            Value = value;
            Next = new Node();
        }
    }
}
