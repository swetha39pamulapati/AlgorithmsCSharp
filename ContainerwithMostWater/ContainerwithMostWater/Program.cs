using System;

namespace ContainerwithMostWater
{
    class Program
    {
        public int maxArea(int[] H)
        {
            int ans = 0, i = 0, j = H.Length - 1, res = 0;
            while (i < j)
            {
                if (H[i] <= H[j])
                {
                    res = H[i] * (j - i);
                    i++;
                }
                else
                {
                    res = H[j] * (j - i);
                    j--;
                }
                if (res > ans) ans = res;
            }
            return ans;
        }

        //public int maxArea(int[] height)
        //{
        //    // Maximum area will be stored in this variable
        //    int maximumArea = int.MinValue;
        //    // Left and right pointers
        //    int left = 0;
        //    int right = height.Length - 1;
        //    // Loop until left and right meet
        //    while (left < right)
        //    {
        //        // Shorter pole/vertical line
        //        int shorterLine = Math.Min(height[left], height[right]);
        //        // Update maximum area if required
        //        maximumArea = Math.Max(maximumArea, shorterLine * (right - left));
        //        // If there is a longer vertical line present
        //        if (height[left] < height[right])
        //        {
        //            left++;
        //        }
        //        else
        //        {
        //            right--;
        //        }
        //    }
        //    return maximumArea;
        //}
        static void Main(string[] args)
        {
            Program p = new Program();
            //int[] data = { 1, 1 };
            //int[] data = { 4, 3, 2, 1, 4 };
            int[] data = { 1, 2, 1 };
            int result = p.maxArea(data);
            Console.WriteLine(result);
        }
    }
}
