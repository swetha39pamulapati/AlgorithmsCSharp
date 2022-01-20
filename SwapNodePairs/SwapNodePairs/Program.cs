using System;

namespace SwapNodePairs
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
		public Node SwapPairs(Node head)
		{
			if (head == null || head.next == null)
				return head;

			var res = head.next;
			Node parent = null;
			while (head != null)
			{
				SwapNodes(ref parent, ref head);
				head = head.next;
			}
			return res;
		}

		private void SwapNodes(ref Node parent, ref Node node)
		{
			var nextNode = node.next;
			if (nextNode == null)
				return;

			if (parent != null)
				parent.next = nextNode;
			node.next = nextNode.next;
			nextNode.next = node;
			parent = node;
		}
		static void Main(string[] args)
		{
			Program p = new Program();
			Node head1 = new Node(1);
			head1.next = new Node(2);
			head1.next.next = new Node(3);
			head1.next.next.next = new Node(4);
			Node swapPairs = p.SwapPairs(head1);
			while (swapPairs != null)
			{
				Console.Write(swapPairs.Value);
				swapPairs = swapPairs.next;
			}
			//Console.WriteLine(swapPairs);
		}

	}
}
