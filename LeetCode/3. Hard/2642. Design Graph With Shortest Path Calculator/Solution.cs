using System.Collections.Generic;

namespace LeetCode._3._Hard._2642._Design_Graph_With_Shortest_Path_Calculator;

public class Graph
{
    private readonly Dictionary<int, Node> edges = new();

    public Graph(int n, int[][] edges)
    {
        foreach (var edge in edges)
        {
            var from = edge[0];
            var to = edge[1];
            var weight = edge[2];

            if (!this.edges.ContainsKey(from))
            {
                this.edges[from] = new Node();
            }

            this.edges[from].AddEdge(to, weight);
        }
    }

    public int ShortestPath(int from, int to)
    {
        if (from == to)
            return 0;

        if (!edges.ContainsKey(from))
            return -1;

        var minimalPaths = new Dictionary<int, int>();
        var queue = new Queue<(Node, int)>();
        queue.Enqueue((edges[from], 0));

        while (queue.Count != 0)
        {
            var (node, sumWeight) = queue.Dequeue();

            var neighbours = node.Neighbours;
            foreach (var neighbour in neighbours)
            {
                var neighbourTo = neighbour.Key;
                var neighbourWeight = sumWeight + neighbour.Value;

                if (!minimalPaths.ContainsKey(neighbourTo) ||
                    minimalPaths[neighbourTo] > neighbourWeight)
                {
                    minimalPaths[neighbourTo] = neighbourWeight;
                    if (edges.ContainsKey(neighbourTo))
                    {
                        queue.Enqueue((edges[neighbourTo], neighbourWeight));
                    }
                }
            }
        }

        return minimalPaths.ContainsKey(to) ? minimalPaths[to] : -1;
    }

    public void AddEdge(int[] edge)
    {
        var from = edge[0];
        var to = edge[1];
        var weight = edge[2];

        if (!edges.ContainsKey(from))
        {
            edges[from] = new Node();
        }

        edges[from].AddEdge(to, weight);
    }

    public class Node
    {
        // to, weight
        public readonly Dictionary<int, int> Neighbours = new();

        public void AddEdge(int to, int weight)
        {
            Neighbours.Add(to, weight);
        }
    }
}
