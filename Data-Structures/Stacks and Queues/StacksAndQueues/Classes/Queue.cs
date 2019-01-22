using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public Node Temp { get; set; }

        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        public Node Dequeue()
        {

        }

        public void Peek()
        {
            return Front;
        }
    }
}
