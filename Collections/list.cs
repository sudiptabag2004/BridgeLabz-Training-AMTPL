using System;

namespace Practice
{
    class EvenList
    {
        public static void Run()
        {
            List<int> li = new List<int>();
            li.Add(4);
            li.Add(4);
            li.Add(1);  
            li.Add(2);
            li.Add(7);
            
            li.RemoveAll(x =>  x%2 ==0);
            
            foreach (int x in li)
            {
                Console.WriteLine(x);
            }
        }
    }
};