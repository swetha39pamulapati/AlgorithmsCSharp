using System;
using System.Collections.Generic;

namespace merge2sortedLists
{
    class Program
    {
       
        public class Node
        {
            public int Value;
            public Node next;
            public Node(int value)
            {
                Value = value;
                next = null;
            }
        }
            public static Node MergeTwoLists(Node l1, Node l2)
            {
                if (l1 == null) return l2;
                if (l2 == null) return l1;

                Node result;

                if (l1.Value < l2.Value)
                {
                    result = l1;
                    result.next = MergeTwoLists(l1.next, l2);
                }
                else
                {
                    result = l2;
                    result.next = MergeTwoLists(l1, l2.next);
                }
                return result;
            }
            public Node push(Node head_ref, int new_data)
            {
                Node new_node = new Node(new_data);
                new_node.Value = new_data;
                new_node.next = (head_ref);
                (head_ref) = new_node;
                return head_ref;
            }
        static void printList(Node node)
        {
            while (node != null)
            {
                Console.Write("{0} ", node.Value);
                node = node.next;
            }
        }
    
     
        static void Main(string[] args)
        {
            Node head1 = new Node(1);
            head1.next = new Node(2);
            head1.next.next = new Node(4);
            Node head2 = new Node(1);
            head2.next = new Node(3);
            head2.next.next = new Node(4);
            Node mergedhead = MergeTwoLists(head1, head2);
            printList(mergedhead);
        }
    }
}
