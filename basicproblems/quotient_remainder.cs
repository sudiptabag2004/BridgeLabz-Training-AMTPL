using System;

namespace basicproblems
{
    class Quotient_Remainder
    {
        public static void Run()
        {

            Console.WriteLine("Enter dividend:");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter divisor:");

            int m = Convert.ToInt32(Console.ReadLine());

            int j = n / m;
            int l = n % m;

            Console.WriteLine($"The quotient is {j}");
            Console.WriteLine($"The remainder is {l}");





        }

    }
}