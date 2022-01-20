using System;

namespace BinarySearch
{
    class Program
    {
        static int binarySearch(int[] arr, int x)
        {
            int l = 0, r = arr.Length -1 ;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (arr[mid] == x)
                    return mid;

                if (arr[mid] < x)
                    l = mid + 1;

                else
                    r = mid - 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 15, 24, 45, 65, 98 };
            int n = arr.Length;
            //int x = 10;
            int result = binarySearch(arr, 15);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "+ "index " + result);
        }
    }
}
