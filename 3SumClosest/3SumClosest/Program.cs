using System;

namespace _3SumClosest
{
    class Program
    {
        public static int threeSumClosest(int[] num, int target)
        {
            if (num == null || num.Length < 3)
            {
                return int.MaxValue;
            }
            Array.Sort(num);

            var diff = int.MaxValue;
            for (var i = 0; i < num.Length; i++)
            {
                var next = i + 1;
                var last = num.Length - 1;
                while (next < last)
                {
                    var sum = num[i] + num[next] + num[last];
                    var tempdiff = Math.Abs(sum - target);
                    if (tempdiff < Math.Abs(diff))
                    {
                        diff = sum - target;
                    }
                    if (sum >= target)
                    {
                        last--;
                    }
                    else if (sum < target)
                    {
                        next++;
                    }
                }
            }

            return diff + target;
        }
        static void Main(string[] args)
        {
            //int[] arraydata = { -1, 2, 1, -4 }; target 1
            int[] arraydata = { 0, 0, 0 }; //target 1
            int data = threeSumClosest(arraydata, 1);
            Console.WriteLine(data);
        }
    }
}
