using System;
using System.Collections.Generic;

namespace NearestRepeatedEntries
{
    class Program
    {
        public static int findNearestRepetition(List<string> s)
        {
            var stringToLocation = new Dictionary<string, int>();
            int closestDis = int.MaxValue;
            for (int i = 0; i < s.Count; ++i)
            {
                if (stringToLocation.ContainsKey(s[i]))
                {
                    closestDis = Math.Min(closestDis, i - stringToLocation[s[i]]);
                }
                stringToLocation.Add(s[i], i);
            }
            return closestDis;
        }
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("All");
            data.Add("work");
            data.Add("and");
            data.Add("no");
            data.Add("play");
            data.Add("makes");
            data.Add("for");
            data.Add("no");
            data.Add("work");
            data.Add("no");
            data.Add("fun");
            data.Add("and");
            data.Add("no");
            data.Add("results");
            int result = findNearestRepetition(data);
            Console.WriteLine(result);
        }
    }
}
