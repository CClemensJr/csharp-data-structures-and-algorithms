using System;
using LinkedList.Classes;

namespace LinkedList
{
    public class LinkedList
    {
        static void Main(string[] args)
        {
            Node node = new Node();

            LList linkedList = new LList(node);

            Console.WriteLine($"LLHEAD = { linkedList.Head.value }");

            Console.Write("\n\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
