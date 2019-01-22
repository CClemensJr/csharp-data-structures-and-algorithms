using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTests
{
    public class StackTests
    {
        [Fact]
        public void Test1()
        {

        }
    }

    public class QueueTests
    {
        //enqueue
        [Fact]
        public static void CanAddToQueue()
        {
            Queue queue = new Queue();
            Node node = new Node(7);

            queue.Enqueue(node);

            Assert.True(queue.Size > 0);
        }

        [Fact]
        public void CanSetNewNodeToRear()
        {

        }


        //dequeue
        [Fact]
        public void CanRemoveFromQueue()
        {

        }

        [Fact]
        public void CanSetNewFront()
        {

        }

        [Fact]
        public void CanReturnNode()
        {

        }


        // peek
        [Fact]
        public void CanDetectFrontNode()
        {

        }

        [Fact]
        public void CanReturnANode()
        {

        }

        [Fact]
        public void CanReturnTheFrontNode()
        {

        }
    }
}
