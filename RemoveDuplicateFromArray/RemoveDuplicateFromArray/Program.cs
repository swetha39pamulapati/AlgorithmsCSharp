using System;

namespace RemoveDuplicateFromArray
{
    class Program
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int previous = nums[0];
            int currentIndex = 0;
            for(int i =0; i<nums.Length; i++)
            {
                if(previous != nums[i])
                {
                    currentIndex++;
                    nums[currentIndex] = nums[i];
                    previous = nums[i];
                }
            }
            Console.Write(nums);
            return currentIndex + 1;
        }
        static void Main(string[] args)
        {
            int[] resultset = {0, 1, 1, 2 };
            int data = RemoveDuplicates(resultset);
            Console.WriteLine(data);
        }
    }
}
