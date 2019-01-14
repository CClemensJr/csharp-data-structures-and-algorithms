using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// The insert method takes a value and uses it to create a node. It then sets the next property of the node to Head, the Head property to the current node, and the Current property equal to Head
        /// </summary>
        /// <param name="number"></param>
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

                Console.Write("\n\nPress any key to exit...");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// The Includes method takes a number, sets the Current node to the Head node, and then iterates over the list, returning true of the number matches any of the node values. Otherwise it returns false
        /// </summary>
        /// <param name="number"></param>
        /// <returns>True if the number is in the list, False if it is not</returns>
        public bool Includes (int number)
        {
            try
            {
                Current = Head;

                while (Current.Next != null)
                {
                    if (Current.Value == number)
                    {
                        Console.WriteLine($"The number { number } is in the list");
                        return true;
                    }

                    Current = Current.Next;
                }
            }
            catch (Exception error)
            {
                Console.Write("An error has occurred: ");
                Console.WriteLine(error.Message);

                Console.Write("\n\nPress any key to exit...");
                Console.ReadLine();
            }

            return false;
        }

        /// <summary>
        /// The Print method sets the Current node to Head and then iterates over all of the nodes in the list, writing them to the console.
        /// </summary>
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
