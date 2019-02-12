using System;

namespace AreCharactersUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "padre";
            bool isUnique = AreCharactersUnique(word);

            Console.WriteLine($"All characters in the word { word } are unique: { isUnique }");


            Console.Write("Please press any key to exit...");
            Console.ReadLine();
        }

        public static bool AreCharactersUnique(string toBeChecked)
        {
            for (int i = 0; i < toBeChecked.Length; i++)
            {
                for (int j = 1; j < toBeChecked.Length; j++)
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
