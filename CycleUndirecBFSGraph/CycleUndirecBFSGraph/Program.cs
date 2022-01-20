using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Graph
{

    private int vertex;

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
    public void AddEdge(int node, int edge)
    {
        _adj[node].AddLast(edge);
        _adj[edge].AddLast(node);

    }
    public bool BFSUtil(LinkedList<int>[] _adj, int s, int vertex, bool[] visited)
    {
        int[] parent = new int[vertex];
        for (int i = 0; i < vertex; i++)
            parent[i] = -1;
        Queue<int> queue = new Queue<int>();
        //LinkedList<int> queue = new LinkedList<int>();
        visited[s] = true;
        //queue.AddLast(s);
        queue.Enqueue(s);

        while (queue.Count() != 0)
        {
            s = queue.First();
            //queue.RemoveFirst();
            queue.Dequeue();
            LinkedList<int> list = _adj[s];

            foreach (var val in list)
            {
                //int v =_-adj[s][i];
                if (!visited[val])
                {
                    visited[val] = true;
                    //queue.AddLast(val);
                    queue.Enqueue(val);
                    parent[val] = s;
                }
                else
                {
                    return true;
                }
            }
        }
        return false;
    }
    public bool BFS()
    {

        bool[] visited = new bool[vertex];
        for (int i = 0; i < vertex; i++)
        {
            if (!visited[i] && BFSUtil(_adj, i, vertex, visited))
            {
                return true;
            }


        }
        return false;
    }

    static void Main(string[] args)
    {
        Graph g = new Graph(4);

        g.AddEdge(0, 1);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);

        bool data = g.BFS();
        if (data == true)
            Console.WriteLine("Has cycle");
        else
            Console.WriteLine("No cycle");
    }
}
