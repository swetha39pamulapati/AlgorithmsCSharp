using System;
using System.Collections.Generic;

namespace _49Anagrams
{
    class Program
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {

            IList<IList<string>> result = new List<IList<string>>();

            Dictionary<string, IList<string>> ht = new Dictionary<string, IList<string>>();
            for (int i = 0; strs.Length > i; i++)
            {
                char[] chars = strs[i].ToCharArray();
                Array.Sort(chars);
                string s = new string(chars);
                if (!ht.ContainsKey(s))
                {
                    IList<string> list = new List<string>();
                    list.Add(strs[i]);
                    ht.Add(s, list);
                }
                else
                {
                    IList<string> l = (List<string>)ht[s];
                    l.Add(strs[i]);
                }
            }
            foreach (var item in ht.Values)
                result.Add(item);

            return result;
            //return (IList<IList<string>>)ht;
        }
        static void Main(string[] args)
        {
            
            string[] str = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> resultData = GroupAnagrams(str);
            foreach(IList<string> s in resultData)
            {
                foreach(string d in s) {
                Console.Write(d + ",");
                }
            }
           
        }
    }
}
