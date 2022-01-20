using System;

namespace JaggedArrays
{
    class Program
    {
        public static void JaggedArray()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[1];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[4];
            Console.WriteLine("Enter the numbers for jagged array");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string st = Console.ReadLine();
                    jaggedArray[i][j] = int.Parse(st);
                }

            }
            Console.WriteLine("");
            Console.WriteLine("Printing the elements:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]);
                    Console.Write("\0");

                }
                Console.WriteLine("");
            }
        }
        public static void Main(string[] Args)
        {
            JaggedArray();
            Console.Read();
        }
    }

}
