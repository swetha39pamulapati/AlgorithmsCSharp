using System;

namespace stackOperationsLinkedList
{
    public class Program
    {
        private class Node
        {
            public int data;

            public Node next;
            public Node(int x)
            {
                data = x; next = null;
            }
        }
        Node top;
        public Program()
        {
            this.top = null;
        }
        public void push(int x)
        {
            // create new node temp and allocate memory
            Node newNode = new Node(x);
            newNode.next = top;
            top = newNode;
        }
        public void peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");

            }
            else
            {
                Console.WriteLine("The top element is : " + top.data);
            }
        }
        public void pop()
        {
            Node temp = top;
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("The data deleted is" + top.data);
                top = top.next;
                temp = null;
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

                    Console.WriteLine(temp.data);

                    temp = temp.next;
                }
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.push(10);
            obj.push(20);
            obj.push(30);
            obj.push(40);
            obj.display();
            obj.pop();
            obj.display();
            obj.peek();
        }
    }
}
