using System;

namespace palindromrecursion
{
    class Program
    {
        public static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }

        //number-Palindrome


        //static int rev(int n,
        //       int temp)
        //{
        //    // base case
        //    if (n == 0)
        //        return temp;

        //    // stores the reverse
        //    // of a number
        //    temp = (temp * 10) +
        //               (n % 10);

        //    return rev(n / 10, temp);
        //}

        static void Main(string[] args)
        {
            Console.Write("\n\n Recursion: \n");
            string str1;
            bool tf;
            Console.Write(" Input a string : ");
            str1 = Console.ReadLine();
            tf = IsPalindrome(str1);
            if (tf == true)
            {
                Console.WriteLine(" The string is Palindrome.\n");
            }
            else
            {
                Console.WriteLine(" The string is not a Palindrome.\n");
            }

            //number-Palindrome


            //Console.Write("Enter the number :");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write(" Input a string : ");
            ////str1 = Console.ReadLine();
            //int temp = rev(n, 0);

            //if (temp == n)
            //    Console.WriteLine("Number is palindrome");
            //else
            //    Console.WriteLine("Number is not palindrome");
        }
    }
}
