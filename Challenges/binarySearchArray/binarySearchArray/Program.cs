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

            Console.ReadLine();
        }

        public static int BinarySearch(int[] array, int searchKey)
        {
            int midPoint = array.Length / 2 - 1;
            int leftBound = array[0];
            int rightBound = array[array.Length - 1];
            int searches = array.Length;
            int searchKeyIndex = midPoint;

            try
            {
                while (searches != 0)
                {
                    if (searchKey > array[midPoint])
                    {
                        leftBound = midPoint + 1;
                        midPoint += midPoint / 2;

                        searches /= 2;
                    }
                    else if (searchKey < array[midPoint])
                    {
                        rightBound = midPoint - 1;
                        midPoint -= midPoint / 2;

                        searches /= 2;
                    }
                    else if (searchKey == array[midPoint])
                    {
                        searchKeyIndex = midPoint;

                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The formula was incorrect.");
            }

            return searchKeyIndex;
        }
    }
}
