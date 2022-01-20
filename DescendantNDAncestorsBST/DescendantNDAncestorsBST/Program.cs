using System;

namespace DescendantNDAncestorsBST
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
        public static bool pairIncludesAandD(TreeNode possibleaord0, TreeNode possibleaord1,TreeNode middle)
        {
            TreeNode search0 = possibleaord0, search1 = possibleaord1;
            while(search0 != possibleaord1  && search0!= middle && search1 != possibleaord0 && search1 != middle && (search0 != null || search1 != null))
            {
                if(search0 != null)
                {
                    search0 = search0.val > middle.val ? search0.left : search0.right;
                }
                if (search1 != null)
                {
                    search1 = search1.val > middle.val ? search1.left : search1.right;
                }
            }
            if(search0 == possibleaord1 || search1 == possibleaord0 || (search0 != middle || search1 != middle)){
                return false;
            }
            return search0 == middle ? searchTarget(middle, possibleaord1) : searchTarget(middle, possibleaord0);
        }
        private static bool searchTarget(TreeNode from,TreeNode target)
        {
            while(from!= null && from!= target)
            {
                from = from.val > target.val ? from.left : from.right;
            }
            return from == target;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
