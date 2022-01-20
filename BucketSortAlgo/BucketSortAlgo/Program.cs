using System;
using System.Collections.Generic;

namespace BucketSortAlgo
{
    class Program
    {
      
            static void bucketSort(int[] arr, int n)
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
            }
        static void bucketSortAlgo(int[] arr, int n, int pos)
        {
            List<int>[] buckets = new List<int>[10];
            List<int>[] sortedBuckets = new List<int>[n];
            int i;
            for (i = 0; i < 10; i++)
                buckets[i] = new List<int>();
            for (i = 0; i < n; i++)
            {
               int data = ((arr[i] / pos) % 10);
                buckets[data].Add(arr[i]);
                
            }
            foreach(List<int> data in buckets)
            {
               foreach(int x in data)
                {
                    //sortedBuckets.Add(x);
                    Console.WriteLine(sortedBuckets);
                }


            }
        }



        static void Main(string[] args)
        {
            int[] arr = { 015, 001, 321, 010, 802, 002, 123, 090, 109, 011 };
            int n = arr.Length;
            bucketSort(arr, n);
        }
    }
}
