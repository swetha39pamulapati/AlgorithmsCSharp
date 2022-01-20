using System;
using System.Linq;

namespace MissingNumber
{
    class Program
    {
        public int missingNumber(int[] nums)
        {
            int n = nums.Length;
            int sum = n * (n + 1) / 2;
            int sums = nums.Sum();
            return sum - sums;
        }



        static void Main(string[] args)
        {
            Program p = new Program();
            int[] data = { 1,4,2,0};
            int result = p.missingNumber(data);
            Console.WriteLine(result);
        }
    }
}
