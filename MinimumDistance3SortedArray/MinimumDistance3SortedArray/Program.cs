using System;

namespace MinimumDistance3SortedArray
{
    class Program
    {
        static void findClosest(int[] A, int[] B,
                            int[] C, int p,
                            int q, int r)
         
        {
            // Initialize min diff
            int diff = int.MaxValue;

            // Initialize result
            int res_i = 0,
                res_j = 0,
                res_k = 0;

            // Traverse arrays
            int i = 0, j = 0, k = 0;
            while (i < p && j < q && k < r)
            {
                // Find minimum and maximum
                // of current three elements
                int minimum = Math.Min(A[i],
                              Math.Min(B[j], C[k]));
                int maximum = Math.Max(A[i],
                              Math.Max(B[j], C[k]));

                // Update result if current
                // diff is less than the min
                // diff so far
                if (maximum - minimum < diff)
                {
                    res_i = i;
                    res_j = j;
                    res_k = k;
                    diff = maximum - minimum;
                }

                // We can't get less than 0
                // as values are absolute
                if (diff == 0) break;

                // Increment index of array
                // with smallest value
                if (A[i] == minimum) i++;
                else if (B[j] == minimum) j++;
                else k++;
            }

            // Print result
            Console.WriteLine(A[res_i] + " " +
                              B[res_j] + " " +
                              C[res_k]);
        }
        static void Main(string[] args)
        {
            int[] A = { 5,10,15 };
            int[] B = { 3,6,9,12,15 };
            int[] C = { 8,16,24 };

            int p = A.Length;
            int q = B.Length;
            int r = C.Length;

            // Function calling
            findClosest(A, B, C, p, q, r);
        }
    }
}
