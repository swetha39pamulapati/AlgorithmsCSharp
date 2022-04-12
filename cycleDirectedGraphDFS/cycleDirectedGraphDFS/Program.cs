using System;
using System.Collections.Generic;
using System.Linq;

namespace cycleDirectedGraphDFS
{
    class Graph
    {
        private int vertex;
        private LinkedList<int>[] adj;

        Graph(int vertices)
        {
            vertex = vertices;
            adj = new LinkedList<int>[vertices];
            for (int i = 0; i < vertices; ++i)
                adj[i] = new LinkedList<int>();
        }
        void addEgde(int node, int edge)
        {
            adj[node].AddLast(edge); 
        }
        public bool DFSUtil(int vertex, bool[] visited, bool[] recursiveArr)
        {
            visited[vertex] = true;
            recursiveArr[vertex] = true;

            for (int i = 0; i < adj[vertex].Count(); i++)
            {
                int adjVertex = adj[vertex].ElementAt(i);
                if (!visited[adjVertex] && DFSUtil(adjVertex, visited, recursiveArr))
                {
                    return true;
                }
                else if (recursiveArr[adjVertex])
                    return true;
            }
            recursiveArr[vertex] = false;
            return false;
        }

        bool DFS()
        {
            bool[] visited = new bool[vertex];
            bool[] recursiveArr = new bool[vertex];
            for (int i = 0; i < vertex; i++)
            {
                if (DFSUtil(i, visited, recursiveArr))
                    return true;
            }
            return false;

        }
        public static void Main()
        {
            int vertices = 4;
            Graph graph = new Graph(vertices);
            graph.addEgde(0, 1);
            graph.addEgde(1, 2);
            graph.addEgde(2, 0);
            graph.addEgde(2, 3);
            bool result = graph.DFS();
            Console.WriteLine("is Cycle present: " + result);

        }
    }
    //public class Graph
    //{

    //    private readonly int V;
    //    private readonly List<List<int>> adj;

    //    public Graph(int V)
    //    {
    //        this.V = V;
    //        adj = new List<List<int>>(V);

    //        for (int i = 0; i < V; i++)
    //            adj.Add(new List<int>());
    //    }

    //    // This function is a variation of DFSUtil() in 
    //    // https://www.geeksforgeeks.org/archives/18212 
    //    private bool isCyclicUtil(int i, bool[] visited,
    //                                    bool[] recStack)
    //    {

    //        // Mark the current node as visited and 
    //        // part of recursion stack 
    //        if (recStack[i])
    //            return true;

    //        if (visited[i])
    //            return false;

    //        visited[i] = true;

    //        recStack[i] = true;
    //        List<int> children = adj[i];

    //        foreach (int c in children)
    //            if (isCyclicUtil(c, visited, recStack))
    //                return true;

    //        recStack[i] = false;

    //        return false;
    //    }

    //    private void addEdge(int sou, int dest)
    //    {
    //        adj[sou].Add(dest);
    //    }

    //    // Returns true if the graph contains a 
    //    // cycle, else false. 
    //    // This function is a variation of DFS() in 
    //    // https://www.geeksforgeeks.org/archives/18212 
    //    private bool isCyclic()
    //    {

    //        // Mark all the vertices as not visited and 
    //        // not part of recursion stack 
    //        bool[] visited = new bool[V];
    //        bool[] recStack = new bool[V];


    //        // Call the recursive helper function to 
    //        // detect cycle in different DFS trees 
    //        for (int i = 0; i < V; i++)
    //            if (isCyclicUtil(i, visited, recStack))
    //                return true;

    //        return false;
    //    }

    //    // Driver code 
    //    public static void Main(String[] args)
    //    {
    //        Graph graph = new Graph(4);
    //        graph.addEdge(0, 1);
    //        graph.addEdge(0, 2);
    //        graph.addEdge(1, 2);
    //        graph.addEdge(2, 0);
    //        graph.addEdge(2, 3);
    //        graph.addEdge(3, 3);

    //        if (graph.isCyclic())
    //            Console.WriteLine("Graph contains cycle");
    //        else
    //            Console.WriteLine("Graph doesn't "
    //                                    + "contain cycle");
    //    }
    //}
    //class GFG
    //{

    //    // A DFS based approach to find if 
    //    // there is a cycle in a directed graph. 
    //    // This approach strictly follows the 
    //    // algorithm given in CLRS book. 
    //    static int WHITE = 0, GRAY = 1, BLACK = 2;

    //    // Graph class represents a directed graph 
    //    // using adjacency list representation 
    //    public class Graph
    //    {
    //        public int V;
    //        public List<int>[] adjList;

    //        // Constructor 
    //        public Graph(int ver)
    //        {
    //            V = ver;
    //            adjList = new List<int>[V];
    //            for (int i = 0; i < V; i++)
    //                adjList[i] = new List<int>();
    //        }
    //    }

    //    // Utility function to add an edge 
    //    static void addEdge(Graph g, int u, int v)
    //    {
    //        g.adjList[u].Add(v); // Add v to u's list. 
    //    }

    //    // Recursive function to find if there is back edge 
    //    // in DFS subtree tree rooted with 'u' 
    //    static bool DFSUtil(Graph g, int u, int[] color)
    //    {
    //        // GRAY : This vertex is being processed (DFS 
    //        // for this vertex has started, but not 
    //        // ended (or this vertex is in function 
    //        // call stack) 
    //        color[u] = GRAY;

    //        // Iterate through all adjacent vertices
    //        foreach (int iN in g.adjList[u])
    //        {
    //            // If there is
    //            if (color[iN] == GRAY)
    //                return true;

    //            // If v is not processed and there is a back 
    //            // edge in subtree rooted with v 
    //            if (color[iN] == WHITE &&
    //                DFSUtil(g, iN, color) == true)
    //                return true;
    //        }

    //        // Mark this vertex as processed 
    //        color[u] = BLACK;
    //        return false;
    //    }

    //    // Returns true if there is a cycle in graph
    //    static bool isCyclic(Graph g)
    //    {
    //        // Initialize color of all vertices as WHITE
    //        int[] color = new int[g.V];
    //        for (int i = 0; i < g.V; i++)
    //        {
    //            color[i] = WHITE;
    //        }

    //        // Do a DFS traversal beginning with all 
    //        // vertices 
    //        for (int i = 0; i < g.V; i++)
    //        {
    //            if (color[i] == WHITE)
    //            {
    //                if (DFSUtil(g, i, color) == true)
    //                    return true;
    //            }
    //        }
    //        return false;

    //    }

    //    // Driver Code
    //    public static void Main(String[] args)
    //    {
    //        // Create a graph given in the above diagram
    //        Graph g = new Graph(4);
    //        addEdge(g, 0, 1);
    //        addEdge(g, 0, 2);
    //        addEdge(g, 1, 2);
    //        addEdge(g, 2, 0);
    //        addEdge(g, 2, 3);
    //        addEdge(g, 3, 3);
    //        if (isCyclic(g))
    //            Console.WriteLine("Graph contains cycle");
    //        else
    //            Console.WriteLine("Graph doesn't contain cycle");
    //    }
    //}
}
