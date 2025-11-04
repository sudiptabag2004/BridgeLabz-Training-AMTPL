using System;

namespace basicproblems
{
    class PerfectNo
    {
        public static void Run()
        {
            Console.WriteLine("give the the no:");
            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == a)
            {
                Console.WriteLine($"{a} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{a} is not a perfect number.");
            }


        }

    }
}