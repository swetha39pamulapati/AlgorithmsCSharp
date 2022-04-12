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
                    newNode.next = top;
                top = newNode;
            }
            public void pop()
            {
                Node temp = top;
                if (top == null)
                    Console.WriteLine("Deletion not possible");
                else
                {
                    Console.WriteLine("The deleted element is " + top.value);
                    top = top.next;
                    temp = null;
                }
            }
            public void peek()
            {
                if (top == null)
                    Console.WriteLine("stack is empty");
                else
                {
                    Console.WriteLine("The top element is " + top.value);
                }
            }
            public void display()
            {
                if (top == null)
                {
                    Console.Write("\nStack Underflow");
                    return;
                }
                else
                {
                    Node temp = top;
                    while (temp != null)
                    {

                        Console.WriteLine(temp.value);

                        temp = temp.next;
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
            data.display();
            data.peek();
        }
    }
}
