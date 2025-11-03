using System;

namespace basicproblems
{
    class EvenOdd { 
        public static void Run()
        {

            Console.WriteLine("Write the number :");

            int n = Convert.ToInt32(Console.ReadLine());

            if(n == 0)
            {
                Console.WriteLine($"{n} is an even number");

            }
            else if(n%2 == 0)
            {
                Console.WriteLine($"{n} is an even number");
            }
            else
            {
                Console.WriteLine($"{n} is a odd number");
            }   

        }

    }
}