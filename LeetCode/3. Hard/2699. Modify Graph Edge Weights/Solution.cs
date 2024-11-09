using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._2699._Modify_Graph_Edge_Weights;

public class Solution
{
    private const int maxValue = 2_000_000_000;

    public int[][] ModifiedGraphEdges(int n, int[][] edges, int source, int destination, int target)
    {
        var map = CreateMap(n, edges);
        var pathWithoutUnknown = TryStepToDestinationWithoutUnknownRoads(map, source, destination);
        if (pathWithoutUnknown != null && pathWithoutUnknown.SpentDistance < target)
            return Array.Empty<int[]>();

        InitTargets(target, map[destination], map[source]);

        var pathWithUnknown = TryStepToDestinationWithUnknownRoads(map, source, destination);
        if (pathWithUnknown.SpentDistance > target)
            return Array.Empty<int[]>();

        foreach (var unknownRoad in map.UnknownRoads)
            if (unknownRoad.Weight == -1)
                unknownRoad.Weight = maxValue;

        return map.CreateEdges();
    }

    private Map CreateMap(int n, int[][] edges)
    {
        var map = new Map();

        for (var i = 0; i < n; i++)
            map.Nodes[i] = new Node(i);

        foreach (var edge in edges)
        {
            var node1 = map.Nodes[edge[0]];
            var node2 = map.Nodes[edge[1]];
            var road = new Road(node1, node2, edge[2]);
            node1.Roads.AddLast(road);
            node2.Roads.AddLast(road);
            map.AllRoads.Add(road);
            if (road.Weight == -1)
                map.UnknownRoads.Add(road);
        }

        return map;
    }

    private Path TryStepToDestinationWithoutUnknownRoads(Map map, int start, int end)
    {
        var queue = new Queue<Path>();
        var startPath = new Path(map[start], 0);
        queue.Enqueue(startPath);

        var fastestPaths = new Dictionary<int, Path> { [start] = startPath };
        while (queue.Count > 0)
        {
            var currPath = queue.Dequeue();
            foreach (var neighbour in currPath.Node.GetNeighbours())
                if (!neighbour.Road.IsUnknown &&
                    (!fastestPaths.ContainsKey(neighbour.Node.Index) ||
                     fastestPaths[neighbour.Node.Index].SpentDistance > currPath.SpentDistance + neighbour.Weight))
                {
                    var fastestPath = new Path(neighbour.Node, currPath.SpentDistance + neighbour.Weight, currPath);
                    fastestPaths[neighbour.Node.Index] = fastestPath;
                    queue.Enqueue(fastestPath);
                }
        }

        return fastestPaths.GetValueOrDefault(end);
    }

    private Path TryStepToDestinationWithUnknownRoads(Map map, int start, int end)
    {
        var queue = new Queue<Path>();
        var startPath = new Path(map[start], 0);
        queue.Enqueue(startPath);

        var fastestPaths = new Dictionary<int, Path> { [start] = startPath };
        while (queue.Count > 0)
        {
            var currPath = queue.Dequeue();
            foreach (var (neighbourNode, weight, road) in currPath.Node.GetNeighbours())
            {
                var neighbourWeight = weight;
                if (road.IsUnknown)
                    if (neighbourNode.Target != -1)
                        if (neighbourNode.Target > currPath.SpentDistance)
                            neighbourWeight = neighbourNode.Target - currPath.SpentDistance;
                        else
                            neighbourWeight = maxValue;
                    else
                        neighbourWeight = 1;

                try
                {
                    checked
                    {
                        if (!fastestPaths.ContainsKey(neighbourNode.Index) ||
                            fastestPaths[neighbourNode.Index].SpentDistance >= currPath.SpentDistance + neighbourWeight)
                        {
                            var fastestPath = new Path(neighbourNode, currPath.SpentDistance + neighbourWeight, currPath);
                            fastestPaths[neighbourNode.Index] = fastestPath;
                            road.Weight = neighbourWeight;
                            queue.Enqueue(fastestPath);
                        }
                    }
                }
                catch { }
            }
        }

        return fastestPaths.GetValueOrDefault(end);
    }

    private void InitTargets(int target, Node startNode, Node untargetNode)
    {
        startNode.Target = target;

        var queue = new Queue<Node>();
        queue.Enqueue(startNode);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            foreach (var (neighbourNode, weight, road) in node.GetNeighbours())
                if (weight != -1 && neighbourNode.Target == -1 && node.Target > weight && neighbourNode != untargetNode)
                {
                    neighbourNode.Target = node.Target - weight;
                    queue.Enqueue(neighbourNode);
                }
        }
    }

    class Path
    {
        public Node Node { get; init; }
        public int SpentDistance { get; init; }
        public Path Prev { get; init; }

        public Path(Node node, int spentDistance, Path prev = null)
        {
            Node = node;
            SpentDistance = spentDistance;
            Prev = prev;
        }
    }

    class Map
    {
        public Dictionary<int, Node> Nodes { get; init; } = new();
        public List<Road> AllRoads { get; init; } = new();
        public List<Road> UnknownRoads { get; init; } = new();

        public Node this[int index] => Nodes[index];

        public int[][] CreateEdges() =>
            AllRoads.Select(road => new[] { road.Node1.Index, road.Node2.Index, road.Weight }).ToArray();
    }

    class Node
    {
        public int Index { get; init; }
        public int Target { get; set; } = -1;
        public LinkedList<Road> Roads { get; init; } = new();

        public Node(int index)
        {
            Index = index;
        }

        public IEnumerable<(Node Node, int Weight, Road Road)> GetNeighbours() =>
            Roads.Select(road => (road.GetDestination(this), road.Weight, road));

        public override string ToString() =>
            $"{Index}({Target}) Roads to [{string.Join(", ", GetNeighbours().Select(x => x.Node.Index))}]";
    }

    class Road
    {
        public Node Node1 { get; }
        public Node Node2 { get; }

        public bool IsUnknown { get; init; }
        public int Weight { get; set; }

        public Road(Node node1, Node node2, int weight)
        {
            Node1 = node1;
            Node2 = node2;
            Weight = weight;
            IsUnknown = weight == -1;
        }

        public Node GetDestination(Node sourceNode) =>
            sourceNode == Node1 ? Node2 : Node1;

        public override string ToString() =>
            $"{Node1.Index}-{Node2.Index}: {(IsUnknown ? "?" : "")}{Weight}";
    }
}