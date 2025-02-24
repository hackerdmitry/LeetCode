using System.Collections.Generic;

namespace LeetCode._2._Middle._2467._Most_Profitable_Path_in_a_Tree;

public class Solution
{
    public int MostProfitablePath(int[][] edges, int bob, int[] amount)
    {
        var map = CreateMap(edges, amount);
        BobDFS(map[bob]);
        return GetMaxNetIncomeOfAlice(map[0]);
    }

    private Dictionary<int, Node> CreateMap(int[][] edges, int[] amount)
    {
        var map = new Dictionary<int, Node>(amount.Length);
        for (var i = 0; i < amount.Length; i++)
            map[i] = new Node
            {
                Index = i,
                Amount = amount[i],
            };
        foreach (var edge in edges)
        {
            map[edge[0]].Neighbours.AddLast(map[edge[1]]);
            map[edge[1]].Neighbours.AddLast(map[edge[0]]);
        }

        return map;
    }

    private void BobDFS(Node bobStartNode)
    {
        var bobTrail = GetBobTrailDFS(bobStartNode);
        while (bobTrail != null)
        {
            bobTrail.Node.BobStep = bobTrail.Length - 1;
            bobTrail = bobTrail.Prev;
        }
    }

    private Trail GetBobTrailDFS(Node bobStartNode)
    {
        var queue = new Queue<Trail>();
        queue.Enqueue(new Trail(bobStartNode));

        while (queue.Count > 0)
        {
            var trail = queue.Dequeue();
            if (trail.Node.Index == 0)
                return trail;

            foreach (var neighbour in trail.Node.Neighbours)
                if (trail.Prev == null || trail.Prev.Node.Index != neighbour.Index)
                    queue.Enqueue(new Trail(neighbour, trail));
        }

        return null;
    }

    private int GetMaxNetIncomeOfAlice(Node aliceStartNode)
    {
        var maxNetIncome = int.MinValue;
        var queue = new Queue<(Node, Node, int, int)>();
        queue.Enqueue((aliceStartNode, null, 0, 0));

        while (queue.Count > 0)
        {
            var (node, prevNode, prevAmount, step) = queue.Dequeue();
            var amount = prevAmount + (step == node.BobStep
                ? node.Amount / 2
                : step < node.BobStep
                    ? node.Amount
                    : 0);
            if (node.Index != 0 && node.Neighbours.Count == 1 && amount > maxNetIncome)
                maxNetIncome = amount;
            foreach (var neighbour in node.Neighbours)
                if (prevNode == null || prevNode.Index != neighbour.Index)
                    queue.Enqueue((neighbour, node, amount, step + 1));
        }

        return maxNetIncome;
    }

    private class Node
    {
        public int Index { get; set; }
        public LinkedList<Node> Neighbours { get; set; } = new();
        public int Amount { get; set; }
        public int BobStep { get; set; } = int.MaxValue;
    }

    private class Trail
    {
        public Node Node { get; }
        public Trail Prev { get; }
        public int Length { get; }

        public Trail(Node node, Trail prev = null)
        {
            Node = node;
            Length = (prev?.Length ?? 0) + 1;
            Prev = prev;
        }
    }
}