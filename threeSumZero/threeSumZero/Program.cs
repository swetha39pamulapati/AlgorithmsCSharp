using System;
using System.Diagnostics;

namespace threeSumZero
{
    //This returns the count of triplets

    //class Program
    //{
    //    public static int findTriplets(int[] arr)
    //    {
    //        int n = arr.Length;
    //        int counter = 0;
    //        for (int i = 0; i < n; i++)
    //        {
    //            for (int j = i + 1; j < n; j++)
    //            {
    //                for (int k = j + 1; k < n; k++)
    //                {
    //                    if (arr[i] + arr[j] + arr[k] == 0)
    //                    {
    //                        counter++;
    //                    }
    //                }
    //            }
    //        }
    //        if (counter == 0)
    //            return -1;
    //        else
    //            return counter;

    //    }
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 0, -1, 1, 2, -2, 3 };
    //        var watch = new Stopwatch();
    //        watch.Start();
    //        var triplets = findTriplets(arr);
    //        watch.Stop();
    //        Console.WriteLine($"the number of triplets: {triplets}");
    //        Console.WriteLine($"time taken: {watch.Elapsed:g}");
    //    }
    //}

    //This returns the arrays of triplets

    class Program
    {
        static void findTriplets(int[] arr, int n)
        {
            bool found = false;
            if (arr[0] == 0)
            {
                Console.Write(0);
                found = true;
            }
           
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (arr[i] + arr[j] + arr[k]
                                               == 0)
                        {
                            Console.Write(arr[i]);
                            Console.Write(" ");
                            Console.Write(arr[j]);
                            Console.Write(" ");
                            Console.Write(arr[k]);
                            Console.Write("\n");
                            found = true;
                        }
                    }
                }
            }

            //If no triplet with 0 sum found in
            // array
            if (found == false)
                Console.Write(" not exist ");
        }
        public static void Main()
        {
            int[] arr = {1,-1,2,0,-2,3 };
            //int[] arr = { 0 };
            int n = arr.Length;
            findTriplets(arr, n);
        }
    }
}
