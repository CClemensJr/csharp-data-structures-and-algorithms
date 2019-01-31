﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        /// <summary>
        /// This method traverses through the tree by accessing the root node first then accessing the left child before the right child.
        /// </summary>
        /// <returns>An array of values in the tree</returns>
        public List<int> PreOrder(Node root)
        {
            List<int> list = new List<int>();

            list.Add(root.Value);

            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }
            
            return list;
        }

        /// <summary>
        /// This method traverses through the tree by accessing the left child node first then accessing the root node before the right child.
        /// </summary>
        /// <returns>An array of values in the tree</returns>
        public int[] InOrder()
        {
            return null;
        }

        /// <summary>
        /// This method traverses through the tree by accessing the left child node first then accessing the right child before the root node.
        /// </summary>
        /// <returns>An array of values in the tree</returns>
        public int[] PostOrder()
        {
            return null;
        }
    }
}
