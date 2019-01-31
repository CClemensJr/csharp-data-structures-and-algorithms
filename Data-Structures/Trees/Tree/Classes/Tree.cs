using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Tree
    {
        public Node Root { get; set; }

        /// <summary>
        /// This method takes in a value and adds it to the tree. If the root node is null, the node is set to root. Subsequent nodes are added in a left to right fashion.
        /// </summary>
        /// <param name="value"></param>
        public void Add(int value)
        {
            try
            {
                if (Root == null)
                {
                    Root = new Node(value);
                }

                if (Root.LeftChild == null)
                {
                    Root.LeftChild = new Node(value);
                }

                if (Root.RightChild == null)
                {
                    Root.RightChild = new Node(value);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"An error has occurred: { error.Message } ");
            }
        }
    }
}
