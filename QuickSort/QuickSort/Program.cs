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
        ////        //starting as pivot
        //public static int partition(int[] arr, int lb, int ub)
        //{
        //    int pivot = lb;
        //    int start = lb;
        //    int end = ub;

        //    while (start < end)
        //    {
        //        while (arr[start] <= arr[pivot] && start < end)
        //        {

        //            start++;
        //        }

        //        while (arr[end] > arr[pivot])
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

        //Random Number
        //public static void quickSort(int[] arr, int lb, int ub)
        //{
        //    if (lb < ub)
        //    {
        //        int loc = partitionRandom(arr, lb, ub);
        //        quickSort(arr, lb, loc - 1);
        //        quickSort(arr, loc + 1, ub);

        //    }
        //}
        //private static int partitionRandom(int[] arr, int low, int high)
        //{
        //    Random ran = new Random();
        //    int random = ran.Next(low, high);
        //    //swap with starting element and make it pivot
        //    int temp = arr[random];
        //    arr[random] = arr[low];
        //    arr[low] = temp;
        //    return partition(arr, low, high);

        //}
        ////starting as pivot
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
            if (lb < ub)
            {

                int middle = lb + (ub - lb) / 2;
                int pivot = middle;
                int start = lb, end = ub;
                while (start < end)
                {
                    while (arr[start] < arr[pivot])
                    {
                        start++;
                    }

                    while (arr[end] > arr[pivot])
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
        }



        //ENDING AS PIVOT
        //public static void quickSort(int[] arr, int lb, int ub)
        //{
        //    if (lb < ub)
        //    {
        //        int loc = partition(arr, lb, ub);
        //        quickSort(arr, lb, loc - 1);
        //        quickSort(arr, loc + 1, ub);

        //    }

        //}
        //public static int partition(int[] arr, int lb, int ub)
        //{
        //    int start = lb;
        //    int end = ub - 1;
        //   int pivot = ub;

        //    while (start <= end)
        //    {
        //        while (arr[start] < arr[pivot])
        //        {
        //            start++;
        //        }
        //        while (end>= start && arr[end] >= arr[pivot])
        //        {
        //            end--;
        //        }
        //        if (start < end)
        //        {
        //            int temp = arr[start];
        //            arr[start] = arr[end];
        //            arr[end] = temp;
        //        }
        //    }
        //    int temp1 = arr[start];
        //    arr[start] = arr[pivot];
        //    arr[pivot] = temp1;

        //    return start;
        //}
        static void Main(string[] args)
        {
            int[] arr = { 7,6,10,5,7,2,1,15,4 };
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
