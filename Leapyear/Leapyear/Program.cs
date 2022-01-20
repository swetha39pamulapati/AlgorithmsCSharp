using System;

namespace Leapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the year to find out whether it is leap year or not:");
            //int n;
            //n = int.Parse(Console.ReadLine());

            //if(n%4 == 0)
            //    Console.WriteLine("Leap year");

            //else
            //    Console.WriteLine(" Not A Leap year");


            Console.Write("Enter a number");
            int n1, n2, n3;
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number");
            n2 = int.Parse(Console.ReadLine());
            n3 = n1 + n2;
            Console.WriteLine($"the sum of two numbers: {n3}");
        }
    }
}
