using System;
using System.Collections.Generic;

namespace bridgeInGraph
{
    public class Graph
    {
        private int V; 
        private List<int>[] adj;
        int time = 0;
        Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }
        void addEdge(int v, int w)
        {
            adj[v].Add(w); 
            adj[w].Add(v); 
        }
        void bridgeUtil(int u, bool[] visited, int[] disc,
                        int[] low, int parent)
        {
            visited[u] = true;
            disc[u] = low[u] = ++time;
            foreach (int v in adj[u])
            {
                if (v == parent)
                    continue;
                if (!visited[v])
                {
                    bridgeUtil(v, visited, disc, low, u);
                    low[u] = Math.Min(low[u], low[v]);
                    if (low[v] > disc[u])
                        Console.WriteLine(u + " " + v);
                }
                else 
                    low[u] = Math.Min(low[u], disc[v]);
            }
        }
        void bridge()
        {
            bool[] visited = new bool[V];
            int[] disc = new int[V];
            int[] low = new int[V];
            for (int i = 0; i < V; i++)
                if (visited[i] == false)
                    bridgeUtil(i, visited, disc, low, -1);
        }
        public static void Main(string[] args)
        {
            // Create graphs given in above diagrams
            //Console.WriteLine("Bridges in first graph ");
            //Graph g1 = new Graph(5);
            //g1.addEdge(1, 0);
            //g1.addEdge(0, 2);
            //g1.addEdge(2, 1);
            //g1.addEdge(0, 3);
            //g1.addEdge(3, 4);
            //g1.bridge();
            //Console.WriteLine();

            //Console.WriteLine("Bridges in Second graph");
            //Graph g2 = new Graph(4);
            //g2.addEdge(0, 1);
            //g2.addEdge(1, 2);
            //g2.addEdge(2, 3);
            //g2.bridge();
            //Console.WriteLine();

            Console.WriteLine("Bridges in Third graph ");
            Graph g3 = new Graph(6);
            //g3.addEdge(0, 1);
            //g3.addEdge(1, 2);
            //g3.addEdge(2, 0);
            //g3.addEdge(1, 3);
            //g3.addEdge(1, 4);
            //g3.addEdge(1, 6);
            //g3.addEdge(3, 5);
            //g3.addEdge(4, 5);

            g3.addEdge(0, 1);
            g3.addEdge(1, 2);
            g3.addEdge(2, 3);
            g3.addEdge(3, 4);
            g3.addEdge(5, 3);
            g3.addEdge(5, 1);

            g3.bridge();
        }
    }
}
