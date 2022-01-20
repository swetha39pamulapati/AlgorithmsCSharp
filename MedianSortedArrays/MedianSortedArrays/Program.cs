using System;

namespace MedianSortedArrays
{
    class Program
    {
        public static  double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            int n1 = nums1.Length;
            int n2 = nums2.Length;

            int[] nums3 = new int[n1 + n2];

            nums3 = mergeArrays(nums1, nums2);

            int n = nums3.Length;

            Array.Sort(nums3);

            foreach (int data in nums3)
            {
                Console.Write(data + " ");
            }

            if (n % 2 != 0)
                return (double)nums3[n / 2];

            return (double)(nums3[(n - 1) / 2] + nums3[n / 2]) / 2.0;

        }
        public static  int[] mergeArrays(int[] arr1, int[] arr2)
        {

            int[] arr3 = new int[arr1.Length + arr2.Length];

            int i = 0, j = 0, n = 0;

            // Store elements of first array 
            while (i < arr1.Length)
                arr3[n++] = arr1[i++];

            // Store of second array 
            while (j < arr2.Length)
                arr3[n++] = arr2[j++];
           
            return arr3;
           

        }
        static void Main(string[] args)
        {
            int[] data1 = {-5,3,6,12,15 };
            int[] data2 = {-12,-10,-6,-3,4,10};
            double data = FindMedianSortedArrays(data1,data2);
            Console.WriteLine("The median of given data is :" +data);
        }
    }
}
