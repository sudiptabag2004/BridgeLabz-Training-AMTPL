using System;

namespace BasicCSharp
{
    class Operators
    {
        public static void Run()
        {
            bool a = true;
            bool b = false;
            bool c = a || b;
            bool d = a && b;


            Console.WriteLine("Logical OR Implementation");
            Console.WriteLine(c);
            Console.WriteLine("Logical AND Implementation");
            Console.WriteLine(d);
            Console.WriteLine("Logical NOT Implementation");
            Console.WriteLine(!a);


            int j = 45;
            int k = 24;
            int l = j | k;
            int m = j & k;

            Console.WriteLine("Bitwise OR Implementation");
            Console.WriteLine(l);
            Console.WriteLine("Bitwise AND Implementation");
            Console.WriteLine(m);
            Console.WriteLine("Bitwise NOT Implementation");
            Console.WriteLine(l);

            int g = 45;
            Console.WriteLine($"Pre Increment Operator {++g}");
            int h = 45;
            Console.WriteLine($"Post Increment Operator {h++}");
            int i = 45;
            Console.WriteLine($"Pre Decrement Operator {--i}");
            int z = 45;
            Console.WriteLine($"Post Decrement Operator {z--}");

        }
    
    }
    
}