using System;

namespace _98ISValidBST
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
      public bool isValidBST(TreeNode root)
        {
            if(root == null)
            {
                return true;
            }
            return dfs(root, null, null);
        } 
        private bool dfs(TreeNode root, int? min, int? max)
        {
            if (root == null)
                return true;
            if((min != null && root.val<= min) || (max != null && root.val >= max)){
                return false;
            }
            return dfs(root.left, min, root.val) && dfs(root.right, root.val, max);
        }

       
        //private static long previous = long.MinValue;
        //public static bool IsValidBST(TreeNode root)
        //{
        //    if (root != null)
        //    {
        //        if (!IsValidBST(root.left))
        //        {
        //            return false;
        //        }

        //        if (root.val <= previous)
        //        {
        //            return false;
        //        }

        //        previous = root.val;

        //        return IsValidBST(root.right);
        //    }

        //    return true;
        //}
        static void Main(string[] args)
        {
            Program p = new Program();
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);
            //root.left.left = new TreeNode();
            //root.left.right = new TreeNode();
            //root.right.left = new TreeNode(3);
            //root.right.right = new TreeNode(6);
            bool result = p.isValidBST(root);
            Console.WriteLine(result);
        }
    }
}
