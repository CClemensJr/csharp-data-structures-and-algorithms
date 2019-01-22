using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Stack
    {
        public Node Top { get; set; }
        public Node Temp { get; set; }

        public Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
