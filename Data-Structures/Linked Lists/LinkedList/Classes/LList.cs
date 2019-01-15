using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
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
        /// The InsertBefore method takes the value of an existing node and a new value. The method checks if the Head is equal to the new value and inserts the new node if true. Otherwise, the method iterates through the list and when the next node value is equal to the value of the existing node, it sets the new node as the next value and then sets the value of the original node as it's next value.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="newNumber"></param>
        public void InsertBefore(int number, int newNumber)
        {
            try
            {
                Current = Head;

                if (Current.Value == newNumber)
                {
                    Insert(newNumber);

                    return;
                }

                while (Current.Next != null)
                {
                    if (Current.Next.Value == number)
                    {
                        Node node = new Node(newNumber);

                        node.Next = Current.Next;
                        Current.Next = node;

                        return;
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
        }

        public void InsertAfter(int number, int newNumber)
        {
            try
            {
                Current = Head;

                while (Current.Next != null)
                {
                    if (Current.Next.Value == number)
                    {
                        Node node = new Node(newNumber);

                        Current = Current.Next;
                        node.Next = Current.Next;
                        Current.Next = node;

                        return;
                    }

                    Current = Current.Next;
                }

                if (Current.Value == number) Append(newNumber);
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
        /// The Append method takes a value, iterates over the list, then sets the Next property of the Current node to the new node.
        /// </summary>
        /// <param name="number"></param>
        public void Append(int number)
        {
            try
            {
                Node node = new Node(number);

                while (Current.Next != null)
                {
                    Current = Current.Next;
                }

                Current.Next = node;
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
                        return true;
                    }

                    Current = Current.Next;
                }

                if (Current.Value == number) return true;
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
        /// The Print method creates a string, uses iteration to add the values of each node to the string, and then returns the string to the consuming method.
        /// </summary>
        /// <returns>Returns a string with the values for allnodes</returns>
        public string Print()
        {
            try
            {
                int i = 1;
                string output = "";

                Current = Head;

                while (Current.Next != null)
                {
                    output += $"| Node { i } >> Value = { Current.Value } |";

                    i++;

                    Current = Current.Next;
                }

                return output;
            }
            catch (Exception error)
            {
                Console.Write("An error has occurred: ");
                Console.WriteLine(error.Message);

                Console.Write("\n\nPress any key to exit...");
                Console.ReadLine();
            }

            return null;
        }
    }
}
