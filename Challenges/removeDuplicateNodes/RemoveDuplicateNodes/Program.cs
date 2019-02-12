using System;
using LinkedList.Classes;

namespace RemoveDuplicateNodes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        /// <summary>
        /// This method takes a list, iterates over the list, removes duplicate nodes, and then returns the updated list
        /// </summary>
        /// <param name="list"></param>
        /// <returns>An updated LinkedList</returns>
        public static LList RemoveDuplicateNodes(LList list)
        {
            list.Current = list.Head;

            while(list.Current != null)
            {
                Node currentNode = list.Current;

                while (currentNode.Next != null)
                {
                    if (currentNode.Next == list.Current)
                    {
                        currentNode = currentNode.Next;
                        currentNode.Next = currentNode;
                        currentNode = currentNode.Next;
                    }
                    else
                    {
                        currentNode = currentNode.Next;
                    }
                }

                list.Current = list.Current.Next;
            }

            return list;
        }
    }

}
