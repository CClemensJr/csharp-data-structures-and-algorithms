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
            Console.WriteLine("A queue with the following values has been created: ");

            PseudoQueue queue = new PseudoQueue();
            
            for (int i = 0; i < 10; i++)
            {
                Node node(i) = new Node();

            }


        }
    }
}
