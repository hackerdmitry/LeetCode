using System.Collections.Generic;

namespace LeetCode._2._Middle._2976._Minimum_Cost_to_Convert_String_I;

public class Solution
{
    public long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost)
    {
        var map = CreateMap(original, changed, cost);
        var minimumCosts = CreateMinimumCosts(map);
        return CalculateMinTransform(source, target, minimumCosts);
    }

    private Dictionary<char, Node> CreateMap(char[] original, char[] changed, int[] cost)
    {
        var map = new Dictionary<char, Node>();
        var length = original.Length;

        for (var i = 0; i < length; i++)
        {
            if (!map.TryGetValue(changed[i], out var destinationNode))
            {
                destinationNode = new Node(changed[i]);
                map[changed[i]] = destinationNode;
            }

            var road = new Road(cost[i], destinationNode);

            if (!map.TryGetValue(original[i], out var sourceNode))
            {
                sourceNode = new Node(original[i]);
                map[original[i]] = sourceNode;
            }

            sourceNode.Neighbours.Add(road);
        }

        return map;
    }

    private int[,] CreateMinimumCosts(Dictionary<char, Node> map)
    {
        var minimumCosts = new int[26,26];
        for (var i = 0; i < 26; i++)
            for (var j = 0; j < 26; j++)
                minimumCosts[i,j] = i == j ? 0 : -1;

        var queue = new Queue<(Node, int)>();
        for (var startNodeValue = 'a'; startNodeValue <= 'z'; startNodeValue++)
        {
            if (!map.TryGetValue(startNodeValue, out var startNode))
                continue;

            var from = startNodeValue - 'a';

            queue.Enqueue((startNode, 0));
            while (queue.Count > 0)
            {
                var (node, totalCost) = queue.Dequeue();
                foreach (var (cost, neighbourNode) in node.Neighbours)
                {
                    var to = neighbourNode.Name - 'a';
                    var toNeighbourCost = totalCost + cost;
                    if (minimumCosts[from, to] == -1 || toNeighbourCost < minimumCosts[from, to])
                    {
                        queue.Enqueue((neighbourNode, toNeighbourCost));
                        minimumCosts[from, to] = toNeighbourCost;
                    }
                }
            }
        }

        return minimumCosts;
    }

    private long CalculateMinTransform(string source, string target, int[,] minimumCosts)
    {
        var length = source.Length;
        var resultCost = 0L;
        for (var i = 0; i < length; i++)
        {
            var from = source[i] - 'a';
            var to = target[i] - 'a';
            var cost = minimumCosts[from, to];

            if (cost == -1)
                return -1;

            resultCost += cost;
        }

        return resultCost;
    }

    class Node
    {
        public char Name { get; init; }
        public List<Road> Neighbours { get; init; } = new();

        public Node(char name)
        {
            Name = name;
        }
    }

    record Road(int Cost, Node Node);
}
