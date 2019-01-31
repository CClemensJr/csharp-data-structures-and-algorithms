using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        /// <summary>
        /// This method traverses through the tree by accessing the root node first then accessing the left child before the right child.
        /// </summary>
        /// <returns>A list of values in the tree</returns>
        public List<int> PreOrder(Node root)
        {
            try
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
                List<int> list = new List<int>();

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
        /// <returns>An array of values in the tree</returns>
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

                List<int> list = new List<int>();

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
