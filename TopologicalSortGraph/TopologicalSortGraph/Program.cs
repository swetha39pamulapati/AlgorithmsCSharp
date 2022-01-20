using System;
using System.Collections.Generic;

namespace TopologicalSortGraph
{

    //WithLinkedList
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
        public void topologicalUtil(int i, bool[] visited, LinkedList<int> list)
        {
            visited[i] = true;
            foreach (var val in adj[i])
            {
                if (!visited[val])
                {
                    topologicalUtil(val, visited, list);
                }
            }
            list.AddFirst(i);
        }
        public void topologicalSort()
        {
            LinkedList<int> list = new LinkedList<int>();
            bool[] visited = new bool[vertex];
            for (int i = 0; i < vertex; i++)
            {
                if (!visited[i])
                {
                    topologicalUtil(i, visited, list);
                }
            }
            foreach (var vertices in list)
            {
                Console.Write(vertices + " ");
            }
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
