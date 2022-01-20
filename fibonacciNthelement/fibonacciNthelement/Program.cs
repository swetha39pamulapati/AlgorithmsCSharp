using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace fibonacciNthelement
{
	//class Program
	//{
	//    static Dictionary<int, long> _memo =
	//        new() { { 0, 0 }, { 1, 1 } };

	//    static void Main(string[] args)
	//    {

	//            Console.WriteLine($"Fib({50}) = {Fib(50)}");

	//    }

	//    static long Fib(int n)
	//    {
	//        if (_memo.ContainsKey(n))
	//            return _memo[n];

	//        var value = Fib(n - 1) + Fib(n - 2);

	//        _memo[n] = value;

	//        return value;
	//    }
	//}


	public class Program
	{
		public static void Main()
		{
			

			// Memoize
			
				int?[] memoList = new int?[51];
				Console.Write(GetFibValueOf_Memoize(51, memoList).ToString() + ",");
		


			
			Console.WriteLine();

		}

		private static int GetFibValueOf_Recursive(int position)
		{
			if (position == 1 || position == 2)
				return 1;
			return GetFibValueOf_Recursive(position - 1) + GetFibValueOf_Recursive(position - 2);
		}

		private static int? GetFibValueOf_Memoize(int position, int?[] memoList)
		{
			if (memoList[position - 1] != null)
			{
				return memoList[position - 1];
			}

			int? result = 0;
			if (position == 1 || position == 2)
				result = memoList[position - 1] = 1;
			else
			{
				result = memoList[position - 1] = GetFibValueOf_Memoize(position - 1, memoList) + GetFibValueOf_Memoize(position - 2, memoList);
			}

			return result;
		}

		private static int? GetFibValueOf_BottomUp(int position)
		{
			if (position == 1 || position == 2)
				return 1;
			else
			{
				int[] fibArray = new int[position];
				fibArray[0] = 1;
				fibArray[1] = 1;

				for (int i = 2; i < position; i++)
				{
					fibArray[i] = (fibArray[i - 1]) + (fibArray[i - 2]);
				}

				return fibArray[position - 1];
			}
		}
	}
}

