using System;

namespace _234PalindromicLinkedList
{
    class Program
    {
     //o(n) and o(1)
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
        public static bool IsPalindrome(Node head)
        {
            var fast = head;
            var slow = head;
            int midCount = 1;
            //find Middle(slow)
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                midCount++;

            }
            if (midCount == 1)
                return true;
            //reverse second half
            var prev = slow;
            var curr = slow.next;
            while (curr != null)
            {
                var next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            //check Palindrome
            var right = prev;
            var left = head;
            for (int i = 1; i < midCount; i++)
            {
                if (left.Value != right.Value)
                    return false;

                left = left.next;
                right = right.next;
            }
            return true;
        }
            static void Main(string[] args)
        {
            Node head1 = new Node(1);
            head1.next = new Node(2);
            head1.next.next = new Node(2);
            head1.next.next.next = new Node(1);
            bool data = IsPalindrome(head1);
            Console.WriteLine(data);
        }
    }
}
