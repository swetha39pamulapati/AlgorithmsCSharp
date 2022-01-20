using System;

namespace HeapSort
{
    class Program
    {
        public static void heapSort(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 ; i >= 0; i--)
                heapify(arr, n, i);

            // One by one extract an element from heap(delete)
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap
                heapify(arr, i, 0);
            }
        }
      public static void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i; // left = 2*i 
            int r = 2 * i + 1; // right = 2*i + 1

            // If left child is larger than root
            if (l < n && arr[l] > arr[largest])
                largest = l;

            // If right child is larger than largest so far
            if (r < n && arr[r] > arr[largest])
                largest = r;

            // If largest is not root
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Recursively heapify the affected sub-tree
                heapify(arr, n, largest);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 15, 6, 5, 4, 7,20, 30};
            int n = arr.Length;
            heapSort(arr);
            Console.WriteLine("SortedArray using Heap sort :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

                Console.WriteLine();
                 
            }
        }
    }
}
