using System;
using System.Collections.Generic;

namespace SortAlmostSortedArrayHeap
{
    class Program
    {
        static void kSort(int[] arr, int n, int k)
        {

            // min heap
            List<int> priorityQueue = new List<int>();

            // add first k + 1 items to the min heap
            for (int i = 0; i < k + 1; i++)
            {
                priorityQueue.Add(arr[i]);
            }

            priorityQueue.Sort();           

            int index = 0;
            for (int i = k + 1; i < n; i++)
            {
                arr[index++] = priorityQueue[0];
                priorityQueue.RemoveAt(0);
                priorityQueue.Add(arr[i]);
                priorityQueue.Sort();
            }

            int queue_size = priorityQueue.Count;

            for (int i = 0; i < queue_size; i++)
            {
                arr[index++] = priorityQueue[0];
                priorityQueue.RemoveAt(0);
            }
        }

        // A utility function to print the array
        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
        static void Main(string[] args)
        {
            int k = 3;
            int[] arr = { 2, 6, 3, 12, 56, 8 };
            int n = arr.Length;
            kSort(arr, n, k);
            Console.WriteLine("Following is sorted array");
            printArray(arr, n);
        
        }
    }
}
