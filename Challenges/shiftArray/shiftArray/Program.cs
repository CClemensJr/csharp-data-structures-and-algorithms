using System;

namespace shiftArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayShift();

            Console.ReadLine();
        }

        /// <summary>
        /// The ArrayShift method creates a default array and value to be added to the array. It then sends them to InsertShiftArray and assigns the returned array to a variable that is used to display the resulting array in the console.
        /// </summary>
        static void ArrayShift()
        {
            int[] array = { 2, 6, 4, 8 };
            int toBeAdded = 5;

            int[] shiftedArray = InsertShiftArray(array, toBeAdded);

            Console.Write("[ ");
            foreach(int num in shiftedArray)
            {
                Console.Write($"{ num } ");
            }
            Console.Write("]");
        }

        /// <summary>
        /// InsertShitArray takes an inputArray of integers and an integer toBeAdded to the array. It then creates a new solutionArray that is one element larger that the inputArray. The method then finds the midpoint of the new array and then iterates over it. During iteration the values in the first half of the inputArray are assigned to the solutionArray. When the middle element of the solutionArray is reached, the integer toBeAdded is assigned to the element and then the remaining half of the inputArray fills up the rest of the solutionArray. The solutionArray is then returned to ArrayShift.
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="toBeAdded"></param>
        /// <returns>An array of integers containing the number to be added</returns>
        static int[] InsertShiftArray(int[] inputArray, int toBeAdded)
        {
            int[] solutionArray = new int[inputArray.Length + 1];
            int middleIndex = solutionArray.Length / 2;

            for (int i = 0; i < solutionArray.Length; i++)
            {
                if (i < middleIndex) { solutionArray[i] = inputArray[i]; }
                if (i > middleIndex) { solutionArray[i] = inputArray[i - 1]; }
                if (i == middleIndex) { solutionArray[i] = toBeAdded; }

            }

            return solutionArray;
        }
    }
}
