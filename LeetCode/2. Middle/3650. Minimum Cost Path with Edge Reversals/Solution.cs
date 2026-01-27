using System.Collections.Generic;

namespace LeetCode._2._Middle._3650._Minimum_Cost_Path_with_Edge_Reversals;

public class Solution
{
    public int MinCost(int n, int[][] edges)
    {
        var graph = CreateGraph(n, edges);
        var visited = new int[n];
        for (var i = 1; i < n; i++)
            visited[i] = -1;

        var queue = new Queue<int>();
        queue.Enqueue(0);

        while (queue.Count > 0)
        {
            var node = graph[queue.Dequeue()];
            var nodeDistance = visited[node.Index];
            if (node.Neighbours != null)
                foreach (var (neighbour, neighbourDistance) in node.Neighbours)
                    if (visited[neighbour.Index] == -1 || visited[neighbour.Index] > nodeDistance + neighbourDistance)
                    {
                        visited[neighbour.Index] = nodeDistance + neighbourDistance;
                        queue.Enqueue(neighbour.Index);
                    }
        }

        return visited[^1];
    }

    private Node[] CreateGraph(int n, int[][] edges)
    {
        var graph = new Node[n];
        for (var i = 0; i < n; i++)
            graph[i] = new Node(i);
        foreach (var edge in edges)
        {
            graph[edge[0]].AddNeighbour(graph[edge[1]], edge[2]);
            graph[edge[1]].AddNeighbour(graph[edge[0]], edge[2] * 2);
        }
        return graph;
    }

    private class Node
    {
        public int Index { get; }
        public LinkedList<(Node Node, int Weight)> Neighbours { get; private set; }

        public Node(int index)
        {
            Index = index;
        }

        public void AddNeighbour(Node node, int weight)
        {
            Neighbours ??= new();
            Neighbours.AddLast((node, weight));
        }
    }
}
