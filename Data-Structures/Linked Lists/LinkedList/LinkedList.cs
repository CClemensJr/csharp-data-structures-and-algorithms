using System;
using LinkedList.Classes;

namespace LinkedList
{
    public class LinkedList
    {
        static void Main(string[] args)
        {
            Node node = new Node();

            LList linkedList = new LList();

            Console.Write($"Enter a number:");
            string input = Console.ReadLine();
            int nodeValue = int.Parse(input);

            linkedList.Insert(nodeValue);

            Console.WriteLine($"The value of Head is { linkedList.Head.value }");


            Console.Write("\n\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
