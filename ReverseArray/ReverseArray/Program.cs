using System;

namespace ReverseArray
{
    class Program
    {
        static void reverseArray(int[]arr)
        {
            for(int i = arr.Length-1;i>= 0;i--)
            {
                Console.Write(arr[i]);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 10,9,2,6,4,8,7};
            int n = arr.Length;
            reverseArray(arr);
        }
    }
}
