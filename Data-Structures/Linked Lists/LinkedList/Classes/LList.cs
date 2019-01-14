using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }
        private int Nodes { get; set; } = 1;

        //public LList(Node node)
        //{
        //    Head = node;
        //    Current = Head;
        //}

        public void Insert (int number)
        {
            Node node = new Node(number);
            Nodes++;

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
                    return true;
                }

                Current = Current.Next;
            }

            return false;
        }

        public void Print()
        {
            int i = 1;

            while (Current.Next != null)
            {
                Console.WriteLine($"Node { i }: Value = { Current.Value }");
            }
        }
    }
}
