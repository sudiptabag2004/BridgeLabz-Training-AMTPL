using System;

namespace basicproblems
{
    class Harmonic
    {
        public static void Run()
        {
            Console.WriteLine("Give the number");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += (1.0/i);
            }

            Console.WriteLine(sum);

        }

    }
}