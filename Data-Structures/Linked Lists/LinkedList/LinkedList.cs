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
            Console.WriteLine("Here is the linked list:");
            list.Print();

            Console.WriteLine("\n-------------------------------------------------------------------\n");
            Console.WriteLine("Inserted a random number before 777");
            list.InsertBefore(777, rand.Next(50));
            Console.WriteLine("Here is the updated list\n");
            list.Print();

            Console.WriteLine("\n-------------------------------------------------------------------\n");
            Console.WriteLine("Inserted a random number after 777");
            list.InsertAfter(777, rand.Next(50));
            Console.WriteLine("Here is the updated list\n");
            list.Print();

            Console.WriteLine("\n-------------------------------------------------------------------\n");
            list.Append(rand.Next(50));
            Console.WriteLine("Appended a random number to the end of the list");
            Console.WriteLine("Here is the updated list\n");
            list.Print();



            Console.Write("\n\nPress any key to continue...");
            Console.ReadLine();
        }

        //static void Interface(LList list)
        //{
        //    try
        //    {
        //        Console.Clear();

        //        Console.WriteLine("What would you like to do?\n\n");
        //        Console.WriteLine("1. Create a linked list");
        //        Console.WriteLine("2. Check if a number is in the linked list");
        //        Console.WriteLine("3. See the nodes in the linked list");
        //        Console.WriteLine("4. Exit");
        //        string userInput = Console.ReadLine();
        //        int selection = int.Parse(userInput);

        //        switch (selection)
        //        {
        //            case 1:
        //                CreateNodes(list);

        //                break;

        //            case 2:
        //                CheckNodes(list);

        //                break;

        //            case 3:
        //                ShowNodes(list);

        //                break;

        //            case 4:
        //                Environment.Exit(32);

        //                break;

        //            default:

        //                Console.WriteLine("Please make a valid selection");

        //                Interface(list);

        //                break;
        //        }
                
        //    }
        //    catch (Exception error)
        //    {
        //        Console.Write("An error has occurred: ");
        //        Console.WriteLine(error.Message);

        //        Console.Write("\n\nPress any key to exit...");
        //        Console.ReadLine();
        //    }
        //}

        //static void CreateNodes(LList list)
        //{
        //    try
        //    {
        //        Console.Clear();
        //        Console.WriteLine("\n\nEnter whole numbers to add nodes to your list. Enter DONE when finished:");

        //        string userInput = "";
        //        int nodeValue = 0;

        //        while (userInput != "DONE")
        //        {
        //            userInput = Console.ReadLine();

        //            if (userInput.Contains("DONE"))
        //            {
        //                Interface(list);
        //            }

        //            nodeValue = int.Parse(userInput);

        //            list.Insert(nodeValue);
        //        }

        //    }
        //    catch (Exception error)
        //    {
        //        Console.Write("An error has occurred: ");
        //        Console.WriteLine(error.Message);

        //        CreateNodes(list);
        //    }
        //    finally
        //    {
        //        Interface(list);
        //    }
        //}

        //static void CheckNodes(LList list)
        //{
        //    try
        //    {
        //        Console.Clear();
        //        Console.Write("\n\nEnter a number to see if it is in the linked list:  ");

        //        string userInput = Console.ReadLine();
        //        int checkNumber = int.Parse(userInput);

        //        bool isInList = list.Includes(checkNumber);

        //        Console.WriteLine($"The number { checkNumber } is in the list: { isInList }");

        //    }
        //    catch (Exception error)
        //    {
        //        Console.Write("An error has occurred: ");
        //        Console.WriteLine(error.Message);

        //        CheckNodes(list);
        //    }
        //    finally
        //    {
        //        Interface(list);
        //    }
        //}

        //static void ShowNodes(LList list)
        //{
        //    try
        //    {
        //        Console.Clear();

        //        list.Print();
        //    }
        //    catch (Exception error)
        //    {
        //        Console.Write("An error has occurred: ");
        //        Console.WriteLine(error.Message);

        //        ShowNodes(list);
        //    }
        //    finally
        //    {
        //        Interface(list);
        //    }
        //}
    }
}
