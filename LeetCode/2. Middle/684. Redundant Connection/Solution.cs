using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._684._Redundant_Connection;

public class Solution
{
    public int[] FindRedundantConnection(int[][] edges)
    {
        var nodes = CreateNodes(edges);
        var suspectNodes = nodes.Values.Where(x => x.Neighbours.Count > 2).ToArray();
        switch (suspectNodes.Length)
        {
            case 0:
                return edges.Last();
            case 1:
                var suitableResult = GetSuitableResult(suspectNodes[0]);
                return edges.Last(x => suitableResult.Contains((x[0], x[1])));
            default:
                return suspectNodes[0].Index < suspectNodes[1].Index
                    ? new[] {suspectNodes[0].Index, suspectNodes[1].Index}
                    : new[] {suspectNodes[1].Index, suspectNodes[0].Index};
        }
    }

    private Dictionary<int, Node> CreateNodes(int[][] edges)
    {
        var nodes = new Dictionary<int, Node>();
        for (var i = 1; i <= edges.Length; i++)
            nodes[i] = new Node(i);
        foreach (var edge in edges)
        {
            nodes[edge[0]].Neighbours.AddLast(nodes[edge[1]]);
            nodes[edge[1]].Neighbours.AddLast(nodes[edge[0]]);
        }

        return nodes;
    }

    private HashSet<(int, int)> GetSuitableResult(Node suspectNode)
    {
        var nodeFrom = suspectNode;
        var nodeTo = IsLeadsToCircle(nodeFrom, suspectNode.Neighbours.First!.Value)
            ? suspectNode.Neighbours.First!.Value
            : suspectNode.Neighbours.Last!.Value;

        var suitableResult = new HashSet<(int, int)> {CreateTupleNodeIndexes(nodeFrom, nodeTo)};
        while (nodeTo.Neighbours.Count != 3)
        {
            var nodeTemp = nodeTo;
            nodeTo = nodeTo.Neighbours.First!.Value.Index == nodeFrom.Index
                ? nodeTo.Neighbours.Last!.Value
                : nodeTo.Neighbours.First!.Value;
            nodeFrom = nodeTemp;
            suitableResult.Add(CreateTupleNodeIndexes(nodeFrom, nodeTo));
        }

        return suitableResult;
    }

    private (int, int) CreateTupleNodeIndexes(Node nodeFrom, Node nodeTo) =>
        nodeFrom.Index < nodeTo.Index
            ? (nodeFrom.Index, nodeTo.Index)
            : (nodeTo.Index, nodeFrom.Index);

    private bool IsLeadsToCircle(Node nodeFrom, Node nodeTo)
    {
        while (nodeTo.Neighbours.Count == 2)
        {
            var nodeTemp = nodeTo;
            nodeTo = nodeTo.Neighbours.First!.Value.Index == nodeFrom.Index
                ? nodeTo.Neighbours.Last!.Value
                : nodeTo.Neighbours.First!.Value;
            nodeFrom = nodeTemp;
        }

        return nodeTo.Neighbours.Count == 3;
    }

    private class Node
    {
        public int Index { get; set; }
        public LinkedList<Node> Neighbours { get; set; }

        public Node(int index)
        {
            Index = index;
            Neighbours = new LinkedList<Node>();
        }

        public override string ToString()
        {
            return $"{Index}: to=[{string.Join(", ", Neighbours.Select(x => x.Index))}]";
        }
    }
}
