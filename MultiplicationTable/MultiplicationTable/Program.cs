using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiplicationTable
{
    class Program
    {
        private static long FactCalc(int n1)
        {
            if (n1 == 0)
            {
                return 1;
            }
            return n1 * FactCalc(n1 - 1);
        }



        static void Main(string[] args)
        {

            //Multiplication

            //Console.Write("Enter a number :");
            //int x;
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.Write("{0} X {1} = {2} \n", n, i,  n * i);
            //}




            //even or odd

            //Console.Write("Enter a number :");
            //int n = int.Parse(Console.ReadLine());
            //if (n % 2 == 0)
            //    Console.Write("Even number ");
            //else
            //    Console.Write("odd number ");

            //greeting
            //Console.Write("Enter your name :");
            //string n = Console.ReadLine();
            //Console.Write($"Hi {n}");

            //operations
            //Console.Write("Enter a number");
            //int n1, n2, n3,n4,n5,n6;
            //n1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter a number");
            //n2 = int.Parse(Console.ReadLine());
            //n3 = n1 + n2;
            //n4 = n1 - n2;
            //n5 = n1/n2;
            //n6 = n1*n2;
            //Console.WriteLine($"the sum of two numbers: {n3}");
            //Console.WriteLine($"the subtraction of two numbers: {n4}");
            //Console.WriteLine($"the multiplication of two numbers: {n6}");
            //Console.WriteLine($"the division of two numbers: {n5}");


            //print largest
            //Console.Write("Enter a number");
            //int n1, n2;
            //n1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter a number");
            //n2 = int.Parse(Console.ReadLine());
            //if (n1 > n2)
            //    Console.Write($"The largest number is {n1}");
            //else
            //    Console.Write($"The largest number is {n2}");

            //convert currency to dollars.
            //double inr, usd;
            //Console.Write("Enter indian currency :");
            // inr = Convert.ToDouble(Console.ReadLine());
            //usd = Convert.ToDouble(inr/75);
            //Console.Write($"The USD of {inr} rupee is ${usd}");


            //keep taking numbers as  input till user enters 0, after that print the average of all
            //int n, sum = 0, counter = 0, temp = 0;
            //Console.WriteLine("Enter a Number: ");
            //n = int.Parse(Console.ReadLine());

            //while (n != 0)
            //{
            //    sum += n;
            //    counter++;
            //    temp = (n > temp) ? n : temp;
            //    n = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("the sum is: " + sum);
            //Console.WriteLine("The counter is: " + counter);
            //Console.WriteLine("The average is: " + sum / counter);
            //Console.WriteLine("The max value is: " + temp);
            //Console.ReadLine();


            //Factors of a number

            //Console.WriteLine("Enter a Number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for(int factor = 1; factor <= n; factor++)
            //{
            //    if(n%factor == 0)
            //    {
            //        Console.Write(factor + " ");
            //    }
            //}
            //Console.ReadLine();


            //Factorial using for loop
            //Console.WriteLine("Enter a Number: ");
            //int i, number, fact;
            //number = Convert.ToInt32(Console.ReadLine());
            //fact = number;
            //for (i = number - 1; i >= 1; i--)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine("The max value is: " + fact);

            //Factorial using while loop
            //Console.WriteLine("Enter a Number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            ////int i = 1;
            //long factorial = number;
            //while (number > 1)
            //{
            //    factorial *= --number;
            //    //To display each step
            //    //Console.WriteLine("{0}. {1} * {2} = {3}", i++, factorial / number, number, factorial);
            //}
            //Console.WriteLine("The factorial of given number  is: " + factorial);




            //Factorial using recursion
            //Console.Write(" Input any  number : ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //long fact = FactCalc(n1);
            //Console.WriteLine(" The factorial of {0} is : {1} ", n1, fact);
            //Console.ReadKey();


            //sum of n numbers
            //int sum = 0;
            //Console.Write("Enter the number");
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 0; i <= n; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("the sum of numbers is :" + sum);



            //Armstrong numbers -  number that is equal to the sum of cubes of its digits (153 = 1^3 +5^3 +3^3)
            //int n,r,sum =0, temp;
            //Console.Write("Enter the number");
            // n = int.Parse(Console.ReadLine());
            //temp = n;
            //while (n != 0)
            //{
            //    r = n % 10;
            //    sum += (r * r * r);
            //    n /=10;
            //}
            //if(temp == sum)

            //    Console.WriteLine("Is armstron number");

            //else
            //    Console.WriteLine("Not armstron number");


            //Reverse a string
            //string reverse = string.Empty;
            //Console.Write("Enter a string");
            //string text = Convert.ToString(Console.ReadLine());
            //for(int i = text.Length - 1; i >= 0; i--)
            //{
            //    reverse += text[i];
            //}
            //Console.WriteLine(reverse);

            //Console.ReadLine();



            //vowel or consonant
            //char ch;

            //Console.WriteLine("Enter any character: ");
            //ch = Convert.ToChar(Console.ReadLine());


            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            //{

            //    Console.WriteLine(ch + " is Vowel.");

            //}
            //else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            //{
            //    Console.WriteLine(ch + " is Consonant.");
            //}

            //Console.ReadLine();


            //print the sum of negative numbers, sum of positive even numbers and sum of positive odd numbers from a list of numbers entered by the user. The list terminates when the user enters a zero.
            //int nsum = 0, esum = 0, osum = 0;

            //    Console.WriteLine("Enter numbers: ");
            //while (true)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    if (n == 0)
            //        break;
            //    if (n < 0)
            //    {
            //        nsum += n;
            //    }
            //    else if (n %2 ==  0)
            //    {
            //        esum += n;
            //    }
            //    else
            //    {
            //        osum += n;
            //    }
            //}
            //Console.WriteLine("Negative No. Sum = " + nsum);
            //Console.WriteLine("even No. Sum = " + esum);
            //Console.WriteLine("odd No. Sum = " + osum);



            //Sum Of A Digits Of Number
            //int sum = 0,temp =0;
            //Console.Write("Enter the number");
            //int n = int.Parse(Console.ReadLine());
            //while (n != 0)
            //{
            //    temp = n % 10;
            //    sum += temp;
            //    n /= 10;
            //}
            //Console.WriteLine("sum of digits in number = " + sum);
        }
    }
}
