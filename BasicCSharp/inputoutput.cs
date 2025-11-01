using System;

namespace BasicCSharp
{

    class Inputoutput
    {
        public static void Run()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What's your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your GPA ?");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"My name is {name} and age is {age} and I have a gpa of {gpa}");
        }
    }
}

