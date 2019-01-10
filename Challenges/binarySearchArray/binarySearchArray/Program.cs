using System;

namespace binarySearchArray
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToBeSearched = { 4, 8, 15, 16, 23, 42 };
            int searchKey = 23;

            int searchKeyIndex = BinarySearch(arrayToBeSearched, searchKey);

            Console.WriteLine($"THE SEARCH KEY INDEX IS {searchKeyIndex.ToString()}");
            Console.ReadLine();
        }

        public static int BinarySearch(int[] array, int searchKey)
        {
            //Binary search works on sorted arrays. Binary search begins by comparing the middle element of the array with the target value.If the target value matches the middle element, its position in the array is returned.If the target value is less than the middle element, the search continues in the lower half of the array. If the target value is greater than the middle element, the search continues in the upper half of the array. By doing this, the algorithm eliminates the half in which the target value cannot lie in each iteration
            int leftPoint = 0;
            int rightPoint = array.Length - 1;
            int midPoint = (leftPoint + rightPoint) / 2;

            try
            {
                do
                {
                    if (leftPoint > rightPoint)
                    {
                        return -1;
                    }
                    if (array[midPoint] == searchKey)
                    {
                        return midPoint;
                    }
                    else if(array[midPoint] < searchKey)
                    {
                        leftPoint = midPoint + 1;
                    }
                    else if (array[midPoint] > searchKey)
                    {
                        rightPoint = midPoint - 1;
                    }

                } while (leftPoint < rightPoint);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }

            return -1;
        }
    }
}
