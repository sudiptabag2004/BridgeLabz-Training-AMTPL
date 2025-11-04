using System;

namespace basicproblems
{
    class IsVowel
    {
        public static void Run()
        {

            Console.WriteLine("Give the alphabet :");

            char a = Convert.ToChar(Console.ReadLine().ToLower());

            if (!char.IsLetter(a))
            {
                Console.WriteLine($"{a} is not a alphabet");
            }
            else
            {
                if(a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                {
                    Console.WriteLine($"{a} is a vowel");
                }
                else
                {
                    Console.WriteLine($"{a} is a consonant");
                }
            }
        }

    }
}