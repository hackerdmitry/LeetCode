using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._39._Combination_Sum;

public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var queueList = new Queue<(Node, int)>();

        var resultList = new List<IList<int>>();
        foreach (var candidate in candidates)
        {
            if (candidate > target)
                break;
            if (candidate == target)
                resultList.Add(new[] {candidate});
            else
                queueList.Enqueue((new Node(candidate), target - candidate));
        }

        while (queueList.Count > 0)
        {
            var (node, leftTarget) = queueList.Dequeue();
            foreach (var candidate in candidates)
            {
                if (candidate > leftTarget)
                    break;
                if (candidate < node.Value)
                    continue;
                if (leftTarget == candidate)
                    resultList.Add(new Node(node, candidate).ToList());
                else
                    queueList.Enqueue((new Node(node, candidate), leftTarget - candidate));
            }
        }

        return resultList;
    }

    private class Node
    {
        public Node PrevNode { get; set; }
        public int Value { get; set; }
        public int Length { get; set; }

        public Node(int value)
        {
            Value = value;
            Length = 1;
        }

        public Node(Node prevNode, int value)
        {
            PrevNode = prevNode;
            Value = value;
            Length = prevNode.Length + 1;
        }

        public IList<int> ToList()
        {
            var resultArray = new int[Length];
            var i = Length - 1;
            var node = this;
            while (node != null)
            {
                resultArray[i--] = node.Value;
                node = node.PrevNode;
            }

            return resultArray;
        }

        public override string ToString()
        {
            return $"[{string.Join(',', ToList())}]";
        }
    }
}