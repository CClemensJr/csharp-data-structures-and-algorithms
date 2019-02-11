using System;
using Xunit;
using Tree.Classes;
using System.Collections.Generic;

namespace TreeTests
{
    /// <summary>
    /// Node Class Tests
    /// </summary>
    public class NodeTests
    {
        [Fact]
        public void CanCreateNode()
        {
            Node testNode = new Node();

            testNode.Value = 7;

            Assert.Equal(7, testNode.Value);
        }

        [Fact]
        public void CanGetNodeValue()
        {
            Node testNode = new Node();

            testNode.Value = 7;

            int testValue = Convert.ToInt32(testNode.Value);

            Assert.True(testValue == Convert.ToInt32(testNode.Value));
        }

        [Fact]
        public void CanSetNodeValue()
        {
            Node testNode = new Node();

            testNode.Value = 7;
            int testValue = Convert.ToInt32(testNode.Value);

            testNode.Value = 89;

            Assert.NotEqual(testValue, testNode.Value);
        }
    }

    /// <summary>
    /// Tree class tests
    /// </summary>
    public class TreeTests
    {
        [Fact]
        public void CanGetRootValue()
        {
            Tree.Classes.Tree testTree = new Tree.Classes.Tree();

            testTree.Add(7);

            Assert.Equal(7, testTree.Root.Value);
        }

        [Fact]
        public void CanSetRootValue()
        {
            Tree.Classes.Tree testTree = new Tree.Classes.Tree();

            testTree.Add(9);

            testTree.Root.Value = 7;

            Assert.Equal(7, testTree.Root.Value);
        }

        [Fact]
        public void CanAddChildNodes()
        {
            Tree.Classes.Tree testTree = new Tree.Classes.Tree(new Node(7));

            testTree.Add(9);
            testTree.Add(10);

            Assert.Equal(9, testTree.Root.LeftChild.Value);
        }
    }


    /// <summary>
    /// BinaryTree class tests
    /// </summary>
    public class BinaryTreePreOrderTests
    {
        [Fact]
        public void CanGetRoot()
        {
            Node testNode1 = new Node(7);

            BinaryTree tree = new BinaryTree(testNode1);

            Assert.True(tree.Root == testNode1);
        }

        [Fact]
        public void CanReturnListOfNodes()
        {
            BinaryTree tree = new BinaryTree(new Node(7));

            tree.Add(77);

            List<int> list = tree.PreOrder(tree.Root);

            Assert.True(list.Count > 1);
        }

        [Fact]
        public void CanOutputRootFirst()
        {
            BinaryTree tree = new BinaryTree(new Node(7));

            tree.Add(77);

            List<int> list = tree.PreOrder(tree.Root);

            Assert.Equal(7, list[0]);
        } 
    }

    public class BinaryTreeInOrderTests
    {
        [Fact]
        public void CanGetRoot()
        {
            Node testNode1 = new Node(7);

            BinaryTree tree = new BinaryTree(testNode1);

            Assert.True(tree.Root == testNode1);
        }

        [Fact]
        public void CanReturnList()
        {
            BinaryTree tree = new BinaryTree(new Node(7));

            tree.Add(77);

            List<int> list = tree.InOrder(tree.Root);

            Assert.True(list.Count > 1);
        }

        [Fact]
        public void CanOutputRootSecond()
        {
            BinaryTree tree = new BinaryTree(new Node(7));

            tree.Add(77);

            List<int> list = tree.InOrder(tree.Root);

            Assert.Equal(7, list[1]);
        }
    }

    public class BinaryTreePostOrderTests
    {
        [Fact]
        public void CanGetRoot()
        {
            Node testNode1 = new Node(7);

            BinaryTree tree = new BinaryTree(testNode1);

            Assert.True(tree.Root == testNode1);
        }

        [Fact]
        public void CanReturnList()
        {
            BinaryTree tree = new BinaryTree(new Node(7));

            tree.Add(77);

            List<int> list = tree.InOrder(tree.Root);

            Assert.True(list.Count > 1);
        }

        [Fact]
        public void CanOutputRootThird()
        {
            BinaryTree tree = new BinaryTree(new Node(7));

            tree.Add(77);
            tree.Add(777);

            List<int> list = tree.PostOrder(tree.Root);

            Assert.Equal(7, list[2]);
        }
    }

    /// <summary>
    /// BinarySearchTree class tests
    /// </summary>
    public class BinarySearchTreeTests
    {
        [Fact]
        public void CanGetRoot()
        {
            BinarySearchTree tree = new BinarySearchTree(new Node(7));

            Assert.Equal(7, tree.Root.Value);
        }

        [Fact]
        public void CanCheckIfTreeContainsValue()
        {
            BinarySearchTree tree = new BinarySearchTree(new Node(100));

            tree.Add(50);
            tree.Add(150);

            bool inTree = tree.Contains(150);

            Assert.True(inTree);
        }
    }
}
