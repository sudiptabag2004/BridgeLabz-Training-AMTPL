using System;

namespace arrays
{
    class Reverse_string
    {
        public static void Run()
        {
            Console.WriteLine("Give your input:");
            string name = Console.ReadLine();

            string reversed = rev_erse(name);
            Console.WriteLine("Reversed string: " + reversed);
        }

        static string rev_erse(string name)
        {
            int n = name.Length;
            string newString = "";

            for (int i = n - 1; i >= 0; i--)
            {
                newString += name[i];
            }

            return newString;
        }
    }
}
