using System;

namespace CircularQueueusingArray
{
    class Program
    {
        class createQueueArray
        {
            private int Max;
            private int front;
            private int rear;
            private int[] queue;
            public createQueueArray()
            {
                Max = 5;
                queue = new int[Max];
                front = -1;rear = -1;
            }
            public void enqueue(int data)
            {
                if(front ==-1&& rear== -1)
                {
                    front = rear = 0;
                    queue[rear] = data;
                }
                else if(((rear+1)%Max) == front)
                {
                    Console.WriteLine("queue is full");
                    return;
                }
                else
                {
                    rear = (rear + 1) % Max; //As the queue has to be circular, we will check this condition instead of incrementing.
                    queue[rear] = data;
                }
            }
            public void dequeue()
            {
                if (front == -1 && rear == -1)
                {
                    Console.WriteLine("The queue is empty");
                }
                else if (front == rear)
                { //only 1 element in the queue
                    front = rear = -1; //To make queue empty;
                }
                else
                {
                   // Console.WriteLine(queue[front]);
                    front = (front+1)% Max;
                }
            }
            public void peek()
            {
                if (front == -1 && rear == -1)
                {
                    Console.WriteLine("The queue is empty");
                }
                else
                {
                    Console.WriteLine("The top value is :"+queue[front]);
                }
            }
            public void display()
            {
                
                if(front==-1 && rear == -1)
                {
                    Console.WriteLine("The queue is empty");
                }
                else
                {
                    //while(i != rear+1)
                    //{
                    //    Console.WriteLine(queue[i]);
                    //    i= (i+1)% Max;
                    //}
                    for (int i = 0; i < queue.Length; i++)

                    {

                        Console.WriteLine(queue[i]);

                    }

                }
            }
        }
        static void Main(string[] args)
        {
            createQueueArray arr = new createQueueArray();
            arr.enqueue(5);
            arr.enqueue(4);
            arr.enqueue(3);
            arr.enqueue(2);
            arr.enqueue(1);
            arr.display();
            arr.dequeue();
            arr.peek();
            arr.dequeue();
            arr.peek();
            //Console.WriteLine("data removed");
            //arr.enqueue(9);
            //arr.display();

            //Console.WriteLine("Hello World!");
        }
    }
}
