using System;
using queueWithStacks.Classes;
using StacksAndQueues.Classes;

namespace queueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueWithStacks();
        }

        public static void QueueWithStacks()
        {
            Console.WriteLine("A queue has been created.");

            PseudoQueue queue = new PseudoQueue();

            Node node1 = new Node(11);
            Node node2 = new Node(23);
            Node node3 = new Node(43);
            Node node4 = new Node(7);
            Node node5 = new Node(91);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);

            Console.WriteLine($"{ queue.queueStack.Peek().Value } is currently in front.");

            Node removedNode = queue.Dequeue();

            Console.WriteLine($"{ removedNode.Value } was removed from the queue. { queue.queueStack.Peek().Value } is now in front.");
        }
    }
}
