using System;
using System.Collections.Generic;

namespace Practice
{
    public class Stack
    {
        public static void Run()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");
            
            Console.WriteLine("Popped:"+stack.Pop() );
         
            Console.WriteLine("Popped:"+stack.Pop() );
          
            Console.WriteLine("Top:"+stack.Peek() );

            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }
        }
    }
}