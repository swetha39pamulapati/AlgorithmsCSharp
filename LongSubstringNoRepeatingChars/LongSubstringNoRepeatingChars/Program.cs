using System;
using System.Collections.Generic;

namespace LongSubstringNoRepeatingChars
{
    class Program
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            if (n < 2) return n;
            int len = 1;
            var map = new Dictionary<char, int>();
            map.Add(s[0], 0);
            for (int start = 0, end = 1; start < n && end < n; end++)
            {
                if (map.ContainsKey(s[end]))
                {
                    start = Math.Max(start, map[s[end]] + 1);
                }

                map[s[end]] = end;
                len = Math.Max(len, end - start + 1);
            }
            foreach (char key in map.Keys)
            {
                Console.Write(key);
            }
            return len;
        }
        static void Main(string[] args)
        {

            int data = LengthOfLongestSubstring("FSFETWENWE");
            Console.WriteLine("\n The length of substring is :" +data);

        }
    }
}
