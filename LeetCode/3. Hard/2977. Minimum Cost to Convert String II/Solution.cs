using System.Collections.Generic;

namespace LeetCode._3._Hard._2977._Minimum_Cost_to_Convert_String_II;

public class Solution
{
    public long MinimumCost(string source, string target, string[] original, string[] changed, int[] cost)
    {
        var graph = BuildGraph(original, changed, cost);
        var converts = CreateConverts(source, target, original, graph);
        return FindMinCostsToConvert(source, target, converts);
    }

    private Dictionary<string, Node> BuildGraph(string[] original, string[] changed, int[] cost)
    {
        var graph = new Dictionary<string, Node>();
        var n = original.Length;

        for (var i = 0; i < n; i++)
        {
            if (!graph.ContainsKey(original[i]))
                graph[original[i]] = new Node(original[i]);
            if (!graph.ContainsKey(changed[i]))
                graph[changed[i]] = new Node(changed[i]);

            graph[original[i]].Edges.Add(new Edge(graph[changed[i]], cost[i]));
        }

        return graph;
    }

    private Dictionary<int, List<(int End, long Cost)>> CreateConverts(string source, string target, string[] original, Dictionary<string, Node> graph)
    {
        var converts = new Dictionary<int, List<(int End, long Cost)>>();
        var visited = new HashSet<string>();

        for (var i = 0; i < original.Length; i++)
        {
            var start = source.IndexOf(original[i]);
            if (visited.Add(original[i]))
                while (start != -1)
                {
                    var targetNodeValue = target.Substring(start, original[i].Length);
                    if (original[i] != targetNodeValue && graph.TryGetValue(targetNodeValue, out var targetNode))
                    {
                        var sourceNode = graph[original[i]];
                        var minCostToTargetNode = MinCost(sourceNode, targetNode);
                        if (minCostToTargetNode != -1)
                            if (converts.ContainsKey(start))
                                converts[start].Add((start + original[i].Length - 1, minCostToTargetNode));
                            else
                                converts[start] = new List<(int End, long Cost)>
                                {
                                    (start + original[i].Length - 1, minCostToTargetNode),
                                };
                    }

                    start = source.IndexOf(original[i], start + 1);
                }
        }

        return converts;
    }

    private long MinCost(Node start, Node target)
    {
        var pq = new PriorityQueue<(Node Node, long Cost), long>();
        var minCosts = new Dictionary<string, long>();

        pq.Enqueue((start, 0), 0);
        minCosts[start.Value] = 0;

        while (pq.Count > 0)
        {
            var (currentNode, currentCost) = pq.Dequeue();
            if (currentNode == target)
                return currentCost;

            foreach (var edge in currentNode.Edges)
            {
                var newCost = currentCost + edge.Weight;
                if (!minCosts.ContainsKey(edge.To.Value) || newCost < minCosts[edge.To.Value])
                {
                    minCosts[edge.To.Value] = newCost;
                    pq.Enqueue((edge.To, newCost), newCost);
                }
            }
        }

        return -1;
    }

    private long FindMinCostsToConvert(string source, string target, Dictionary<int, List<(int End, long Cost)>> converts)
    {
        var dp = new long[source.Length + 1];
        for (var i = 1; i < dp.Length; i++)
            dp[i] = -1;

        for (var i = 0; i < source.Length; i++)
        {
            var cost = dp[i];
            if (cost == -1)
                continue;

            if (source[i] == target[i] && (dp[i + 1] == -1 || cost < dp[i + 1]))
                dp[i + 1] = cost;

            if (converts.TryGetValue(i, out var variants))
                foreach (var convert in variants)
                {
                    var newCost = cost + convert.Cost;
                    var endIndex = convert.End + 1;
                    if (dp[endIndex] == -1 || newCost < dp[endIndex])
                        dp[endIndex] = newCost;
                }
        }

        return dp[^1];
    }

    private class Edge
    {
        public Node To { get; }
        public int Weight { get; }

        public Edge(Node to, int weight)
        {
            To = to;
            Weight = weight;
        }
    }

    private class Node
    {
        public string Value { get; }
        public List<Edge> Edges { get; } = new();

        public Node(string value)
        {
            Value = value;
        }
    }
}