using System;
using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._1161._Maximum_Level_Sum_of_a_Binary_Tree;

public class Solution
{
    private readonly Dictionary<int, int> levelSums = new();
    private int maxLevel;

    public int MaxLevelSum(TreeNode root)
    {
        AddLevelSum(root, 1);

        var result = 1;
        var maxLevelSum = levelSums[1];
        for (var i = 2; i <= maxLevel; i++)
            if (maxLevelSum < levelSums[i])
            {
                maxLevelSum = levelSums[i];
                result = i;
            }

        return result;
    }

    private void AddLevelSum(TreeNode node, int level)
    {
        if (!levelSums.TryAdd(level, node.val))
            levelSums[level] += node.val;
        else
            maxLevel = Math.Max(maxLevel, level);

        if (node.left != null)
            AddLevelSum(node.left, level + 1);

        if (node.right != null)
            AddLevelSum(node.right, level + 1);
    }
}