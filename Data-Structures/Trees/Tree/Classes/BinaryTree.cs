using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree : Tree
    {
        public List<int> BinaryTreeList = new List<int>();

        /// <summary>
        /// A default constructor for binary tree
        /// </summary>
        public BinaryTree()
        {
            Root = null;
        }


        /// <summary>
        /// This method sets the root node to the node argument if the object is created with a node
        /// </summary>
        /// <param name="node"></param>
        public BinaryTree(Node node)
        {
            Root = node;
        }

        /// <summary>
        /// This method traverses through the tree by accessing the root node first then accessing the left child before the right child.
        /// </summary>
        /// <returns>A list of values in the tree</returns>
        public List<int> PreOrder(Node root)
        {
            try
            {
                BinaryTreeList.Add(Root.Value);

                if (root.LeftChild != null)
                {
                    PreOrder(root.LeftChild);
                }

                if (root.RightChild != null)
                {
                    PreOrder(root.RightChild);
                }
            
                return BinaryTreeList;
            }
            catch (Exception error)
            {
                Console.WriteLine($"An error has occurred: { error.Message }");
            }

            return null;
        }

        /// <summary>
        /// This method traverses through the tree by accessing the left child node first then accessing the root node before the right child.
        /// </summary>
        /// <returns>A list of values in the tree</returns>
        public List<int> InOrder(Node root)
        {
            try
            {
                if (root.LeftChild != null)
                {
                    PreOrder(root.LeftChild);
                }

                BinaryTreeList.Add(root.Value);

                if (root.RightChild != null)
                {
                    PreOrder(root.RightChild);
                }

                return BinaryTreeList;
            }
            catch (Exception error)
            {
                Console.WriteLine($"An error has occurred: { error.Message }");
            }

            return null;
        }

        /// <summary>
        /// This method traverses through the tree by accessing the left child node first then accessing the right child before the root node.
        /// </summary>
        /// <returns>A list of values in the tree</returns>
        public List<int> PostOrder(Node root)
        {
            try
            {
                if (root.LeftChild != null)
                {
                    PreOrder(root.LeftChild);
                }

                if (root.RightChild != null)
                {
                    PreOrder(root.RightChild);
                }

                BinaryTreeList.Add(root.Value);

                return BinaryTreeList;
            }
            catch (Exception error)
            {
                Console.WriteLine($"An error has occurred: { error.Message }");
            }

            return null;
        }
    }
}
