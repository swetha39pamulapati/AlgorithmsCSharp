using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    //Allpath shortest
    //class Graph
    //{
    //    public const int INF = 99999;
    //    private static void Print(int[,] distance, int verticesCount)
    //    {
    //        Console.WriteLine("Shortest distances between every pair of vertices:");

    //        for (int i = 0; i < verticesCount; ++i)
    //        {
    //            for (int j = 0; j < verticesCount; ++j)
    //            {
    //                if (distance[i, j] == INF)
    //                    Console.Write("INF".PadLeft(5));
    //                else
    //                    Console.Write(distance[i, j].ToString().PadLeft(5));
    //            }

    //            Console.WriteLine();
    //        }
    //    }

    //    public static void FloydWarshall(int[,]graph , int verticesCount)
    //    {
    //        int[,] distance = new int[verticesCount, verticesCount];

    //        for (int i = 0; i < verticesCount; ++i)
    //            for (int j = 0; j < verticesCount; ++j)
    //                distance[i, j] = graph[i, j];
    //        for(int k = 0; k< verticesCount; k++)
    //        {
    //            for (int i = 0; i < verticesCount; i++)
    //            {
    //                for (int j = 0; j < verticesCount; j++)
    //                {
    //                    if (distance[i, k] + distance[k, j] < distance[i, j])
    //                        distance[i, j] = distance[i, k] + distance[k, j];
    //                }
    //            }
    //        }
    //        Print(distance, verticesCount);
    //    }
    //    static void Main(string[] args)
    //    {
    //        int[,] graph = {
    //                      { 0,   9, -4 , INF },
    //                      { 6, 0,   INF, 2 },
    //                      { INF, 5, 0,   INF },
    //                      { INF, INF, 1, 0 }
    //                       };

    //        FloydWarshall(graph, 4);
    //    }
    //}
    //BellManFord
    //class Graph
    //{
    //    int V, E;
    //      Edge[] edge;
    //    public struct Edge
    //    {
    //        public int Source;
    //        public int Destination;
    //        public int Weight;
    //    }
    //    public Graph(int v, int e)
    //    {
    //        V = v; E = e;
    //        edge = new Edge[E];
    //                for (int i = 0; i < e; i++)
    //                   edge[i] = new Edge();
    //    }
    //    public void Print(int [] distance, int vertices)
    //    {
    //        Console.WriteLine("Vertex   Distance from source");
    //        for (int i = 0; i<V; i++)
    //        {
    //            Console.WriteLine("{0}\t {1}", i, distance[i]);
    //        }
    //    }
    //    public void BellmanFord(Graph g, int s)
    //    {
    //        int[] distance = new int[V];
    //        for (int k = 0; k < V; k++)
    //            distance[k] = int.MaxValue;
    //        distance[s] = 0;
    //        for(int i = 1; i<V-1; i++)
    //        {
    //            for(int j = 0; j<V; j++)
    //            {
    //                int u = g.edge[j].Source;
    //                int v = g.edge[j].Destination;
    //                int weight = g.edge[j].Weight;
    //                if(distance[u] + weight < distance[v])
    //                {
    //                    distance[v] = distance[u] + weight;
    //                }
    //            }
    //        }
    //        for(int count = 0; count < E; count++)
    //        {
    //            int u = g.edge[count].Source;
    //            int v = g.edge[count].Destination;
    //            int weight = g.edge[count].Weight;
    //            if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
    //            {
    //                Console.Write("The graph contains negative cycle");
    //            }
    //        }
    //        Print(distance, V);
    //    }
    //    static void Main(string[] args)
    //    {
    //        int verticesCount = 5;
    //        int edgesCount = 8;
    //        Graph graph = new Graph(verticesCount, edgesCount);

    //        // Edge 0-1
    //        graph.edge[0].Source = 0;
    //        graph.edge[0].Destination = 1;
    //        graph.edge[0].Weight = -1;

    //        // Edge 0-2
    //        graph.edge[1].Source = 0;
    //        graph.edge[1].Destination = 2;
    //        graph.edge[1].Weight = 4;

    //        // Edge 1-2
    //        graph.edge[2].Source = 1;
    //        graph.edge[2].Destination = 2;
    //        graph.edge[2].Weight = 3;

    //        // Edge 1-3
    //        graph.edge[3].Source = 1;
    //        graph.edge[3].Destination = 3;
    //        graph.edge[3].Weight = 2;

    //        // Edge 1-4
    //        graph.edge[4].Source = 1;
    //        graph.edge[4].Destination = 4;
    //        graph.edge[4].Weight = 2;

    //        // Edge 3-2
    //        graph.edge[5].Source = 3;
    //        graph.edge[5].Destination = 2;
    //        graph.edge[5].Weight = 5;

    //        // Edge 3-1
    //        graph.edge[6].Source = 3;
    //        graph.edge[6].Destination = 1;
    //        graph.edge[6].Weight = 1;

    //        // Edge 4-3
    //        graph.edge[7].Source = 4;
    //        graph.edge[7].Destination = 3;
    //        graph.edge[7].Weight = -3;

    //        graph.BellmanFord(graph, 0);
    //    }
    //}
    //Dijkstra adjacency matrix
    //class Dijkstra
    //{

    //    private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
    //    {
    //        int min = int.MaxValue;
    //        int minIndex = 0;

    //        for (int v = 0; v < verticesCount; ++v)
    //        {
    //            if (shortestPathTreeSet[v] == false && distance[v] <= min)
    //            {
    //                min = distance[v];
    //                minIndex = v;
    //            }
    //        }

    //        return minIndex;
    //    }

    //    private static void Print(int[] distance, int verticesCount)
    //    {
    //        Console.WriteLine("Vertex    Distance from source");

    //        for (int i = 0; i < verticesCount; ++i)
    //            Console.WriteLine("{0}\t  {1}", i, distance[i]);
    //    }

    //    public static void DijkstraAlgo(int[,] graph, int source, int verticesCount)
    //    {
    //        int[] distance = new int[verticesCount];
    //        bool[] shortestPathTreeSet = new bool[verticesCount];

    //        for (int i = 0; i < verticesCount; ++i)
    //        {
    //            distance[i] = int.MaxValue;
    //            shortestPathTreeSet[i] = false;
    //        }

    //        distance[source] = 0;

    //        for (int count = 0; count < verticesCount - 1; ++count)
    //        {
    //            int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
    //            shortestPathTreeSet[u] = true;

    //            for (int v = 0; v < verticesCount; ++v)
    //                if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
    //                    distance[v] = distance[u] + graph[u, v];
    //        }

    //        Print(distance, verticesCount);
    //    }

    //    static void Main(string[] args)
    //    {
    //        int[,] graph =  {
    //                      { 0, 6, 0, 0, 0, 0, 0, 9, 0 },
    //                      { 6, 0, 9, 0, 0, 0, 0, 11, 0 },
    //                      { 0, 9, 0, 5, 0, 6, 0, 0, 2 },
    //                      { 0, 0, 5, 0, 9, 16, 0, 0, 0 },
    //                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
    //                      { 0, 0, 6, 0, 10, 0, 2, 0, 0 },
    //                      { 0, 0, 0, 16, 0, 2, 0, 1, 6 },
    //                      { 9, 11, 0, 0, 0, 0, 1, 0, 5 },
    //                      { 0, 0, 2, 0, 0, 0, 6, 5, 0 }
    //                        };

    //        DijkstraAlgo(graph, 0, 9);
    //    }
    //}
    //Need To modify -Dijkstra Algorithm(adjacency List)
    public class Graph
    {
        public class Edge
        {
            public int Source, Destination, Weight;
        }
        int V, E;
        Edge[] edge;
        public Graph(int v, int e)
        {
            V = v; E = e;
            edge = new Edge[E];
            for (int i = 0; i < e; i++)
                edge[i] = new Edge();
        }
        private void Print(int[] distance, int count)
        {
            Console.WriteLine("Vertex   Distance from source");

            for (int i = 0; i < count; ++i)
                Console.WriteLine("{0}\t {1}", i, distance[i]);
        }
        public int minimum(int[] distance, bool[] visited, int vertices)
        {
            int min = int.MaxValue;
            int minIndex = 0;
            for(int v =0; v < vertices; v++)
            {
                if(visited[v] == false && distance[v]<= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }
            return minIndex;
        }
        public void dijkstraAlgo(Graph g, int s)
        {
            int[] distance = new int[V];
            bool[] visited = new bool[V];
            for (int i = 0; i < V; i++) { 
                distance[i] = int.MaxValue;
                visited[i] = false;
            }
            distance[s] = 0;
            for(int count = 0; count<V-1; count++) {
                int min = minimum(distance, visited, V);
                visited[min] = true;
            for (int j = 0; j < V; j++)
            {
                //int v = 0;
                int u = min;
                int v = g.edge[j].Destination;
                int weight = g.edge[j].Weight;
                if (distance[u] + weight < distance[v])
                {
                    distance[v] = distance[u] + weight;
                }
            }
            }
            Print(distance, V);
        }
        static void Main()
        {
            int V = 5;
            int E = 8;
            Graph graph = new Graph(V, E);

           // Edge 0-1
            graph.edge[0].Source = 0;
            graph.edge[0].Destination = 1;
            graph.edge[0].Weight = 10;

            // Edge 0-2
            graph.edge[1].Source = 0;
            graph.edge[1].Destination = 2;
            graph.edge[1].Weight = 5;

            // Edge 1-3
            graph.edge[2].Source = 1;
            graph.edge[2].Destination = 3;
            graph.edge[2].Weight = 1;

            // Edge 2-1
            graph.edge[3].Source = 2;
            graph.edge[3].Destination = 1;
            graph.edge[3].Weight = 3;

            // Edge 2-4
            graph.edge[4].Source = 2;
            graph.edge[4].Destination = 4;
            graph.edge[4].Weight = 2;

            // Edge 4-3
            graph.edge[5].Source = 4;
            graph.edge[5].Destination = 3;
            graph.edge[5].Weight = 6;

            // Edge 2-3
            graph.edge[6].Source = 2;
            graph.edge[6].Destination = 3;
            graph.edge[6].Weight = 9;

            // Edge 4-0
            graph.edge[7].Source = 4;
            graph.edge[7].Destination = 0;
            graph.edge[7].Weight = 2;
            graph.dijkstraAlgo(graph, 0);
        }
    }

}


    //bridges in graph
    //public class Graph
    //{
    //    private int vertex;
    //    int time = 0;
    //    LinkedList<int>[] adj;
    //    static readonly int NIL = -1;
    //    public Graph(int x)
    //    {
    //        vertex = x;
    //        adj = new LinkedList<int>[x];
    //        for (int i = 0; i < x; i++)
    //        {
    //            adj[i] = new LinkedList<int>();
    //        }
    //    }
    //    public void addEdge(int n, int e)
    //    {
    //        adj[n].AddLast(e);
    //        adj[e].AddLast(n);
    //    }
    //    public void bridgeUtil(int u, bool[] visited, int [] disc, int[] low,int[] parent)
    //    {
    //        visited[u] = true;
    //        disc[u] = low[u] = ++time;
    //        foreach(var i in adj[u])
    //        {
    //            int v = i;
    //            if (!visited[i])
    //            {
    //                parent[v] = u;
    //                bridgeUtil(v, visited, disc, low, parent);
    //                low[u] = Math.Min(low[u], low[v]);
    //                if (low[v] > disc[u])
    //                    Console.WriteLine(u + " " + v);
    //            }
    //            else if(v!= parent[u])
    //            {
    //                low[u] = Math.Min(low[u], disc[v]);
    //            }

    //        }
    //    }
    //    public void bridge()
    //    {
    //        var visited = new bool[vertex];
    //        var disc = new int[vertex];
    //        var low = new int[vertex];
    //        var parent = new int[vertex];
    //        for(int i = 0; i < vertex; i++)
    //        {
    //            visited[i] = false;
    //            parent[i] = NIL;
    //        }
    //        for(int x = 0; x<vertex; x++)
    //        {
    //            if (!visited[x])
    //                bridgeUtil(x, visited, disc, low, parent);

    //        }
    //    }
    //    public static void Main()
    //    {
    //        Graph g3 = new Graph(6);
    //        g3.addEdge(0, 1);
    //        g3.addEdge(1, 2);
    //        g3.addEdge(2, 3);
    //        g3.addEdge(3, 4);
    //        g3.addEdge(5, 3);
    //        g3.addEdge(5, 1);

    //        g3.bridge();
    //    }
    //}
    //Connected components
    //public class Graph
    //{
    //    private int vertex;
    //    LinkedList<int>[] adj;
    //    public Graph(int x)
    //    {
    //        vertex = x;
    //        adj = new LinkedList<int>[vertex];
    //        for(int i =0; i<x; i++)
    //        {
    //            adj[i] = new LinkedList<int>();
    //        }
    //    }
    //    public void addEdge(int n, int node)
    //    {
    //        adj[n].AddLast(node);
    //        adj[node].AddLast(n);
    //    }
    //    public void countGraph(int i,bool[] visited)
    //    {
    //        visited[i] = true;
    //        Console.Write(i + " ");
    //        foreach(var val in adj[i])
    //        {
    //            if (!visited[val])
    //                countGraph(val, visited);
    //        }
    //    }
    //    public void connectedGraph()
    //    {
    //        int count = 0;
    //        bool[] visited = new bool[vertex];
    //        for(int i =0; i<vertex; i++)
    //        {
    //            if (!visited[i])
    //            {
    //                countGraph(i, visited);
    //                count++;
    //                Console.WriteLine();
    //            }
    //        }
    //        Console.WriteLine("The total number of components is:" + count);
    //    }
    //    public static void Main()
    //    {
    //        Graph g = new Graph(5); // 5 vertices numbered from 0 to 4  

    //        g.addEdge(1, 0);
    //        g.addEdge(2, 3);
    //        g.addEdge(3, 4);
    //        Console.WriteLine("Following are connected components");
    //        g.connectedGraph();
    //    }
    //}
    //Topological sort
    //public class Graph
    //{
    //    private int vertex;
    //    LinkedList<int>[] adj;
    //    public Graph(int x)
    //    {
    //        vertex = x;
    //        adj = new LinkedList<int>[x];
    //        for (int i = 0; i < x; i++)
    //            adj[i] = new LinkedList<int>();

    //    }
    //    public void addEdge(int n, int e)
    //    {
    //        adj[n].AddLast(e);
    //    }
    //    public void topologicalUtil(int i, bool[] visited, LinkedList<int> list)
    //    {
    //        visited[i] = true;
    //        foreach (var val in adj[i])
    //        {
    //            if (!visited[val])
    //            {
    //                topologicalUtil(val, visited, list);
    //            }
    //        }
    //        list.AddFirst(i);
    //    }
    //    public void topologicalSort()
    //    {
    //        LinkedList<int> list = new LinkedList<int>();
    //        bool[] visited = new bool[vertex];
    //        for (int i = 0; i < vertex; i++)
    //        {
    //            if (!visited[i])
    //            {
    //                topologicalUtil(i, visited, list);
    //            }
    //        }
    //        foreach (var vertices in list)
    //        {
    //            Console.Write(vertices + " ");
    //        }
    //    }
    //    public static void Main()
    //    {
    //        Graph g = new Graph(6);
    //        //g.addEdge(5, 2);
    //        //g.addEdge(5, 0);
    //        //g.addEdge(4, 0);
    //        //g.addEdge(4, 1);
    //        //g.addEdge(2, 3);
    //        //g.addEdge(3, 1);
    //        g.addEdge(0, 2);
    //        g.addEdge(1, 2);
    //        g.addEdge(1, 4);
    //        g.addEdge(2, 4);
    //        g.addEdge(4, 3);
    //        g.addEdge(2, 3);
    //        g.addEdge(4, 5);
    //        g.topologicalSort();
    //    }
    //}
