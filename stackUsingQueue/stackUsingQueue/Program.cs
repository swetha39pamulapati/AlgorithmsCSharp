using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace stackUsingQueue
{
    class Program
    {
        public class MyStack
        {
            Queue<int> queue1 = new Queue<int>();
            public void Push(int x)
            {

                var queue2 = new Queue<int>();
                queue2.Enqueue(x);

                while (queue1.Any())
                {
                    queue2.Enqueue(queue1.Dequeue());
                }
                queue1 = queue2;
            }
            public int Pop()
            {
                if (queue1.Count == 0)
                    return -1;

                return queue1.Dequeue();
            }
            public int TopPeek()
            {
                if (queue1.Count == 0)
                    return -1;
                return queue1.Peek();
            }
            public bool Empty()
            {
                if (queue1.Count == 0)
                    return true;
                return false;
            }
           
       
        static void Main(string[] args)
        {
            MyStack p = new MyStack();
            p.Push(5);
            p.Push(6);
            p.Push(7);
            p.Pop();
            p.Push(8);
            p.Pop();
            Console.WriteLine( p.Empty());
            int data =  p.TopPeek();
            Console.WriteLine(data);
        }
        }
    }
}
