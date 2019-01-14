using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        //public LList(Node node)
        //{
        //    Head = node;
        //    Current = Head;
        //}

        public void Insert (int number)
        {
            Node node = new Node(number);

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

        public int[] Print()
        {

            return [1];
        }
    }
}
