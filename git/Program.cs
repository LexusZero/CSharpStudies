using System;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;

            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            
        }

    }
}
