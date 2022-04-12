using System;

namespace circularQueueLinkedList
{
    class Program
    {
       public class Node
        {
            public int value;
            public Node next;
            public Node(int val)
            {
                value = val;next = null;
            }
        }
        public class LinkedList
        {
            public Node front ,rear;
            public LinkedList()
            {
                front = null; rear = null;
            }

       
        public void enqueue(int x)
        {
            Node newNode = new Node(x);
            if(rear == null)
                {
                    front = rear = newNode;
                    rear.next = front;
                }
                else
                {
                    rear.next = newNode;
                    rear = newNode;
                    rear.next = front;
                }


        }
            public void dequeue()
            {
                Node temp = front;
                if (front == null && rear == null)
                    Console.WriteLine("Queue is empty");
                else if (front == rear)
                {
                    front = rear = null;
                    temp = null;
                }
                else
                {
                    front = front.next;
                    rear.next = front;
                    temp = null;
                }
            }
            public void peek()
            {
                if (front == null && rear == null)
                    Console.WriteLine("Queue is empty");
                else
                {
                    Console.WriteLine("The top value is " +front.value);
                }
            }
            public void display()
            {
                Node temp = front;
                if(front== null && rear== null)
                {
                    Console.WriteLine("The List is empty");
                }
                else
                {
                    while(temp.next != front)
                    {
                        Console.WriteLine(temp.value);
                        temp = temp.next;
                    }
                    Console.WriteLine("{0:D}", temp.value);

                }
            }
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.enqueue(10);
            list.enqueue(11);
            list.enqueue(12);
            list.display();
            list.dequeue();
            list.display();
            list.peek();
        }
    }
}
