using System;

namespace BasicCSharp
{
    class Typecasting {
        public static void Run()
        {
            double a = 4.34567;
            int b = Convert.ToInt32(a);

            int m = 4;
            double n = Convert.ToDouble(m) + .45;

            int j = 4567;
            string k = Convert.ToString(j);

            string gi = "hello";
            char hi = Convert.ToChar(gi);




            Console.WriteLine(b);
            Console.WriteLine(b.GetType());
            Console.WriteLine(n);
            Console.WriteLine(n.GetType());
            Console.WriteLine(k);
            Console.WriteLine(k.GetType());
            Console.WriteLine(hi);
            Console.WriteLine(hi.GetType());
            Console.ReadKey();
        }


    }
}
