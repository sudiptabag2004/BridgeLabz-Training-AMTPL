using System;

namespace BasicCSharp
{
    class Datatypes
    {
        public static void Run()
        {
            // Integer Types
            int age = 20;
            long population = 1400000000;

            // Floating Types
            float percentage = 85.6f;
            double pi = 3.14159;

            // Decimal (for money)
            decimal bankBalance = 9999.50m;

            // Character & String
            char grade = 'A';
            string name = "Sudipta";

            // Boolean
            bool isStudent = true;

            // Output
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
