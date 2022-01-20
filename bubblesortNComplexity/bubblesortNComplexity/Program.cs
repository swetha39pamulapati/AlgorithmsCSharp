using System;

namespace bubblesortNComplexity
{
    class Program
    {
        public static void bubbleSortNcomplexity(int[] arr)
        {

            int n = arr.Length;
            int counter = 0;
            for(int i =0; i < n - 1; i++)
            {
                counter++;
                int flag = 0;
            for(int j = 0; j < n - 1 - i; j++)
                {
                    
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        flag = 1;
                    }
                }
                if (flag == 0)
                    break;
            }
            Console.WriteLine($"The number of swappings : {counter}");
            
        }
        static void Main(string[] args)
        {
            int[] arr = { 16, 14, 5, 6, 8 };
            bubbleSortNcomplexity(arr);
            Console.WriteLine("SortedArray using bubble sort:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

                Console.WriteLine();

            }

            //Console.WriteLine();
        }
    }
}
