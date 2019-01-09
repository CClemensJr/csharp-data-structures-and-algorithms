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

        static void ArrayShift()
        {
            int[] array = { 2, 6, 4, 8 };
            int toBeAdded = 5;

            InsertShiftArray(array, toBeAdded);
        }

        static int[] InsertShiftArray(int[] inputArray, int toBeAdded)
        {
            int[] solutionArray = new int[inputArray.Length + 1];
            int middleIndex = solutionArray.Length / 2;

            for (int i = 0; i < solutionArray.Length; i++)
            {
                if (i < middleIndex) { solutionArray[i] = inputArray[i]; }
                if (i > middleIndex) { solutionArray[i] = inputArray[i - 1]; }

                solutionArray[i] = toBeAdded;
            }

            return solutionArray;
        }
    }
}
