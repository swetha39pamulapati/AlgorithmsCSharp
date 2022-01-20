using System;

namespace _236LCAOFBST
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
        public static TreeNode findLCA(TreeNode tree, TreeNode s, TreeNode b)
        {
            TreeNode p = tree;
            while (p != null && (p.val < s.val || p.val > b.val))
            {
                while (p != null && p.val < s.val)
                {
                    p = p.right;
                }
                while (p != null && p.val > b.val)
                {
                    p = p.left;
                }

            }
            return p;

        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(1);
            root.right = new TreeNode(2);


            TreeNode result = findLCA(root, new TreeNode(1), new TreeNode(2));
            Console.WriteLine(result.val);
        }
    }
}
