using System;
using Xunit;
using Tree.Classes;

namespace TreeTests
{
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

    public class BinaryTreeTests
    {
        [Fact]
        public void Test1()
        {

        }
    }

    public class BinarySearchTreeTests
    {
        [Fact]
        public void Test1()
        {

        }
    }
}
