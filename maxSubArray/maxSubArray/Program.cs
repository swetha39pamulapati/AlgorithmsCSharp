﻿using System;

namespace maxSubArray
{
    
    class Program
    {
        static int maxSubArraySum(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue,
                max_ending_here = 0;
           int start = 0, end = 0, s = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    start = s;
                    end = i;
                }

                else if (max_ending_here < 0) { 
                    max_ending_here = 0;
                s = i + 1;
                }
            }
            Console.WriteLine("Starting index " +
                                          start);
            Console.WriteLine("Ending index " +
                                          end);
            return max_so_far;

            
        }

        static void Main(string[] args)
        {
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Console.Write("Maximum contiguous sum is " +
                                    maxSubArraySum(a));
        }
    }
}
