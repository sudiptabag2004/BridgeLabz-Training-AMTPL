using System;

namespace basicproblems
{
    class ReverseNo
    {
        public static void Run()
        {
            Console.WriteLine("give the the no:");
            int a = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            int b = 0;

            while (temp > 0)
            {
                int num = temp % 10;
                b = 10 * b + num;
                temp = temp / 10;

            }

            Console.WriteLine($"The reversed no. is {b}");

        }

    }
}