using System;

namespace stackUsingLinkedList
{
    class Program
    {
        public class Node
        {
            public int value;
            public Node next;
       
        public Node(int x)
        {
            value = x; next = null;

        }
        }
        public class StackLinkedList
        {
            Node top;
            public StackLinkedList()
            {
                top = null;
            }
            public void push(int data)
            {
                Node newNode = new Node(data);
                if (top == null)
                    newNode.next = null;
                else
                {
                    newNode.next = top;
                    
                }
                top = newNode;
                Console.Write("{0} is pushed to stack" + data);
            }
            public void pop()
            {
                if (top == null)
                    Console.WriteLine("Deletion not possible");
                else
                {
                    Console.WriteLine("The deleted element is " + top.value);
                    top = top.next;
                }
            }
            public void peek()
            {
                if (top == null)
                    Console.WriteLine("Deletion not possible");
                else
                {
                    Console.WriteLine("The deleted element is " + top.value);
                }
            }
            public void display()
            {
                if(top == null)
                    Console.WriteLine("stack is empty");
                else
                {
                    while(top!= null)
                    {
                        Console.Write(top.value);
                        top = top.next;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            StackLinkedList data = new StackLinkedList();
            data.push(10);
            data.push(20);
            data.push(30);
            data.push(40);
            data.display();
            data.pop();
            data.peek();
            Console.WriteLine("Hello World!");
        }
    }
}
