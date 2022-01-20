using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {


            int n, sum = 0, r, temp;
            Console.Write("Enter the number :");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Number is palindrome");
            else
                Console.WriteLine("Number is not palindrome");

            //string palindrome


            //string ipstring, opstring = string.Empty;
            //Console.Write("Enter a string :");
            //ipstring = Console.ReadLine();
            //if(ipstring != null)
            //{
            //    for(int i = ipstring.Length-1; i >= 0; i--)
            //    {
            //        opstring += ipstring[i].ToString();

            //    }
            //    if (opstring == ipstring)
            //    {
            //        //Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", ipstring, opstring); }
            //        Console.WriteLine("string is palindrome");
            //    }
            //    else
            //    {
            //        Console.WriteLine("string is not palindrome");
            //        //Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", ipstring, opstring);
            //    }


            //}
            //Console.ReadLine();
        }
        }
    }

