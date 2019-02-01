using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree : Tree
    {
        /// <summary>
        /// A default constructor for binary tree
        /// </summary>
        public BinaryTree()
        {

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
        public List<object> PreOrder(Node root)
        {
            try
            {
                List<object> list = new List<object>();

                list.Add(Root.Value);

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
        public List<object> InOrder(Node root)
        {
            try
            {
                List<object> list = new List<object>();

                if (root.LeftChild != null)
                {
                    PreOrder(root.LeftChild);
                }

                list.Add(root.Value);

                if (root.RightChild != null)
                {
                    PreOrder(root.RightChild);
                }

                return list;
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
        public List<object> PostOrder(Node root)
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

                List<object> list = new List<object>();

                list.Add(root.Value);

                return list;
            }
            catch (Exception error)
            {
                Console.WriteLine($"An error has occurred: { error.Message }");
            }

            return null;
        }
    }
}
