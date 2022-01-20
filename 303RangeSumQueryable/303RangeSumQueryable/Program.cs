using System;

namespace _303RangeSumQueryable
{
    class NumArray
    {
        private int[] sum;

        public NumArray(int[] nums)
        {
            sum = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                sum[i + 1] = sum[i] + nums[i];
            }
        }

        public int sumRange(int left, int right)
        {
            return sum[right + 1] - sum[left];
        }


        static void Main(string[] args)
        {
            int[] nums = new int[] { -2, 0, 3, -5, 2, -1 };
            NumArray numArray = new NumArray(nums);
            Console.WriteLine(numArray.sumRange(0, 2)); 
            Console.WriteLine(numArray.sumRange(2, 5)); 
            Console.WriteLine(numArray.sumRange(0, 5));
        }
    }

    
}
