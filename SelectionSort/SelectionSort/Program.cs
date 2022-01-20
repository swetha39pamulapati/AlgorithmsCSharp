using System;

namespace SelectionSort
{
    class Program
    {
        public static void selectionSort(int[] arr)
        {
            int n = arr.Length; 
            for (int i = 0; i < n - 1; i++)
            {
                int temp,min = i;
                for (int j = i+1; j<n; j++)
                {
                    if(arr[j]< arr[min])
                    {
                        min = j;
                    }
                }
                temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;

            }
            Console.WriteLine("SortedArray using selection sort :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

                Console.WriteLine();

            }

        }
        public static void Main()
        {
            int[] arr = { 7,8,10,6,2};
            selectionSort(arr);
        }
    }
}
