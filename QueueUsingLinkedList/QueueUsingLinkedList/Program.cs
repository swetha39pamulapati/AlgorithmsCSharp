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
                if (this.rear == null)
                {
                    this.front = this.rear = newNode;
                }
                else
                {
                    // Add the new node at the end of queue and change rear  
                    this.rear.next = newNode;
                    this.rear = newNode;
                }
                Console.WriteLine("{0} inserted into Queue", item);
            }
            public void display()
            {
                Node temp = this.front;
                if (this.front == null && this.rear == null)
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                else
                {
                    while (this.front != null)
                    {
                        Console.WriteLine("\n" +this.front.data);
                        this.front = this.front.next;
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
                if (this.front == null)
                {
                    Console.WriteLine("The Queue is empty");
                    return;
                }

                // Store previous front and move front one node ahead  
                Node temp = this.front;
                this.front = this.front.next;

                // If front becomes NULL, then change rear also as NULL  
                if (this.front == null)
                {
                    this.rear = null;
                }

                Console.WriteLine("Item deleted is {0}", temp.data);
            }
        }
        
        static void Main(string[] args)
        {
            LinkListQueue queue = new LinkListQueue();
            queue.Enqueue(10);
            queue.Enqueue(40);
            queue.Enqueue(60);
            queue.Dequeue();
            queue.peek();
            queue.display();
        }
    }
}
