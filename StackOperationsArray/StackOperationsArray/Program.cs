using System;

namespace StackOperationsArray
{
    class Program
    {
        public class CreateStack { 
        private int MAX = 100;
        private int top;
        private int[] stack;

        public CreateStack()
        {
            //assigning MAX size of the stack
            stack = new int[MAX];
            top = -1;
        }

        // create a method to check whether 
        // the stack is empty or not  
        public void isEmpty()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine("Stack is not empty.");
            }
        }
            public void display()
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }

            //create a method to return size of the stack 
            public int size()
        {
            return top + 1;
        }

            //create a method to add new element  
            public void push(int x)
        {
            if (top == (MAX - 1))
            {
                Console.WriteLine("Stack size limit reached.");
            }
            else
            {
                stack[++top] = x;
                Console.WriteLine(x + " is added into the stack.");
            }
        }

        //create a method to delete top element       
        public void pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                int x = stack[top--];
                Console.WriteLine(x + " is deleted from the stack.");
            }
        }

        //create a method to get top element       
        public int peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty.");
                return 0;
            }
            else
            {
                    //Console.WriteLine("Stack not empty.");
                    return stack[top];
            }
        }


        static void Main(string[] args)
        {
                CreateStack MyStack = new CreateStack();
                MyStack.push(10);
                MyStack.push(20);
                MyStack.push(30);
                MyStack.push(40);
                MyStack.display();
                MyStack.pop();
                MyStack.isEmpty();
              int result =  MyStack.peek();
                Console.WriteLine($"The topElement is : {result}");
            }
    }
    }
}