//}

//cycle in directGraph
//class Graph
//{
//    private int vertex;
//    private LinkedList<int>[] adj;

//    Graph(int vertices)
//    {
//        vertex = vertices;
//        adj = new LinkedList<int>[vertices];
//        for (int i = 0; i < vertices; ++i)
//            adj[i] = new LinkedList<int>();
//    }
//    void addEgde(int node, int edge)
//    {
//        adj[node].AddLast(edge); // Add w to v's list.
//    }
//    public bool DFSUtil(int vertex, bool[] visited, bool[] recursiveArr)
//    {
//        visited[vertex] = true;
//        recursiveArr[vertex] = true;

//        for (int i = 0; i < adj[vertex].Count(); i++)
//        {
//            int adjVertex = adj[vertex].ElementAt(i);
//            if (!visited[adjVertex] && DFSUtil(adjVertex, visited, recursiveArr))
//            {
//                return true;
//            }
//            else if (recursiveArr[adjVertex])
//                return true;
//        }
//        recursiveArr[vertex] = false;
//        return false;
//    }

//    bool DFS()
//    {
//        bool[] visited = new bool[vertex];
//        bool[] recursiveArr = new bool[vertex];
//        for (int i = 0; i < vertex; i++)
//        {
//            if (DFSUtil(i, visited, recursiveArr))
//                return true;
//        }
//        return false;

