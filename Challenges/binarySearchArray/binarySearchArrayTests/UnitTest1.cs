using System;
using Xunit;
using binarySearchArray;

namespace binarySearchArrayTests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturnIndexIfSearchKeyExistsInArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchKey = 1;

            Assert.Equal(0, Program.BinarySearch(array, searchKey));
        }

        [Fact]
        public void ShouldNotReturnIndexIfSearchKeyDoesNotExistInArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchKey = 27;

            Assert.NotEqual(27, Program.BinarySearch(array, searchKey));
        }

        [Fact]
        public void ShouldReturnNegativeOneIfSearchKeyDoesNotExistInArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchKey = 27;

            Assert.Equal(-1, Program.BinarySearch(array, searchKey));
        }

        [Fact]
        public void ShouldNotReturnNegativeOneIfSearchKeyExistsInArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchKey = 7;

            Assert.NotEqual(-1, Program.BinarySearch(array, searchKey));
        }
    }
}
