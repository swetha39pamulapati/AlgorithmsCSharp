using System;

namespace QueueUsingLinkedList
{
    class Program
    {
        internal class Node
        {
            internal int data;
            internal Node next;

            // Constructor to create a new node.Next is by default initialized as null  
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        internal class LinkListQueue
        {
            Node front;
            Node rear;

            public LinkListQueue()
            {
                this.front = this.rear = null;
            }
            internal void Enqueue(int item)
            {
                Node newNode = new Node(item);

                // If queue is empty, then new node is front and rear both  
                if (this.rear == null && this.front == null)
                {
                    this.front = this.rear = newNode;
                }
                else
                {
                    // Add the new node at the end of queue and change rear  
                    this.rear.next = newNode;
                    this.rear = newNode;
                    Console.WriteLine("{0} inserted into Queue", item);
                }
               
            }
            public void display()
            {
               
                if (this.front == null && this.rear == null)
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                else
                {
                    Node temp = this.front;
                    while (temp != null)
                    {
                        Console.WriteLine("\n" + temp.data);
                        temp = temp.next;
                    }

                }
            }
            public void peek()
            {
                Node temp = this.front;
                if (this.front == null && this.rear == null)
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                else
                {
                    Console.Write("The top element is " + this.front.data);
                }
            }
            internal void Dequeue()
            {
                // If queue is empty, return NULL.  
                if (this.front == null && this.rear == null)
                {
                    Console.WriteLine("The Queue is empty");
                    return;
                }
                else
                {
                    // Store previous front and move front one node ahead  
                    Node temp = this.front;
                    this.front = this.front.next;
                    Console.WriteLine("Item deleted is {0}", temp.data);
                    temp = null;
                }
            }
        }
        
        static void Main(string[] args)
        {
            LinkListQueue queue = new LinkListQueue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.display();
            queue.Dequeue();
            queue.peek();
        }
    }
}
