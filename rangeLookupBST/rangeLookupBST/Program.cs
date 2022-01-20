using System;
using System.Collections.Generic;

namespace rangeLookupBST
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
    public  class Interval
    {
        public int left, right;
        public Interval(int left, int right)
        {
            this.left = left;
            this.right = right;
        }
    }
    class Program
    {
        public static List<int> rangeLookUpBST(TreeNode tree, Interval interval)
        {
            List<int> result = new List<int>();
            rangeLookUpHelper(tree, interval, result);
            return result;
        }
        private static void rangeLookUpHelper( TreeNode tree, Interval interval, List<int> results)
        {
            if (tree == null)
                return;

            if (interval.left <= tree.val && tree.val <= interval.right) {
                rangeLookUpHelper(tree.left, interval, results);
                results.Add(tree.val);
                rangeLookUpHelper(tree.right, interval, results);

            }
            else if(interval.left > tree.val)
            {
                rangeLookUpHelper(tree.right, interval, results);
            }
            else
            {
                rangeLookUpHelper(tree.left, interval, results);
            }
            }

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(19);
            root.left = new TreeNode(7);
            root.right = new TreeNode(15);
            root.left.left = new TreeNode(17);
            root.left.right = new TreeNode(11);
            root.right.left = new TreeNode(18);
            root.right.right = new TreeNode(9);
            Interval data = new Interval(7,19);

            List<int> resultSet = rangeLookUpBST(root, 
                data);
            foreach(int i in resultSet)
            {
                Console.Write(i + " ");
            }
        }
    }
}
