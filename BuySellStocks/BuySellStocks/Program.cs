using System;
using System.Collections.Generic;

namespace BuySellStocks
{
    class Program
    {
        public static double computeProfit(List<double> prices)
        {
            double minPrice = double.MaxValue, maxprofit = 0;
            foreach(double price in prices)
            {
                maxprofit = Math.Max(maxprofit, price - minPrice);
                minPrice = Math.Min(minPrice, price);
            }
            return maxprofit;

        }
        //public static int maxProfit2(int[] stocks)
        //{
        //    int profit = 0;
        //    int maxProfit = 0;

        //    if (stocks == null || stocks.Length <= 1)
        //        return profit;

        //    int bp = stocks[0];
        //    int sp = -1; // price will not be negative

        //    for (int i = 1; i < stocks.Length; i++)
        //    {
        //        // first pick the BP
        //        if (stocks[i] <= bp)
        //        {
        //            bp = stocks[i];
        //            //reset the SP
        //            sp = 0;
        //        }
        //        // pick the SP, pick the new SP even though it is the duplicate SP for situations line [2,1,2,1 0,1,2]
        //        else if (stocks[i] >= sp)
        //        {
        //            sp = stocks[i];
        //            //calculate profit only after getting the sp to avoid situations like [2,4,1]
        //            profit = sp - bp;
        //            maxProfit = Math.Max(profit, maxProfit);
        //        }
        //    }

        //    return maxProfit;
        //}
        static void Main(string[] args)
        {
            //int[] data = { 7, 1, 5, 3, 6, 4 };
            //int[] data = { 7, 6, 4, 3, 1 };
            //int[] data = { 310,315,275,295,260,270,290,230,255,250 };
            //int result = maxProfit2(data);
            //Console.WriteLine(result);
            List<double> data = new List<double> { 7, 1, 5, 3, 6, 4 };
            //List<double> data = new List<double> { 7, 6, 4, 3, 1 };
            //List<double> data = new List<double> { 310, 315, 275, 295, 260, 270, 290, 230, 255, 250 };
          var result =  computeProfit(data);
            Console.WriteLine(result);
        }
    }
}
