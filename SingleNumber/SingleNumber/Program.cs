using System;
using System.Collections.Generic;
using System.Linq;

namespace SingleNumber
{
    class Program
    {
        public static int singleNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for(int i = 0; i< nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    set.Remove(nums[i]);

                }
                else
                {
                    set.Add(nums[i]);
                }
            }
            return set.ElementAt(0);
        }
        static void Main(string[] args)
        {
            int[] data = { 1,4,2,2,4 };
            int result = singleNumber(data);
            Console.WriteLine(result);
        }
    }
}
