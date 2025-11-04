using System;

namespace basicproblems
{
    class PrimeNo
    {
        public static void Run()
        {
            Console.WriteLine("give the the no:");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a <= 1)
            {
                Console.WriteLine($"{a} is not a prime number.");
                return;
            }

            bool isPrime = true;

            for(int i = 2; i*i <= a; i++)
            {
                if (a % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{a} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{a} is not a prime number.");
            }

            

        }

    }
}