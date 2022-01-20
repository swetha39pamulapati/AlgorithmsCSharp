using System;
using System.Collections.Generic;

namespace _230KthLargestBST
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
        public static List<int> findKthElements(TreeNode tree, int k)
        {
            List<int> KLargestElements = new List<int>();
            findKthLargestBST(tree, k, KLargestElements);
            return KLargestElements;
        }
        private static void findKthLargestBST(TreeNode tree, int k, List<int> KLargestElements)
        {
            if(tree!=null && KLargestElements.Count < k)
            {
                findKthLargestBST(tree.right, k, KLargestElements);
                if(KLargestElements.Count < k)
                {
                    KLargestElements.Add(tree.val);

                }
                findKthLargestBST(tree.left, k, KLargestElements);
            }
        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(19);
            root.left = new TreeNode(7);
            root.right = new TreeNode(43);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(11);
            root.right.left = new TreeNode(23);
            root.right.right = new TreeNode(47);
            List<int> data = findKthElements(root, 4);
            foreach(int i in data)
            {
                Console.Write(i + " ");
            }

        }
    }
}
