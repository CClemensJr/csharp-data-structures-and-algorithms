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
    }

    public LList RemoveDuplicateNodes(LList list)
    {
        list.Current = list.Head;

        while(list.Current != null)
        {
            Node currentNode = list.Current;

            while (currentNode.Next != null)
            {

            }
        }

        return list;
    }
}
