using System;
using System.Collections.Generic;
using System.Linq;



//Looking for some feedback on the Two Sum LeetCode problem.Looking for feedback on code style in general, use of var, variable naming and initialization, return placement, and any other feedback or optimizations I could make.
//Problem Given an array of integers, return indices of the two numbers such that they add up to a specific target.
namespace Indicesof2numberswithTarget
{
    class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var numsDictionary = new Dictionary<int, int>();

            int complement = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];
                int index = 0;
                if (numsDictionary.TryGetValue(complement, out index))
                {
                    int[] twoSumSolution = { index, i };
                    return twoSumSolution;
                }

                if (!numsDictionary.ContainsKey(nums[i]))
                {
                    numsDictionary.Add(nums[i], i);
                }
            }

            return null;
        }
        static void Main(string[] args)
        {

            int[] numbers = new int[] {  11, 2, 7, 15 };
            int[] output = TwoSum(numbers, 9);

            if (output == null)
                Console.WriteLine("No matched indexes for given target");
            else
                Console.WriteLine($"the two sum indexs are : {output[0]}, {output[1]}");
        }
    }
}
