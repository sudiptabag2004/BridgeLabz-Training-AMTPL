using System;
using System.Collections.Generic;

namespace Practice
{
    public class Hashset1
    {
        public static void Run()
        {
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(2);
            li.Add(3);
            li.Add(2);
            li.Add(4);
            li.Add(3);
            li.Add(5);

            HashSet<int> hash = new HashSet<int>();

            foreach (int i in li)
            {
                if (hash.Contains(i))
                {
                    continue;
                }
                else
                {
                    hash.Add(i);
                }
            }

            if (hash.Contains(3))
            {
                Console.WriteLine("3 is present");
            }
            else
            {
                Console.WriteLine("3 is not present");
            }
            
            hash.Remove(2);

            foreach (int i in hash)
            {
                Console.WriteLine(i);
            }
        }
    }
}