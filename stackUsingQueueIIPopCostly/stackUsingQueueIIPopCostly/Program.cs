using System;
using System.Collections;
class GfG
{
	public class Stack
	{
		public Queue q1 = new Queue();
		
		public void Push(int x) { 
			q1.Enqueue(x); 
		}
		public int Pop()
		{
			var q2 = new Queue();
			if (q1.Count == 0)
				return -1;
			while (q1.Count != 1)
			{ 
				q2.Enqueue(q1.Dequeue());
			}
			int res = (int)q1.Dequeue();
			q1 = q2;
			return res;
		}

		public int Size() 
		{
			return q1.Count;
		}

		public int Top()
		{
			var q2 = new Queue();
			if (q1.Count == 0)
				return -1;
			while (q1.Count != 1)
			{
				q2.Enqueue(q1.Dequeue());
			}
			int res = (int)q1.Dequeue();
			q2.Enqueue(res);
			q1 = q2;
			return res;
		}
	};
	public static void Main(String[] args)
	{
		Stack s = new Stack();
		s.Push(5);
		s.Push(6);
		s.Push(7);
		s.Pop();
		s.Push(8);
		s.Pop();
		Console.WriteLine("Size of Stack: " + s.Size() + "\tTop : " + s.Top());
	}
}
