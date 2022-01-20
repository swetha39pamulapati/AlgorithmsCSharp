using System;

namespace ReverseBits
{
    class Program
    {
		public static uint reverseBits(uint n)
		{
			uint result = 0;

			for (int i = 0; i < 32; i++)
			{
				// 1. shift result to left
				result <<= 1;

				// 2. update result's last digit to n's last digit
				result = result | (n & 1);

				// 3. shift n to right
				n >>= 1;
			}

			return result;
		}
		static void Main(string[] args)
        {
			uint data = reverseBits();

			Console.WriteLine(data);
        }
    }
}
