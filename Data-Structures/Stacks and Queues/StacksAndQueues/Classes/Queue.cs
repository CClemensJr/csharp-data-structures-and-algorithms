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
            Temp = Front;
            Front = Front.Next;
            Temp.Next = null;

            return Temp;
        }

        public void Peek()
        {
            return Front;
        }
    }
}
