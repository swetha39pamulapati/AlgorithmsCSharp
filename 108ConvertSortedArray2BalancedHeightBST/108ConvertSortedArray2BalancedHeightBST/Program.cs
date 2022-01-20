using System;
using System.Collections.Generic;

namespace _108ConvertSortedArray2BalancedHeightBST
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    class Program
    {
        public static TreeNode buildMinHeightBST(List<int> a)
        {
            return buildMinheighFromSortedSubArray(a, 0, a.Count);
        }
        private static TreeNode buildMinheighFromSortedSubArray(List<int> a,int start, int end)
        {
            if(start >= end)
            {
                return null;
            }
            int mid = start + ((end - start) / 2);
            TreeNode root = new TreeNode(a[mid]);
            root.left = buildMinheighFromSortedSubArray(a, start, mid - 1);
            root.right = buildMinheighFromSortedSubArray(a, mid + 1, end);
            return root;
        }
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            data.Add(2);
            data.Add(3);
            data.Add(5);
            data.Add(7);
            data.Add(11);
            data.Add(13);
            data.Add(17);
            data.Add(19);
            data.Add(23);
            TreeNode result =   buildMinHeightBST(data);
            Console.WriteLine(result.val);
        }
    }
}
