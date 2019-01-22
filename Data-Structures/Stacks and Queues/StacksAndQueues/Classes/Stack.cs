using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Stack
    {
        public Node Top { get; set; }
        public Node Temp { get; set; }

        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        public Node Pop(Node node)
        {
            Temp = Top;
            Top = node.Next;
            Temp.Next = null;

            return Temp;
        }
    }
}
