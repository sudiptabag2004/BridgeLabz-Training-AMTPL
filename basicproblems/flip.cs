using System;

namespace basicproblems
{
    class Flip
    {
        public static void Run()
        {
            Random rnd = new Random();
            double num = rnd.NextDouble();
            if (num < 0.5)
            {
                Console.WriteLine("Tails");       
            }
            else
            {
                Console.WriteLine("Heads");
            }
        }
    }
}