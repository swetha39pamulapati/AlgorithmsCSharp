using System;

namespace ClimbingSteps
{
    class Program
    {
        public static int climbingSteps(int n)
        {
           
            // For 3 steps (If order matters):-
            // There are three ways to climb to the top.
                //1. 1 step + 1 step + 1 step
                //2. 1 step + 2 steps
                //3. 2 steps + 1 step
                    // If order doesn't matter ,means : (1 step+ 2 steps) and (2steps +1 step) are same;
            Console.WriteLine("Number of ways when order of steps " +
                     "does not matter is : " + (1 + (n / 2)));
            if (n < 0) { 
                return 0;
            }
            else if (n == 1) { 
                return 1;
            }
            else
            {
                int a = 0, b = 1, c = 0;
                for(int i = 0;i<n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return c;
            }
            
        }
        static void Main(string[] args)
        {
            int result = climbingSteps(3);
            
            Console.WriteLine(result);
        }
    }
}
