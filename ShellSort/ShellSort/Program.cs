using System;

namespace ShellSort
{
    class Program
    {
        public static void shellSort(int[] arr)
        {
            int n = arr.Length;
            int gap = n / 2;
            int temp, i, j;


            while (gap > 0)
            {
                for (i = gap; i < n; i++)
                {
                    temp = arr[i];
                    j = i;
                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j = j - gap;
                    }
                    arr[j] = temp;
                }
                 gap = gap / 2;
            }
        }
       //public  static void shellSort(int [] arr)
       // {
       //     int n = arr.Length;
       //     for (int gap = n / 2; gap > 0; gap /= 2)
       //     {
       //         for (int j = gap; j < n; j++)
       //         {
       //             for (int i = j - gap; i >= 0; i -= gap)
       //             {
       //                 if (arr[i + gap] > arr[i])
       //                 {
       //                     break;

        //                 } 
        //                 else
        //                 {
        //                     int temp = arr[i];
        //                     arr[i] = arr[i + gap];
        //                     arr[i + gap] = temp;
        //                 }
        //             }

        //         }
        //     }
        // }
        static void Main(string[] args)
        {
            int[] arr = { 2,7,9,10,1};
            shellSort(arr);
            Console.WriteLine("SortedArray using shell sort:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

                Console.WriteLine();

            }
        }
    }
}
