using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LetterCombPhoneNum
{
    class Program
    {
        private Dictionary<char, List<string>> phonenumber = new Dictionary<char, List<string>>
        {
            {'0', new List<string>()},
            {'1', new List<string>()},
            {'2', new List<string>() {"a", "b", "c"}},
            {'3', new List<string>() {"d", "e", "f"}},
            {'4', new List<string>() {"g", "h", "i"}},
            {'5', new List<string>() {"j", "k", "l"}},
            {'6', new List<string>() {"m", "n", "o"}},
            {'7', new List<string>() { "p", "q", "r","s" }},
            {'8', new List<string>() {"t", "u", "v"}},
            {'9', new List<string>() { "w", "x", "y", "z" }}
        };
        private List<string> resstring = new List<string>();
        public IList LetterCombinations(string digits)
        {
            LetterCombinationsHelper(digits, 0, new StringBuilder());

            return resstring;
        }

        private void LetterCombinationsHelper(string digits, int i, StringBuilder result)
        {
            if (i >= digits.Length)
            {
                if (result.Length > 0)
                {
                    resstring.Add(result.ToString());
                }
                return;
            }

            var cur = phonenumber[digits[i]];
            foreach (var letter in cur)
            {
                result.Append(letter);
                LetterCombinationsHelper(digits, i + 1, result);
                result.Remove(result.Length - 1, 1);
            }
        }

        static void Main(string[] args)
        {
            Program x = new Program();
            IList data = x.LetterCombinations("23");
            foreach (string i in data)
            {
                Console.Write( i + " ");
            }
        }
    }
}
