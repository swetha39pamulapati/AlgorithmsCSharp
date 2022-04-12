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


    }

    public bool BFS(int s)
    {

        bool[] visited = new bool[vertex];
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
                if (!visited[val])
                {
                    visited[val] = true;
                    //queue.AddLast(val);
                    queue.Enqueue(val);
                }
                else
                {
                    return true;
                }
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

        bool data = g.BFS(0);
        if (data == true)
            Console.WriteLine("Has cycle");
        else
            Console.WriteLine("No cycle");
    }
}