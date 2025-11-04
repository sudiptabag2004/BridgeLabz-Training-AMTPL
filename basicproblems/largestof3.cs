using System;

namespace basicproblems
{
    class Largestof3
    {
        public static void Run()
        {
            Console.WriteLine("give the three nos. one by one:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int d = Math.Max(a, b);
            int e = Math.Max(c, d);

            Console.WriteLine($"Max value is:{e}");

        }

    }
}