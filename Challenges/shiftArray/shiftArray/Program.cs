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

            InsertShiftArray(array, toBeAdded).ToString();
        }

        static int[] InsertShiftArray(int[] array, int toBeAdded)
        {
            return array;
        }


    }
}
