using System;

namespace basicproblems
{
    class Leap_year
    {
        public static void Run()
        {
            Console.WriteLine("Write the year:");
            int year = Convert.ToInt32(Console.ReadLine());
            bool ans = Check(year);
            int digits = year.ToString().Length;
            if (digits != 4)
            {
                Console.WriteLine($"{year} is invalid");
                return;
            }
            if (ans == true)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");

            }
           

        }

        static bool Check(int year)
        {

            if(year % 4==0 && year%100!=0 ||year%400==0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}