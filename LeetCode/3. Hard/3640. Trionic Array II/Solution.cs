using System;
using System.Collections.Generic;

namespace LeetCode._3._Hard._3640._Trionic_Array_II;

public class Solution
{
    public long MaxSumTrionic(int[] nums)
    {
        var nodes = CreateNodes(nums);
        var maxSum = long.MinValue;
        foreach (var decreasingNode in GetDecreasingNodes(nodes))
            maxSum = Math.Max(maxSum, CalculateMaxSumAroundIncreasingNodes(decreasingNode));
        return maxSum;
    }

    private LinkedList<Node> CreateNodes(int[] nums)
    {
        var nodes = new LinkedList<Node>();
        nodes.AddLast(new Node(nums[0], State.None));

        for (var i = 1; i < nums.Length; i++)
        {
            var state = GetState(nums[i - 1], nums[i]);
            if (state == State.Decreasing && nodes.Last!.Value.State == State.Decreasing)
                nodes.Last.Value.Value += nums[i];
            else
                nodes.AddLast(new Node(nums[i], state, nums[i - 1]));
        }

        return nodes;
    }

    private State GetState(int prevValue, int currentValue)
    {
        if (currentValue > prevValue)
            return State.Increasing;

        if (currentValue < prevValue)
            return State.Decreasing;

        return State.None;
    }

    private IEnumerable<LinkedListNode<Node>> GetDecreasingNodes(LinkedList<Node> nodes)
    {
        var node = nodes.First;
        while (node != null)
        {
            if (node.Value.State == State.Decreasing)
                yield return node;
            node = node.Next;
        }
    }

    private long CalculateMaxSumAroundIncreasingNodes(LinkedListNode<Node> decreasingNode)
    {
        if (decreasingNode.Previous == null || decreasingNode.Previous.Value.State != State.Increasing ||
            decreasingNode.Next == null || decreasingNode.Next.Value.State != State.Increasing)
            return long.MinValue;

        var leftNode = decreasingNode.Previous;
        var maxLeftSum = (long) leftNode.Value.Value + leftNode.Value.PrevValue!.Value;
        var leftSum = (long) leftNode.Value.Value + (leftNode = leftNode.Previous)!.Value.Value;
        if (leftNode.Value.State == State.Increasing)
        {
            maxLeftSum = Math.Max(maxLeftSum, leftSum);
            leftNode = leftNode.Previous;
            while (leftNode != null && leftNode.Value.State == State.Increasing)
            {
                leftSum += leftNode.Value.Value;
                maxLeftSum = Math.Max(maxLeftSum, leftSum);
                leftNode = leftNode.Previous;
            }

            if (leftNode != null)
            {
                leftSum += leftNode.Next!.Value.PrevValue!.Value;
                maxLeftSum = Math.Max(maxLeftSum, leftSum);
            }
        }

        var rightNode = decreasingNode.Next;
        var rightSum = 0L;
        var maxRightSum = long.MinValue;
        while (rightNode != null && rightNode.Value.State == State.Increasing)
        {
            rightSum += rightNode.Value.Value;
            maxRightSum = Math.Max(maxRightSum, rightSum);
            rightNode = rightNode.Next;
        }

        return maxLeftSum + maxRightSum + decreasingNode.Value.Value;
    }

    private class Node
    {
        public int? PrevValue { get; set; }
        public long Value { get; set; }
        public State State { get; set; }

        public Node(long value, State state, int? prevValue = null)
        {
            Value = value;
            State = state;
            PrevValue = state == State.Increasing ? prevValue : null;
        }
    }

    private enum State
    {
        None = 1,
        Increasing = 2,
        Decreasing = 3,
    }
}