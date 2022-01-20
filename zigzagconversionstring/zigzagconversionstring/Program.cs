using System;

namespace zigzagconversionstring
{
    class Program
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            string[] rs = new string[numRows];
            bool direction = false;
            int lineNumber = 0;
            foreach (char c in s)
            {
                rs[lineNumber] += c;
                if (direction == false)
                {
                    lineNumber += 1;
                }
                else
                {
                    lineNumber -= 1;
                }
                if (lineNumber == 0 || lineNumber == (numRows - 1))
                {
                    direction = !direction;
                }
            }
            string result = "";
            foreach (string ss in rs) result += ss;
            return result;
        }
        static void Main(string[] args)
        {
            string result = Convert("PAYPALISHIRING", 3);
            Console.WriteLine(result);
        }
    }
}
