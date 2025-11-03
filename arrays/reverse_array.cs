using System;

namespace arrays
{
    class ReverseArray
    {
        public static void Run()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;

            for (int i = 0; i < n / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = temp;
            }

            Console.WriteLine("Reversed Array:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
