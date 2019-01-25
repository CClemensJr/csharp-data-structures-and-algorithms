using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTests
{
    public class StackTests
    {
        // PUSH TESTS
        [Fact]
        public void CanAddToStack()
        {
            Stack stack = new Stack();

            Node node = new Node(7);

            stack.Push(node);

            Assert.True(stack.Size == 1);
        }

        [Fact]
        public void CanSetNewNodeToTop()
        {
            Stack stack = new Stack();

            Node node = new Node(7);
            Node node1 = new Node(35);

            stack.Push(node);
            stack.Push(node1);

            Assert.True(stack.Top.Value == node1.Value);
        }

        [Fact]
        public void CanVerifyTopNodeIsNotFirstNode()
        {
            Stack stack = new Stack();

            Node node = new Node(7);
            Node node1 = new Node(35);

            stack.Push(node);
            stack.Push(node1);

            Assert.True(stack.Top.Value != node.Value);
        }


        // POP TESTS
        [Fact]
        public void CanRemoveFromStack()
        {
            Stack stack = new Stack();

            Node node1 = new Node(7);
            Node node2 = new Node(10);
            Node node3 = new Node(71);

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);

            stack.Pop();

            Assert.True(stack.Size == 2);
        }

        [Fact]
        public void CanSetTop()
        {
            Stack stack = new Stack();

            Node node1 = new Node(7);
            Node node2 = new Node(10);
            Node node3 = new Node(71);

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);

            stack.Pop();

            Assert.True(stack.Top.Value == node2.Value);
        }

        [Fact]
        public void CanReturnRemovedNode()
        {
            Stack stack = new Stack();

            Node node1 = new Node(7);
            Node node2 = new Node(10);
            Node node3 = new Node(71);

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);

            Node removedNode = stack.Pop();

            Assert.True(removedNode.Value == node3.Value);
        }

        // PEEK TESTS
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

            Assert.True(queue.Size == 1);
        }

        [Fact]
        public void CanSetNewNodeToRear()
        {
            Queue queue = new Queue();
            Node node = new Node(7);

            queue.Enqueue(node);

            Assert.Equal(7, queue.Rear.Value);
        }

        [Fact]
        public void CanSetFrontNodeIfQueueEmpty()
        {
            Queue queue = new Queue();
            Node node = new Node(7);

            queue.Enqueue(node);

            Assert.Equal(7, queue.Front.Value);
        }


        //dequeue
        [Fact]
        public void CanRemoveFromQueue()
        {
            Queue queue = new Queue();

            Node node1 = new Node(7);
            Node node2 = new Node(10);
            Node node3 = new Node(71);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Node removedNode = queue.Dequeue();

            Assert.Equal(7, removedNode.Value);
        }

        [Fact]
        public void CanSetFront()
        {
            Queue queue = new Queue();

            Node node1 = new Node(7);
            Node node2 = new Node(10);
            Node node3 = new Node(71);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Assert.Equal(7, queue.Front.Value);
        }

        [Fact]
        public void CanReturnRemovedNode()
        {
            Queue queue = new Queue();

            Node node1 = new Node(7);
            Node node2 = new Node(10);
            Node node3 = new Node(71);

            queue.Enqueue(node1);

            Node removedNode = queue.Dequeue();

            Assert.Equal(7, removedNode.Value);
        }


        // peek
        [Fact]
        public void CanReturnTheFrontNode()
        {
            Queue queue = new Queue();

            Node node1 = new Node(7);
            Node node2 = new Node(10);
            Node node3 = new Node(71);

            queue.Enqueue(node1);

            Node nodeInFront = queue.Peek();

            Assert.Equal(7, nodeInFront.Value);
        }
    }
}
