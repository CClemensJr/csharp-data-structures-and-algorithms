using System;
using LinkedList.Classes;

namespace LinkedList
{
    public class LinkedList
    {
        static void Main(string[] args)
        {
            //Node node = new Node();
            LList linkedList = new LList();

            //Console.Write($"Enter a number:");
            //string input = Console.ReadLine();
            //int nodeValue = int.Parse(input);

            linkedList.Insert(27);
            linkedList.Insert(13);
            linkedList.Insert(29);
            linkedList.Insert(5);
            linkedList.Insert(49);
            linkedList.Insert(58);
            linkedList.Insert(32);


            Console.WriteLine($"The value of Head is { linkedList.Head.value }");


            Console.Write("\n\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
