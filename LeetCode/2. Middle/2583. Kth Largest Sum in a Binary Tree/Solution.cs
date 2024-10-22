using System.Collections.Generic;
using System.Linq;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._2583._Kth_Largest_Sum_in_a_Binary_Tree;

public class Solution
{
    public long KthLargestLevelSum(TreeNode root, int k)
    {
        if (root == null)
            return -1;

        var nodeWithDepths = new Queue<(TreeNode, int)>();
        nodeWithDepths.Enqueue((root, 0));

        var levelSums = new List<long>();

        while (nodeWithDepths.Count > 0)
        {
            var (node, depth) = nodeWithDepths.Dequeue();

            if (depth == levelSums.Count)
                levelSums.Add(0);
            levelSums[depth] += node.val;

            if (node.left != null)
                nodeWithDepths.Enqueue((node.left, depth + 1));

            if (node.right != null)
                nodeWithDepths.Enqueue((node.right, depth + 1));
        }

        if (levelSums.Count < k)
            return -1;

        return levelSums.OrderByDescending(x => x).Skip(k - 1).First();
    }
}