using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2597._The_Number_of_Beautiful_Subsets;

public class Solution
{
    public int BeautifulSubsets(int[] nums, int k)
    {
        var count = nums.Length;
        var queue = new Queue<Node>();
        for (var i = 0; i < nums.Length; i++)
            queue.Enqueue(new Node(i, nums[i]));

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            for (var i = node.Index + 1; i < nums.Length; i++)
                if (CanAdd(node, nums[i], k))
                {
                    queue.Enqueue(new Node(i, nums[i], node));
                    count++;
                }
        }

        return count;
    }

    private bool CanAdd(Node node, int value, int k)
    {
        while (node != null)
        {
            if (Math.Abs(node.Value - value) == k)
                return false;
            node = node.Prev;
        }

        return true;
    }

    class Node
    {
        public int Index { get; set; }
        public int Value { get; set; }
        public Node Prev { get; set; }

        public Node(int index, int value, Node prev = null)
        {
            Index = index;
            Value = value;
            Prev = prev;
        }
    }
}