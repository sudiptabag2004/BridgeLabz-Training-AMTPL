using System;

namespace BasicCSharp
{
    class Datatypes
    {
        public static void Run()
        {
            
            int age = 20;
            long population = 1400000000;

            
            float percentage = 85.6f;
            double pi = 3.14159;

           
            decimal bankBalance = 9999.50m;

            
            char grade = 'A';
            string name = "Sudipta";

            
            bool isStudent = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Percentage: " + percentage);
            Console.WriteLine("PI: " + pi);
            Console.WriteLine("Bank Balance: " + bankBalance);
            Console.WriteLine("Indian Population: " + population);
            Console.WriteLine("Is Student: " + isStudent);
        }
    }
}
