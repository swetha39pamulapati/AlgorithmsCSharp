using System;

namespace BubbleSort
{
    class Program
    {
        //static void bubbleSort(int[] arr)
        //{
        //    int n = arr.Length;
        //    int counter = 0;
        //    for (int patindex = n - 1; patindex > 0; patindex--)
        //    {
        //        for (int i = 0; i < patindex; i++)
        //        {
        //            if (arr[i] > arr[i + 1])
        //            {

        //                swap(arr, i, i + 1);
        //                counter++;
        //                Console.WriteLine();

        //            }
        //        }

        //    }
        //    Console.WriteLine($"the number of swappings : {counter}");
        //    Console.WriteLine("sortedarray :");
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.Write(arr[i] + " ");

        //        Console.WriteLine();

        //    }
        //}
        //static void swap(int[] arr, int i, int j)
        //{
        //    if (i == j)
        //        return;
        //    int temp = arr[i];
        //    arr[i] = arr[j];
        //    arr[j] = temp;



        //}

        public static void bubbleSort(int[] arr)
        {

            int n = arr.Length;
            int counter = 0;
            for (int i = 0; i < n - 1; i++)
            {
                counter++;
                int flag = 0;
                for (int j = 0; j < n - 1 - i; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = 1;
                    }
                }
                if (flag == 0)
                    break;
            }
            Console.WriteLine($"The number of swappings : {counter}");
            
        }
        public static void Main()
        {
            int[] arr = { 74, 36, 89, 46, 54, 12 };
            bubbleSort(arr);
            Console.WriteLine("SortedArray :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

                Console.WriteLine();

            }
            //bubbleSort(brr);
            //Console.WriteLine("SortedArray :");
            // printArray(arr);
        }
    }
}
