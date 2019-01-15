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

        [Fact]
        public void ShouldReturnNodeValuesInString()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);

            string output = test.Print();

            Assert.True(output.Contains("25"));
        }

        [Fact]
        public void ShouldHaveAllNodesInString()
        {
            LList test = new LList();

            test.Insert(15);
            test.Insert(25);

            string output = test.Print();

            Assert.True(output.Contains("Node 1") && output.Contains("Node 2"));

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
