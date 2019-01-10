using System;

namespace binarySearchArray
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToBeSearched = { 4, 8, 15, 16, 23, 42 };
            int searchKey = 42;

            BinarySearch(arrayToBeSearched, searchKey);
        }

        public static int BinarySearch(int[] array, int searchKey)
        {
            int middleIndex = array.Length / 2;
            int searches = array.Length;

            //while (array[middleIndex] != searchKey || searches != 0)
            //{
            //    middleIndex
            //}

            return middleIndex;
        }
    }
}
