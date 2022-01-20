using System;
using System.Collections.Generic;

namespace validparenthesis
{
    class Program
    {
        public static bool IsValid(string s)
        {
            Dictionary<char, char> parenthesesMap = new Dictionary<char, char>();
            parenthesesMap['{'] = '}';
            parenthesesMap['('] = ')';
            parenthesesMap['['] = ']';
            parenthesesMap['<'] = '>';

            // If there are an odd number of characters we know 
            // there is no matching closing parenthesis
            if (s.Length % 2 != 0) { return false; }

            Stack<char> closedParentheses = new Stack<char>();
            foreach (char p in s)
            {
                // Check if the parenthesis is an opening parenthesis
                if (parenthesesMap.ContainsKey(p))
                {
                    closedParentheses.Push(parenthesesMap[p]);
                }
                // Check if the parenthesis is a closing parenthesis
                else if (parenthesesMap.ContainsValue(p))
                {
                    // This closing parenthesis is not paired with an opening parenthesis
                    if (closedParentheses.Count == 0) { return false; }

                    // Pop from the stack and validate popped item matches current closed parenthesis
                    if (closedParentheses.Pop() != p)
                    {
                        return false;
                    }
                }
                else  // Invalid character
                {
                    return false;
                }
            }
            // Stack should be empty if its properly balanced
            return (closedParentheses.Count == 0);
        }
        static void Main(string[] args)
        {
            bool data = IsValid("()[]{}");
            //bool data = IsValid("(]");
            //bool data = IsValid("()]");
            
            Console.WriteLine(data);
        }
    }
}
