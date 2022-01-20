using System;

namespace RadixSort
{
    class Program
    {
        static void radixSort(int[]arr,int n)
        {
            int max = getMax(arr,n);
            for (int pos = 1; max / pos > 0; pos *= 10)
                countSort(arr, n, pos);
        }
        public static void countSort(int[] arr, int n, int pos)
        {
            int[] brr = new int[10];
            int[] count = new int[10];
            int i;
            for (i = 0; i < 10; i++)
                count[i] = 0;
            for (i = 0; i < n; i++)
                count[(arr[i] / pos) % 10]++;
            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];
            for (i = n - 1; i >= 0; i--)
            {
                brr[--count[(arr[i] / pos) % 10]] = arr[i];
               
            }
            for (i = 0; i < n; i++)
                arr[i] = brr[i];
        }
            public static int getMax(int[] arr, int n)
        {
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }
        static void Main(string[] args)
        {
            int[] arr = { 432,8,530,90,88,231,11,45,677,199};
            int n = arr.Length;
            radixSort(arr, n);
            Console.WriteLine("SortedArray using Radix sort :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

                Console.WriteLine();

                }
            }
    }
}