//    }
//    public static void Main()
//    {
//        int vertices = 4;
//        Graph graph = new Graph(vertices);
//        graph.addEgde(0, 1);
//        graph.addEgde(1, 2);
//        graph.addEgde(2, 3);
//        graph.addEgde(3, 1);
//        bool result = graph.DFS();
//        Console.WriteLine("is Cycle present: " + result);

//    }
//}
//Detect Cycle in undirected graph
//    class Graph
//    {
//        public int V, E;
//        public Edge[] edge;

//        public Graph(int nV, int nE)
//        {
//            V = nV;
//            E = nE;
//            edge = new Edge[E];
//            for (int i = 0; i < E; i++)
//            {
//                edge[i] = new Edge();
//            }
//        }
//        public class Edge
//        {
//            public int src, dest;
//        }
//        class subset
//        {
//            public int parent;
//            public int rank;
//        }
//        int find(subset[] subsets, int i)
//        {
//            if (subsets[i].parent != i)
//            {
//                subsets[i].parent = find(subsets, subsets[i].parent);
//            }
//            return subsets[i].parent;
//        }
//        void union(subset[] subsets, int x, int y)
//        {
//            int xRoot = find(subsets, x);
//            int yRoot = find(subsets, y);
//            if (subsets[xRoot].rank < subsets[yRoot].rank)
//                subsets[xRoot].parent = yRoot;
//            else if (subsets[xRoot].rank > subsets[yRoot].rank)
//                subsets[yRoot].parent = xRoot;
//            else
//            {
//                subsets[yRoot].parent = xRoot;
//                subsets[xRoot].rank++;
//            }


