using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        public Node Temp { get; set; }

        /// <summary>
        /// This method takes a new node and pushes it into the top of the stack by setting it = to the Top node.
        /// </summary>
        /// <param name="node"></param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// This method removes the node at the Top of the stack and returns it for consumption.
        /// </summary>
        /// <param name="node"></param>
        /// <returns>The node that was removed from the stack</returns>
        public Node Pop(Node node)
        {
            Temp = Top;
            Top = node.Next;
            Temp.Next = null;

            return Temp;
        }

        /// <summary>
        /// This method returns the node at the Top of the stack.
        /// </summary>
        /// <returns>The node that is at the top of the stack</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
