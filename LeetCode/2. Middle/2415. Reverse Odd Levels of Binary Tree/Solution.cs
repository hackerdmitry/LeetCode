using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._2415._Reverse_Odd_Levels_of_Binary_Tree;

public class Solution
{
    public TreeNode ReverseOddLevels(TreeNode root)
    {
        if (root.right == null)
            return root;

        var levelNodes = new List<TreeNode>{root};
        var nextLevel = 2;
        var nextLevelNodes = new List<TreeNode>{root.left,root.right};
        ReverseLevelNodes(nextLevelNodes);

        while (nextLevelNodes[0].left != null)
        {
            (nextLevelNodes, levelNodes) = (levelNodes, nextLevelNodes);
            nextLevelNodes.Clear();
            foreach (var levelNode in levelNodes)
            {
                nextLevelNodes.Add(levelNode.left);
                nextLevelNodes.Add(levelNode.right);
            }

            if (++nextLevel % 2 == 0)
                ReverseLevelNodes(nextLevelNodes);
        }

        return root;
    }

    private void ReverseLevelNodes(List<TreeNode> nodes)
    {
        for (var i = 0; i < nodes.Count / 2; i++)
            (nodes[i].val, nodes[^(i + 1)].val) = (nodes[^(i + 1)].val, nodes[i].val);
    }
}