//        }
//        int isCycleConnected(Graph graph)
//        {
//            subset[] subsets = new subset[V];
//            for (int i = 0; i < V; ++i)
//                subsets[i] = new subset();

//            Create V subsets with single elements
//            for (int v = 0; v < V; ++v)
//            {
//                subsets[v].parent = v;
//                subsets[v].rank = 0;
//            }
//            for (int e = 0; e < E; e++)
//            {
//                int x = find(subsets, graph.edge[e].src);
//                int y = find(subsets, graph.edge[e].dest);
//                if (x == y)
//                    return 1;
//                union(subsets, x, y);
//            }
//            return 0;
//        }
//        static void Main()
//        {
//            int V = 3, E = 3;
//            Graph graph = new Graph(V, E);
//            graph.edge[0].src = 0;
//            graph.edge[0].dest = 1;

//            add edge 1 - 2
//            graph.edge[1].src = 1;
//            graph.edge[1].dest = 2;

//            add edge 0 - 2
//            graph.edge[2].src = 0;
//            graph.edge[2].dest = 2;
//            int data = graph.isCycleConnected(graph);
//            if (data == 1)
//                Console.WriteLine("Has cycle");
//            else
//                Console.WriteLine("No cycle");

//        }
//    }
//}

// class Program { 
//     static int V= 5;
//     public static int minKey(int[] key, bool[] mstSet)
//     {
//         int min = int.MaxValue; int minIndex = -1;
//         for(int i = 0; i<V; i++)
//         {
//             if(mstSet[i] == false && key[i] < min)
//             {
//                 min = key[i];
//                 minIndex = i;
//             }
//         }
//         return minIndex;
//     }
//     public static void printMst(int[] parent, int[,] graph)
//     {
//         int minCost = 0;
//         for (int i = 1; i < V; i++)
//         {
//             Console.WriteLine(parent[i] + "--" + i + "==" + graph[parent[i], i]);
//             minCost += graph[parent[i], i];
//         }
//         Console.WriteLine("The minimum spanning tree is" + minCost);
//     }
//     public static void primsAlgo(int[,] graph)
//     {
//         int[] parent = new int[V];
//         int[] key = new int[V];
//         bool[] mstSet = new bool[V];
//         for(int i = 0; i<V; i++)
//         {
//             mstSet[i] = false;
//             key[i] = int.MaxValue;
//         }
//         key[0] = 0;
//         parent[0] = -1;
//         for(int x=0; x<V-1; x++)
//         {
//             int u = minKey(key, mstSet);
//             mstSet[u] = true;
//             for(int v = 0; v<V; v++)
//             {
//                 if(graph[u,v]!=0 && mstSet[v] == false && graph[u,v] < key[v])
//                 {
//                     parent[v] = u;
//                     key[v] = graph[u, v];
//                 }
//             }
//         }
//         printMst(parent, graph);
//     }
//public static void Main()
// {
//     int[,] graph = new int[,] { { 0, 2, 0, 6, 0 },
//                                   { 2, 0, 3, 8, 5 },
//                                   { 0, 3, 0, 0, 7 },
//                                   { 6, 8, 0, 0, 9 },
//                                   { 0, 5, 7, 9, 0 } };
//     primsAlgo(graph);
// }
// }
//public class Graph
//{
//    public int vertex;
//    public LinkedList<int>[] adjList;
//    public Graph(int x)
//    {
//        adjList = new LinkedList<int>[x];
//        for (int i = 0; i < x; i++)
//            adjList[i] = new LinkedList<int>();
//        vertex = x;
//    }
//    public void AddEdge(int n, int e)
//    {
//        adjList[n].AddLast(e);
//    }
//    public void DFSUtil(int s, bool[] visited)
//    {
//        visited[s] = true;
//        Console.Write(s + " ");
//        LinkedList<int> list = adjList[s];
//        foreach (var val in list)
//        {
//            if (!visited[val])
//                DFSUtil(val, visited);
//        }
//    }
//    public void DFS(int s)

