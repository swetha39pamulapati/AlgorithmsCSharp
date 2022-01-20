using System;
using System.Collections.Generic;
using System.Text;

namespace Int2Roman
{
    class Program
    {
        //private static string IntToRoman(int num)
        //{
        //    string[] Letters = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        //    int[] Integers = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        //    string result = "";
        //    for (int i = 0; i < Integers.Length; i++)
        //    {
        //        int NumberDividedByIntegers = num / Integers[i]; 
        //        if (NumberDividedByIntegers > 0)
        //        {
        //            while (NumberDividedByIntegers > 0)
        //            {
        //                result += Letters[i];
        //                NumberDividedByIntegers--;
        //            }
        //            num %= Integers[i];
        //        }
        //    }
        //    return result;
        //}
        public static string IntToRoman(int num)
        {
            var Dictionary = new Dictionary<string, int>() {

                {"M", 1000}, {"CM", 900}, {"D", 500}, {"CD", 400}, {"C", 100}, {"XC", 90}, {"L", 50}, {"XL", 40}, {"X", 10}, {"IX", 9}, {"V", 5}, {"IV", 4}, {"I", 1}
            };
            var stb = new StringBuilder();

            var remaining = num;
            foreach (var item in Dictionary)
            {
                while (remaining > 0 && remaining >= item.Value)
                {
                    stb.Append(item.Key);
                    remaining -= item.Value;
                }
                if (remaining < 1)
                {
                    break;
                }
            }

            return stb.ToString();

        }
        static void Main(string[] args)
        {
            string data = IntToRoman(443);
            Console.WriteLine(data);
        }
    }
}
