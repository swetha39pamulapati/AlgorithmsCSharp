using System;

namespace _88MergeSortedArrayHeap
{
    class Program
    {
        static void minHeapify(int[] brr,
                       int i, int M)
        {
            int left = 2 * i;
            int right = 2 * i + 1;
            int smallest = i;

            // Check if arr[left] less than
            // arr[smallest]
            if (left < M && brr[left] <
                brr[smallest])
            {

                // Update smallest
                smallest = left;
            }

            // Check if arr[right] less
            // than arr[smallest]
            if (right < M && brr[right] <
                brr[smallest])
            {

                // Update smallest
                smallest = right;
            }

            // If i is not the index
            // of smallest element
            if (smallest != i)
            {

                // Swap arr[i] and
                // arr[smallest]
                int temp = brr[i];
                brr[i] = brr[smallest];
                brr[smallest] = temp;

                // Perform heapify on smallest
                minHeapify(brr, smallest, M);
            }
        }

        // Function to merge two
        // sorted arrays
        static void merge(int[] arr, int[] brr,
                          int N, int M)
        {

            // Traverse the array []arr
            for (int i = 0; i < N; ++i)
            {

                // Check if current element
                // is less than brr[0]
                if (arr[i] > brr[0])
                {

                    int temp = arr[i];
                    arr[i] = brr[0];
                    brr[0] = temp;

                    // Perform heapify on brr[]
                    minHeapify(brr, 0, M);
                }
            }

            // Sort array brr[]
            Array.Sort(brr);
        }
        static void printArray(int[] arr,
                       int N)
        {

            // Traverse array []arr
            for (int i = 0; i < N; i++)
                Console.Write(arr[i] + " ");
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 23, 35, 235, 2335};
            int[] brr = { 3, 5,7 };
            int N = arr.Length;
            int M = brr.Length;
            merge(arr, brr, N, M);
            printArray(arr, N);
            printArray(brr, M);
        }
    }
    }

