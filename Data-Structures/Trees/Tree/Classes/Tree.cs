﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Tree
    {
        public Node Root { get; set; }

        /// <summary>
        /// This default contructor allows a tree object to be created without a root specified
        /// </summary>
        public Tree() {}

        /// <summary>
        /// This custom contructor create a tree object with the root node set to the Node passed into it.
        /// </summary>
        /// <param name="root"></param>
        public Tree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// This method takes in a value and adds it to the tree. If the root node is null, the node is set to root. Subsequent nodes are added in a left to right fashion.
        /// </summary>
        /// <param name="value"></param>
        public virtual void Add(int value)
        {
            try
            {
                if (Root == null)
                {
                    Root = new Node(value);
                }
                else if (Root.LeftChild == null)
                {
                    Root.LeftChild = new Node(value);
                }
                else if (Root.RightChild == null)
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
