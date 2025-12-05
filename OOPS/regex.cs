using System;
using System.Text.RegularExpressions;

namespace OOPS
{
    class Program2
    {
        public void Run()
        {
            string pattern = @"^[A-Z]{3}$";   // your regex
            string input = Console.ReadLine(); // input to test

            bool result = Regex.IsMatch(input, pattern);

            Console.WriteLine(result); // true or false
        }
    }
}