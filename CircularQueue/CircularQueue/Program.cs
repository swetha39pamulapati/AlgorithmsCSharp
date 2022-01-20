using System;

namespace CircularQueue
{
    class Program
    {
        // Structure of a Node  
        public class Node
        {
            public int data;
            public Node link;
        }

        public class LinkedList
        {
            public Node front, rear;
        }

        // Function to create Circular queue  
        public static void enQueue(LinkedList q,
                                   int value)
        {
            Node temp = new Node();
            temp.data = value;
            if (q.front == null)
            {
                q.front = temp;
            }
            else
            {
                q.rear.link = temp;
            }

            q.rear = temp;
            q.rear.link = q.front;
        }
        // Function to delete element from 
        // Circular Queue  
        public static int deQueue(LinkedList q)
        {
            if (q.front == null)
            {
                Console.WriteLine("Queue is empty");
                return int.MinValue;
            }

            // If this is the last node to be deleted  
            int value; // Value to be dequeued 
            if (q.front == q.rear)
            {
                value = q.front.data;
                q.front = null;
                q.rear = null;
            }
            else // There are more than one nodes 
            {
                Node temp = q.front;
                value = temp.data;
                q.front = q.front.link;
                q.rear.link = q.front;
            }

            return value;
        }
        // Function displaying the elements  
        // of Circular Queue  
        public static void displayQueue(LinkedList q)
        {
            Node temp = q.front;
            Console.WriteLine("Elements in Circular Queue are: "); 
            while (temp.link != q.front)
            {
                Console.WriteLine("{0:D} ", temp.data);
                temp = temp.link;
            }
            Console.WriteLine("{0:D}", temp.data);
        }
        static void Main(string[] args)
        {
            LinkedList q = new LinkedList();
            q.front = q.rear = null;
            enQueue(q, 14);
            enQueue(q, 22);
            enQueue(q, 6);

            displayQueue(q);
            deQueue(q);
            displayQueue(q);
            // Deleting elements from Circular Queue  

            deQueue(q);
            

            // Remaining elements in Circular Queue  
            displayQueue(q);

            enQueue(q, 9);
            enQueue(q, 20);
            displayQueue(q);
        }
    }
}
