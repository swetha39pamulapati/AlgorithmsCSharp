using System;
using System.Collections.Generic;

namespace BucketSortAlgo
{
    class Program
    {
      
            static int[] bucketSort(int[] arr, int n)
            {
            int max = 0;
            //find largest element in the Array
            for (int i = 0; i < n; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            for (int pos = 1; max / pos > 0; pos *= 10)
                    bucketSortAlgo(arr, n, pos);
            return arr;
            }
        static void bucketSortAlgo(int[] arr, int n, int pos)
        {
            List<int>[] buckets = new List<int>[10];
            int i;
            for (i = 0; i < 10; i++)
                buckets[i] = new List<int>();
           
            for (i = 0; i < n; i++)
            {
               int data = ((arr[i] / pos) % 10);
                buckets[data].Add(arr[i]);
                arr[i] = 0;
                
            }
            var arrayvar = 0;
            foreach(List<int> data in buckets)
            {
               
               foreach(int x in data)
                {
                    arr[arrayvar] = x;
                    arrayvar++;
                }


            }
        }



        static void Main(string[] args)
        {
            int[] arr = { 015, 001, 321, 010, 802, 002, 123, 090, 109, 011 };
            int n = arr.Length;
         int[] data =    bucketSort(arr, n);
            for (int i = 0; i < data.Length; i++)
                Console.WriteLine( data[i] + " ");
        }
    }
}
