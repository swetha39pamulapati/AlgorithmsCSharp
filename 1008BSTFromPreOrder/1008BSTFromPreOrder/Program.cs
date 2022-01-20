using System;
using System.Collections.Generic;

namespace _1008BSTFromPreOrder
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
        public static int rootIdx;
        public static TreeNode rebuildBSTFromPreOrder(List<int> preorderSequence)
        {
            rootIdx = 0;
            return rebuildBSTHelper(preorderSequence, int.MinValue, int.MaxValue);
        }
        private static TreeNode rebuildBSTHelper(List<int> preorderSequence, int lowerBound,int upperBound)
        {
        if(rootIdx== preorderSequence.Count)
            {
                return null;
            }
            int root = preorderSequence[rootIdx];
            if(root< lowerBound || root > upperBound)
            {
                return null;
            }
            ++rootIdx;
            TreeNode leftSubtree = rebuildBSTHelper(preorderSequence, lowerBound, root);
            TreeNode rightSubtree = rebuildBSTHelper(preorderSequence, root, upperBound);
            return new TreeNode(root, leftSubtree, rightSubtree);

        }
        static void Main(string[] args)
        {
            //TreeNode root = new TreeNode(19);
            //root.left = new TreeNode(7);
            //root.right = new TreeNode(43);
            //root.left.left = new TreeNode(3);
            //root.left.right = new TreeNode(11);
            //root.right.left = new TreeNode(23);
            //root.right.right = new TreeNode(47);
            List<int> data = new List<int>();
            data.Add(8);
            data.Add(5);
            data.Add(1);
            data.Add(7);
            data.Add(10);
            data.Add(12);
            TreeNode result = rebuildBSTFromPreOrder(data);
            Console.WriteLine(result);
        }
    }
}
