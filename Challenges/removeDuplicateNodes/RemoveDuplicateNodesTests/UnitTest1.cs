using System;
using Xunit;
using RemoveDuplicateNodes;
using LinkedList.Classes;

namespace RemoveDuplicateNodesTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnALinkedList()
        {
            LList list = new LList();
            list.Insert(7);

            Assert.IsType<LList>(Program.RemoveDuplicateNodes(list));
        }

        [Fact]
        public void CanRemoveANode()
        {
            LList list = new LList();
            list.Insert(7);
            list.Insert(7);

            LList newList = Program.RemoveDuplicateNodes(list);

            Assert.True(newList.Includes(7));
        }

        [Fact]
        public void CanRemoveADupNode()
        {
            LList list = new LList();
            list.Insert(7);
            list.Insert(7);

            LList newList = Program.RemoveDuplicateNodes(list);

            Assert.True(newList.Includes(7));
        }
    }
}
