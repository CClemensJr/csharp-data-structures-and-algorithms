﻿using System;
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

                if (Convert.ToInt32(Root.Value) == value)
                {
                    return true;
                }

                while (Root.RightChild != null)
                {
                    if (Convert.ToInt32(Root.LeftChild.Value) == value || Convert.ToInt32(Root.RightChild.Value) == value)
                    {
                        return true;
                    }

                    if (value < Convert.ToInt32(Root.LeftChild.Value))
                    {
                        Root = Root.LeftChild;
                    }

                    if (value > Convert.ToInt32(Root.RightChild.Value))
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
