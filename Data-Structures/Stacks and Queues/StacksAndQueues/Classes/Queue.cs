using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public Node Temp { get; set; }
        public int Size { get; set; } = 0;

        /// <summary>
        /// The Enqueue method allows a new node to be placed in the end of the queue. It sets the node Next to the Rear node = to the incoming node then sets the Rear node equal to the incoming node.
        /// </summary>
        /// <param name="node"></param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;

            Size++;
        }

        /// <summary>
        /// The Dequeue method removes a node from the queue by setting a temporary node equal to the Front node, then setting Front equal to Front.Next, then sets Temp.Next = to null to remove any stray memory.
        /// </summary>
        /// <returns>The node that was removed from the queue</returns>
        public Node Dequeue()
        {
            Temp = Front;
            Front = Front.Next;
            Temp.Next = null;

            return Temp;
        }

        /// <summary>
        /// This method returns the Front node in the queue.
        /// </summary>
        public Node Peek()
        {
            return Front;
        }
    }
}
