using System;

namespace BinaryTreeandTraversals
{
    public class Node
    {
        public int data;
        public Node leftChild;
        public Node rightChild;
        public Node(int value)
        {
            data = value; leftChild = null; rightChild = null;
        }
    }
    class Program
    {
        public Node root;
        public Node createBinaryTree(int[] arr,int i,Node root)
        {
            if (i < arr.Length)
            {
                Node temp = new Node(arr[i]);
                root = temp;
                root.leftChild = createBinaryTree(arr, 2 * i + 1, root.leftChild);
                root.rightChild = createBinaryTree(arr, 2 * i + 2, root.rightChild);
            }
            return root;
        }
        public void inorderTraversal(Node root)
        {
            if (root != null)
            {
                inorderTraversal(root.leftChild);
                Console.WriteLine(root.data + "");
                inorderTraversal(root.rightChild);
            }
        }
        public void preOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data + "");
                preOrderTraversal(root.leftChild);
                preOrderTraversal(root.rightChild);
            }
        }
        public void postOrderTraversal(Node root)
        {
            if (root != null)
            {
                postOrderTraversal(root.leftChild);
                postOrderTraversal(root.rightChild);
                Console.WriteLine(root.data + "");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            int[] arr = { 7,6,5,4,3,2,1};
            p.root = p.createBinaryTree(arr,0,p.root);
            Console.WriteLine("\n Inorder: ");
            p.inorderTraversal(p.root);
            Console.WriteLine("\n Preorder: ");
            p.preOrderTraversal(p.root);
            Console.WriteLine("\n Postorder: ");
            p.postOrderTraversal(p.root);
        }
    }
}
