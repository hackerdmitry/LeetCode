using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._3108._Minimum_Cost_Walk_in_Weighted_Graph;

public class Solution
{
    private const int maxValue = 0b1_1111_1111_1111_1111;

    public int[] MinimumCost(int n, int[][] edges, int[][] query)
    {
        var map = CreateMap(n, edges);
        var minifiedMap = MinifyMap(map);
        return AnswerQuery(minifiedMap, query);
    }

    private Node[] CreateMap(int n, int[][] edges)
    {
        var map = Enumerable.Range(0, n).Select(id => new Node(id)).ToArray();
        foreach (var edge in edges)
        {
            map[edge[0]].Neighbours.Add(new Edge(map[edge[1]], edge[2]));
            map[edge[1]].Neighbours.Add(new Edge(map[edge[0]], edge[2]));
        }

        return map;
    }

    private MinifiedBag[] MinifyMap(Node[] map)
    {
        var countVisited = 0;
        var visited = new bool[map.Length];
        var lastVisited = -1;
        var queueBFS = new Queue<int>();

        var minifiedMap = new MinifiedBag[map.Length];
        while (countVisited < map.Length)
        {
            for (lastVisited++; visited[lastVisited]; lastVisited++) ;
            var localBag = new MinifiedBag(maxValue);
            localBag.NodeIds.Add(lastVisited);

            visited[lastVisited] = true;
            countVisited++;
            queueBFS.Enqueue(lastVisited);
            minifiedMap[lastVisited] = localBag;

            while (queueBFS.Count > 0)
            {
                var node = map[queueBFS.Dequeue()];
                foreach (var edge in node.Neighbours)
                {
                    localBag.Weight &= edge.Weight;
                    if (visited[edge.Node.Id])
                        continue;
                    queueBFS.Enqueue(edge.Node.Id);
                    visited[edge.Node.Id] = true;
                    countVisited++;
                    minifiedMap[edge.Node.Id] = localBag;
                    localBag.NodeIds.Add(edge.Node.Id);
                }
            }
        }

        return minifiedMap;
    }

    private int[] AnswerQuery(MinifiedBag[] minifiedMap, int[][] query)
    {
        var answer = new int[query.Length];
        for (var i = 0; i < query.Length; i++)
        {
            var minifiedBag = minifiedMap[query[i][0]];
            answer[i] = minifiedBag.NodeIds.Contains(query[i][1])
                ? minifiedBag.Weight
                : -1;
        }

        return answer;
    }

    private class MinifiedBag
    {
        public HashSet<int> NodeIds { get; set; } = new();
        public int Weight { get; set; }

        public MinifiedBag(int weight)
        {
            Weight = weight;
        }
    }

    private class Edge
    {
        public Node Node { get; set; }
        public int Weight { get; set; }

        public Edge(Node node, int weight)
        {
            Node = node;
            Weight = weight;
        }
    }

    private class Node
    {
        public int Id { get; set; }
        public List<Edge> Neighbours { get; set; } = new();

        public Node(int id)
        {
            Id = id;
        }
    }
}
