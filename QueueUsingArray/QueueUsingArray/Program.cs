using System;

namespace QueueUsingArray
{
    class Program
    {
        class CreateQueue
        {
            private int MAX = 10;
            private int front;
            private int rear;
            private int[] queue;

            public CreateQueue()
            {
                //assigning MAX size of the queue
                queue = new int[MAX];
                front = -1;
                rear = -1;
            }

            // create a method to check whether 
            // the queue is empty or not  
            public void isEmpty()
            {
                if (rear == -1 && front == -1)
                {
                    Console.WriteLine("Queue is empty.");
                }
                else
                {
                    Console.WriteLine("Queue is not empty.");
                }
            }

            //create a method to return size of the queue 
            public int size()
            {
                return (rear - front)+1;
            }
            //create a method to add new element       
            public void EnQueue(int x)
            {
                if (rear == (MAX - 1))
                {
                    Console.WriteLine("Queue size limit reached.");
                }
                else if(front==-1 && rear == -1)
                {
                    front = rear = 0;
                    queue[rear] = x;
                    Console.WriteLine(x + " is added into the queue.");
                }
                else
                {
                    queue[++rear] = x;
                    Console.WriteLine(x + " is added into the queue.");
                }
            }

            //create a method to delete front element       
            public void DeQueue()
            {
                if (rear == -1 && front == -1)
                {
                    Console.WriteLine("Queue is empty.");
                }
                else if(rear == front)
                {
                    front = rear = -1;

                }
                else
                {
                    int x = queue[front];
                    Console.WriteLine(x + " is deleted from the queue.");
                    front++;
                }
            }

            //create a method to get rear element       
            public int rearElement()
            {
                if (rear == front)
                {
                    Console.WriteLine("Queue is empty.");
                    return 0;
                }
                else
                {
                    return queue[rear];
                }
            }
            public void display()
            {
                if (rear == -1 && front == -1)
                {
                    Console.WriteLine("queue is empty");
                }
                else
                {
                    for(int i = front; i<=rear; i++)
                    {
                        Console.WriteLine(queue[i]);
                    }
}
            }
            //create a method to get front element -Peek   
            public int frontElement()
            {
                if (rear == front)
                {
                    Console.WriteLine("Queue is empty.");
                    return 0;
                }
                else
                {
                    return queue[front];
                }
            }
        }
        static void Main(string[] args)
        {
            CreateQueue MyQueue = new CreateQueue();
            MyQueue.EnQueue(10);
            MyQueue.EnQueue(20);
            MyQueue.EnQueue(30);
            MyQueue.EnQueue(40);
            MyQueue.display();
            Console.WriteLine("data removed");
            MyQueue.DeQueue();
            MyQueue.display();
            MyQueue.isEmpty();
            int result = MyQueue.frontElement();
            Console.WriteLine($"The topElement is : {result}");
            int result1 = MyQueue.rearElement();
            Console.WriteLine($"The lastElement is : {result1}");
           int variable = MyQueue.size();
            Console.WriteLine($"The size is : {variable}");
        }
    }
    }

