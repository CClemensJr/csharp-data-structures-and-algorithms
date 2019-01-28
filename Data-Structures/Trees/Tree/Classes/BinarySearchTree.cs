using System;
using System.Collections.Generic;
using System.Text;
using Tree.Classes;

namespace Tree.Classes
{
    public class BinarySearchTree
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
            }
            catch(Exception error)
            {
                Console.WriteLine($"An error has occurred: { error.Message } ");
            }
        }

        /// <summary>
        /// This method takes a value then traverses the tree returning true or false depending on if the value is in the tree
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True or false, depending on if the value is in the tree</returns>
        public bool Contains(int value)
        {
            // Determine if value is in try at least once
            return false;
        }
    }
}
