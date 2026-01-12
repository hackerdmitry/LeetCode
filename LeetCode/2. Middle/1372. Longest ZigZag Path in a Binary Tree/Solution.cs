using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._1372._Longest_ZigZag_Path_in_a_Binary_Tree;

public class Solution
{
    public int LongestZigZag(TreeNode root)
    {
        var result = 0;
        var queue = new Queue<(TreeNode, From, int)>();
        if (root.left != null)
            queue.Enqueue((root.left, From.Left, 1));
        if (root.right != null)
            queue.Enqueue((root.right, From.Right, 1));

        while (queue.Count > 0)
        {
            var (node, from, depth) = queue.Dequeue();
            if (depth > result)
                result = depth;
            if (node.left != null)
                queue.Enqueue((node.left, From.Left, from == From.Right ? depth + 1 : 1));
            if (node.right != null)
                queue.Enqueue((node.right, From.Right, from == From.Left ? depth + 1 : 1));
        }

        return result;
    }

    private enum From
    {
        Left = 1,
        Right = 2,
    }
}
