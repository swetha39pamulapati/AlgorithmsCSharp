using System;
using System.Collections.Generic;
using System.Linq;

namespace _4sum
{
    class Program
    {
		public IList<IList<int>> SumOfanyNumb(int[] nums, int target)
		{
			Array.Sort(nums);
			return kSum(nums, 0, 4, target);
		}

		public IList<IList<int>> kSum(int[] nums, int start, int k, int target)
		{
			int len = nums.Length;
			IList<IList<int>> res = new List<IList<int>>();
			if (k == 2)
			{
				int left = start, right = len - 1;
				while (left < right)
				{
					int sum = nums[left] + nums[right];
					if (sum == target)
					{
						res.Add((new List<int> { nums[left], nums[right] }));
						while (left < right && nums[left] == nums[left + 1]) left++;
						while (left < right && nums[right] == nums[right - 1]) right--;
						left++;
						right--;
					}
					else if (sum < target) left++;
					else right--;
				}
			}
			else
			{
				for (int i = start; i < len - k + 1; i++)
				{
					while (i > start && i < len - 1 && nums[i] == nums[i - 1]) { i++; };
					var temp = kSum(nums, i + 1, k - 1, target - nums[i]);
					foreach (var element in temp)
					{
						element.Add(nums[i]);
					}
					foreach (var val in temp)
					{
						res.Add(val);
					}
				}
			}

			return res;
		}
		static void Main(string[] args)
        {
			Program p = new Program();
			int[] arr = { 1, -1, 2, 0, -2, 3 };
			IList<IList<int>> result = p.SumOfanyNumb(arr,0);
			//         foreach (IList<int> i in data)
			//{

			//	Console.Write(i);
			//}

			Console.Write("[");
			for (int k = 0; k < result.Count; k++)
			{
				IList<int> i = result[k];
				string output = "";
				Console.Write("[");
				for (int l = 0; l < i.Count; l++)
				{
					int j = i[l];
					if (output != "")
					{
						output += ",";
					}
					output += Convert.ToString(j);
				}
				Console.Write(output);
				Console.Write("]");
			}
			Console.Write("]");
		}
    }
}
