using System;
using System.Collections.Generic;

namespace depth1stSearchGrapgh
{
    class Graph
    {
        private int vertex; // No. of vertices

        // Array of lists for
        // Adjacency List Representation
        private LinkedList<int>[] adj;

        // Constructor
        Graph(int vertices)
        {
            vertex = vertices;
            adj = new LinkedList<int>[vertices];
            for (int i = 0; i < vertices; ++i)
                adj[i] = new LinkedList<int>();
        }

        // Function to Add an edge into the graph
        void AddEdge(int node, int edge)
        {
            adj[node].AddLast(edge); // Add w to v's list.
        }

        // A function used by DFS
        void DFSUtil(int v, bool[] visited)
        {
            // Mark the current node as visited
            // and print it
            visited[v] = true;
            Console.Write(v + " ");

            // Recur for all the vertices
            // adjacent to this vertex
            LinkedList<int> vList = adj[v];
            foreach (var n in vList)
            {
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }

        // The function to do DFS traversal.
        // It uses recursive DFSUtil()
        void DFS(int v)
        {
            // Mark all the vertices as not visited
            // (set as false by default in c#)
            bool[] visited = new bool[vertex];

            // Call the recursive helper function
            // to print DFS traversal
            DFSUtil(v, visited);
        }

        // Driver Code
        public static void Main(String[] args)
        {
            Graph g = new Graph(7);

            g.AddEdge(0, 1);
            g.AddEdge(0, 3);
            g.AddEdge(1, 2);
            g.AddEdge(3, 2);
            g.AddEdge(2, 4);
            g.AddEdge(2, 5);
            g.AddEdge(3, 4);
            g.AddEdge(4, 6);
            g.AddEdge(5, 1);
            g.AddEdge(6, 1);

            Console.WriteLine(
                "Following is Depth First Traversal "
                + "(starting from vertex 2)");

            g.DFS(0);
            Console.ReadKey();
        }
    }
}
