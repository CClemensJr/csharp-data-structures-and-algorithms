using System;
using System.Collections.Generic;
using System.Text;
using Tree.Classes;

namespace Tree.Classes
{
    public class BinarySearchTree : Tree
    {
        /// <summary>
        /// When a BST object is created, it requires a root node be included
        /// </summary>
        /// <param name="root"></param>
        public BinarySearchTree(Node root)
        {
            Root = root;
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

                if (Root.Value == value)
                {
                    return true;
                }

                while (Root.RightChild != null)
                {
                    if (Root.LeftChild.Value == value || Root.RightChild.Value == value)
                    {
                        return true;
                    }

                    if (value < Root.LeftChild.Value)
                    {
                        Root = Root.LeftChild;
                    }

                    if (value > Root.RightChild.Value)
                    {
                        Root = Root.RightChild;
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
