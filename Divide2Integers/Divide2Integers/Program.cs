using System;

namespace Divide2Integers
{
    class Program
    {
        public static int divide2Integers(int dividend, int divisor)
        {
            // Calculate sign of divisor i.e.,
            // sign will be negative only iff
            // either one of them is negative
            // otherwise it will be positive
            int sign = ((dividend < 0) ^
                  (divisor < 0)) ? -1 : 1;

            // Update both divisor and
            // dividend positive
            dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);

            // Initialize the quotient
            int quotient = 0;

            while (dividend >= divisor)
            {
                dividend -= divisor;
                ++quotient;
            }

            //if the sign value computed earlier is -1 then negate the value of quotient
            if (sign == -1) quotient = -quotient;
            return quotient;
        }
        static void Main(string[] args)
        {
            int a = -10;
            int b = -3;
            Console.WriteLine(divide2Integers(a, b));

            a = 7;
            b = -3;
            Console.WriteLine(divide2Integers(a, b));
            a = 0;
            b = 1;
            Console.WriteLine(divide2Integers(a, b));
            a = 1;
            b = 1;
            Console.WriteLine(divide2Integers(a, b));
        }
    }
}
