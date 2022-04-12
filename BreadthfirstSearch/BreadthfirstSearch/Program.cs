using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Graph
{

    // No. of vertices    
    private int vertex;

    //Adjacency Lists
    LinkedList<int>[] _adj;

    public Graph(int vertices)
    {
        _adj = new LinkedList<int>[vertices];
        for (int i = 0; i < _adj.Length; i++)
        {
            _adj[i] = new LinkedList<int>();
        }
        vertex = vertices;
    }
    // Function to add an edge into the graph
    public void AddEdge(int node, int edge)
    {
        _adj[node].AddLast(edge);
        //_adj[edge].AddLast(node);

    }

    // Prints BFS traversal from a given source s
    public void BFS(int s)
    {

        // Mark all the vertices as not
        // visited(By default set as false)
        bool[] visited = new bool[vertex];
       

        // Create a queue for BFS
        //LinkedList<int> queue = new LinkedList<int>();
        Queue<int> queue = new Queue<int>();
        // Mark the current node as
        // visited and enqueue it
        visited[s] = true;
        queue.Enqueue(s);
        //queue.AddLast(s);

        while (queue.Any())
        {
            // Dequeue a vertex from queue
            // and print it
            s = queue.First();
            Console.Write(s + " ");
            //queue.RemoveFirst();
            queue.Dequeue();
            // Get all adjacent vertices of the
            // dequeued vertex s. If a adjacent
            // has not been visited, then mark it
            // visited and enqueue it
            LinkedList<int> list = _adj[s];

            foreach (var val in list)
            {
                if (!visited[val])
                {
                    visited[val] = true;
                    //queue.AddLast(val);
                    queue.Enqueue(val);
                }
            }
        }
    }

    // Driver code
    static void Main(string[] args)
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



        Console.Write("Following is Breadth First " +
                      "Traversal(starting from " +
                      "vertex 2)\n");
        g.BFS(0);
    }
}