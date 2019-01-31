using System;
using System.Collections.Generic;
using System.Text;
using Tree.Classes;

namespace Tree.Classes
{
    public class BinarySearchTree : Tree
    {
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
