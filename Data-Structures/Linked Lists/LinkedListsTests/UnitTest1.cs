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
        public void ShouldShowAllNodes()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);
            test.Insert(10);

            Assert.("10\n25\n15", test.Print());
        }
    }

    public class AppendTests
    {

    }

    public class InsertBeforeTests
    {

    }

    public class InsertAfterTests
    {

    }
}