//    {
//        bool[] visited = new bool[vertex];
//        DFSUtil(s, visited);
//    }

//    static void Main()
//    {
//        Graph g = new Graph(7);

//        g.AddEdge(0, 1);
//        g.AddEdge(0, 3);
//        g.AddEdge(1, 2);
//        g.AddEdge(3, 2);
//        g.AddEdge(2, 4);
//        g.AddEdge(2, 5);
//        g.AddEdge(3, 4);
//        g.AddEdge(4, 6);
//        g.AddEdge(5, 1);
//        g.AddEdge(6, 1);

//        Console.WriteLine(
//            "Following is Depth First Traversal "
//            + "(starting from vertex 2)");

//        g.DFS(0);
//    }
//}
//public class Graph
//{
//    int vertex;
//    LinkedList<int>[] adjList;
//    public Graph(int v)
//    {
//        adjList = new LinkedList<int>[v];
//        for (int i = 0; i < adjList.Length; i++) { 
//            adjList[i] = new LinkedList<int>();
//        }
//        vertex = v;
//    }
//    public void AddEdge(int n, int e)
//    {
//        adjList[n].AddLast(e);
//    }
//    public void BFS(int s)
//    {
//        bool[] visited = new bool[vertex];
//        for (int i = 0; i < vertex; i++)
//            visited[i] = false;
//        visited[s] = true;
//        LinkedList<int> queue = new LinkedList<int>();
//        queue.AddLast(s);
//        while (queue.Any())
//        {
//            s = queue.First();
//            Console.Write(s + " ");
//            queue.RemoveFirst();
//            LinkedList<int> list = adjList[s];
//            foreach(var val in list)
//            {
//                if (!visited[val])
//                {
//                    visited[val] = true;
//                    queue.AddLast(val);
//                }
//            }
//        }

