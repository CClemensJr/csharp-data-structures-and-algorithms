﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Tree
    {
        public Node Root { get; set; }

        /// <summary>
        /// This method takes in a value and adds it to the tree. If the root node is null, the node is set to root. Subsequent nodes are added in a left to right fashion.
        /// </summary>
        /// <param name="value"></param>
        public virtual void Add(int value)
        {
            try
            {
                Queue<object> que = new Queue<object>();


                if (Root == null)
                {
                    Root = new Node(value);
                }

                que.Enqueue(Root);

                while (que.Peek() != null)
                {
                    Node front = new Node(que.Dequeue());

                    if (front.LeftChild == null)
                    {
                        front.LeftChild = new Node(value);
                        que.Enqueue(front.LeftChild);
                    }
                    else if (front.LeftChild != null)
                    {
                        que.Enqueue(front.LeftChild);
                    }

                    if (front.RightChild == null)
                    {
                        front.RightChild = new Node(value);
                        que.Enqueue(front.RightChild);
                    }
                    else if (front.RightChild != null)
                    {
                        que.Enqueue(front.RightChild);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"An error has occurred: { error.Message } ");
            }
        }
    }
}
