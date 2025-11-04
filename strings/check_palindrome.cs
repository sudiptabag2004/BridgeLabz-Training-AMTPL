using System;

namespace strings
{
    class CheckPalindrome
    {
        public static void Run()
        {
            Console.WriteLine("Give your input:");
            string name = Console.ReadLine();

            int n = name.Length;

            bool isPalindrome = true;

            for(int i = 0; i < n/2; i++)
            {
                if(name[i] != name[n-1-i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("The string is a palindrome");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome");
            }
        }
    }
}
