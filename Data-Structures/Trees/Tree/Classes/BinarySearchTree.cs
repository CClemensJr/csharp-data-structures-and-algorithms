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


        public override void Add(int value)
        {
            //try
            //{
                //    Queue<int> que = new Queue<int>();


                //    if (Root == null)
                //    {
                //        Root = new Node(value);
                //    }

                //    que.Enqueue(Root.Value);

                //    Node front = new Node();

                //    while (que.Count != 0 )
                //    {
                //        front.Value = que.Dequeue();

                //        if (front.LeftChild == null)
                //        {
                //            front.LeftChild = new Node(value);
                //            que.Enqueue(front.LeftChild.Value);
                //        }
                //        else if (front.LeftChild != null)
                //        {
                //            que.Enqueue(front.LeftChild.Value);
                //        }

                //        if (front.RightChild == null)
                //        {
                //            front.RightChild = new Node(value);
                //            que.Enqueue(front.RightChild.Value);
                //        }
                //        else if (front.RightChild != null)
                //        {
                //            que.Enqueue(front.RightChild.Value);
                //        }
                //    }

                //}

            try
            {
                if (Root == null)
                {
                    Root = new Node(value);
                }

                Node parentNode = new Node();

                while (parentNode != null)
                {
                    parentNode = Root;

                    if (value < Root.Value)
                    {
                        Root = Root.LeftChild;
                    }
                    else
                    {
                        Root = Root.RightChild;
                    }
                }

            }
            catch (Exception error)
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
                    else if (value < Root.Value)
                    {
                        Root = Root.LeftChild;
                    }
                    else if (value > Root.Value)
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
