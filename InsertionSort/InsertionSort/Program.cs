using System;

namespace InsertionSort
{
    class Program
    {
        //static void insertionSort(int [] arr)
        //{
        //    int n = arr.Length;
        //    for (int patIndex = 1; patIndex< n; patIndex++)
        //    {
        //        int currentUnsorted = arr[patIndex];
        //        int i = 0;
        //        for(i = patIndex; i>0 && arr[i-1] > currentUnsorted; i--)
        //        {
        //            arr[i] = arr[i - 1];
        //        }
        //        arr[i] = currentUnsorted;
        //    }
        //    Console.WriteLine("SortedArray :");
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write(arr[i] + " ");

        //        Console.WriteLine();

        //    }
        //}
        static void insertionSort(int[] arr)
        {
            int n = arr.Length;
            for(int i =0; i < n-1; i++)
            {
              int  temp = arr[i+1];
                //int j = i - 1;
                //for (j = i - 1; j >= 0 && arr[j] > temp; j--)
                //{
                //    arr[j + 1] = arr[j];
                //}
                int j = i ;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            //Console.WriteLine($"The number of swappings : {counter}");
        }
        static void Main(string[] args)
        {
            int[] arr = { 44, 8, 22, 7, 9,31 };
            insertionSort(arr);
            Console.WriteLine("SortedArray using Insertion sort :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

                Console.WriteLine();

            }
        }
    }
}
