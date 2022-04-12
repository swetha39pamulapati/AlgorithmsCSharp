using System;

namespace MergeSort
{
    class Program
    {
        public static void mergeSort(int[] arr,int lb, int ub)
        {
            if (lb < ub)
            {
                int mid = (lb + ub) / 2;
                mergeSort(arr, lb, mid);
                mergeSort(arr, mid+1, ub);
                merge(arr, lb, mid, ub);
            }
            
        }
       public static void merge(int []arr, int lb, int mid,int ub)
        {
            int i = lb;
            int j = mid + 1;
            int k = lb;
            int[] brr = new int[arr.Length];
            while (i<=mid && j<= ub)
            {
                
                if (arr[i]<= arr[j])
                {
                   
                    brr[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    brr[k] = arr[j];
                    j++;
                    k++;
                }
            }
            if(i > mid)
            {
                while (j <= ub)
                {
                    brr[k]= arr[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i <= mid)
                {
                    brr[k] = arr[i];
                    i++;
                    k++;
                }

            }
            for(k = lb; k<= ub; k++)
            {
                arr[k] = brr[k];
            }
            

        }
       
      
        static void Main(string[] args)
        {
            int[] arr = {15,5,24,8,1,31,6,10,20 };
            int n = arr.Length;
            mergeSort(arr,0,n-1);
            Console.WriteLine("sorrtedArray using bubble sort :");
            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write(arr[x] + " ");

                Console.WriteLine();

            }
        }
    }
}
