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

                if (root.LeftChild == null)
                {
                    root.LeftChild = node;
                }

                if (root.RightChild == null)
                {
                    root.RightChild = node;
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
            try
            {
                if (root.Value == value)
                {
                    return true;
                }

                while (root.RightChild != null)
                {
                    if (root.LeftChild.Value == value || root.RightChild.Value == value)
                    {
                        return true;
                    }

                    if (value < root.LeftChild.Value)
                    {
                        root = root.LeftChild;
                    }

                    if (value > root.RightChild.Value)
                    {
                        root = root.RightChild;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"An error has occured: { error.Message }");
            }

            return false;
        }
    }
}
