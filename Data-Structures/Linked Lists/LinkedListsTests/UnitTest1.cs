using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListsTests
{
    public class InsertTests
    {
        [Fact]
        public void ShouldCreateNodes()
        {
            LList test = new LList();

            test.Insert(10);

            Assert.True(test.Includes(10));
        }

        [Fact]
        public void ShouldSetHeadNode()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);
            test.Insert(10);

            Assert.NotNull(test.Head);
        }

        [Fact]
        public void ShouldSetCurrentNodeEqualToHeadNode()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);
            test.Insert(10);

            Assert.Same(test.Current, test.Head);
        }
    }

    public class IncludesTests
    {
        [Fact]
        public void ShouldReturnTrueIfInList()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);
            test.Insert(10);

            Assert.True(test.Includes(10));
        }

        [Fact]
        public void ShouldReturnFalseIfNotInList()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);
            test.Insert(10);

            Assert.False(test.Includes(54));
        }

        [Fact]
        public void ShouldSearchFromBeginningOfList()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);
            test.Insert(10);

            Assert.True(test.Head.Value == 10);
        }
    }

    public class PrintTests
    {
        [Fact]
        public void ShouldReturnAString()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);

            string output = test.Print();

            Assert.IsType<String>(output);
        }
    }

    public class AppendTests
    {
        [Fact]
        public void ShouldAddNode()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);
            test.Append(12);

            Assert.True(test.Includes(12));
        }

        [Fact]
        public void ShouldCreateFirstNodeIfNone()
        {
            LList test = new LList();

            test.Append(12);

            Assert.True(test.Head.Value == 12);
        }
    }

    public class InsertBeforeTests
    {
        [Fact]
        public void ShouldAddNode()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);
            test.InsertBefore(15, 12);

            Assert.True(test.Includes(12));
        }

        [Fact]
        public void ShouldInsertIfReferenceNodeIsFirst()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);
            test.InsertBefore(25, 12);

            Assert.True(test.Head.Value == 12);
        }
    }

    public class InsertAfterTests
    {
        [Fact]
        public void ShouldAddNode()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);
            test.Insert(37);
            test.InsertAfter(25, 12);

            Assert.True(test.Includes(12));
        }

        [Fact]
        public void ShouldAppendIfReferenceNodeIsLast()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);
            test.InsertAfter(15, 12);

            Assert.True(test.Current.Next.Value == 12);
        }
    }
}
