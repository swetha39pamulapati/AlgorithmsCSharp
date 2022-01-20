using System;

namespace QuickSort
{
    class Program
    {
        //public static void quickSort(int[] arr, int lb, int ub)
        //{
        //    if (lb < ub)
        //    {
        //        int loc = partition(arr, lb, ub);
        //        quickSort(arr, lb, loc - 1);
        //        quickSort(arr, loc + 1, ub);

        //    }
        //}
        //starting as pivot
        //public static int partition(int[] arr, int lb, int ub)
        //{
        //    int pivot = arr[lb];
        //    int start = lb;
        //    int end = ub;

        //    while (start < end)
        //    {
        //        while (arr[start] <= pivot && start < end)
        //        {

        //            start++;
        //        }

        //        while (arr[end] > pivot)
        //        {
        //            end--;
        //        }
        //        if (start < end)
        //        {
        //            //   swap(arr, arr[start], arr[end]);
        //            int temp = arr[start];
        //            arr[start] = arr[end];
        //            arr[end] = temp;
        //        }
        //    }
        //    //swap(arr, arr[lb], arr[end]);
        //    int temp2 = arr[lb];
        //    arr[lb] = arr[end];
        //    arr[end] = temp2;

        //    return end;
        //}

        //MIDDLE 
        public static void quickSort(int[] arr, int lb, int ub)
        {
            if (lb >= ub)
                return;

            int middle = lb + (ub - lb) / 2;
            int pivot = arr[middle];
            int start = lb, end = ub;
            while (start <= end)
            {
                while (arr[start] < pivot)
                {
                    start++;
                }

                while (arr[end] > pivot)
                {
                    end--;
                }

                if (start <= end)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    start++;
                    end--;
                }
            }

            // recursively sort two sub parts
            if (lb < end)
                quickSort(arr, lb, end);

            if (ub > start)
                quickSort(arr, start, ub);
        }



        //ENDING AS PIVOT
        //public static int partition(int[] arr, int start, int end)
        //{
        //    int pivot = arr[end];

        //    for (int i = start; i < end; i++)
        //    {
        //        if (arr[i] < pivot)
        //        {
        //            int temp1 = arr[start];
        //            arr[start] = arr[i];
        //            arr[i] = temp1;
        //            start++;
        //        }
        //    }


        //    int temp = arr[start];
        //    arr[start] = pivot;
        //    arr[end] = temp;

        //    return start;
        //}

        static void Main(string[] args)
        {
            int[] arr = { 26, 14, 12, 9, 23, 5, 2 };
            int n = arr.Length;
            quickSort(arr, 0, n - 1);
            Console.WriteLine("sorrtedArray using quick sort :");
            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write(arr[x] + " ");

                Console.WriteLine();

            }
        }
    }
}
