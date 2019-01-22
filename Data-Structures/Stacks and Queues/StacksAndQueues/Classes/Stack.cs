using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// This method takes a new node and pushes it into the top of the stack by setting it = to the Top node.
        /// </summary>
        /// <param name="node"></param>
        public void Push(Node node)
        {
            try
            {
                node.Next = Top;
                Top = node;
            }
            catch (Exception error)
            {
                Console.WriteLine("Something has happened: ");
                Console.WriteLine(error.Message);
            }
        }

        /// <summary>
        /// This method removes the node at the Top of the stack and returns it for consumption.
        /// </summary>
        /// <param name="node"></param>
        /// <returns>The node that was removed from the stack</returns>
        public Node Pop(Node node)
        {
            try
            {
                Node temp = new Node();
                temp = Top;
                Top = node.Next;
                temp.Next = null;

                return temp;
            }
            catch (Exception error)
            {
                Console.WriteLine("Something has happened: ");
                Console.WriteLine(error.Message);
            }

            return null;
        }

        /// <summary>
        /// This method returns the node at the Top of the stack.
        /// </summary>
        /// <returns>The node that is at the top of the stack</returns>
        public Node Peek()
        {
            try
            {
                return Top;
            }
            catch (Exception error)
            {
                Console.WriteLine("Something has happened: ");
                Console.WriteLine(error.Message);
            }

            return null;
        }
    }
}
