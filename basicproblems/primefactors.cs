using System;

namespace basicproblems
{
    class PrimeFactors
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The prime factors of {n} are:");
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }

            if (n > 2)
            {
                Console.Write(n);
            }

            Console.WriteLine();
        }
    }
}
