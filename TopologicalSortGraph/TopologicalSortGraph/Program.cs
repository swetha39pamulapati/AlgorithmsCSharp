using System;
using System.Collections.Generic;

namespace TopologicalSortGraph
{
    public class Graph
    {
        private int vertex;
        LinkedList<int>[] adj;
        public Graph(int x)
        {
            vertex = x;
            adj = new LinkedList<int>[x];
            for (int i = 0; i < x; i++)
                adj[i] = new LinkedList<int>();

        }
        public void addEdge(int n, int e)
        {
            adj[n].AddLast(e);
        }
        public void topologicalSort()
        {
            int[] in_degree = new int[vertex];

            for (int u = 0; u < vertex; u++)
            {
                foreach (int itr in adj[u]) 
                    in_degree[itr]++;
            }

            Queue<int> q = new Queue<int>();
            for (int i = 0; i < vertex; i++)
                if (in_degree[i] == 0)
                    q.Enqueue(i);

            int cnt = 0;

           
            List<int> list = new List<int>();

           
            while (q.Count > 0)
            {

                int u = q.Dequeue();
                list.Add(u);

               
                foreach (int itr in adj[u])
                {

                    if (--in_degree[itr] == 0)
                        q.Enqueue(itr);
                }

                cnt++;
            }

           
            if (cnt != vertex)
            {
                Console.WriteLine(
                  "There exists a cycle in the graph");
                return;
            }

            // Print topological order
            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + " ");
            Console.WriteLine();
        }
 
        public static void Main()
        {
            Graph g = new Graph(6);
            g.addEdge(5, 2);
            g.addEdge(5, 0);
            g.addEdge(4, 0);
            g.addEdge(4, 1);
            g.addEdge(2, 3);
            g.addEdge(3, 1);
            g.topologicalSort();
        }
    }
    //class Graph
    //{

    //    // No. of vertices
    //    private int V;

    //    // Adjacency List as ArrayList
    //    // of ArrayList's
    //    private List<List<int>> adj;

    //    // Constructor
    //    Graph(int v)
    //    {
    //        V = v;
    //        adj = new List<List<int>>(v);
    //        for (int i = 0; i < v; i++)
    //            adj.Add(new List<int>());
    //    }

    //    // Function to add an edge into the graph
    //    public void AddEdge(int v, int w) { adj[v].Add(w); }

    //    // A recursive function used by topologicalSort
    //    void TopologicalSortUtil(int v, bool[] visited,
    //                             Stack<int> stack)
    //    {

    //        // Mark the current node as visited.
    //        visited[v] = true;

    //        // Recur for all the vertices
    //        // adjacent to this vertex
    //        foreach (var vertex in adj[v])
    //        {
    //            if (!visited[vertex])
    //                TopologicalSortUtil(vertex, visited, stack);
    //        }

    //        // Push current vertex to
    //        // stack which stores result
    //        stack.Push(v);
    //    }

    //    // The function to do Topological Sort.
    //    // It uses recursive topologicalSortUtil()
    //    void TopologicalSort()
    //    {
    //        Stack<int> stack = new Stack<int>();

    //        // Mark all the vertices as not visited
    //        var visited = new bool[V];

    //        // Call the recursive helper function
    //        // to store Topological Sort starting
    //        // from all vertices one by one
    //        for (int i = 0; i < V; i++)
    //        {
    //            if (visited[i] == false)
    //                TopologicalSortUtil(i, visited, stack);
    //        }

    //        // Print contents of stack
    //        foreach (var vertex in stack)
    //        {
    //            Console.Write(vertex + " ");
    //        }
    //    }

    //    // Driver code
    //    public static void Main(string[] args)
    //    {

    //        // Create a graph given
    //        // in the above diagram
    //        Graph g = new Graph(6);
    //        g.AddEdge(5, 2);
    //        g.AddEdge(5, 0);
    //        g.AddEdge(4, 0);
    //        g.AddEdge(4, 1);
    //        g.AddEdge(2, 3);
    //        g.AddEdge(3, 1);

    //        Console.WriteLine("Following is a Topological "
    //                          + "sort of the given graph");

    //        // Function Call
    //        g.TopologicalSort();
    //    }
    //}


}
