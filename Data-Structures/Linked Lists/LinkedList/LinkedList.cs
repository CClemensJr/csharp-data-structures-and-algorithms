using System;
using LinkedList.Classes;

namespace LinkedList
{
    public class LinkedList
    {
        static void Main(string[] args)
        {
            LList linkedList = new LList();

            linkedList.Insert(27);
            linkedList.Insert(13);
            linkedList.Insert(29);
            linkedList.Insert(5);
            linkedList.Insert(49);
            linkedList.Insert(58);
            linkedList.Insert(32);

            int value = 27;
            bool isInList = linkedList.Includes(value);
            Console.WriteLine($"The value of { value } is in list: { isInList }");

            linkedList.Print();

            Console.Write("\n\nPress any key to continue...");
            Console.ReadLine();
        }

        static void Interface()
        {
            try
            {
                Console.WriteLine("What would you like to do?\n\n");
                Console.WriteLine("1. Create a linked list");
                Console.WriteLine("2. Check if a number is in the linked list");
                string userInput = Console.ReadLine();
                int selection = int.Parse(userInput);

                switch (selection)
                {
                    case 1:
                        CreateNodes();

                        break;

                    case 2:
                        CheckNodes();

                        break;

                    default:

                        Console.WriteLine("Please make a valid selection");

                        Interface();

                        break;
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

        static void CreateNodes()
        {
            try
            {
                Console.WriteLine("Lets create a linked list.");
                Console.WriteLine("Enter whole numbers to add nodes to your list. Enter DONE when finished:");

                
            }
            catch (Exception error)
            {
                Console.Write("An error has occurred: ");
                Console.WriteLine(error.Message);

                Console.Write("\n\nPress any key to exit...");
                Console.ReadLine();
            }
        }
    }
}
