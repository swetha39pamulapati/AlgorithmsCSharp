using System;

namespace KthLargestElementInArrayHeap
{
    class Program
    {
        public int FindKthLargest(int[] nums, int k)
        {
            int n = nums.Length;
            for (int i = n / 2 ; i >= 0; i--)
            { // Create the max heap
                Heapify(nums, n, i);
            }
            for (int i = n - 1; i >= n - k; i--)
            { // Order until we have the kth element 
                Swap(nums, 0, i);
                Heapify(nums, i, 0);
            }
            return nums[n - k];
        }
        private void Heapify(int[] nums, int n, int i)
        {
            int largest = i, l = 2 * i, r = 2 * i + 1;
            if (l < n && nums[l] > nums[largest]) largest = l;
            if (r < n && nums[r] > nums[largest]) largest = r;
            if (largest != i)
            {
                Swap(nums, i, largest);
                Heapify(nums, n, largest);
            }
        }
        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] set = { 7, 4, 6, 3, 9, 1 };
            int data = p.FindKthLargest(set,2);
            Console.WriteLine(data);
        }
    }
}
