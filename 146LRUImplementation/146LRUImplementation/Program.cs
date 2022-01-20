using System;
using System.Collections.Generic;

namespace _146LRUImplementation
{
    class LRUCache
    {
        private int capacity = 0;
        private LinkedList<int[]> list = new LinkedList<int[]>();
        private Dictionary<int, LinkedListNode<int[]>> dict = new Dictionary<int, LinkedListNode<int[]>>();

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            if (!dict.ContainsKey(key))
                return -1;

            Reorder(dict[key]);

            return dict[key].Value[1];
        }

        public void Put(int key, int value)
        {
            if (dict.ContainsKey(key))
                dict[key].Value[1] = value;
            else
            {
                if (dict.Count == this.capacity)
                {
                    dict.Remove(list.Last.Value[0]);
                    list.RemoveLast();
                }

                dict.Add(key, new LinkedListNode<int[]>(new int[] { key, value }));
            }

            Reorder(dict[key]);
        }

        private void Reorder(LinkedListNode<int[]> node)
        {
            //if (node.Previous != null)
            //    list.Remove(node);

            //if (list.First != node)
            //    list.AddFirst(node);
            if (node.Next != null) list.Remove(node);
            if (list.Last != node) list.AddLast(node);
        }

        static void Main(string[] args)
        {
            LRUCache lRUCache = new LRUCache(2);
            lRUCache.Put(1, 1); // cache is {1=1}
            lRUCache.Put(2, 2); // cache is {1=1, 2=2}
           int data= lRUCache.Get(1);    // return 1
            Console.WriteLine(data);
            lRUCache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
            int data1=    lRUCache.Get(2);    // returns -1 (not found)
            Console.WriteLine(data1);
            lRUCache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
            int data4= lRUCache.Get(1);    // return -1 (not found)
            Console.WriteLine(data4);
            int data2=lRUCache.Get(3);    // return 3
            Console.WriteLine(data2);
            int data3 = lRUCache.Get(4);    // return 4
            Console.WriteLine(data3);
            //Console.WriteLine("Hello World!");
        }
    }
}
