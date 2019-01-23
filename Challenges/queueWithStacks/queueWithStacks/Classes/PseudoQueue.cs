using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace queueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stack queueStack { get; set; }

        public void Enqueue(Node node)
        {
            Stack tempStack = new Stack();

            if (queueStack.Top != null)
            {
                while (queueStack.Top != null)
                {
                    tempStack.Push(queueStack.Pop());
                }
            }
        }

        public Node Dequeue()
        {
            return null;
        }
    }
}
