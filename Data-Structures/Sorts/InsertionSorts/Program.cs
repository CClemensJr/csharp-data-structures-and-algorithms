using System;

namespace InsertionSorts
{
    public class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            int size = 10;
            int[] unsortedArray = new int[size];
            
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = RandomNumber(min, max);
            }

            int[] sortedArray = InsertionSort(unsortedArray);

            foreach (int num in sortedArray)
            {
                Console.Write(num + " | ");
            }

            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }


        /// <summary>
        /// This method takes in an unsorted array and returns a sorted array using Insertion Sort
        /// </summary>
        /// <param name="array"></param>
        /// <returns>A sorted array</returns>
        public static int[] InsertionSort(int[] unsortedArray)
        {
            int value = 0;
            int position = 0;


            for (int i = 1; i < unsortedArray.Length; i++)
            {
                value = unsortedArray[i];
                position = i;

                while (position > 0 && unsortedArray[position - 1] > value)
                {
                    unsortedArray[position] = unsortedArray[position - 1];

                    position -= 1;
                }

                unsortedArray[position] = value;
            }

            return unsortedArray;
        }


        /// <summary>
        /// This method takes in a minimum value and a maximum value then returns a random number between the two.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>A random number between the min and max values</returns>
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();

            return random.Next(min, max);
        }
    }
}
