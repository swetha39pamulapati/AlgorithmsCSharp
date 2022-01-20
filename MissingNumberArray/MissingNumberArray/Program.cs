using System;
using System.Collections.Generic;

namespace MissingNumberArray
{
    class Program
    {
        static List<int> missingNumberArray(List<int> nums)
        {
            int idx = 0;
            List<int> missedIntegers = new List<int>();
            for(int i = 0; i<nums.Count; i++)
            {
                //Find Index
                idx = Math.Abs(nums[i]) - 1;
                if (nums[idx] > 0)
                    nums[idx] *= -1;
               
            }
            for (int i = 0; i < nums.Count; i++)
            {
                if(nums[i] > 0)
                {
                    missedIntegers.Add(i + 1);
                   
                }
            }
            return missedIntegers;

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            List<int> data = new List<int>();
            data.Add(3);
            data.Add(3);
            data.Add(3);
            data.Add(5);
            data.Add(1);
            List<int> missEle = missingNumberArray(data);
            foreach(int i in missEle) { 
            Console.WriteLine(i);
            }
        }
    }
}
