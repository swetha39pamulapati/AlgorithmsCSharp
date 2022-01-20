using System;
using System.Collections.Generic;

namespace _295MedianSortedArrays
{
    class Program
    {
        public static void printMedian(int[] a)
        {
            double med = a[0];

            // max heap to store the smaller half elements
            List<int> smaller = new List<int>();

            // min-heap to store the greater half elements
            List<int> greater = new List<int>();
            smaller.Add(a[0]);
            Console.WriteLine(med);

            // reading elements of stream one by one
            /* At any time we try to make heaps balanced and
                    their sizes differ by at-most 1. If heaps are
                    balanced,then we declare median as average of
                    min_heap_right.top() and max_heap_left.top()
                    If heaps are unbalanced,then median is defined
                    as the top element of heap of larger size */
            for (int i = 1; i < a.Length; i++)
            {

                int x = a[i];

                // case1(left side heap has more elements)
                if (smaller.Count > greater.Count)
                {
                    if (x < med)
                    {
                        smaller.Sort();
                        smaller.Reverse();
                        greater.Add(smaller[0]);
                        smaller.RemoveAt(0);
                        smaller.Add(x);
                    }
                    else
                        greater.Add(x);
                    smaller.Sort();
                    smaller.Reverse();
                    greater.Sort();
                    med = (double)(smaller[0] + greater[0]) / 2;
                }

                // case2(both heaps are balanced)
                else if (smaller.Count == greater.Count)
                {
                    if (x < med)
                    {
                        smaller.Add(x);
                        smaller.Sort();
                        smaller.Reverse();
                        med = (double)smaller[0];
                    }
                    else
                    {
                        greater.Add(x);
                        greater.Sort();
                        med = (double)greater[0];
                    }
                }

                // case3(right side heap has more elements)
                else
                {
                    if (x > med)
                    {
                        greater.Sort();
                        smaller.Add(greater[0]);
                        greater.RemoveAt(0);
                        greater.Add(x);
                    }
                    else
                        smaller.Add(x);
                    smaller.Sort();
                    smaller.Reverse();
                    med = (double)(smaller[0] + greater[0]) / 2;

                }
                Console.WriteLine(med);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 15, 10, 20, 3 };
            printMedian(arr);
        }
    }
}
