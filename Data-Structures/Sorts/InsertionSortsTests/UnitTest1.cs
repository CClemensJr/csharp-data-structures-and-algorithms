using InsertionSorts;
using System;
using Xunit;

namespace InsertionSortsTests
{
    public class UnitTest1
    {
        // A randomly generated unsorted array returns the array sorted
        [Fact]
        public void CanSortArray()
        {
            int min = 1;
            int max = 50;
            int size = 5;
            int[] unsortedArray = new int[size];

            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = Program.RandomNumber(min, max);
            }

            int[] sortedArray = Program.InsertionSort(unsortedArray);

            Assert.True(sortedArray[0] < sortedArray[sortedArray.Length - 1]);
        }

        // A sorted array returns the same sorted array
        [Fact]
        public void CanReturnPreviouslySortedArrays()
        {
            int[] array = { 10, 15, 25, 50, 51 };

            int[] sortedArray = Program.InsertionSort(array);

            Assert.True(sortedArray == array);
        }

        // A backwards-sorted array returns the array sorted
        [Fact]
        public void CanSortBackWardsSortedArray()
        {
            int[] array = { 51, 50, 25, 15, 10 };

            int[] sortedArray = Program.InsertionSort(array);

            Assert.True(sortedArray == array);
        }

        // An empty array returns the same empty array
        [Fact]
        public void CanReturnEmptyArray()
        {
            int[] array = new int[0];

            int[] sortedArray = Program.InsertionSort(array);

            Assert.True(sortedArray == array);
        }

        // An array of one element returns the same single-element array
        [Fact]
        public void CanReturnSingleElementArray()
        {
            int[] array = { 51 };

            int[] sortedArray = Program.InsertionSort(array);

            Assert.True(sortedArray == array);
        }
    }
}
