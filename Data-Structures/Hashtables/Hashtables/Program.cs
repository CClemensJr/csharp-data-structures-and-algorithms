using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "static";
            int index = 0;

            for (int i = 0; i < key.Length; i++)
            {
                index += (int)key[i];
            }

            index = index % 10;

            Console.WriteLine($"The index of { key } is { index }");

            Console.Write("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
