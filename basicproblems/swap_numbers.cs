using System;

namespace basicproblems
{
    class SwapNumbers
    {
        public static void Run()
        {
            Console.WriteLine("Enter the value of a :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b :");
            int b = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After swapping a = {a} and b = {b}");
        }

    }
}