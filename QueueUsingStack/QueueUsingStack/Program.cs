using System;

namespace QueueUsingStack
{
    class Program
    {
        public class createStack
        {
            private int[] stack1, stack2;
            private int Max;
            private int top1;
            private int top2;
            int count;
            public createStack()
            {
                Max = 5;
                stack1 = new int[Max];
                stack2 = new int[Max];
                top1 = -1;
                top2 = -1;
                count = 0;
            }
            public void enqueue(int data)
            {
                push1(data);
                count++;
            }
            public void dequeue()
            {
                if(top1== -1 && top2 ==-1)
                {
                    Console.WriteLine("Stack is empty");
                }
                else
                {
                    for(int i =0; i<count; i++)
                    {
                        int x = pop1();
                        push2(x);
                    }
                    int y = pop2();
                    Console.WriteLine("The dequeued element is:" + y);
                    count--;
                    for(int i=0;i<count; i++)
                    {
                        int z = pop2();
                        push1(z);
                    }
                }
            }
           public void display()
            {
                for (int i = 0; i <= top1; i++)
                {
                    Console.WriteLine( stack1[i] + " ");
                }
            }
            public void peek()
            {
                if (top1 == -1 && top2 == -1)
                {
                    Console.WriteLine("Stack is empty");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        int x = pop1();
                        push2(x);
                    }
                    int y = top2;
                    Console.WriteLine("The top element is :" + y);
                    for (int i = 0; i < count; i++)
                    {
                        int z = pop2();
                        push1(z);
                    }
                }
            }
            public int pop2()
            {
                if (top2 == -1)
                {
                    Console.WriteLine("Stack is empty");
                    return 0;
                }
                else
                {
                    int pop = stack2[top2];
                    top2--;
                    return pop;
                }
            }
            public void push2(int x)
            {
                if (top2 == Max - 1)
                {
                    Console.WriteLine("Stack is full");
                }
                else
                {
                    stack2[++top2] = x;
                }
            }
            public int pop1()
            {
                if(top1== -1)
                {
                    Console.WriteLine("Stack is empty");
                    return 0;
                }
                else
                {
                    int a = stack1[top1];
                    top1--;
                    return a; 
                }
            }
           public void push1(int x)
            {
                if(top1 == Max - 1)
                {
                    Console.WriteLine("Stack is full");
                }
                else
                {
                    stack1[++top1] = x;
                }
            }
        }
        static void Main(string[] args)
        {
            createStack stack = new createStack();
            stack.enqueue(5);
            stack.enqueue(4);
            stack.enqueue(3);
            stack.enqueue(2);
            stack.enqueue(1);
            stack.display();
            stack.dequeue();
            stack.display();
            stack.peek();
            stack.display();
        }
    }
}
