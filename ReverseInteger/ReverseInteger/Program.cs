using System;

namespace ReverseInteger
{
    class Program
    {
        public static int reverse(int x)
        {
                int result = 0;
                while (x != 0)
                {

                    var val = x % 10;
                    var temp = result * 10 + val;
                    if ((temp - val) / 10 != result) 
                        return 0;
                    result = temp;
                    x = x / 10;
                }
                return result;
            
        }
        static void Main(string[] args)
        {
            int result = reverse(1054);
            Console.WriteLine("The reversal of given number is:" +result);
        }
    }
}
