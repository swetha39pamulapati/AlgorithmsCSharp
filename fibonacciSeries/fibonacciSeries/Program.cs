using System;

namespace fibonacciSeries
{
    class Program
    {
        public static int FibonacciSeries(int n)
        {
            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
        static void Main(string[] args)
        {
            //Fibonacci series
            //int n1 = 0, n2 = 1, n3, i, number;
            //Console.Write("enter the number of elements :");
            //number = int.Parse(Console.ReadLine());
            //Console.Write(n1 +" " + n2 + " ");
            //for (i = 2; i < number; i++)
            //{
            //    n3 = n2 + n1;
            //    Console.Write(n3 + " ");
            //    n1 = n2;
            //    n2 = n3;
            //}


            //using recursion
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciSeries(i));
            }
            Console.ReadKey();
           

        }
    }
}
