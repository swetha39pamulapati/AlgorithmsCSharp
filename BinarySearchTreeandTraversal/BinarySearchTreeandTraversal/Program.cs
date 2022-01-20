using System;

namespace BinarySearchTreeandTraversal
{
    public class TreeNode
    {
        public int val;
        public TreeNode leftChild;
        public TreeNode rightChild;
        public TreeNode(int val = 0, TreeNode leftChild = null, TreeNode rightChild = null)
        {
            this.val = val;
            this.leftChild = leftChild;
            this.rightChild = rightChild;
        }
    }
    class Program
    {
        public TreeNode root;
        public void Add(int data)
        {
            // Create a new node
            TreeNode node = new TreeNode(data);
            if (this.root == null)
            {
                // When adds a first node in bst
                this.root = node;
            }
            else
            {
                TreeNode parent = this.root;
                // Add new node to proper position
                while (parent != null)
                {
                    if (data < parent.val)
                    {
                        if (parent.leftChild == null)
                        {
                            // When leftChild child empty
                            // So add new node here
                            parent.leftChild = node;
                            return;
                        }
                        else
                        {
                            // Otherwise
                            // Visit leftChild sub-tree
                            parent = parent.leftChild;
                        }
                    }
                    else if(data > parent.val)
                    {
                        if (parent.rightChild == null)
                        {
                            // When rightChild child empty
                            // So add new node here
                            parent.rightChild = node;
                            return;
                        }
                        else
                        {
                            // Visit rightChild sub-tree
                            parent = parent.rightChild;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        public void TraversePreOrder(TreeNode parent)
        {
            if (parent != null)
            {
                Console.Write(parent.val + " ");
                TraversePreOrder(parent.leftChild);
                TraversePreOrder(parent.rightChild);
            }
        }
        public void TraverseInOrder(TreeNode parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.leftChild);
                Console.Write(parent.val + " ");
                TraverseInOrder(parent.rightChild);
            }
        }
        public void TraversePostOrder(TreeNode parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.leftChild);
                TraversePostOrder(parent.rightChild);
                Console.Write(parent.val + " ");
            }
        }
        public int GetTreeDepth(TreeNode parent)
        {
            if (parent == null)
                return 0;
            else
            {
                int leftChildDepth = GetTreeDepth(parent.leftChild);
                int rightChildDepth = GetTreeDepth(parent.rightChild);
                if(leftChildDepth > rightChildDepth)
                    return leftChildDepth + 1;
                else
                    return rightChildDepth + 1;
            }
        }
        public bool search(TreeNode parent,int value)
        {
            while(parent!= null)
            {
                if (value == parent.val)
                    return true;
                else if (value < parent.val)
                    return search(parent.leftChild, value);
                else
                    return search(parent.rightChild, value);
            }
            return false;
        }
        //public TreeNode remove(TreeNode parent, int value)
        //{
        //    if (parent == null)
        //        return parent;
        //     if (value < parent.val)
        //    {
        //        parent.leftChild =  remove(parent.leftChild, value);
        //    }
        //    else if(value > parent.val)
        //    {
        //        parent.rightChild = remove(parent.rightChild, value);
        //    }
        //    else
        //    {
        //        if (parent.leftChild == null)
        //            return parent.rightChild;
        //        else if (parent.rightChild == null)
        //            return parent.leftChild;

        //            parent.val = findMax(parent.rightChild);

        //        parent.rightChild = remove(parent.rightChild, value);
        //       
        //    }
        // return parent;
        //}
        public int findMax(TreeNode node)
        {
            while (node.leftChild != null)
            {
                node = node.leftChild;
            }
            return node.val;
        }
        public TreeNode remove(TreeNode parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.val)
                parent.leftChild = remove(parent.leftChild, key);
            else if (key > parent.val)
                parent.rightChild = remove(parent.rightChild, key);

            // if value is same as parent's value, then this is the TreeNode to be deleted  
            else
            {
                // TreeNode with only one child or no child  
                if (parent.leftChild == null)
                    return parent.rightChild;
                else if (parent.rightChild == null)
                    return parent.leftChild;

                // TreeNode with two children: Get the inorder successor (smallest in the rightChild subtree)  
                parent.val = findMax(parent.rightChild);

                // Delete the inorder successor  
                parent.rightChild = remove(parent.rightChild, parent.val);
            }

            return parent;
        }

        //private int MinValue(TreeNode TreeNode)
        //{
        //    int minv = TreeNode.val;

        //    while (TreeNode.leftChild != null)
        //    {
        //        minv = TreeNode.leftChild.val;
        //        TreeNode = TreeNode.leftChild;
        //    }

        //    return minv;
        //}

        static void Main(string[] args)
        {
            Program binaryTree = new Program();

            binaryTree.Add(12);
            binaryTree.Add(11);
            binaryTree.Add(14);
            binaryTree.Add(20);
            binaryTree.Add(15);
            binaryTree.Add(6);
            binaryTree.Add(8);
            binaryTree.Add(17);
            binaryTree.Add(5);

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.root);
            Console.WriteLine();
            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.root);
            Console.WriteLine();
            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.root);
            Console.WriteLine();
           int depthData =  binaryTree.GetTreeDepth(binaryTree.root);
            Console.WriteLine("The height of tree is : "+depthData);
            bool data = binaryTree.search(binaryTree.root, 20);
            Console.WriteLine(data== true?"The data is present " :"Not present");
           binaryTree.remove(binaryTree.root, 12);
            Console.Write("The list after deletion :");
            binaryTree.TraverseInOrder(binaryTree.root);
            //        //Console.ReadLine();
        }
    }
        }
