using System;

namespace BinaryTreePostPreTraversal
{
    public class Node
    {
        public int data;
        public Node rightChild;
        public Node leftChild;
        public Node(int x)
        {
            data = x; rightChild = leftChild = null;
        }
    }
    class Program
    {
        int preIndex = 0;
            public Node traverse(int[] pre, int[] post, int start,int end, int size) {
            if (start > end)
                return null;
            Node newNode = new Node(pre[preIndex++]);
            if (start == end)
                return newNode;
            int i;
            for(i = start; i <= end; i++)
            {
                if(post[i]== pre[preIndex])
                    break;
            }
            newNode.leftChild = traverse(pre, post, start, i, size);
            newNode.rightChild = traverse(pre, post, i + 1, end - 1, size);
            return newNode;
        }
        public void printPre(Node node)
        {
            if(node!= null)
            {
                Console.WriteLine(node.data + " ");
                printPre(node.leftChild);
                printPre(node.rightChild);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] postOrder = { 8, 9, 4, 5, 2, 6, 7, 3, 1 };
            int[] preOrder = { 1, 2, 4, 8, 9, 5, 3, 6, 7 };
            int size = preOrder.Length;
            Node root = p.traverse(preOrder, postOrder, 0, size - 1, size);
            p.printPre(root);
        
        
        
        }
    }
}
