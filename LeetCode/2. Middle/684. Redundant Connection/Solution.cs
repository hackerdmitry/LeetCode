using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._684._Redundant_Connection;

public class Solution
{
    public int[] FindRedundantConnection(int[][] rawEdges)
    {
        var nodes = Enumerable.Range(0, rawEdges.Length).Select(_ => new Node()).ToArray();
        var treeNumber = 1;

        foreach (var rawEdge in rawEdges)
        {
            var node1 = rawEdge[0] - 1;
            var node2 = rawEdge[1] - 1;

            if (nodes[node1].IsVisited && nodes[node2].IsVisited)
                if (nodes[node1].TreeNumber == nodes[node2].TreeNumber)
                    return rawEdge;
                else
                    ChangeTreeNumber(nodes, node2, nodes[node1].TreeNumber);
            else
            {
                var localTreeNumber = Math.Max(nodes[node1].TreeNumber, nodes[node2].TreeNumber);
                if (localTreeNumber > 0)
                {
                    nodes[node1].TreeNumber = localTreeNumber;
                    nodes[node2].TreeNumber = localTreeNumber;
                }
                else
                {
                    nodes[node1].TreeNumber = treeNumber;
                    nodes[node2].TreeNumber = treeNumber++;
                }
            }

            var edge = new Edge(rawEdge);
            nodes[edge.Node1].Edges.AddLast(edge);
            nodes[edge.Node2].Edges.AddLast(edge);
        }

        return Array.Empty<int>();
    }

    private void ChangeTreeNumber(Node[] nodes, int startNodeIndex, int treeNumber)
    {
        var queue = new Queue<int>();
        queue.Enqueue(startNodeIndex);

        while (queue.Count > 0)
        {
            var nodeIndex = queue.Dequeue();
            var node = nodes[nodeIndex];
            foreach (var edge in node.Edges)
            {
                var neighbourIndex = edge.To(nodeIndex);
                var neighbour = nodes[neighbourIndex];
                if (neighbour.TreeNumber != treeNumber)
                {
                    queue.Enqueue(neighbourIndex);
                    neighbour.TreeNumber = treeNumber;
                }
            }
        }
    }

    private class Edge
    {
        public int Node1 { get; }
        public int Node2 { get; }

        public Edge(int[] edge)
        {
            Node1 = edge[0] - 1;
            Node2 = edge[1] - 1;
        }

        public int To(int sourceNode)
        {
            return sourceNode == Node1 ? Node2 : Node1;
        }
    }

    private class Node
    {
        public int TreeNumber { get; set; }
        public bool IsVisited => TreeNumber != 0;
        public LinkedList<Edge> Edges { get; } = new();
    }
}