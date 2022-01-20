using System;
using System.Collections.Generic;

namespace recursion
{
    class Program
    {
        public int missingNumbers(int[]arr, int n)
        {
            int sum = 0;
            int sumN = n * (n + 1) / 2;
            for(int i = 0;i<n; i++)
            {
                sum += arr[i];
            }
            return sumN - sum;
        }


        static void Main(string[] args)
        {
            Program r = new Program();
            int[] arra = { 0,1, 2, 4, 5, 6 };
            int n = arra.Length;
            int data= r.missingNumbers(arra,n);
            Console.WriteLine(data);
        }
    }
}
