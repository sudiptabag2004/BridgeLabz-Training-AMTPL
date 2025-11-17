using System;
using System.Collections;

namespace Practice
{
    class RemoveDuplicates
    {
        public static void Run()
        {
            List<int>  Lis = new List<int>();
            
            int n =  int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                Lis.Add(num);
            }

            int right = 1;
            for (int i = 1; i < n; i++)
            {
                if (Lis[i] != Lis[i - 1])
                {
                    Lis[right] = Lis[i];
                    right++;
                }
            }
            
            Lis.RemoveRange(right,n-right);
            Console.WriteLine("New List is");
            foreach (int i in Lis)
            {
                Console.WriteLine(i);
            }

        }
    }
    
    
}