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
            Tree.Classes.Tree testTree = new Tree.Classes.Tree();

            testTree.Add(9);
            testTree.Add(7);
            testTree.Add(10);

            Assert.Equal(7, testTree.Root.LeftChild.Value);
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
            Node testNode2 = new Node(77);
            Node testNode3 = new Node(777);

            BinaryTree tree = new BinaryTree();

            List<object> list = tree.PreOrder(testNode1);

            Assert.True(tree.PreOrder(testNode1));
        }

        [Fact]
        public void CanReturnList()
        {

        }

        [Fact]
        public void CanOutputRootFirst()
        {

        } 
    }

    public class BinaryTreeInOrderTests
    {
        [Fact]
        public void CanGetRoot()
        {

        }

        [Fact]
        public void CanReturnList()
        {

        }

        [Fact]
        public void CanOutputRootFirst()
        {

        }
    }

    public class BinaryTreePostOrderTests
    {
        [Fact]
        public void CanGetRoot()
        {

        }

        [Fact]
        public void CanReturnList()
        {

        }

        [Fact]
        public void CanOutputRootFirst()
        {

        }
    }

    /// <summary>
    /// BinarySearchTree class tests
    /// </summary>
    public class BinarySearchTreeTests
    {
        [Fact]
        public void Test1()
        {

        }
    }
}