//    }
//    static void Main()
//    {
//        Graph g = new Graph(5);
//        g.AddEdge(0, 1);
//        g.AddEdge(0, 2);
//        g.AddEdge(1, 2);
//        g.AddEdge(2, 3);
//        g.AddEdge(3, 1);
//        g.AddEdge(3, 4);
//        g.AddEdge(4, 1);
//        g.BFS(0);
//    }
//}
//public class Graph
//  {
//      public class Edge :IComparable<Edge>
//      {
//          public int src, dest, weight;
//          public int CompareTo(Edge compareEdge)
//          {
//              return this.weight - compareEdge.weight;
//          }
//      }
//      public class subset
//      {
//          public int parent, rank;
//      }
//      int V, E;
//      Edge[] edge;
//      public Graph(int v, int e)
//      {
//          V = v;E = e;
//          edge = new Edge[E];
//          for (int i = 0; i < e; i++)
//              edge[i] = new Edge();
//      }
//      public int find(subset [] subsets, int i)
//      {
//          if (subsets[i].parent != i)
//              subsets[i].parent = find(subsets, subsets[i].parent);
//              return subsets[i].parent;
//      }
//      public void union (subset[] subsets, int x,int y)
//      {
//          int xroot = find(subsets, x);
//          int yroot = find(subsets, y);
//          if (subsets[xroot].parent < subsets[yroot].parent)
//              subsets[xroot].parent = yroot;
//          else if(subsets[xroot].parent > subsets[yroot].parent)
//              subsets[yroot].parent = xroot;
//          else
//          {
//              subsets[yroot].parent = xroot;
//              subsets[xroot].rank++;
//          }
//      }
//      public void KruskalMST()
//      {
//          Edge[] result = new Edge[V];
//          int e = 0; int i = 0;
//          for (i = 0; i < V; i++)
//              result[i] = new Edge();
//          Array.Sort(edge);

