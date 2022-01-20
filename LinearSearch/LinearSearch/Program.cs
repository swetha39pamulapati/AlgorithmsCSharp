using System;

namespace LinearSearch
{
    class Program
    {
        public static void linearSearch(int[] arr, int data)
        {
            int n = arr.Length;
            int found = 0;
            for(int i = 0; i<n; i++)
            {
                if(arr[i] == data)
                {
                    found = 1;
                    Console.Write($"Data is found at index: {i}");
                }
            }
            if(found == 0)
            {
                Console.Write("\n Data is not found");
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 15, 5, 20, 1, 17, 10, 30 };
            int n = arr.Length;
            linearSearch(arr, 39);
        }
    }
}
