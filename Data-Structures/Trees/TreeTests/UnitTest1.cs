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

            Assert.True(testNode.Value == 7);
        }

        [Fact]
        public void CanGetNodeValue()
        {
            Node testNode = new Node();

            testNode.Value = 7;

            int testValue = testNode.Value;

            Assert.True(testValue == testNode.Value);
        }

        [Fact]
        public void CanSetNodeValue()
        {
            Node testNode = new Node();

            testNode.Value = 7;
            int testValue = testNode.Value;

            testNode.Value = 89;

            Assert.True(testNode.Value != testValue);
        }
    }

    public class TreeTests
    {
        [Fact]
        public void Test1()
        {

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