//          subset[] subsets = new subset[V];
//          for (i = 0; i < V; i++)
//              subsets[i] = new subset();
//          for(int v =0; v < V; v++)
//          {
//              subsets[v].parent = v;
//              subsets[v].rank = 0;
//          }
//          i = 0;
//          while (e < V - 1)
//          {
//              Edge nextEdge = new Edge();
//              nextEdge = edge[i++];
//              int x = find(subsets, nextEdge.src);
//              int y = find(subsets, nextEdge.dest);
//              if(x!= y)
//              {
//                  result[e++] = nextEdge;
//                  union(subsets, x, y);
//              }
//          }
//          Console.WriteLine("Minimum spanning tree is :");
//          int minimumCost = 0;
//          for(i =0; i<e; i++)
//          {
//              Console.WriteLine(result[i].src + "--" + result[i].dest + "==" + result[i].weight);
//              minimumCost += result[i].weight;
//          }
//          Console.WriteLine("The minimu cost is :" + minimumCost);
//      }
//      static void Main()
//      {
//          int V = 4;
//          int E = 5;
//          Graph graph = new Graph(V, E);

//          // add edge 0-1
//          graph.edge[0].src = 0;
//          graph.edge[0].dest = 1;
//          graph.edge[0].weight = 10;

//          // add edge 0-2
//          graph.edge[1].src = 0;
//          graph.edge[1].dest = 2;
//          graph.edge[1].weight = 6;

//          // add edge 0-3
//          graph.edge[2].src = 0;
//          graph.edge[2].dest = 3;
//          graph.edge[2].weight = 5;

//          // add edge 1-3
//          graph.edge[3].src = 1;
//          graph.edge[3].dest = 3;
//          graph.edge[3].weight = 15;

//          // add edge 2-3
//          graph.edge[4].src = 2;
//          graph.edge[4].dest = 3;
//          graph.edge[4].weight = 4;

//          graph.KruskalMST();
//      }
//  }

