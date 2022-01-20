using System;

namespace _141LinkedListCycle
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
        public static bool HasCycle(Node head)
        {
            var slow = head;
            var fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast) return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            Node head1 = new Node(3);
            head1.next = new Node(2);
            head1.next.next = new Node(0);
            head1.next.next.next = new Node(-4);
            head1.next.next.next.next = head1; //postion to make the linked list cycle;
            bool data = HasCycle(head1);
            Console.WriteLine(data);
        }
    }
}
