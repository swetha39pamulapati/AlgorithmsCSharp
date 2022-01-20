using System;

namespace _83RemoveDuplSortedList
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
        public static Node DeleteDuplicates(Node head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var start = head;
            while (start.next != null)
            {
                if (start.Value == start.next.Value)
                {
                    start.next = start.next.next;
                }
                else
                {
                    start = start.next;
                }
            }

            return head;
        }
        static void Main(string[] args)
        {
            Node head1 = new Node(1);
            head1.next = new Node(1);
            head1.next.next = new Node(2);
            //head1.next.next.next = new Node(-4);
            Node data = DeleteDuplicates(head1);
            //foreach(Node i in data)
            //{
                Console.WriteLine(data.Value);
            //}
            
        }
    }
}
