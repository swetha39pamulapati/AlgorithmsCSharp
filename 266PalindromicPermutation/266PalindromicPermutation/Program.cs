using System;
using System.Collections.Generic;
using System.Text;

namespace _266PalindromicPermutation
{
    class Program
    {
        //Time: n*n/2!
        //Space:  n*n/2!


        HashSet<string> set = new HashSet<string>(); // Using HashSet data-structure, we can remove duplicate permutations.
        public List<string> generatePalindromes(string s)
        {
            int[] map = new int[128];
            char[] st = new char[s.Length / 2];   // contains all the characters of s but occurences reduced to half
            if (!canPermutePalindrome(s, map))
            {
                return new List<string>();
            }
            char ch = (char)0;    //  the only character occured an odd number of times
            int k = 0;
            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] % 2 == 1)
                {
                    ch = (char)i;
                }
                // construct the st
                for (int j = 0; j < map[i] / 2; j++)
                {
                    st[k++] = (char)i;
                }
            }
            permute(st, 0, ch);
            return new List<string>(set);
        }

        public bool canPermutePalindrome(string s, int[] map)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                map[s[i]]++;
                if (map[s[i]] % 2 == 0)
                {
                    count--;
                }
                else
                {
                    count++;
                }
            }
            return count <= 1;
        }

        void permute(char[] s, int start, char ch)
        {
            if (start == s.Length)
            {
                set.Add(new string(s) + (ch == 0 ? "" : ch) + new StringBuilder(new string(s)).Remove(s.Length-1,1));
                


            }
            else
            {
                for (int i = start; i < s.Length; i++)
                {
                    if (s[start] != s[i] || start == i)
                    {
                        swap(s, start, i);
                        permute(s, start + 1, ch);
                        swap(s, start, i);
                    }
                }
            }
        }

        public void swap(char[] s, int i, int j)
        {
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            List<string> data = p.generatePalindromes("aabb");
            foreach(string s in data)
            {
                Console.Write(s + " ,");
            }
        }
    }
}
