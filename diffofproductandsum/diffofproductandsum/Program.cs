using System;

namespace diffofproductandsum
{
    class Program
    {
        public static int sumandproduct(int n)
        {
            int sum = 0, product = 1;
            while (n > 0)
            {
                sum += n % 10;
                product *= n % 10;
                n /= 10;
            }
            return  product - sum;
        }
        static void Main(string[] args)
        {
            var data = sumandproduct(146);
            Console.WriteLine($"The difference of sum and product is : {data}" );
        }
    }
}
