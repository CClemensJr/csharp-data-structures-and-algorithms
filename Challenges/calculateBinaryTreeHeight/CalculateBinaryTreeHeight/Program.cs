using System;
using System.Collections;
using Tree.Classes;

namespace CalculateBinaryTreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int CalculateBinaryTreeHeight(Node root)
        {
            Queue queue = new Queue();

            int height = 0;

            queue.Enqueue(root);

            while(queue.Count > 0)
            {

            }

            return height;
        }
    }
}
