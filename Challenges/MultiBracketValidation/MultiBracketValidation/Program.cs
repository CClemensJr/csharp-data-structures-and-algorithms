using StacksAndQueues.Classes;
using System;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = MultiBracketValidation("[}");
        }

        public static bool MultiBracketValidation(string input)
        {
            try
            {
                char[] inputArray = input.ToCharArray();
                Queue queue = new Queue();

                foreach (char character in inputArray)
                {
                    queue.Enqueue(character);
                }
            }
            catch
            {

            }

            return false;
        }
    }
}
