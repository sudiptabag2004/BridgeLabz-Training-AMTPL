using System;

namespace basicproblems
{
    class Powerof2
    {
        public static void Run()
        {

            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0 || n >= 31)
            {
                Console.WriteLine("Give a value in the range 0-30");
            }
            else
            {
                for (int i = 0; i <= n; i++)
                {
                    if (n < 31)
                    {
                        int m = (int)Math.Pow(2, i);
                        Console.WriteLine(m);
                    }
                }
            }

            
        }

    }
}