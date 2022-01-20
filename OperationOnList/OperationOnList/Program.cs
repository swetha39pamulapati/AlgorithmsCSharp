using System;
using System.Collections.Generic;

namespace OperationOnList
{
    class Program
    {
        public static void LogCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"count{list.Count}. Capacity{list.Capacity}");
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            LogCountAndCapacity(list); // without adding data the count and capacity are 0;
            for(int i=0; i < 16; i++)
            {
                list.Add(i);
                LogCountAndCapacity(list);
            }
        }
    }
}
