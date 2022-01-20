using System;

namespace BinaryTreeFromPreInOrder
{
   public class Node
    {
        public int data;
        public Node leftChild;
        public Node rightChild;
        public Node(int value)
        {
            data = value; leftChild = rightChild = null;
        }
    }
    class Program
    {
        public static int preIndex = 0;
        public Node traverseList(int[] inOrdr, int[]pre,int start, int end)
        {
            if (start > end )
                return null;
           
            Node tnode = new Node(pre[preIndex++]);
            //If node has No children
            if (start == end)
                return tnode;

            //else find the index of tnode in inorder
            int index = search(inOrdr, tnode.data, start, end);
            tnode.leftChild = traverseList(inOrdr, pre, start, index - 1);
            tnode.rightChild = traverseList(inOrdr, pre,index+1,end);
            return tnode;
        }
        public int search(int[]arr, int data, int start, int end)
        {
            int i;
            
            for(i =start;i<end; i++)
            {
                if(arr[i] == data)
                {
                    return i;
                }
            }
            return i;
        }
       public void  printInorder(Node node)
        {
            if (node == null)
            {
                return;
            }

            printInorder(node.leftChild);
            Console.Write(node.data + " ");
            printInorder(node.rightChild);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] preOrder = { 1, 2, 4, 8, 9, 10, 11, 5, 3, 6, 7 };
            int[] inorder = { 8, 4, 10, 9, 11, 2, 5, 1, 6, 3, 7 };
            int length = inorder.Length;
          Node root =   p.traverseList(inorder,preOrder, 0, length - 1);
            p.printInorder(root);
        }
    }
}
