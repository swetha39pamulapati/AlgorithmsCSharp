using System;

namespace BinaryTreeFromPostInOrder
{
    class Node
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
        public Node traverse(int[] post,int postIdx, int[] inOrdr,int start,int end)
        {
            if (start > end || postIdx<0)
                return null;
            Node tNode = new Node(post[postIdx]);
            if (start == end)
                return tNode;
            int i;
            for(i = start;i<end; i++) {
                if (inOrdr[i] == post[postIdx])
                    break;
            }
            tNode.rightChild = traverse(post, postIdx-1, inOrdr, i+1, end);
            tNode.leftChild = traverse(post, postIdx - 1 - (end - i), inOrdr, start, i - 1);
            return tNode;
        }
        public int search(int[] arr, int start, int end,int value)
        {
            int i;
            for(i = start; i < end; i++)
            {
                if(arr[i]== value)
                {
                    return i;
                }
            }
            return i;
        }
        public void printPostOrder(Node node)
        {
            if(node!= null)
            {
                printPostOrder(node.leftChild);
                printPostOrder(node.rightChild);
                Console.Write(node.data + " ");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] postOrder = { 9, 1, 2, 12, 7, 5, 3, 11, 4, 8 };
            int[] inOrder = { 9, 5, 1, 7, 2, 12, 8, 4, 3, 11 };
            int length = postOrder.Length;
            Node root = p.traverse(postOrder, postOrder.Length-1, inOrder,0, length);
            p.printPostOrder(root);
            //Console.WriteLine("Hello World!");
        }
    }
}
