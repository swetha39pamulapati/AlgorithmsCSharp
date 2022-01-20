using System;

namespace _876middleNodeLinkedList
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
        public static Node MiddleNode(Node head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                
            }

            return slow;
        }
        static void Main(string[] args)
        {
            Node head1 = new Node(3);
            head1.next = new Node(2);
            head1.next.next = new Node(0);
           // head1.next.next.next = new Node(-4);
            Node data = MiddleNode(head1);
            Console.WriteLine($"The middle value of node is :" +data.Value);
        }
    }
}
