using System;
using Xunit;
using Tree.Classes;
using CalculateBinaryTreeHeight;

namespace CalculateBinaryTreeHeightTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetRoot()
        {
            BinaryTree tree = new BinaryTree(new Node(7));
            
            Assert.Equal(7, tree.Root.Value);
        }

        [Fact]
        public void CanReturnHeight()
        {
            BinaryTree tree = new BinaryTree(new Node(7));

            Assert.Equal(0, Program.CalculateBinaryTreesHeight(tree.Root));
        }

        [Fact]
        public void CanGetReturnZeroIfOnlyOneNode()
        {
            BinaryTree tree = new BinaryTree(new Node(7));

            Assert.Equal(0, Program.CalculateBinaryTreesHeight(tree.Root));
        }
    }
}
