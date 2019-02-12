using System;

namespace AreCharactersUnique
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string word = "padra";
            bool isUnique = AreAllCharactersUnique(word);

            Console.WriteLine($"All characters in the word { word } are unique: { isUnique }");


            Console.Write("Please press any key to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// This method takes a string, iterates over each character and checks it against the rest of the string to test for uniqueness.
        /// </summary>
        /// <param name="toBeChecked"></param>
        /// <returns>A boolean based on if all characters are unique</returns>
        public static bool AreAllCharactersUnique(string toBeChecked)
        {
            for (int i = 0; i < toBeChecked.Length; i++)
            {
                for (int j = i + 1; j < toBeChecked.Length; j++)
                {
                    if (toBeChecked[i] == toBeChecked[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
