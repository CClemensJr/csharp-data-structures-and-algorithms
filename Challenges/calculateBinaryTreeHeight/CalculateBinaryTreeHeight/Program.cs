using System;
using System.Collections;
using System.Collections.Generic;
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
            Queue<Node> queue = new Queue<Node>();

            int height = 0;

            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                Node parentNode = queue.Peek();

                if (parentNode.LeftChild != null)
                {
                    queue.Enqueue(parentNode.LeftChild);
                }
                else if (parentNode.RightChild != null)
                {
                    queue.Enqueue(parentNode.RightChild);
                }
                else
                {
                    return 0;
                }

                queue.Dequeue();

                height++;
            }

            return height;
        }
    }
}
