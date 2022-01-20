using System;
using System.Collections.Generic;

namespace GenerateParanthesis
{
    class Program
    {
        List<string> result = new List<string>();
        int maxLen;

        public IList<string> GenerateParenthesis(int n)
        {
            maxLen = n;
            GenerateAndCheck("", 0, 0);
            return result;
        }

        private void GenerateAndCheck(string str, int opened, int closed)
        {
            if (opened == closed && opened == maxLen)
            {
                result.Add(str);
                return;
            }

            if (opened < maxLen)
                GenerateAndCheck(str + "(", opened + 1, closed);
            if (closed < opened)
                GenerateAndCheck(str + ")", opened, closed + 1);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            IList<string> result = p.GenerateParenthesis(2);
            foreach (string i in result)
            {
                Console.Write(i + " ");
            }
            //Console.WriteLine(result);
        }
    }
}
