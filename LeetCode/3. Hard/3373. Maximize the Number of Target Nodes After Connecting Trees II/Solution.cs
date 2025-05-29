using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._3373._Maximize_the_Number_of_Target_Nodes_After_Connecting_Trees_II;

public class Solution
{
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2)
    {
        var tree1 = CreateTree(edges1);
        var tree2 = CreateTree(edges2);

        var (even1, odd1) = CountTargetNodes(tree1);
        var (even2, odd2) = CountTargetNodes(tree2);

        var additionalTargetCount = Math.Max(even2, odd2);
        var both1 = even1 + odd1 + additionalTargetCount;
        even1 += additionalTargetCount;
        odd1 += additionalTargetCount;

        return tree1.Select(x => x.Type switch
            {
                NodeType.Even => even1,
                NodeType.Odd => odd1,
                _ => both1
            })
            .ToArray();
    }

    private (int even, int odd) CountTargetNodes(Node[] tree)
    {
        var even = 0;
        var odd = 0;

        var queue = new Queue<Node>();
        if (TryPaintNode(tree[0], NodeType.Odd, ref even, ref odd))
            queue.Enqueue(tree[0]);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            foreach (var neighbour in current.Neighbours)
                if (TryPaintNode(neighbour, current.Type, ref even, ref odd))
                    queue.Enqueue(neighbour);
        }

        return (even, odd);
    }

    private bool TryPaintNode(Node node, NodeType prevNodeType, ref int even, ref int odd)
    {
        switch (prevNodeType)
        {
            case NodeType.Even:
                return TryPaintOdd(node, ref odd);
            case NodeType.Odd:
                return TryPaintEven(node, ref even);
            case NodeType.Both:
                return node.Type == NodeType.Even
                    ? TryPaintOdd(node, ref odd)
                    : TryPaintEven(node, ref even);
            default:
                return false;
        }
    }

    private bool TryPaintEven(Node node, ref int even)
    {
        switch (node.Type)
        {
            case NodeType.None:
                even++;
                node.Type = NodeType.Even;
                return true;
            case NodeType.Odd:
                even++;
                node.Type = NodeType.Both;
                return true;
            default:
                return false;
        }
    }

    private bool TryPaintOdd(Node node, ref int odd)
    {
        switch (node.Type)
        {
            case NodeType.None:
                odd++;
                node.Type = NodeType.Odd;
                return true;
            case NodeType.Even:
                odd++;
                node.Type = NodeType.Both;
                return true;
            default:
                return false;
        }
    }

    private Node[] CreateTree(int[][] edges)
    {
        var tree = new Node[edges.Length + 1];
        for (var i = 0; i < tree.Length; i++)
            tree[i] = new Node(i);

        foreach (var edge in edges)
        {
            tree[edge[0]].Neighbours.Add(tree[edge[1]]);
            tree[edge[1]].Neighbours.Add(tree[edge[0]]);
        }

        return tree;
    }

    private class Node
    {
        public int Id { get; set; }
        public List<Node> Neighbours { get; set; } = new();
        public NodeType Type { get; set; }

        public Node(int id)
        {
            Id = id;
        }
    }

    private enum NodeType
    {
        None,
        Even,
        Odd,
        Both,
    }
}