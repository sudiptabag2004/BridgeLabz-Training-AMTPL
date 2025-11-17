using System;
using System.Collections;

namespace Practice
{
    class Reverse
    {
        public static void Run()
        {
            List<int>  Lis = new List<int>();
            
            Console.WriteLine("Enter the array size:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Lis.Add(num);
            }
            
           

            for (int i = 0; i < n / 2; i++)
            {
                int temp = Lis[i];
                Lis[i] = Lis[n-1-i];
                Lis[n - 1 -i] = temp;
                
            }
            
            Console.WriteLine("The reverse array is:");
            foreach (int i in Lis)
            {
                Console.WriteLine(i);
            }
            

        }
    }
    
    
}

