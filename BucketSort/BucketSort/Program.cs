using System;
using System.Collections.Generic;

namespace BucketSort
{
    class Program
    {
        static void bucketSort(float[] arr, int n)
        {
            if (n <= 0)
                return;

            // 1) Create n empty buckets
            List<float>[] buckets = new List<float>[n];

            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<float>();
            }

            // 2) Put array elements in different buckets
            for (int i = 0; i < n; i++)
            {
                float idx = arr[i] * n;
                buckets[(int)idx].Add(arr[i]);
            }

            // 3) Sort individual buckets
            for (int i = 0; i < n; i++)
            {
                buckets[i].Sort();
            }
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    arr[index++] = buckets[i][j];
                }
            }
        }
        static void Main(string[] args)
        {
            float[] arr = { (float)0.897, (float)0.565,
                   (float)0.656, (float)0.1234,
                   (float)0.665, (float)0.3434 };
            int n = arr.Length;
            bucketSort(arr, n);
            Console.WriteLine("SortedArray using Radix sort :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

                Console.WriteLine();

            }
        }
    }
}
