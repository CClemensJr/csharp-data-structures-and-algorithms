using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public void Insert (int number)
        {
            try
            {
                Node node = new Node(number);

                node.Next = Head;
                Head = node;
                Current = Head;
            }
            catch (Exception error)
            {
                Console.Write("An error has occurred: ");
                Console.WriteLine(error.Message);
            }
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
