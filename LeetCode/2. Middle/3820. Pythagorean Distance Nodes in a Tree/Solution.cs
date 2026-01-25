using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3820._Pythagorean_Distance_Nodes_in_a_Tree;

public class Solution
{
    public int SpecialNodes(int n, int[][] edges, int x, int y, int z)
    {
        var tree = CreateTree(n, edges);
        CalculateDeltas(tree[x], (prev, node) => node.DX = prev.DX + 1);
        CalculateDeltas(tree[y], (prev, node) => node.DY = prev.DY + 1);
        CalculateDeltas(tree[z], (prev, node) => node.DZ = prev.DZ + 1);
        return tree.Count(node => node.IsSpecial());
    }

    private Node[] CreateTree(int n, int[][] edges)
    {
        var tree = new Node[n];
        for (var i = 0; i < n; i++)
            tree[i] = new Node(i);

        foreach (var edge in edges)
        {
            var u = edge[0];
            var v = edge[1];
            tree[u].AddNeighbour(tree[v]);
            tree[v].AddNeighbour(tree[u]);
        }

        return tree;
    }

    private void CalculateDeltas(Node node, Action<Node, Node> incrementDelta)
    {
        var queue = new Queue<(Node prev, Node curr)>();
        queue.Enqueue((node, node));

        while (queue.Count > 0)
        {
            var (prev, curr) = queue.Dequeue();
            foreach (var neighbour in curr.Neighbours)
                if (neighbour != prev)
                {
                    incrementDelta(curr, neighbour);
                    queue.Enqueue((curr, neighbour));
                }
        }
    }

    private class Node
    {
        private int Index { get; }

        public int DX { get; set; }
        public int DY { get; set; }
        public int DZ { get; set; }

        public LinkedList<Node> Neighbours { get; set; } = new();

        public Node(int index)
        {
            Index = index;
        }

        public void AddNeighbour(Node child)
        {
            Neighbours.AddLast(child);
        }

        public bool IsSpecial()
        {
            if (DX >= DY && DX >= DZ)
                return DX * DX == DY * DY + DZ * DZ;

            if (DY >= DX && DY >= DZ)
                return DY * DY == DX * DX + DZ * DZ;

            return DZ * DZ == DX * DX + DY * DY;
        }

        public override string ToString()
        {
            return Index.ToString();
        }
    }
}