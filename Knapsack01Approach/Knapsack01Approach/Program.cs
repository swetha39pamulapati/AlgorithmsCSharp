using System;

namespace Knapsack01Approach
{
    class Program
    {
		public static int KnapSack(int capacity, int[] weight, int[] value, int itemsCount)
		//public static int KnapSack(int W, int[] wt, int[] val, int n)
		{
            int[,] K = new int[itemsCount + 1, capacity + 1];

            for (int i = 0; i <= itemsCount; ++i)
            {
                for (int w = 0; w <= capacity; ++w)
                {
                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (weight[i - 1] <= w)
                        K[i, w] = Math.Max(value[i - 1] + K[i - 1, w - weight[i - 1]], K[i - 1, w]);
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            return K[itemsCount, capacity];




  //          int[] dp = new int[W + 1];

		//	for (int i = 1; i < n + 1; i++)
		//	{
		//		for (int w = W; w >= 0; w--)
		//		{

		//			if (wt[i - 1] <= w)

		//				// finding the maximum value
		//				dp[w] = Math.Max(dp[w], dp[w - wt[i - 1]] + val[i - 1]);
		//		}
		//	}
		//	return dp[W];
		}

		static void Main(string[] args)

        {
			int[] value = { 2,3,1,4 };
			int[] weight = { 3, 4, 6, 5 };
			int capacity = 8;
			int itemsCount = 4;

			int result = KnapSack(capacity, weight, value, itemsCount);

			Console.WriteLine(result);
		}
    }
}
