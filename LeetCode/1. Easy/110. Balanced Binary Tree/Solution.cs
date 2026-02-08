using System;
using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._1._Easy._110._Balanced_Binary_Tree;

public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
            return true;

        var heights = CreateHeights(root);
        return IsAllBalanced(root, heights);
    }

    private Dictionary<TreeNode, int> CreateHeights(TreeNode root)
    {
        var heights = new Dictionary<TreeNode, int>();
        GetHeight(root);
        return heights;

        int GetHeight(TreeNode node)
        {
            if (node == null)
                return 0;

            var height = Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
            heights.Add(node, height);
            return height;
        }
    }

    private bool IsAllBalanced(TreeNode node, Dictionary<TreeNode, int> heights)
    {
        if (node == null)
            return true;

        var leftHeight = node.left == null ? 0 : heights[node.left];
        var rightHeight = node.right == null ? 0 : heights[node.right];
        return Math.Abs(leftHeight - rightHeight) <= 1 && IsAllBalanced(node.left, heights)  && IsAllBalanced(node.right, heights);
    }
}
