using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Tree
    {
        public Node root { get; set; }

        /// <summary>
        /// This method takes in a value and adds it to the tree. If the root node is null, the node is set to root. Subsequent nodes are added in a left to right fashion.
        /// </summary>
        /// <param name="value"></param>
        public void Add(int value)
        {
            try
            {
                Node node = new Node();

                node.Value = value;

                if (root == null)
                {
                    root = node;
                }

                if (root.LeftChild == null)
                {
                    root.LeftChild = node;
                }

                if (root.RightChild == null)
                {
                    root.RightChild = node;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"An error has occurred: { error.Message } ");
            }
        }
    }
}
