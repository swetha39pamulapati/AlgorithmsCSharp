using System;

namespace CountingSort
{
    class Program
    {
        static void countingsort(int[] arr)
        {
            int n = arr.Length;
            int max = 0;
            //find largest element in the Array
            for (int i = 0; i < n; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            //Create a freq array to store number of occurrences of 
            //each unique elements in the given array 
            int[] count = new int[max + 1];
            for (int i = 0; i < max + 1; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                count[arr[i]]++;
            }

            //sort the given array using freq array
            for (int i = 0, j = 0; i <= max; i++)
            {
                while (count[i] > 0)
                {
                    arr[j] = i;
                    j++;
                    count[i]--;
                }
            }
        }

        // function to print array
        static void PrintArray(int[] Array)
        {
            int n = Array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(Array[i] + " ");
            Console.Write("\n");
        }

        // test the code
        static void Main(string[] args)
        {
            int[] MyArray = { 2,1,1,0,2,5,4,0,2,8,7,7,9,2,0,1,9};
            Console.Write("Original Array\n");
            PrintArray(MyArray);

            countingsort(MyArray);
            Console.Write("\nSorted Array\n");
            PrintArray(MyArray);
        }
    }
}
