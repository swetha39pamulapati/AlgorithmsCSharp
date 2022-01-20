using System;

namespace computeParity
{
    class Program
    {
        public static int[] computeParity(int num)
        {
            int[] counts = new int[num + 1];
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i / 2] + (i % 2);
            }
            return counts;
        }
        static void Main(string[] args)

        {
            var data = computeParity(5);
            Console.Write( "[");
            foreach (int i in data)
            {
                
                Console.Write(i +",");
            }
            Console.Write("]");
        }
    }
}
