using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._437._Path_Sum_III;

public class Solution
{
    public int PathSum(TreeNode node, int targetSum, LinkedList<long> prefixSum = null)
    {
        if (node == null)
            return 0;

        var result = node.val == targetSum ? 1 : 0;

        prefixSum ??= new LinkedList<long>();

        var prefixSumNode = prefixSum.First;
        while (prefixSumNode != null)
        {
            prefixSumNode.Value += node.val;
            if (prefixSumNode.Value == targetSum)
                result++;
            prefixSumNode = prefixSumNode.Next;
        }
        prefixSum.AddLast(node.val);

        var leftResult = node.left != null ? PathSum(node.left, targetSum, prefixSum) : 0;
        var rightResult = node.right != null ? PathSum(node.right, targetSum, prefixSum) : 0;

        prefixSum.RemoveLast();
        prefixSumNode = prefixSum.First;
        while (prefixSumNode != null)
        {
            prefixSumNode.Value -= node.val;
            prefixSumNode = prefixSumNode.Next;
        }

        return result + leftResult + rightResult;
    }
}