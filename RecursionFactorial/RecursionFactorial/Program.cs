using System;

namespace RecursionFactorial
{
    //class Program
    //{
    //    public static int iterativeFactorial(int n)
    //    {
    //        if (n == 0)
    //            return 1;
    //        int factorial = 1;
    //        for( int i =1; i <= n; i++) {
    //            factorial *= i;

    //        }

    //        return factorial;
            
    //    }
    //    static void Main(string[] args)
    //    {
    //        int x = 6;
    //      int factorial =   iterativeFactorial(x);
           
    //        Console.Write("Factorial of " + x + " is: " + factorial);
    
    //    }
    //}
    class program
    {
        static int recursiveFactorial (int n)
        {
            if (n == 0)
                return 1;
            return n * recursiveFactorial(n - 1);
        }
        public static void Main()
        {
            int x = 6;
            int factorial = recursiveFactorial(x);

            Console.Write("Factorial of " + x + " is: " + factorial);
           
        }
    }
}
