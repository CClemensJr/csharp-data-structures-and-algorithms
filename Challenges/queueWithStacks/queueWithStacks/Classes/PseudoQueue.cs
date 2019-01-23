using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace queueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stack queueStack { get; set; }

        /// <summary>
        /// This method takes in a node object. If the queue stack is empty the node is pushed into the stack, otherwise the queue stack is emptied into the temporary stack, the node placed in the empty queue stack, and then the temp stack is emptied into the queue stack
        /// </summary>
        /// <param name="node"></param>
        public void Enqueue(Node node)
        {
            Stack tempStack = new Stack();

            if (queueStack.Top != null)
            {
                while (queueStack.Top != null)
                {
                    tempStack.Push(queueStack.Pop());
                }

                queueStack.Push(node);

                while (tempStack.Top != null)
                {
                    queueStack.Push(tempStack.Pop());
                }
            }
            else
            {
                queueStack.Push(node);
            }
        }

        /// <summary>
        /// This method checks the stack for a node. If there is one, it is popped otherwise null is returned.
        /// </summary>
        /// <returns>A node object that has been removed from a stack</returns>
        public Node Dequeue()
        {
            if (queueStack.Top != null)
            {
                return queueStack.Pop();
            }

            return null;
        }
    }
}
