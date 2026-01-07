using System;
using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._1339._Maximum_Product_of_Splitted_Binary_Tree;

public class Solution
{
    private const int modulo = 1_000_000_007;

    private long rootSum;
    private readonly Dictionary<TreeNode, long> sums = new();

    public int MaxProduct(TreeNode root)
    {
        sums[root] = rootSum = Sum(root);
        return (int)(LocalMaxProduct(root) % modulo);
    }

    private long LocalMaxProduct(TreeNode node)
    {
        var localSum = sums[node];
        var localProduct = localSum * (rootSum - localSum);

        var leftProduct = node.left == null ? 0 : LocalMaxProduct(node.left);
        var rightProduct = node.right == null ? 0 : LocalMaxProduct(node.right);

        return Math.Max(localProduct, Math.Max(leftProduct, rightProduct));
    }

    private long Sum(TreeNode node)
    {
        if (node.left != null)
            sums[node.left] = Sum(node.left);

        if (node.right != null)
            sums[node.right] = Sum(node.right);

        return (node.left == null ? 0 : sums[node.left]) +
               (node.right == null ? 0 : sums[node.right]) +
               node.val;
    }
}