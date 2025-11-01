using System;

namespace BasicCSharp
{
    class Literals
    {
        public static void Run()
        {
            int a = 100;
            int c = 0x123f;
            int d = 0b1111;

            uint g = 2000U;
            long h = 2000L;
            ulong l = 2000UL;

            Console.WriteLine($"Decimal Literals: {a}");
            Console.WriteLine($"Hexa-decimal Literal: {c}");
            Console.WriteLine($"Binary Literal: {d}");

            Console.WriteLine($"Unsigned integer Literal: {g}");
            Console.WriteLine($"long Literal: {h}");
            Console.WriteLine($"unsigned long literal: {l}");
        }
    }
}