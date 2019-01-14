using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }
        private int TotalNodes { get; set; } = 1;


        public void Insert (int number)
        {
            Node node = new Node(number);
            TotalNodes++;

            node.Next = Head;
            Head = node;
            Current = Head;
        }

        public bool Includes (int number)
        {
            while (Current.Next != null)
            {
                if (Current.Value == number)
                {
                    Console.WriteLine($"The number { number } is in the list");
                    return true;
                }

                Current = Current.Next;
            }

            return false;
        }

        public void Print()
        {
            int i = 1;

            Current = Head;

            while (Current.Next != null)
            {
                Console.WriteLine($"Node { i }: Value = { Current.Value }");

                i++;

                Current = Current.Next;
            }

            Console.WriteLine($"Node { i }: Value = { Current.Value }");
        }
    }
}
