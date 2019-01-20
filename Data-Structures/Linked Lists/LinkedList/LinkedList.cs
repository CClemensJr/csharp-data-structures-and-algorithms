using System;
using LinkedList.Classes;

namespace LinkedList
{
    public class LinkedList
    {
        static void Main(string[] args)
        {
            LList list = new LList();
            Random rand = new Random();

            list.Insert(23);
            for (int i = 0; i < 10; i++)
            {
                if (i == 6) list.Insert(777);

                list.Insert(rand.Next(50));
            }

            Console.WriteLine("The random link list was created.");

            Console.WriteLine($"\n\nThe list has a node containing 10: { list.Includes(10) }" );
            Console.WriteLine($"The list has a node containing 23: { list.Includes(23) }");
            Console.WriteLine($"The list has a node containing 48: { list.Includes(48) }");

            Console.WriteLine("\n-------------------------------------------------------------------\n");
            Console.WriteLine("Here is the linked list: ");
            Console.WriteLine(list.Print());

            Console.WriteLine("\n-------------------------------------------------------------------\n");
            Console.WriteLine("Inserted a random number before 777");
            list.InsertBefore(777, rand.Next(50));
            Console.WriteLine("Here is the updated list\n");
            Console.WriteLine(list.Print());

            Console.WriteLine("\n-------------------------------------------------------------------\n");
            Console.WriteLine("Inserted a random number after 777");
            list.InsertAfter(777, rand.Next(50));
            Console.WriteLine("Here is the updated list\n");
            Console.WriteLine(list.Print());

            Console.WriteLine("\n-------------------------------------------------------------------\n");
            list.Append(rand.Next(50));
            Console.WriteLine("Appended a random number to the end of the list");
            Console.WriteLine("Here is the updated list\n");
            Console.WriteLine(list.Print());



            Console.Write("\n\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
