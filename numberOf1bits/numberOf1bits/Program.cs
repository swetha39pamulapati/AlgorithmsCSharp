using System;

namespace numberOf1bits
{
    class Program
    {
        static int countSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
        static void Main(string[] args)

        {
            //int result = HammingWeight(11);

            //Console.WriteLine(result);
            int i = 11;
            Console.Write(countSetBits(i));
        }
    }
}
