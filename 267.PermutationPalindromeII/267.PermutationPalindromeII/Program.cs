using System;

namespace _267.PermutationPalindromeII
{
    class Program
    {
 //       Time complexity : O(n). We traverse over the string s of length n once only.
 //* Space complexity : O(1). A array of constant size(128) is used.
        public static bool canPermutePalindrome(string s)
        {
            int[] map = new int[128];
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
        static void Main(string[] args)
        {
           bool data =  canPermutePalindrome("level");
            Console.Write(data == true ? "Palindrome Permutation" : "No Palindrome Permutation");
        }
    }
}
