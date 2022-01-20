using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    class Program
    {
        public bool containsDuplicate(int[] data)
        {
            if (data.Length == 0)
                return false;
            HashSet<int> set = new HashSet<int>();
            for(int i =0; i<data.Length; i++)
            {
                if (set.Contains(data[i]))
                {
                    return true;
                }
                set.Add(data[i]);
            }
            return false;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] dataset = { 1, 2, 3, 1, 2 };
            bool result = p.containsDuplicate(dataset);
            Console.WriteLine(result);
        }
    }
}
