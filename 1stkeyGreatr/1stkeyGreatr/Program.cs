using System;

namespace _1stkeyGreatr
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
        public static TreeNode findFirstGreater(TreeNode tree,int k)
        {
            TreeNode subtree = tree, firstSoFar = null;
            while(subtree!= null)
            {
                if(subtree.val > k)
                {
                    firstSoFar = subtree;
                    subtree = subtree.left;


                }
                else
                {
                    subtree = subtree.right;
                }
            }
            return firstSoFar;
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
            TreeNode result = findFirstGreater(root,11);
            Console.WriteLine(result.val);
        }
    }

}
