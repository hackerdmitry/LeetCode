using System.Collections.Generic;

namespace LeetCode._2._Middle._216._Combination_Sum_III;

public class Solution
{
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        var result = new List<IList<int>>();

        var queue = new Queue<(Node node, int sum, int left)>();
        for (var i = 1; i <= 9 && i < n; i++)
            queue.Enqueue((new Node(i), i, k - 1));

        while (queue.Count > 0)
        {
            var (node, sum, left) = queue.Dequeue();
            if (left == 0)
            {
                if (sum == n)
                    result.Add(CreateArray(node, k));
            }
            else
                for (var i = node.val + 1; i <= 9 && sum + i <= n; i++)
                    queue.Enqueue((new Node(i, node), sum + i, left - 1));
        }

        return result;
    }

    private int[] CreateArray(Node node, int length)
    {
        var array = new int[length];
        for (var i = length - 1; i >= 0; i--)
        {
            array[i] = node.val;
            node = node.prev;
        }

        return array;
    }

    record Node(int val, Node prev = null);
}